using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CodeCounter
{
    public partial class FrmCodeCouter : Form
    {

        #region 构造函数

        public FrmCodeCouter()
        {
            InitializeComponent();
        }

        #endregion

        #region 字段

        /// <summary>
        /// 图片按钮窗体的实例
        /// </summary>
        private FrmImageButtons _frmImgBtn = new FrmImageButtons();

        /// <summary>
        /// 存储拖拽上来的文件的路径
        /// </summary>
        private List<String> _path = new List<String>();

        /// <summary>
        /// 存储所有获取到的文件集合
        /// </summary>
        private List<FileInfo> _files = new List<FileInfo>();

        /// <summary>
        /// 存储所有拖拽上来的文件夹的集合
        /// </summary>
        private List<DirectoryInfo> _dirs = new List<DirectoryInfo>();

        /// <summary>
        /// 所有眼计算行数的文件后缀名
        /// </summary>
        private List<String> _extensions = new List<String>();

        /// <summary>
        /// 获取最长的字符串的长度
        /// </summary>
        private int _maxLength = 0;

        /// <summary>
        /// 计算源文件的代码行数
        /// </summary>
        private int _counterNumber = 0;
        
        #endregion

        #region 常量

        /// <summary>
        /// 移动窗体的常量数据   WM_NCHITTEST = 0x84
        /// </summary> 
        private const int WM_NCHITTEST = 0x84;

        /// <summary>
        /// 移动窗体的常量数据   HTCLIENT = 0x1
        /// </summary> 
        private const int HTCLIENT = 0x1;

        /// <summary>
        /// 移动窗体的常量数据   HTCAPTION = 0x2
        /// </summary> 
        private const int HTCAPTION = 0x2;

        /// <summary>
        /// 移动窗体的常量数据   WM_NCLBUTTONDBLCLK = 0xA3
        /// </summary> 
        private const int WM_NCLBUTTONDBLCLK = 0xA3;

        #endregion

        #region 方法

        #region 重写方法

        /// <summary>
        /// 重写系统函数 WndProc(ref Message m);
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x4e:
                case 0xd:
                case 0xe:
                case 0x14:
                    base.WndProc(ref m);
                    break;
                case WM_NCHITTEST://鼠标点任意位置后可以拖动窗体

                    this.DefWndProc(ref m);
                    if (m.Result.ToInt32() == HTCLIENT)
                    {
                        m.Result = new IntPtr(HTCAPTION);
                        return;
                    }
                    break;
                case WM_NCLBUTTONDBLCLK://禁止双击最大化
                    // Console.WriteLine(this.WindowState);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
       
        #endregion

        /// <summary>
        /// 查找字符串数组中，
        /// 字符串长度最长的对象的长度，
        /// 设置ListView上显示内容的宽度
        /// </summary>
        /// <param name="array">要查找的String数组对象</param>
        private void SetListViewContentWidth(String[] array)
        {
            // 获取最长的字符串的长度
            foreach (var str in array)
            {
                if (str.Length > this._maxLength)
                    this._maxLength = str.Length;
            }

            // 设置ListView内容的宽度  ，   最小设置成 484 px
            try
            {
                this.lsvShowResult.Columns[0].Width = (this._maxLength * 9) > 484 ? this._maxLength * 9 : 484;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Application.ProductName);
            }
        }

        /// <summary>
        /// 查找字符串泛型集合中，
        /// 字符串长度最长的对象的长度，
        /// 设置ListView上显示内容的宽度
        /// </summary>
        /// <param name="list">要查找的泛型集合对象</param>
        private void SetListViewContentWidth(List<String> list)
        {
            // 获取最长的字符串的长度
            foreach (var str in list)
            {
                if (str.Length > this._maxLength)
                    this._maxLength = str.Length;
            }

            // 设置ListView内容的宽度  ，   最小设置成 484 px
            try
            {
                this.lsvShowResult.Columns[0].Width = (this._maxLength * 9) > 484 ? this._maxLength * 9 : 484;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Application.ProductName);
            }
        }

        /// <summary>
        /// 设置ListView上内容显示的宽度
        /// </summary>
        /// <param name="content">content：要显示在ListView上的内容</param>
        private void SetListViewContentWidth(String content)
        {
            if (content.Length > this._maxLength)
                this._maxLength = content.Length;

            // 设置ListView内容的宽度  ，   最小设置成 484 px
            try
            {
                this.lsvShowResult.Columns[0].Width = (this._maxLength * 9) > 484 ? this._maxLength * 9 : 484;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Application.ProductName);
            }
        }

        /// <summary>
        /// 验证文件后缀名是否符合要计算的文件类型
        /// </summary>
        /// <param name="extension">要验证的文件后缀名</param>
        /// <returns>如果返回true，就是这个文件符合条件，返回false则为不符合。</returns>
        private bool ValidateFileExtension(String extension)
        {
            bool result = false;

            try
            {
                foreach (var e in this._extensions)
                {
                    if (extension == e)
                        return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Application.ProductName);
            }

            return result;
        }

        /// <summary>
        /// 获取所有符合条件的文件到全局变量 _files
        /// </summary>
        private void GetFilesByDragDrop()
        {
            // 如果没有拖拽文件，就不查找
            if (this._path.Count <= 0)
                return;
            
            // 清除所有文件和文件夹
            this._files.Clear();
            this._dirs.Clear();

            // 循环拖拽上来的文件路径
            foreach (String path in this._path)
            {
                try
                {
                    // 判断文件是否存在，如果文件存在就添加到文件集合中
                    try
                    {
                        // 验证文件是否存在
                        if (File.Exists(path))
                        {
                            // 创建这个文件的实例
                            //FileInfo file = new FileInfo(path);
                            String extension = path.Substring(path.LastIndexOf("."));
                            // 判断这个文件是否符合要查询的文件类型
                            if (this.ValidateFileExtension(extension))
                                this._files.Add(new FileInfo(path));      // 如果符合填写的后缀名，就添加到文件集合中
                            continue;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,Application.ProductName);
                    }

                    // 判断文件夹是否存在，如果存在就添加到文件夹集合中
                    try
                    {
                        if (Directory.Exists(path))
                        {
                            this._dirs.Add(new DirectoryInfo(path));
                            continue;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        //MessageBox.Show(ex.Message,Application.ProductName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,Application.ProductName);
                }
            }

            // 获取每一个文件夹中的文件，及每一个文件夹中的子文件夹中的文件
            foreach (DirectoryInfo dir in this._dirs)
            {
                this.GetFilesByDirectory(dir);
            }

            //MessageBox.Show("获取到的文件数量:" + this._files.Count.ToString());
            //MessageBox.Show("拖拽上来的文件夹熟练： " + this._dirs.Count);
        }

        /// <summary>
        /// 获取传进来的文件夹中的符合条件的文件，包括子文件夹中的文件。
        /// 所以传经来的文件夹，就不要再次把文件夹中的文件获取了。
        /// </summary>
        private void GetFilesByDirectory(DirectoryInfo dir)
        {
            // 添加当前文件夹中中的符合条件的文件到文件集合中
            try
            {
                foreach (var file in dir.GetFiles())
                {
                    // 验证是否符合计算的文件的条件
                    try
                    {
                        if (this.ValidateFileExtension(file.Extension))
                            this._files.Add(file);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message,Application.ProductName);
            }

            // 遍历当前文件夹中的子文件夹，
            try
            {
                foreach (var d in dir.GetDirectories())
                {
                    // 再次调用此方法，将子文件夹作为参数传入，。
                    this.GetFilesByDirectory(d);
                }
            }
            catch (Exception ex)
            {
                 Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message,Application.ProductName);
            }

        }

        /// <summary>
        /// 计算源文件代码的总行数
        /// </summary>
        private void CountCodeNumberByFileList()
        {
            // 设置显示格式
            this.lsvShowResult.Items.Add("");
            this.lsvShowResult.Items.Add("正在计算源文件个数...");
            this.lsvShowResult.Items.Add("统计的源文件数：" + this._files.Count + "个");
            this.lsvShowResult.Items.Add("");

            // 设置显示内容的格式
            String format = "";

            // 遍历所有符合条件的文件，读取他们的内容行数
            try
            {
                for (int i = 0; i < this._files.Count; i++)
                {
                    // 获取这个文件对象
                    try
                    {
                        FileInfo file = this._files[i];
                        // 获取这个读取流
                        StreamReader reader = file.OpenText();
                        // 判断这个文件是否是Unicode字符范式，如果不是正确的Unicode编码，就跳过这个文件
                        if (!reader.ReadToEnd().IsNormalized(NormalizationForm.FormD))
                        {
                            // 关闭读取流
                            reader.Close();
                            continue;
                        }

                        // 关闭读取流
                        reader.Close();
                        // 获取这个文件的字符行数
                        int num = File.ReadAllLines(file.FullName).Length;

                        // 设置显示内容的格式
                        format = String.Format("正在统计第 {0}/{1} 个文件", i + 1, this._files.Count);
                        this.lsvShowResult.Items.Add(format);
                        format = String.Format("{0} <{1}行>", file.FullName, num);
                        // 设置显示在ListView上的内容的宽度
                        this.SetListViewContentWidth(format);
                        this.lsvShowResult.Items.Add(format);
                        this.lsvShowResult.Items.Add("");

                        // 添加到所有行数中
                        this._counterNumber += num;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,Application.ProductName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Application.ProductName);
            }

            format = String.Format("源代码总行数为：{0}行", this._counterNumber);
            this.lsvShowResult.Items.Add(format);

            // 弹出对话框，显示计算结果
            MessageBox.Show(format,Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        #endregion

        #region 事件

        #region 所有图片按钮的相关事件

        /// <summary>
        /// 关闭应用程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picCloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            // 必须是鼠标左键单击，才能关闭
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;
            // 关闭当前程序的所有线程
            Application.ExitThread();
        }

        /// <summary>
        /// 当鼠标按下，在关闭图片按钮上改变样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picCloseButton_MouseDown(object sender, MouseEventArgs e)
        {
            // 必须是鼠标左键点击才改变样式
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;
            this.picCloseButton.Image = this._frmImgBtn.picCloseDown.Image;
        }

        /// <summary>
        /// 当鼠标进入关闭图片按钮时，更改样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picCloseButton_MouseEnter(object sender, EventArgs e)
        {
            this.picCloseButton.Image = this._frmImgBtn.picCloseHighlight.Image;
        }

        /// <summary>
        /// 当鼠标移出关闭按钮时，改变样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picCloseButton_MouseLeave(object sender, EventArgs e)
        {
            this.picCloseButton.Image = this._frmImgBtn.picCloseNormal.Image;
        }

        /// <summary>
        /// 当鼠标单击时，最小化窗体到任务栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picMiniButton_MouseClick(object sender, MouseEventArgs e)
        {
            // 必须是鼠标左键单击才能最小化
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 当鼠标按下最小化按钮时，改变样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picMiniButton_MouseDown(object sender, MouseEventArgs e)
        {
            // 必须是鼠标左键单击才能最小化
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;
            this.picMiniButton.Image = this._frmImgBtn.picMiniDown.Image;
        }

        /// <summary>
        /// 鼠标移动到最小化按钮上时，改变样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picMiniButton_MouseEnter(object sender, EventArgs e)
        {
            this.picMiniButton.Image = this._frmImgBtn.picMiniHighlight.Image;
        }

        /// <summary>
        /// 鼠标移动离开最小化按钮时，改变样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picMiniButton_MouseLeave(object sender, EventArgs e)
        {
            this.picMiniButton.Image = this._frmImgBtn.picMiniNormal.Image;
        }

        /// <summary>
        /// 计算图片按钮的鼠标单击，调用查询按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picCounter_MouseClick(object sender, MouseEventArgs e)
        {
            // 必须是鼠标左键单击才能最小化
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;
            // 调用查询按钮的单击事件
            this.btnSearch_Click(sender,e);
        }

        /// <summary>
        /// 计算图片按钮的鼠标按下，切换图片按钮的图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picCounter_MouseDown(object sender, MouseEventArgs e)
        {
            this.picCounter.Image = this._frmImgBtn.picCounterDown.Image;
        }

        /// <summary>
        /// 计算图片按钮的鼠标移入，切换图片按钮的图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picCounter_MouseEnter(object sender, EventArgs e)
        {
            this.picCounter.Image = this._frmImgBtn.picCounterHighlight.Image;
        }

        /// <summary>
        /// 计算图片按钮的鼠标移出，切换图片按钮的图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picCounter_MouseLeave(object sender, EventArgs e)
        {
            this.picCounter.Image = this._frmImgBtn.picCounterNormal.Image;
        }

        /// <summary>
        /// 计算图片按钮的释放鼠标按键时，切换图片按钮的图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picCounter_MouseUp(object sender, MouseEventArgs e)
        {
            this.picCounter.Image = this._frmImgBtn.picCounterNormal.Image;
        }

        #endregion

        #region 拖拽文件的事件

        /// <summary>
        /// 鼠标拖拽文件或文件夹，到窗体上时，获取路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCodeCouter_DragDrop(object sender, DragEventArgs e)
        {
            // 清空字符串最长的长度
            this._maxLength = 0;

            // 清空ListView的Items集合
            this.lsvShowResult.Items.Clear();

            try
            {
                // 获取所有拖拽上来的文件和文件夹路径
                String[] path = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                // 转换成泛型集合
                this._path = path.ToList<String>();

                // 遍历，查找最长的字符串的长度，并且设置ListView内容的宽度
                this.SetListViewContentWidth(this._path);

                // 将拖拽上来的文件和文件夹的路径，显示在ListView上
                foreach (var p in path)
                {
                    this.lsvShowResult.Items.Add(p);
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Application.ProductName);
            }            
            
        }

        /// <summary>
        ///  拖拽文件，显示提示鼠标样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCodeCounter_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        #endregion

        /// <summary>
        /// 窗体加载....
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCodeCouter_Load(object sender, EventArgs e)
        {
            // 设置控制按钮的图片样式
            this.picMiniButton.Image = this._frmImgBtn.picMiniNormal.Image;
            this.picCloseButton.Image = this._frmImgBtn.picCloseNormal.Image;

            // this.BackgroundImage = null;

            // 清空显示的结果 ListView
            this.lsvShowResult.Items.Clear();

            // this.txtExtension.Text = ".mxml;";

            /*
            FileStream fs = new FileStream(@"C:\Users\Administrator\Desktop\1.doc",FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            int a = 0;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                a++;
            }
            */
          // FileInfo file = new FileInfo(@"C:\Users\Administrator\Desktop\新建文本文档.txt");
            //MessageBox.Show(a+"");
        }

        /// <summary>
        /// 单击查找按钮，计算源代码行数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 清空代码行数记录
            this._counterNumber = 0;

            // 获取要计算的文件格式的后缀名
            String extension = this.txtExtension.Text;

            // 如果，没有填写任何后缀名，就直接返回
            if (String.IsNullOrEmpty(extension.Trim()))
                return;

            // 获取所有要计算的文件格式 （文件后缀名）
            this._extensions = extension.Split(new char[] { ';' }).ToList<String>();

            // 获取拖拽上来的所有符合条件的文件
            this.GetFilesByDragDrop();

            // 如果，没有拖拽任何文件的话，就不计算结果了
            if (this.lsvShowResult.Items.Count <= 0)
                return;

            // 开始计算源文件的代码行数长度
            this.CountCodeNumberByFileList();

            //MessageBox.Show("Test"+this._files.Count);
        }

        /// <summary>
        /// 单击退出，退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // 关闭程序
            Application.ExitThread();
        }

        #endregion

    }
}
