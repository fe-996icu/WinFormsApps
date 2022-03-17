namespace ServiceManage
{
    partial class FrmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.lblMakeDate = new System.Windows.Forms.Label();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.lblProductVersion = new System.Windows.Forms.Label();
            this.lblContactQQ = new System.Windows.Forms.Label();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.pnlAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.Controls.Add(this.lblAbout);
            this.pnlContent.Controls.Add(this.pnlAbout);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(424, 217);
            this.pnlContent.TabIndex = 0;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Location = new System.Drawing.Point(23, 169);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(383, 32);
            this.lblAbout.TabIndex = 5;
            this.lblAbout.Text = "关于 ServiceManage ，这是本人最后一个C#程序。之后，将全身心投入Java\r\n编程事业。对本软件的任何疑意都可联系本人QQ或发送E-mail。";
            // 
            // pnlAbout
            // 
            this.pnlAbout.Controls.Add(this.lblMakeDate);
            this.pnlAbout.Controls.Add(this.lblContactEmail);
            this.pnlAbout.Controls.Add(this.lblProductVersion);
            this.pnlAbout.Controls.Add(this.lblContactQQ);
            this.pnlAbout.Controls.Add(this.lblCopyRight);
            this.pnlAbout.Controls.Add(this.lblProductName);
            this.pnlAbout.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAbout.Location = new System.Drawing.Point(167, 0);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(257, 217);
            this.pnlAbout.TabIndex = 0;
            // 
            // lblMakeDate
            // 
            this.lblMakeDate.AutoSize = true;
            this.lblMakeDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMakeDate.ForeColor = System.Drawing.Color.Snow;
            this.lblMakeDate.Location = new System.Drawing.Point(3, 137);
            this.lblMakeDate.Name = "lblMakeDate";
            this.lblMakeDate.Size = new System.Drawing.Size(126, 17);
            this.lblMakeDate.TabIndex = 7;
            this.lblMakeDate.Text = "创建日期 2011-09-24";
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContactEmail.ForeColor = System.Drawing.Color.Snow;
            this.lblContactEmail.Location = new System.Drawing.Point(3, 119);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(180, 17);
            this.lblContactEmail.TabIndex = 6;
            this.lblContactEmail.Text = "联系邮箱 405440628@qq.com";
            // 
            // lblProductVersion
            // 
            this.lblProductVersion.AutoSize = true;
            this.lblProductVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProductVersion.ForeColor = System.Drawing.Color.Snow;
            this.lblProductVersion.Location = new System.Drawing.Point(3, 65);
            this.lblProductVersion.Name = "lblProductVersion";
            this.lblProductVersion.Size = new System.Drawing.Size(60, 17);
            this.lblProductVersion.TabIndex = 5;
            this.lblProductVersion.Text = "产品版本 ";
            // 
            // lblContactQQ
            // 
            this.lblContactQQ.AutoSize = true;
            this.lblContactQQ.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContactQQ.ForeColor = System.Drawing.Color.Snow;
            this.lblContactQQ.Location = new System.Drawing.Point(3, 101);
            this.lblContactQQ.Name = "lblContactQQ";
            this.lblContactQQ.Size = new System.Drawing.Size(123, 17);
            this.lblContactQQ.TabIndex = 4;
            this.lblContactQQ.Text = "联系 QQ 405440628";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCopyRight.ForeColor = System.Drawing.Color.Snow;
            this.lblCopyRight.Location = new System.Drawing.Point(3, 83);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(96, 17);
            this.lblCopyRight.TabIndex = 3;
            this.lblCopyRight.Text = "版权所有 张智赫";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProductName.ForeColor = System.Drawing.Color.LightCyan;
            this.lblProductName.Location = new System.Drawing.Point(3, 34);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(243, 19);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "北大青鸟-唐城中心 软件服务管理工具";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 217);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于";
            this.TopMost = true;
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Label lblContactQQ;
        private System.Windows.Forms.Label lblProductVersion;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblContactEmail;
        private System.Windows.Forms.Label lblMakeDate;

    }
}