using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


// 引入命名空间
using DevComponents.DotNetBar.Controls;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32;


namespace ReportTime
{
    public partial class FrmReportTime : Form
    {

        #region 构造函数

        public FrmReportTime()
        {
            InitializeComponent();
        }

        #endregion

        #region 字段

        /// <summary>
        /// 改变图像的索引
        /// </summary>
        private int changeImgIndex = 1;

        /// <summary>
        /// 改变图像的速度（秒为单位）
        /// </summary>
        private int changeImgSecond = 0;

        /// <summary>
        /// 随机显示的图片索引
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// 切换图片的间隔时间
        /// </summary>
        private int changeImgTime = 3;

        /// <summary>
        /// 有序或者无序播放图片
        /// </summary>
        private bool orderOrConfusion = false;

        /// <summary>
        /// 提示的信息内容
        /// </summary>
        private String message = "";

        /// <summary>
        /// 提示信息的时间
        /// </summary>
        private int tipTime = 0;

        /// <summary>
        /// 运行程序的路径
        /// </summary>
        private String filePath = "";

        /// <summary>
        /// 倒计时关机时间（秒）
        /// </summary>
        private int _reciprocalSecond = 0;

        /// <summary>
        /// 是否倒计时运行
        /// </summary>
        private bool _isReciprocal = false;

        private bool _isReciprocalRunProgram = false;

        /// <summary>
        /// 运行程序的等待时间（秒）
        /// </summary>
        private int _waitSecond = 0;

        /// <summary>
        /// 倒数的秒数
        /// </summary>
        private int _justSecond = 0;

        /// <summary>
        /// 指定时间关机
        /// </summary>
        private DateTime dateTime = DateTime.Now;

        /// <summary>
        /// 是否定时关机
        /// </summary>
        private bool isTiming = false;

        /// <summary>
        /// 是否运行程序
        /// </summary>
        private bool isRunProgram = false;

        private Process myProcess = new Process();//定义一个进程实例；

        /// <summary>
        /// 是否有任务在执行
        /// </summary>
        private bool _isExecute = false;

        /// <summary>
        /// 是否倒计时执行
        /// </summary>
        private bool _immediately = false;

        /// <summary>
        /// 窗体的纵轴高度
        /// </summary>
        private int _y = 35;

        /// <summary>
        /// 报时声音文件目录
        /// </summary>
        private String _soundPath = "VoiceFile\\";

        /// <summary>
        /// 播放报时的对象
        /// </summary>
        private System.Media.SoundPlayer player;

        /// <summary>
        /// 播放报时的线程
        /// </summary>
        private System.Threading.Thread thread;

        /// <summary>
        /// 窗体的Visible属性值
        /// </summary>
        private bool _isShow = true;

        /// <summary>
        /// 默认将背景图像保存的路径
        /// backgrounds\
        /// </summary>
        private String _bgPath = "backgrounds\\";

        /// <summary>
        /// 是否改变背景图像
        /// </summary>
        private bool _isChangeBG = false;

        #endregion

        #region 常量
        
        private const String title = "In fixed time shut down - 定时关机";

        #endregion

        #region 属性

        /// <summary>
        /// 显示的图片
        /// </summary>
        private Image PicShowMe
        {
            get { return this.picShowMe.Image; }
            set { this.picShowMe.Image = value; }
        }

        #endregion

        #region 方法

        /// <summary>
        /// 创建cmd线程
        /// </summary>
        private void CreateCommmand()
        {
            myProcess.StartInfo.FileName = "cmd.exe";//启动名为"cmd.exe"的线程，就相当于你点击电脑左下角的"开机"-"运行"-输入cmd后回车，也就是启动了命令提示符界面；
            myProcess.StartInfo.UseShellExecute = false;//关闭Shell的使用
            myProcess.StartInfo.RedirectStandardInput = true;//重定向标准输入
            myProcess.StartInfo.RedirectStandardOutput = true;//重定向标准输出
            myProcess.StartInfo.RedirectStandardError = true;//重定向错误输出
            myProcess.StartInfo.CreateNoWindow = true;//设置不显示窗口
            myProcess.Start();//此处才是启动了该线程
        }

        /// <summary>
        /// 计算累计登录时间
        /// </summary>
        private void CountTotalLoginTime()
        { 
            // 获取登录到系统的时间（毫秒为单位）
            int lt = Environment.TickCount/1000;

            int s = lt  %60;
            int m = lt / 60 % 60;
            int h = lt / 60 / 60 % 60;
            int d = lt / 60 / 60 / 24 % 24;
            String ss = s.ToString();
            String mm = m.ToString();

            // 判断秒数是否大于10，如果小于10，就改成 00
            if (s <= 9)
            {
                ss = "0" + s;
            }
            // 判断分钟是否大于10，如果小于10，就改成 00
            if (m <= 9)
            {
                mm = "0" + m;
            }

            String loginTime = "";
            // 如果天数大于0，就显示天数
            if (d > 0)
            {
                loginTime = String.Format("{0}天{1}小时{2}分{3}秒", d, h, mm, ss);
            }
            else
            {
                loginTime = String.Format("{0}小时{1}分{2}秒", h, mm, ss);
            }

            // 显示在控件上
            this.lblTotalHour.Text = loginTime.ToString();
        }

        /// <summary>
        /// 默认顺序播放图片
        /// </summary>
        private void OrderPlayer()
        {

            // 两秒切换一次图片
            if (this.changeImgSecond++ >= this.changeImgTime)
            {
                // 判断，如果显示的图片索引是图片集合的长度，就显示第一张
                if (this.changeImgIndex >= this.imgsShowMe.Images.Count)
                {
                    // 切换图片
                    this.PicShowMe = this.imgsShowMe.Images[this.changeImgIndex = 0];
                }
                else
                {
                    // 切换图片
                    this.PicShowMe = this.imgsShowMe.Images[this.changeImgIndex++];
                }
                // 切换完成清零
                this.changeImgSecond = 0;
            }
            
        }

        /// <summary>
        /// 无序播放图片
        /// </summary>
        private void ConfusionPlayer()
        {
            // 两秒切换一次图片
            if (this.changeImgSecond++ >= this.changeImgTime)
            {
                // 获取一个随机数
                this.changeImgIndex = random.Next(0, this.imgsShowMe.Images.Count);
                // 显示图片
                this.PicShowMe = this.imgsShowMe.Images[this.changeImgIndex];
                // 切换完成清零
                this.changeImgSecond = 0;
            }
            
        }

        /// <summary>
        /// 切换显示的图片
        /// </summary>
        private void ChangeImage()
        {

            // 切换显示图片
            if (this.orderOrConfusion)
            {
                // 有序播放图片
                this.OrderPlayer();
            }
            else
            {
                // 无序播放图片
                this.ConfusionPlayer();
            }

        }
        
        /// <summary>
        /// 激活分组面板
        /// </summary>
        /// <param name="panel"></param>
        private void EnabledControl(bool enabled) 
        {
            // 禁用其他分组面板
            this.groSelectComputer.Enabled = enabled;
            this.groAction.Enabled = enabled;
            this.groOption.Enabled = enabled;
            this.groRunTime.Enabled = enabled;
            // 禁用两个按钮
            this.btnStart.Enabled = enabled;
            this.btnMin.Enabled = enabled;
        }

        /// <summary>
        /// 控制面板展开关闭
        /// </summary>
        private void ControlPanelExpand()
        {
            // 如果面板是展开的
            if (this.pnlControl.Expanded)
            {
                this.pnlControl.TitleText = "  定时关机 - 控制面板";
                this.pnlControl.TitleStyle.Alignment = StringAlignment.Near;

                // 隐藏提示消息面板
                if (!this.groMessage.Enabled)
                {
                    this.groMessage.Hide();
                }
                // 隐藏运行程序面板
                if (!this.groProgram.Enabled)
                {
                    this.groProgram.Hide();
                }
                // 隐藏定时设置面板
                if (!this.groTiming.Enabled)
                {
                    this.groTiming.Hide();
                }

                //this.timerMove.Enabled = true;
                //this.Location = new Point(this.Location.X,35);
            }
            else
            {
                this.pnlControl.TitleText = "定时关机 - 控制面板";
                this.pnlControl.TitleStyle.Alignment = StringAlignment.Center;

                //this.timerMove.Enabled = true;
                //this.Location = new Point(this.Location.X, 211);
            }
            this.timerMove.Enabled = true;
        }

        /// <summary>
        /// 返回行为分组框被选中的按钮，获取行为参数
        /// </summary>
        /// <returns></returns>
        private String GetAction()
        {
            // 遍历行为分组框中的所有控件
            foreach (Control ctrl in this.groAction.Controls)
            {
                // 如果是单选按钮
                if (ctrl is RadioButton)
                {
                    // 转换为单选按钮
                    RadioButton r = ctrl as RadioButton;
                    // 如果这个单选按钮被选中，就返回它的tag 
                    if (r.Checked && r.Tag != null)
                    {
                        return r.Tag.ToString();
                    }
                }
            }

            return "";
        }

        /// <summary>
        /// 倒计时执行
        /// </summary>
        private void ReciprocalExecute()
        {
            // 定时结束
            if (this._justSecond <= 0)
            {
                // 禁止时间在走动
                this._isReciprocal = false;
                // 倒计时运行程序
                this._isReciprocalRunProgram = true;

                // 如果 运行程序 复选框被选中，就设置运行程序的等待时间
                if (this.chkRunProgram.Checked)
                {
                    //设置运行程序的时间
                    this._justSecond = this._waitSecond;
                }

            }        
        }

        /// <summary>
        /// 倒计时运行程序
        /// </summary>
        private void ReciprocalRunProgram()
        {
            if (this._justSecond <= 0)
            {
                // 停止倒计时运行程序设置
                this._isReciprocalRunProgram = false;

                // 开始运行程序
                this.RunProgram();

                // 执行关机命令
                this.ExecuteCommand();

                // 最小化
                this.WindowState = FormWindowState.Minimized;

                //this.notifyIcon.Text = "还原";
            }
        }

        /// <summary>
        /// 执行定时的操作，参数
        /// </summary>
        /// <param name="parameter"></param>
        private void TimingExecute()
        {
            // 定时结束
            if (this.dateTime.ToString() == DateTime.Now.ToString())
            {
                // 禁止时间在走动
                this.isTiming = false;

                //设置运行程序的时间
                this._justSecond = this._waitSecond;
                
                // 开始定时运行程序
                this.isRunProgram = true;
            }            
        }

        /// <summary>
        /// 定时运行程序
        /// </summary>
        private void TimeRunProgram()
        {
            // 运行程序
            if (this._justSecond<=0)
            {
                // 停止倒计时运行程序
                this.isRunProgram = false;
                this.RunProgram();

                // 执行关机代码
                this.ExecuteCommand();
            }
        }

        /// <summary>
        /// 运行程序
        /// </summary>
        private void RunProgram()
        {
            // 如果运行程序被选中，
            if (this.chkRunProgram.Checked)
            {
                if (!String.IsNullOrEmpty(this.filePath.Trim()))
                {                    
                    try
                    {
                        // 加载要打开的程序
                        ProcessStartInfo psi = new ProcessStartInfo(this.filePath);
                        // 开启错误信息
                        psi.ErrorDialog = true;
                        // 开始运行
                        Process.Start(psi);

                        // 显示提示信息
                        this.notifyIcon.BalloonTipText = "本次执行的程序成功运行！";
                        this.notifyIcon.ShowBalloonTip(3000);
                    }
                    catch (Exception ex) {
                          Console.WriteLine(ex.StackTrace);
                    }
                }
            }
        }

        /// <summary>
        /// 立即执行命令
        /// </summary>
        private void ImmediatelyExecuteCommand()
        { 
            // 运行程序
            this.RunProgram();

            // 执行命令
            this.ExecuteCommand();
        }

        /// <summary>
        /// 执行命令（所有执行关机代码）
        /// </summary>
        private void ExecuteCommand()
        {
            // 获取执行参数
            String parameter = this.GetAction();
            // 判断执行操作
            switch (parameter)
            {
                case "关闭显示器":
                    // 关闭显示器
                    this.ControlLCD(2);
                    break;
                case "打开显示器":
                    // 打开显示器
                    this.ControlLCD(-1);
                    break;
                case "无操作":

                    break;
                case "待机":
                    // 执行待机
                    Application.SetSuspendState(PowerState.Suspend, false, false);
                    break;
                case "休眠":
                    // 开启休眠设置
                    this.myProcess.StandardInput.WriteLine(@"%systemroot%\system32\powercfg.exe -h on");
                    // 执行休眠命令
                    Application.SetSuspendState(PowerState.Hibernate,false,false);
                    break;
                case "锁定":
                    // 调用锁定计算机
                    LockWorkStation();
                    break;
                default:
                    // 所有shutdown参数
                    myProcess.StandardInput.WriteLine("shutdown " + parameter);//相当于你在命令提示符界面输入"shutdown -s -t 0"，只不过不显示窗口界面。"shutdown -s -t 0"是电脑关机指令，你可以百度下
                    break;
            }
            // 气泡提示
            this.notifyIcon.BalloonTipText = "本次任务执行完毕！";
            this.notifyIcon.ShowBalloonTip(3000);

            this._isReciprocal = false;

            this._isReciprocalRunProgram = false;

            this.isTiming = false;

            this.isRunProgram = false;

            this._isExecute = false;

        }

        /// <summary>
        /// 显示气泡提示
        /// </summary>
        private void ShowTipIcon(bool isJust)
        {
            if (!isJust)
            {
                this.notifyIcon.BalloonTipText = "您终止了本次任务！";
                this.notifyIcon.ShowBalloonTip(3000);
            }
            else
            {
                String tip = "";
                foreach (Control c in this.groAction.Controls)
                {
                    RadioButton r = c as RadioButton;
                    if (r.Checked)
                    {
                        tip += String.Format("任务正在准备，稍后将要进入 {0} 状态！", r.Text);
                    }
                }
                this.notifyIcon.BalloonTipText = tip;
                this.notifyIcon.Text = tip;
                this.notifyIcon.ShowBalloonTip(5000);
            }
        }

        /// <summary>
        /// 右键菜单执行命令
        /// </summary>
        /// <param name="parameter"></param>
        private void RightMenuExecute(String msg ,String parameter)
        {
            String message=  String.Format("你确定要将你的计算机 {0} 吗？",msg);
            if (MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                String cmd = "shutdown " + parameter;
                myProcess.StandardInput.WriteLine(cmd);
            }
        }

        #region 图像处理

        /// <summary>
        /// 绑定相册
        /// </summary>
        private void GetPhotoAlbum()
        {
            // 获取文件夹路径
            String path = Application.StartupPath + "\\photo";

            // 判断是否存在相册文件夹
            if (!Directory.Exists(path))
                return;
                       
            // 临时存放相册的集合
            List<Image> album = new List<Image>();

            // 遍历累加图片
            foreach (FileInfo imgFile in new DirectoryInfo(path).GetFiles())
            {
                // 如果这个文件是图片格式的文件，就添加到album集合中
                if (this.IsImage(imgFile.Extension))
                {
                    try
                    {
                        album.Add(Image.FromFile(imgFile.FullName));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("文件：“ " + imgFile.Name + " ”，\n\n不是正确的图像文件，或无法正常显示。\n建议将其移出 photo 文件夹。", title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }

            // 如果有图片文件
            if (album.Count > 0)
            {
                // 清楚默认的图像
                this.imgsShowMe.Images.Clear();
                // 添加到图像列表中
                foreach (Image img in album)
                {
                    this.imgsShowMe.Images.Add(img);
                }
            }

            album = null;
        }
        
        /// <summary>
        /// 验证传进来的路径文件是否是图像文件格式
        /// </summary>
        /// <param name="path"></param>
        /// <returns>如果是图像格式，就返回true</returns>
        private bool IsImage(String path)
        {
            // 获取文件的扩展名
            path = path.Substring(path.LastIndexOf("."));
            String extension = path.ToLower();
            
            // 判断扩展名是否是图片格式
            if (extension == ".jpg" || extension == ".jpeg" || extension == ".gif" || extension == ".png" || extension == ".bmp")
                return true;

            return false;
        }

        /// <summary>
        /// 设置背景图像
        /// </summary>
        private void SetBackground()
        {
            // 如果这个图像不存在，就返回
            if (!File.Exists(this._bgPath + "backgroundDefault.jpg"))
                return;
            // 否则，设置背景图像
            FileStream fs = new FileStream(this._bgPath + "backgroundDefault.jpg",FileMode.Open);

            // 创建图像
            Image i = new Bitmap(fs);

            //if (i.Width < this.Width || i.Height < 295)
            //    this.BackgroundImageLayout = ImageLayout.Tile;
            //else
            //    this.BackgroundImageLayout = ImageLayout.None;
            
            this.BackgroundImage = i;

            // 关闭文件流
            fs.Close();
            fs.Dispose();
        }

        /// <summary>
        /// 保存软件快照
        /// </summary>
        private void SaveImage()// 保存窗体图像
        {
            try
            {
                // 创建图像
                Image i = new Bitmap(this.Width, this.Height);
                // 绘制图像
                Graphics g = Graphics.FromImage(i);
                g.CopyFromScreen(new Point(this.Location.X, this.Location.Y), new Point(0, 0), new Size(this.Width, this.Height));
                // 设置
                this.saveDialog.FileName = title + " " + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg";
                // 保存图像
                if (this.saveDialog.ShowDialog() == DialogResult.OK)
                {
                    i.Save(this.saveDialog.FileName);
                    g.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// 创建图像保存到，backgrounds文件夹下
        /// </summary>
        /// <param name="path">将指定路径的图像文件复制到backgrounds文件夹下</param>
        /// <returns></returns>
        private void SaveImage(String path)
        {
            try
            {
                String savePath = "";
                // 创建图像
                Image i = new Bitmap(path);

                // 设置保存路径
                Directory.CreateDirectory(this._bgPath);
                savePath = this._bgPath + "bg_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                // 将图像保存
                i.Save(savePath);

                // 复制文件，命名为backgroundDefault.jpg
                File.Copy(savePath, this._bgPath + "backgroundDefault.jpg", true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 开机启动本程序

        /// <summary>
        /// 开机自动运行
        /// </summary>
        /// <param name="IsStart"></param>
        public void SetRegistryIsStart(bool IsStart)
        {
            if (IsStart)
            {
                try
                {
                    string strAssName = Application.ExecutablePath;
                    string ShortFileName = Application.ProductName;

                    RegistryKey rgkRun = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    if (rgkRun == null)
                    {
                        rgkRun = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                        rgkRun.SetValue(ShortFileName, strAssName);
                    }
                    else
                    {
                        rgkRun.SetValue(ShortFileName, strAssName);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("设置开机启动失败！\n原因可能是其他程序阻止本次修改行为！", title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                try
                {
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue(Application.ProductName, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            // 清理垃圾
            GC.Collect();

            // 设置菜单是否被选中
            this.rmnuAutoRun.Checked = this.IsAutoRun();

        }
                
        /// <summary>  
        /// 判断是否已经设置为开机启动  
        /// </summary>  
        /// <param name="keyName">注册表key</param>  
        /// 楼雨：2010-12-1 16:43  
        public bool IsAutoRun()
        {
            try
            {
                bool _exit = false;

                RegistryKey hkml = Registry.LocalMachine;

                RegistryKey runKey = hkml.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", false);

                string[] subkeyNames;

                subkeyNames = runKey.GetValueNames();
                foreach (string kName in subkeyNames)
                {
                    if (kName == Application.ProductName)
                    {
                        _exit = true;
                        return _exit;
                    }
                }
                return _exit;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region 关闭显示器

        public const uint WM_SYSCOMMAND = 0x0112;
        public const uint SC_MONITORPOWER = 0xF170;
        [DllImport("user32")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint wMsg, uint wParam, int lParam);

        /// <summary>
        /// 操作显示器
        /// </summary>
        /// <param name="cmd">// 2 为关闭显示器， －1则打开显示器 </param>
        public void ControlLCD(int cmd)
        {
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, cmd);    // 2 为关闭显示器， －1则打开显示器 
        }

        #endregion

        #region 锁定计算机
                
        // 锁定计算机.
        [DllImport("user32.dll")]
        /// <summary>
        /// 直接调用，就可关闭显示器
        /// </summary>
        private static extern void LockWorkStation();//须写extern

        #endregion

        #region 报时声音
        
        /// <summary>
        /// 播放现在时间报时
        /// </summary>
        private void PlayTimeNow()
        {

            // 先验证声音文件是否存在 
            if (!this.ValidateSoundFile())
            {
                this.notifyIcon.BalloonTipText = "系统声音文件错误，不能正常报时！";
                this.notifyIcon.ShowBalloonTip(3000);
                return;
            }

            String sound = this._soundPath + "TIMENOW.wav";
            player = new System.Media.SoundPlayer(sound);
            player.PlaySync();

            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 6)
                sound = this._soundPath + "AM0.wav";
            else if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
                sound = this._soundPath + "AM1.wav";
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
                sound = this._soundPath + "PM.wav";
            else
                sound = this._soundPath + "EM.wav";
            player = new System.Media.SoundPlayer(sound);
            player.PlaySync();

            int hours = DateTime.Now.Hour;

            if (hours > 12)
                hours = hours - 12;

            if (hours < 10)
                sound = this._soundPath + "T0" + hours + ".wav";
            else
                sound = this._soundPath + "T" + hours + ".wav";

            player = new System.Media.SoundPlayer(sound);
            player.PlaySync();

            sound = this._soundPath + "POINT.wav";
            player = new System.Media.SoundPlayer(sound);
            player.PlaySync();

            int min = DateTime.Now.Minute;
            if (min >= 0 && min < 10)
                sound = this._soundPath + "T00.wav";
            else if (min >= 10 && min < 20)
                sound = this._soundPath + "T10.wav";
            else if (min >= 20 && min < 30)
                sound = this._soundPath + "T20.wav";
            else if (min >= 30 && min < 40)
                sound = this._soundPath + "T30.wav";
            else if (min >= 40 && min < 50)
                sound = this._soundPath + "T40.wav";
            else if (min >= 50 && min < 60)
                sound = this._soundPath + "T50.wav";
            player = new System.Media.SoundPlayer(sound);
            player.PlaySync();

            min = min % 10;
            if (min != 0)
            {
                sound = this._soundPath + "T0" + min + ".wav";
                player = new System.Media.SoundPlayer(sound);
                player.PlaySync();
            }

            sound = this._soundPath + "MIN.wav";
            player = new System.Media.SoundPlayer(sound);
            player.PlaySync();

            if (player != null)
            {
                player.Dispose();
                player = null;
            }
        }

        /// <summary>
        /// 验证声音文件是否存在
        /// </summary>
        /// <returns></returns>
        private bool ValidateSoundFile() 
        {

            // 声明一个集合，存放所有文件名称
            List<String> fileNames = new List<String>();
            
            // 获取所有声音文件夹下的文件名称 
            foreach (var file in new DirectoryInfo(this._soundPath).GetFiles())
            {
                fileNames.Add(file.Name);
            }

            // 验证文件是否存在
            List<bool> result = new List<bool>(){ 
                           fileNames.Contains("AM0.wav"),
                           fileNames.Contains("AM1.wav"),
                           fileNames.Contains("EM.wav"),
                           fileNames.Contains("MIN.wav"),
                           fileNames.Contains("PM.wav"),
                           fileNames.Contains("POINT.wav"),
                           fileNames.Contains("T00.wav"),
                           fileNames.Contains("T01.wav"),
                           fileNames.Contains("T1.wav"),
                           fileNames.Contains("T02.wav"),
                           fileNames.Contains("T2.wav"),
                           fileNames.Contains("T03.wav"),
                           fileNames.Contains("T04.wav"),
                           fileNames.Contains("T05.wav"),
                           fileNames.Contains("T06.wav"),
                           fileNames.Contains("T07.wav"),
                           fileNames.Contains("T08.wav"),
                           fileNames.Contains("T09.wav"),
                           fileNames.Contains("T10.wav"),
                           fileNames.Contains("T11.wav"),
                           fileNames.Contains("T12.wav"),
                           fileNames.Contains("T20.wav"),
                           fileNames.Contains("T30.wav"),
                           fileNames.Contains("T40.wav"),
                           fileNames.Contains("T50.wav"),
                           fileNames.Contains("TIMENOW.wav")
                       };

            return !result.Contains(false);
        }

        #endregion

        #endregion

        #region 事件

        #region 窗体的事件

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReportTime_Load(object sender, EventArgs e)
        {
            // 设置当前时间
            this.btnTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日(dddd) HH时:mm分:ss秒");
            // 计算累计登录时间
            this.CountTotalLoginTime();

            // 设置主程序的背景图像
            this.SetBackground();

            // 设定相册
            this.GetPhotoAlbum();
            // 默认显示的图片
            this.picShowMe.Image = this.imgsShowMe.Images[0];

            // 创建执行对象cmd
            this.CreateCommmand();
            // 现将面板收起
            this.pnlControl.Expanded = false;

            // 获取是否是开机启动
            this.rmnuAutoRun.Checked = this.IsAutoRun();
            // 设置是否开机启动
            this.SetRegistryIsStart(this.rmnuAutoRun.Checked);
            // 判断是否被选中
            //if (this.rmnuAutoRun.Checked)
            //{
            //    //this.rmnuAutoRun.Text = "取消开机启动";
            //}
            //else
            //{
            //    this.rmnuAutoRun.Text = "开机自动启动";
            //}

            // 窗体加载时，显示窗体
            this.Opacity = 0;
            this.timerShow.Enabled = true;

            // 显示标题栏
            this.cmbControl.Show();

        }

        /// <summary>
        /// 禁止窗体关闭，直接最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReportTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 禁止关闭程序
            e.Cancel = true;
            // 最小化
            //this.WindowState = FormWindowState.Minimized;            
            this._isShow = false;
            this.timerShow.Enabled = true;
        }

        /// <summary>
        /// 窗体最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReportTime_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                // 隐藏窗体
                this.Hide();
                // 显示气泡提示
                this.notifyIcon.BalloonTipText = title + "\n\t\t\t\t隐藏至此！";
                this.notifyIcon.ShowBalloonTip(1000);

                this.rmnuRestore.Text = "还原";
            }
            // 移动窗体，
            //this.timerMove.Enabled = true;
        }

        #endregion
        
        #region 窗体的 ControlBox 中的事件

        /// <summary>
        /// 窗体控制按钮得到焦点后，马上转移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCtrlClose_Enter(object sender, EventArgs e)
        {
            // 将焦点交给图片（个人秀）
            this.picShowMe.Focus();
        }

        /// <summary>
        /// 最小化按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCtrlMin_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            this._isReciprocal = false;

            this._isReciprocalRunProgram = false;

            this.isTiming = false;

            this.isRunProgram = false;

            this._isExecute = false;

            this.Close();
        }

        /// <summary>
        /// 关闭窗体的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCtrlClose_MouseClick(object sender, MouseEventArgs e)
        {
            // 设置是否开机自动运行程序
            this.SetRegistryIsStart(this.rmnuAutoRun.Checked);

            // 关闭线程
            if (this.thread != null)
                this.thread.Abort();

            // 退出程序线程
            Application.ExitThread();
        }

        /// <summary>
        /// 鼠标移入，图像位置下移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeSkin_MouseEnter(object sender, EventArgs e)
        {
            this.btnChangeSkin.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
        }

        /// <summary>
        /// 鼠标移入，图像位置上移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeSkin_MouseLeave(object sender, EventArgs e)
        {
            this.btnChangeSkin.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
        }

        /// <summary>
        /// 更换主题，蓝色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkinBlue_Click(object sender, EventArgs e)
        {
            this.rbcTitleBar.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue;
        }

        /// <summary>
        /// 更换主题，黑色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkinBlack_Click(object sender, EventArgs e)
        {
            this.rbcTitleBar.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
        }

        /// <summary>
        /// 更换主题，灰色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkinGray_Click(object sender, EventArgs e)
        {
            this.rbcTitleBar.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver;
        }
        
        /// <summary>
        /// 软件快照
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSoftCut_Click(object sender, EventArgs e)
        {
            this.SaveImage();
        }

        /// <summary>
        /// 打开标题栏菜单时，检查是否开机启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbtnTitle_PopupOpen(object sender, DevComponents.DotNetBar.PopupOpenEventArgs e)
        {
            // 获取是否是开机启动
            this.rmnuAutoRun.Checked = this.IsAutoRun();
        }

        #endregion
      
        #region Timer 事件

        /// <summary>
        /// 显示隐藏窗体的timer事件，
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerShow_Tick(object sender, EventArgs e)
        {
            // 如果更换图片，就不执行下面的显示隐藏代码
            if (this._isChangeBG)
            {
                if (this._isShow)
                {
                    this.Opacity -= 0.01;
                    if (this.Opacity <= 0.3)
                    {
                        this._isShow = false;
                        // 设置背景图像
                        this.SetBackground();
                    }
                }
                else
                {
                    this.Opacity += 0.02;
                    if (this.Opacity >= 1)
                    {
                        this._isShow = true;
                        this._isChangeBG = false;
                        this.timerShow.Enabled = false;
                    }
                }
                return;
            }

            if (this._isShow)
            {
                this.Opacity += 0.03;
                if (this.Opacity >= 1)
                {
                    //this.Show();
                    this.Opacity = 1;
                    this.WindowState = FormWindowState.Normal;
                    this.timerShow.Enabled = false;
                }
            }
            else
            {
                this.Opacity -= 0.03;
                if (this.Opacity <= 0)
                {
                    //this.Hide();
                    this.Opacity = 0;
                    this.WindowState = FormWindowState.Minimized;
                    this.timerShow.Enabled = false;
                }
            }
        }

        /// <summary>
        /// 更新时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTimeNow_Tick(object sender, EventArgs e)
        {
            // 获取系统时间
            this.btnTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日(dddd) HH时:mm分:ss秒");
            // 计算累计登录时间
            this.CountTotalLoginTime();

            // 切换显示的图片
            this.ChangeImage();
           
            // 如果是定时关机
            if (this.isTiming)
            {
                this.TimingExecute();
            }

            // 开始运行程序
            if (this.isRunProgram)
            {
                // 倒计时运行程序
                this._justSecond--;
                // 执行
                this.TimeRunProgram();
            }

            // 倒计时运行
            if (this._isReciprocal)
            {
                this._justSecond--;
                // 执行倒计时运行
                this.ReciprocalExecute();
            }

            if (this._isReciprocalRunProgram)
            {
                this._justSecond--;
                // 倒计时运行程序
                this.ReciprocalRunProgram();
            }

            // 设置是否整点报时
            if (this.btnAutoPlay.Checked)
            {
                // 整点报时
                if (DateTime.Now.Minute == 0 && DateTime.Now.Second == 0 || DateTime.Now.Minute == 30 && DateTime.Now.Second == 0)
                {
                    // 播放报时
                    this.tsbTimeNow_ButtonClick(sender,e);
                }
            }
        }

        /// <summary>
        /// 移动窗体的位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMove_Tick(object sender, EventArgs e)
        {
            if (this.pnlControl.Expanded)
            {
                this.Location = new Point(this.Location.X, _y -= 10);
                if (_y <= 35)
                {
                    this.timerMove.Enabled = false;
                }
            }
            else
            {
                this.Location = new Point(this.Location.X, _y += 10);
                if (_y >= 211)
                {
                    this.timerMove.Enabled = false;
                }
            }
        }

        #endregion

        /// <summary>
        /// 单击，切换显示图片的方式（有序或无序）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picShowMe_Click(object sender, EventArgs e)
        {
            if (this.orderOrConfusion)
            {
                this.orderOrConfusion = false;
            }
            else
            {
                this.orderOrConfusion = true;
            }
        }

        /// <summary>
        /// 单击语音报时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbTimeNow_ButtonClick(object sender, EventArgs e)
        {
            // 如果上一次报时，没有结束，就禁止再次出发事件
            if (this.player != null)
                return;

            try
            {   // 实例化  线程对象
                thread = new System.Threading.Thread(new System.Threading.ThreadStart(this.PlayTimeNow));
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        
        /// <summary>
        /// 最小化隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMin_Click(object sender, EventArgs e)
        {
            this._isReciprocal = false;

            this._isReciprocalRunProgram = false;

            this.isTiming = false;

            this.isRunProgram = false;

            this._isExecute = false;

            //this.WindowState = FormWindowState.Minimized;
            this.Close();
        }

        /// <summary>
        /// 开始执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            this._isExecute = true;
            // 立即执行
            if (this.rdoImmediately.Checked)
            {
                // 立即执行命令
                this.ImmediatelyExecuteCommand();
                this._immediately = true;
                //return;
            }
            else    // 定时执行
            {
                // 如果 指定时间 被选中
                if (this.rdoTimingAppoint.Checked)
                {
                    this.isTiming = true;
                }
                else
                {
                    // 倒计时执行
                    this._justSecond = this._reciprocalSecond;

                    // 执行倒计时的操作
                    this._isReciprocal = true;
                }
            }

            //this.notifyIcon.Text += "\n\n    任务已成功部署！";

            // 气泡提示
            if (this._immediately)
            {
                this._immediately = false;
            }
            else
            {
                //this.WindowState = FormWindowState.Minimized;
                this.Close();
                this.ShowTipIcon(true);
            }
            
        }
        
        /// <summary>
        /// 双击图标，显示窗体，
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 如果不是鼠标左键双击，就返回
            if (e.Button != MouseButtons.Left)
                return;

            // 如果有任务正在运行，禁止显示窗体
            if (this._isExecute)
                return;

            this.rmnuRestore_Click(sender,new EventArgs());

            //this.Visible = !this.Visible;
            //if (this.Visible)
            //{
            //    this.WindowState = FormWindowState.Normal;
            //    if (this.pnlControl.Expanded)
            //    {
            //        this.Size = new Size(454, 658);
            //    }
            //    else
            //    {
            //        this.Size = new Size(454, 322);
            //    }
            //    this.rmnuRestore.Text = "隐藏";
            //}
            //else
            //{
            //    //this.Close();
            //    this.rmnuRestore.Text = "还原";
            //}
            //this.notifyIcon.Text = title;
        }

        #region 窗体上半部分的 Panel 拖拽文件的事件

        /// <summary>
        /// 拖拽文件时，验证文件是否是图像格式的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlFormBorder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // 获取拖拽文件的路径
                String path = ((String[])e.Data.GetData(DataFormats.FileDrop, false)).GetValue(0).ToString();
                // 如果是图像文件，就显示可以拖拽
                if (this.IsImage(path))
                    e.Effect = DragDropEffects.Copy;
                
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 将图像文件拖拽到form面板上时，更改背景图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlFormBorder_DragDrop(object sender, DragEventArgs e)
        {
            // 接受到文件的路径
            String path = ((String[])e.Data.GetData(DataFormats.FileDrop, false)).GetValue(0).ToString();
            try
            {
                // 保存拖拽上来的图像文件
                this.SaveImage(path);
                this._isChangeBG = true;
                this.timerShow.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("无法对此文件进行引用，请稍后在重试！\n"+ex.Message,title,MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        #endregion
      
        #region 控制面板自身的事件

        /// <summary>
        /// 改变大小时，也改变窗体的大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlControl_Resize(object sender, EventArgs e)
        {
            // 窗体大小  =  窗体本身的宽度，面板的Y轴坐标 + 面板的高度 + 38
            if (this.pnlControl.Expanded)
            {
                this.Size = new Size(this.Size.Width, this.pnlControl.Location.Y + this.pnlControl.Size.Height + 38);
            }
            else
            {
                this.Size = new Size(this.Size.Width, this.pnlControl.Location.Y + this.pnlControl.Size.Height);
            }

        }

        /// <summary>
        /// 改变面板的标题文字对其方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlControl_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            this.ControlPanelExpand();
        }

        /// <summary>
        /// 控制面板启动时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlControl_EnabledChanged(object sender, EventArgs e)
        {
            if (this.pnlControl.Enabled)
            {
                this.AcceptButton = this.btnStart;
                this.CancelButton = this.btnMin;
            }
        }

        #endregion

        #region 选择计算机分组中的事件

        /// <summary>
        /// 远程计算机，单选按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoLong_CheckedChanged(object sender, EventArgs e)
        {
            // 如果远程计算机按钮备选中，就激活 指定 按钮
            if (this.rdoLong.Checked)
            {
                this.btnAppoint.Enabled = true;
            }
            else
            {
                this.btnAppoint.Enabled = false;
            }
        }

        /// <summary>
        /// 单击指定远程计算机按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAppoint_Click_1(object sender, EventArgs e)
        {
            this.notifyIcon.BalloonTipText = "该功能尚未实现，敬请期待！";
            this.notifyIcon.ShowBalloonTip(3000);
        }

        #endregion

        #region 选项分组中的事件
        
        #region 提示消息相关事件

        /// <summary>
        /// 消息选项多选框选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkTipMsg_CheckedChanged(object sender, EventArgs e)
        {
            this.btnMsg.Enabled = this.chkTipMsg.Checked;
           
        }

        /// <summary>
        /// 显示提示消息面板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMsg_Click(object sender, EventArgs e)
        {
            // 禁用所有面板
            this.EnabledControl(false);
            // 显示提示消息面板
            this.groMessage.Show();
            this.groMessage.Enabled = true;
            // 设置显示的位置
            this.groMessage.Location = new Point(34, 113);
            // 设置焦点
            this.txtTipMsgTime.Focus();

            // 设置回车按钮和esc
            this.AcceptButton = this.btnMsgConfirm;
            this.CancelButton = this.btnMsgCancel;
        }

        /// <summary>
        /// 在弹出的消息设置中点击确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMsgConfirm_Click(object sender, EventArgs e)
        {
            // 获取设置信息
            this.message = this.txtTipMsg.Text;
            this.tipTime = Convert.ToInt32(this.txtTipMsgTime.Text);
            // 隐藏信息提示设置
            this.btnMsgCancel_Click(sender, e);
        }

        /// <summary>
        /// 取消提示信息设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMsgCancel_Click(object sender, EventArgs e)
        {
            // 隐藏提示信息面板
            this.groMessage.Hide();
            this.groMessage.Enabled = false;
            // 显示所有面板
            this.EnabledControl(true);
            // 清空还原数据
            this.txtTipMsgTime.Text = this.tipTime.ToString();
            this.txtTipMsg.Text = this.message;
        }

        /// <summary>
        /// 限制输入，只允许输入数字和控制键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTipMsgTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 如果输入的字符是数字  或者 是控制键，允许输入
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                this.lblMsgSecond.Text = "秒";
            }
            else
            {
                e.Handled = true;
                this.lblMsgSecond.Text = "秒（只允许输入数字!）";
            }
        }

        /// <summary>
        /// 失去焦点，还原显示文字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTipMsgTime_Leave(object sender, EventArgs e)
        {
            this.lblMsgSecond.Text = "秒";
        }

        #endregion

        #region 运行程序相关事件

        /// <summary>
        /// 启动或禁用运行程序按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkRunProgram_CheckedChanged(object sender, EventArgs e)
        {
            this.btnProgram.Enabled = this.chkRunProgram.Checked;
        }

        /// <summary>
        /// 点击选择运行程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProgram_Click(object sender, EventArgs e)
        {
            // 禁用所有面板
            this.EnabledControl(false);
            // 设置显示的位置
            this.groProgram.Location = new Point(37, 140);
            // 显示程序面板
            this.groProgram.Show();
            this.groProgram.Enabled = true;
            // 设置焦点
            this.txtProgramPath.Focus();

            // 设置回车按钮和esc
            this.AcceptButton = this.btnProConfirm;
            this.CancelButton = this.btnProCancel;
        }

        /// <summary>
        /// 选择程序面板确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProConfirm_Click(object sender, EventArgs e)
        {
            // 保存程序路径
            this.filePath = this.txtProgramPath.Text;
            // 隐藏面板
            this.btnProCancel_Click(sender, e);

        }

        /// <summary>
        /// 隐藏面板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProCancel_Click(object sender, EventArgs e)
        {
            // 禁用选择程序面板
            this.groProgram.Hide();
            this.groProgram.Enabled = false;
            // 显示所有面板
            this.EnabledControl(true);
            // 还原运行程序的路径
            this.txtProgramPath.Text = this.filePath;
        }

        /// <summary>
        /// 打开文件对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            if (this.openFile.ShowDialog() == DialogResult.OK)
            {
                this.txtProgramPath.Text = this.openFile.FileName;
            }
        }

        #endregion

        /// <summary>
        /// 指定日期 单选按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoTimingAppoint_CheckedChanged(object sender, EventArgs e)
        {
            // 设置时间与此单选钮一起启用
            this.pnlTiming.Enabled = this.rdoTimingAppoint.Checked;
            // 设置倒数时间与此按钮相反
            this.txtTimingReciprocalSecond.Enabled = !this.rdoTimingAppoint.Checked;
        }

        #endregion

        #region 时机分组中的事件
        
        /// <summary>
        /// 定时 单选按钮的checked事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoTiming_CheckedChanged(object sender, EventArgs e)
        {
            this.btnTiming.Enabled = this.rdoTiming.Checked;
        }

        /// <summary>
        /// 打开定时设置面板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTiming_Click(object sender, EventArgs e)
        {
            // 显示和启用定时面板
            this.groTiming.Show();
            this.groTiming.Enabled = true;
            // 设置显示的时间
            this.numTimingHour.Value = dateTime.Hour;
            this.numTimingMinute.Value = dateTime.Minute;
            // 设置显示的位置
            this.groTiming.Location = new Point(33, 100);
            // 禁用所有面板
            this.EnabledControl(false);

            // 设置回车按钮和esc
            this.AcceptButton = this.btnTimingConfirm;
            this.CancelButton = this.btnTimingCancel;
        }
        
        #region 定时设置面板中的事件

        /// <summary>
        /// 限制输入的数字范围（0-59）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numTimingMinute_ValueChanged(object sender, EventArgs e)
        {
            // 获取用户选择的分钟
            decimal value = this.numTimingMinute.Value;

            if (value >= 60)
            {
                this.numTimingMinute.Value = 0;
            }
            else if (value <= -1)
            {
                this.numTimingMinute.Value = 59;
            }
        }

        /// <summary>
        /// 限制输入的数字范围（0-23）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numTimingHour_ValueChanged(object sender, EventArgs e)
        {
            // 获取用户选择的分钟
            decimal value = this.numTimingHour.Value;

            if (value >= 24)
            {
                this.numTimingHour.Value = 0;
            }
            else if (value <= -1)
            {
                this.numTimingHour.Value = 23;
            }
        }
      
        /// <summary>
        /// 定时面板上的确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimingConfirm_Click(object sender, EventArgs e)
        {
            // 获取值
            this._reciprocalSecond = Convert.ToInt32(this.txtTimingReciprocalSecond.Text);
            this._waitSecond = Convert.ToInt32(this.txtTimingWaitSecond.Text);
            // 获取日期
            String datetime = this.dateTiming.Value.Date.ToString();
            datetime = datetime.Substring(0, datetime.IndexOf(" "));
            datetime = datetime +" " + this.numTimingHour.Value + ":";
            datetime += this.numTimingMinute.Value;
            this.dateTime = Convert.ToDateTime(datetime);
            // 隐藏时间设置面板
            this.btnTimingCancel_Click(sender,e);
        }
        
        /// <summary>
        /// 定时面板上的取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimingCancel_Click(object sender, EventArgs e)
        {
            // 隐藏和禁用时间设置面板
            this.groTiming.Enabled = false;
            this.groTiming.Hide();
            // 启用所有面板
            this.EnabledControl(true);
            // 设置时间的值
            this.txtTimingReciprocalSecond.Text = this._reciprocalSecond.ToString();
            this.txtTimingWaitSecond.Text = this._waitSecond.ToString();
            this.dateTiming.Value = this.dateTime.Date;
            this.numTimingHour.Value = this.dateTime.Hour;
            this.numTimingMinute.Value = this.dateTime.Minute;
        }

        /// <summary>
        /// 秒数失去焦点时，还原0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTimingWaitSecond_Leave(object sender, EventArgs e)
        {
            TextBoxX box = sender as TextBoxX;
            if (box.Text == "")
            {
                box.Text = "0";
            }
        }

        #endregion

        #endregion

        #region 右键菜单上的事件

        /// <summary>
        /// 启用和禁用，还原，终止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuIcon_Opening(object sender, CancelEventArgs e)
        {
            // 是否允许还原
            if (!this.Visible)
            {
                this.rmnuRestore.Enabled = true;
            }
            if (this._isExecute)
            {
                this.rmnuRestore.Enabled = false;
            }
            // 是否允许终止执行
            this.rmnuBreak.Enabled = this._isExecute;
        }

        /// <summary>
        /// 还原窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuRestore_Click(object sender, EventArgs e)
        {
            // 颠倒显示
            this._isShow = !this._isShow;
            if (this._isShow)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                if (this.pnlControl.Expanded)
                {
                    this.Size = new Size(454, 658);
                }
                else
                {
                    this.Size = new Size(454, 322);
                }
                this.rmnuRestore.Text = "隐藏";
            }
            else
            {
                this.rmnuRestore.Text = "还原";
            }

            this.timerShow.Enabled = true;

            //this.notifyIcon.Text = title;
        }

        /// <summary>
        /// 注销计算机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuLogout_Click(object sender, EventArgs e)
        {
            this.RightMenuExecute("注销", "-f");
        }

        /// <summary>
        /// 重新启动计算机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuRestart_Click(object sender, EventArgs e)
        {
            this.RightMenuExecute("重新启动", "-r -t 0");
        }

        /// <summary>
        /// 关闭计算机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuCloseSystem_Click(object sender, EventArgs e)
        {
            this.RightMenuExecute("关闭", "-s -t 0");
        }

        /// <summary>
        /// 待机计算机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuWait_Click(object sender, EventArgs e)
        {
            String message = String.Format("你确定要将你的计算机 待机 吗？");
            if (MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                // 待机
                Application.SetSuspendState(PowerState.Suspend,false,false);
            }
        }

        /// <summary>
        /// 休眠计算机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuDormant_Click(object sender, EventArgs e)
        {
            String message = String.Format("你确定要将你的计算机 休眠 吗？");
            if (MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                // 待机
                Application.SetSuspendState(PowerState.Suspend, false, false);
            }
        }

        /// <summary>
        /// 锁定计算机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuLock_Click(object sender, EventArgs e)
        {
            String message = String.Format("你确定要将你的计算机 锁定 吗？");
            if (MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                // 锁定计算机
                LockWorkStation();
            }
        }

        /// <summary>
        /// 关闭显示器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuCloseDisplay_Click(object sender, EventArgs e)
        {
            String message = String.Format("你确定要将你的计算机 关闭显示器 吗？");
            if (MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.ControlLCD(2);
            }
        }

        /// <summary>
        /// 语音报时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuAutoPlay_Click(object sender, EventArgs e)
        {
            this.tsbTimeNow_ButtonClick(sender,e);
        }

        /// <summary>
        /// 停止所有正在执行的任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuBreak_Click(object sender, EventArgs e)
        {
            this._isExecute = false;
            // 取消所有任务
            myProcess.StandardInput.WriteLine("shutdown -a");

            this._isReciprocal = false;

            this._isReciprocalRunProgram = false;

            this.isTiming = false;

            this.isRunProgram = false;
            // 调用还原窗体
            this.rmnuRestore_Click(sender, e);

            // 气泡提示
            this.ShowTipIcon(false);
        }

        /// <summary>
        /// 开机自动运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuAutoRun_Click(object sender, EventArgs e)
        {
            // 修改注册表，
            this.SetRegistryIsStart(!this.rmnuAutoRun.Checked);
            //MessageBox.Show(this.IsAutoRun().ToString());
            if (this.rmnuAutoRun.Checked)
            {
                //this.rmnuAutoRun.Text = "取消开机启动";
                // 设置提示信息
                this.notifyIcon.BalloonTipText = "设置开机启动成功！";
            }
            else
            {
                //this.rmnuAutoRun.Text = "开机自动启动";
                // 设置提示信息
                this.notifyIcon.BalloonTipText = "取消开机启动成功！";
            }

            this.notifyIcon.ShowBalloonTip(3000);
        }

        /// <summary>
        /// 开机自动启动被选中时，也改变标题栏菜单的开机启动按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            this.cbtnAutoRun.Checked = this.rmnuAutoRun.Checked;
        }

        /// <summary>
        /// 退出应用程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmnuExit_Click(object sender, EventArgs e)
        {
            if (this._isExecute)
            {
                DialogResult dr = MessageBox.Show("你现在有未执行完的任务，确定退出吗？", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }

            // 设置是否开机自动运行程序
            this.SetRegistryIsStart(this.rmnuAutoRun.Checked);

            // 关闭线程
            if (this.thread != null)
                this.thread.Abort();

            // 退出程序线程
            Application.ExitThread();
        }

        #endregion

        private void FrmReportTime_MouseEnter(object sender, EventArgs e)
        {
            
        }

        #endregion

    }
}
