namespace CodeCounter
{
    partial class FrmCodeCouter
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "abcdefgABCDEFG显示的文字样式"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCodeCouter));
            this.lblCtrolTitle = new System.Windows.Forms.Label();
            this.picCloseButton = new System.Windows.Forms.PictureBox();
            this.picMiniButton = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblTip = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.lsvShowResult = new System.Windows.Forms.ListView();
            this.colResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picCounter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCtrolTitle
            // 
            this.lblCtrolTitle.AutoSize = true;
            this.lblCtrolTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCtrolTitle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCtrolTitle.ForeColor = System.Drawing.Color.White;
            this.lblCtrolTitle.Location = new System.Drawing.Point(25, 11);
            this.lblCtrolTitle.Name = "lblCtrolTitle";
            this.lblCtrolTitle.Size = new System.Drawing.Size(109, 12);
            this.lblCtrolTitle.TabIndex = 0;
            this.lblCtrolTitle.Text = "源代码行数统计器";
            // 
            // picCloseButton
            // 
            this.picCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.picCloseButton.Location = new System.Drawing.Point(494, 0);
            this.picCloseButton.Name = "picCloseButton";
            this.picCloseButton.Size = new System.Drawing.Size(39, 20);
            this.picCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCloseButton.TabIndex = 1;
            this.picCloseButton.TabStop = false;
            this.toolTip.SetToolTip(this.picCloseButton, "关闭");
            this.picCloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCloseButton_MouseClick);
            this.picCloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCloseButton_MouseDown);
            this.picCloseButton.MouseEnter += new System.EventHandler(this.picCloseButton_MouseEnter);
            this.picCloseButton.MouseLeave += new System.EventHandler(this.picCloseButton_MouseLeave);
            // 
            // picMiniButton
            // 
            this.picMiniButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMiniButton.BackColor = System.Drawing.Color.Transparent;
            this.picMiniButton.Location = new System.Drawing.Point(466, 0);
            this.picMiniButton.Name = "picMiniButton";
            this.picMiniButton.Size = new System.Drawing.Size(28, 20);
            this.picMiniButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMiniButton.TabIndex = 2;
            this.picMiniButton.TabStop = false;
            this.toolTip.SetToolTip(this.picMiniButton, "最小化");
            this.picMiniButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picMiniButton_MouseClick);
            this.picMiniButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMiniButton_MouseDown);
            this.picMiniButton.MouseEnter += new System.EventHandler(this.picMiniButton_MouseEnter);
            this.picMiniButton.MouseLeave += new System.EventHandler(this.picMiniButton_MouseLeave);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BackColor = System.Drawing.Color.Transparent;
            this.lblTip.Location = new System.Drawing.Point(25, 52);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(497, 12);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "使用说明：确认后缀名(分号相隔) -> 拖拽文件及文件夹到次窗口 -> 点击“代码行数统计”";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.BackColor = System.Drawing.Color.Transparent;
            this.lblExtension.Location = new System.Drawing.Point(25, 82);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(77, 12);
            this.lblExtension.TabIndex = 4;
            this.lblExtension.Text = "文件后缀名：";
            // 
            // txtExtension
            // 
            this.txtExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtension.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtExtension.Location = new System.Drawing.Point(108, 76);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(407, 23);
            this.txtExtension.TabIndex = 5;
            this.txtExtension.Text = ".java;.txt";
            // 
            // lsvShowResult
            // 
            this.lsvShowResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvShowResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colResult});
            this.lsvShowResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsvShowResult.FullRowSelect = true;
            this.lsvShowResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvShowResult.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lsvShowResult.Location = new System.Drawing.Point(27, 105);
            this.lsvShowResult.Name = "lsvShowResult";
            this.lsvShowResult.Size = new System.Drawing.Size(488, 221);
            this.lsvShowResult.TabIndex = 0;
            this.lsvShowResult.TabStop = false;
            this.lsvShowResult.UseCompatibleStateImageBehavior = false;
            this.lsvShowResult.View = System.Windows.Forms.View.Details;
            // 
            // colResult
            // 
            this.colResult.Text = "统计结果";
            this.colResult.Width = 484;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(229, 341);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(269, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picCounter
            // 
            this.picCounter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picCounter.BackColor = System.Drawing.Color.Transparent;
            this.picCounter.Image = ((System.Drawing.Image)(resources.GetObject("picCounter.Image")));
            this.picCounter.Location = new System.Drawing.Point(177, 332);
            this.picCounter.Name = "picCounter";
            this.picCounter.Size = new System.Drawing.Size(167, 32);
            this.picCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCounter.TabIndex = 16;
            this.picCounter.TabStop = false;
            this.picCounter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCounter_MouseClick);
            this.picCounter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCounter_MouseDown);
            this.picCounter.MouseEnter += new System.EventHandler(this.picCounter_MouseEnter);
            this.picCounter.MouseLeave += new System.EventHandler(this.picCounter_MouseLeave);
            this.picCounter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCounter_MouseUp);
            // 
            // FrmCodeCouter
            // 
            this.AcceptButton = this.btnSearch;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(545, 390);
            this.ControlBox = false;
            this.Controls.Add(this.picCounter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lsvShowResult);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.picMiniButton);
            this.Controls.Add(this.picCloseButton);
            this.Controls.Add(this.lblCtrolTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCodeCouter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "源代码行数统计器";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmCodeCouter_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmCodeCouter_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmCodeCounter_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCtrolTitle;
        private System.Windows.Forms.PictureBox picCloseButton;
        private System.Windows.Forms.PictureBox picMiniButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.ListView lsvShowResult;
        private System.Windows.Forms.ColumnHeader colResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.PictureBox picCounter;

    }
}

