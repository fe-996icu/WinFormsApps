using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServiceManage
{
    public partial class FrmAbout : Form
    {

        #region 构造函数

        public FrmAbout()
        {
            InitializeComponent();

            // 加载设置
            this.LoadSet();
        }

        #endregion

        #region 字段

        /// <summary>
        /// 所有图片图片按钮存放的窗体
        /// </summary>
        private FrmImageButtons _frmImgBtn = new FrmImageButtons();

        #endregion

        #region 方法

        private void LoadSet()
        {
            // 给所有控件添加鼠标单击事件，关闭窗口
            this.MouseClick += this.FrmAbout_MouseClick;
            this.pnlContent.MouseClick += this.FrmAbout_MouseClick;
            this.pnlAbout.MouseClick += this.FrmAbout_MouseClick;
            this.lblProductName.MouseClick += this.FrmAbout_MouseClick;
            this.lblCopyRight.MouseClick += this.FrmAbout_MouseClick;
            this.lblContactQQ.MouseClick += this.FrmAbout_MouseClick;
            this.lblContactEmail.MouseClick += this.FrmAbout_MouseClick;
            this.lblMakeDate.MouseClick += this.FrmAbout_MouseClick;
            this.lblAbout.MouseClick += this.FrmAbout_MouseClick;

            // 设置显示的信息
            this.lblProductVersion.Text += Application.ProductVersion;

        }

        #endregion

        #region 事件

        /// <summary>
        /// 鼠标单击窗体，关闭关于窗体（本身）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAbout_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Close();
            }
        }

        #endregion

    }
}
