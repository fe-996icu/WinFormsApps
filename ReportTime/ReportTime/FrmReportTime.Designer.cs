namespace ReportTime
{
    partial class FrmReportTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportTime));
            this.timerTimeNow = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalHour = new System.Windows.Forms.Label();
            this.pnlControl = new DevComponents.DotNetBar.ExpandablePanel();
            this.groTiming = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtTimingWaitSecond = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblWait = new DevComponents.DotNetBar.LabelX();
            this.pnlTiming = new System.Windows.Forms.Panel();
            this.lblTimingDate = new DevComponents.DotNetBar.LabelX();
            this.numTimingMinute = new System.Windows.Forms.NumericUpDown();
            this.numTimingHour = new System.Windows.Forms.NumericUpDown();
            this.lblTimingMinute = new DevComponents.DotNetBar.LabelX();
            this.lblTimingHour = new DevComponents.DotNetBar.LabelX();
            this.dateTiming = new System.Windows.Forms.DateTimePicker();
            this.lblTimingTime = new DevComponents.DotNetBar.LabelX();
            this.lblTimingWaitSecond = new DevComponents.DotNetBar.LabelX();
            this.lblTimingSecond = new DevComponents.DotNetBar.LabelX();
            this.txtTimingReciprocalSecond = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rdoTimingReciprocal = new System.Windows.Forms.RadioButton();
            this.rdoTimingAppoint = new System.Windows.Forms.RadioButton();
            this.btnTimingConfirm = new DevComponents.DotNetBar.ButtonX();
            this.btnTimingCancel = new DevComponents.DotNetBar.ButtonX();
            this.groProgram = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnOpenDialog = new DevComponents.DotNetBar.ButtonX();
            this.btnProConfirm = new DevComponents.DotNetBar.ButtonX();
            this.btnProCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtProgramPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRunProgram = new DevComponents.DotNetBar.LabelX();
            this.groMessage = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnMsgConfirm = new DevComponents.DotNetBar.ButtonX();
            this.btnMsgCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtTipMsg = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTipMsg = new DevComponents.DotNetBar.LabelX();
            this.lblMsgSecond = new DevComponents.DotNetBar.LabelX();
            this.txtTipMsgTime = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTipMsgTime = new DevComponents.DotNetBar.LabelX();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.btnMin = new DevComponents.DotNetBar.ButtonX();
            this.groRunTime = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rdoTiming = new System.Windows.Forms.RadioButton();
            this.rdoImmediately = new System.Windows.Forms.RadioButton();
            this.btnTiming = new DevComponents.DotNetBar.ButtonX();
            this.groOption = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnProgram = new DevComponents.DotNetBar.ButtonX();
            this.chkRunProgram = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnMsg = new DevComponents.DotNetBar.ButtonX();
            this.chkTipMsg = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groAction = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rdoNot = new System.Windows.Forms.RadioButton();
            this.rdoOpenDisplay = new System.Windows.Forms.RadioButton();
            this.rdoCloseDisplay = new System.Windows.Forms.RadioButton();
            this.rdoLock = new System.Windows.Forms.RadioButton();
            this.rdoDormant = new System.Windows.Forms.RadioButton();
            this.rdoStopWork = new System.Windows.Forms.RadioButton();
            this.rdoClosePower = new System.Windows.Forms.RadioButton();
            this.rdoCloseSystem = new System.Windows.Forms.RadioButton();
            this.rdoRestart = new System.Windows.Forms.RadioButton();
            this.rdoLogout = new System.Windows.Forms.RadioButton();
            this.groSelectComputer = new System.Windows.Forms.GroupBox();
            this.rdoLocalhost = new System.Windows.Forms.RadioButton();
            this.btnAppoint = new DevComponents.DotNetBar.ButtonX();
            this.rdoLong = new System.Windows.Forms.RadioButton();
            this.picShowMe = new System.Windows.Forms.PictureBox();
            this.imgsShowMe = new System.Windows.Forms.ImageList(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.rmnuIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rmnuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.rmnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.rmnuRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.rmnuCloseSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.rmnuWait = new System.Windows.Forms.ToolStripMenuItem();
            this.rmnuDormant = new System.Windows.Forms.ToolStripMenuItem();
            this.rmnuLock = new System.Windows.Forms.ToolStripMenuItem();
            this.rmnuCloseDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.rmnuAutoPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.rmnuAutoRun = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.rmnuBreak = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.rmnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.rbcTitleBar = new DevComponents.DotNetBar.RibbonControl();
            this.btnCtrlMin = new DevComponents.DotNetBar.ButtonX();
            this.btnCtrlClose = new DevComponents.DotNetBar.ButtonX();
            this.pnlFormBorder = new System.Windows.Forms.Panel();
            this.btnChangeSkin = new DevComponents.DotNetBar.ButtonX();
            this.btnSkinBlue = new DevComponents.DotNetBar.ButtonItem();
            this.btnSkinGray = new DevComponents.DotNetBar.ButtonItem();
            this.btnSkinBlack = new DevComponents.DotNetBar.ButtonItem();
            this.btnMiddleLine = new DevComponents.DotNetBar.ButtonX();
            this.cmbControl = new DevComponents.DotNetBar.ContextMenuBar();
            this.cbtnTitle = new DevComponents.DotNetBar.ButtonItem();
            this.cbtnRestore = new DevComponents.DotNetBar.ButtonItem();
            this.cbtnLogout = new DevComponents.DotNetBar.ButtonItem();
            this.cbtnRestart = new DevComponents.DotNetBar.ButtonItem();
            this.cbtnCloseSystem = new DevComponents.DotNetBar.ButtonItem();
            this.cbtnWait = new DevComponents.DotNetBar.ButtonItem();
            this.cbtnDormant = new DevComponents.DotNetBar.ButtonItem();
            this.cbtnLock = new DevComponents.DotNetBar.ButtonItem();
            this.cbtnCloseDisplay = new DevComponents.DotNetBar.ButtonItem();
            this.cbtnAutoPlay = new DevComponents.DotNetBar.ButtonItem();
            this.btnSoftCut = new DevComponents.DotNetBar.ButtonItem();
            this.cbtnAutoRun = new DevComponents.DotNetBar.ButtonItem();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.btnTimeNow = new DevComponents.DotNetBar.ButtonX();
            this.btnAutoPlay = new DevComponents.DotNetBar.ButtonItem();
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.超级提示 = new DevComponents.DotNetBar.SuperTooltip();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.pnlControl.SuspendLayout();
            this.groTiming.SuspendLayout();
            this.pnlTiming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimingMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimingHour)).BeginInit();
            this.groProgram.SuspendLayout();
            this.groMessage.SuspendLayout();
            this.groRunTime.SuspendLayout();
            this.groOption.SuspendLayout();
            this.groAction.SuspendLayout();
            this.groSelectComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowMe)).BeginInit();
            this.rmnuIcon.SuspendLayout();
            this.pnlFormBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbControl)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTimeNow
            // 
            this.timerTimeNow.Enabled = true;
            this.timerTimeNow.Interval = 1000;
            this.timerTimeNow.Tick += new System.EventHandler(this.timerTimeNow_Tick);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthCalendar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.monthCalendar.Location = new System.Drawing.Point(194, 70);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowWeekNumbers = true;
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "本次已登录:";
            // 
            // lblTotalHour
            // 
            this.lblTotalHour.AutoSize = true;
            this.lblTotalHour.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalHour.ForeColor = System.Drawing.Color.Red;
            this.lblTotalHour.Location = new System.Drawing.Point(25, 62);
            this.lblTotalHour.Name = "lblTotalHour";
            this.lblTotalHour.Size = new System.Drawing.Size(154, 17);
            this.超级提示.SetSuperTooltip(this.lblTotalHour, new DevComponents.DotNetBar.SuperTooltipInfo("这里是您最近一次开机到现在的登录累计时间。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(0, 0)));
            this.lblTotalHour.TabIndex = 8;
            this.lblTotalHour.Text = "dd天hh时:mm分:ss秒";
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.AnimationTime = 350;
            this.pnlControl.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlControl.ColorScheme.ItemDesignTimeBorder = System.Drawing.Color.Black;
            this.pnlControl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlControl.Controls.Add(this.groTiming);
            this.pnlControl.Controls.Add(this.groProgram);
            this.pnlControl.Controls.Add(this.groMessage);
            this.pnlControl.Controls.Add(this.btnStart);
            this.pnlControl.Controls.Add(this.btnMin);
            this.pnlControl.Controls.Add(this.groRunTime);
            this.pnlControl.Controls.Add(this.groOption);
            this.pnlControl.Controls.Add(this.groAction);
            this.pnlControl.Controls.Add(this.groSelectComputer);
            this.pnlControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlControl.Location = new System.Drawing.Point(1, 296);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(452, 361);
            this.pnlControl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlControl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlControl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlControl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlControl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlControl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlControl.Style.GradientAngle = 90;
            this.pnlControl.StyleMouseDown.BorderColor.Color = System.Drawing.Color.White;
            this.pnlControl.TabIndex = 9;
            this.pnlControl.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlControl.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlControl.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlControl.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.pnlControl.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlControl.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlControl.TitleStyle.GradientAngle = 90;
            this.pnlControl.TitleStyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlControl.TitleText = "定时关机 - 控制面板";
            this.pnlControl.ExpandedChanged += new DevComponents.DotNetBar.ExpandChangeEventHandler(this.pnlControl_ExpandedChanged);
            this.pnlControl.Resize += new System.EventHandler(this.pnlControl_Resize);
            this.pnlControl.EnabledChanged += new System.EventHandler(this.pnlControl_EnabledChanged);
            // 
            // groTiming
            // 
            this.groTiming.CanvasColor = System.Drawing.SystemColors.Control;
            this.groTiming.Controls.Add(this.txtTimingWaitSecond);
            this.groTiming.Controls.Add(this.lblWait);
            this.groTiming.Controls.Add(this.pnlTiming);
            this.groTiming.Controls.Add(this.lblTimingWaitSecond);
            this.groTiming.Controls.Add(this.lblTimingSecond);
            this.groTiming.Controls.Add(this.txtTimingReciprocalSecond);
            this.groTiming.Controls.Add(this.rdoTimingReciprocal);
            this.groTiming.Controls.Add(this.rdoTimingAppoint);
            this.groTiming.Controls.Add(this.btnTimingConfirm);
            this.groTiming.Controls.Add(this.btnTimingCancel);
            this.groTiming.Enabled = false;
            this.groTiming.Location = new System.Drawing.Point(145, 385);
            this.groTiming.Name = "groTiming";
            this.groTiming.Size = new System.Drawing.Size(370, 186);
            // 
            // 
            // 
            this.groTiming.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groTiming.Style.BackColorGradientAngle = 90;
            this.groTiming.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groTiming.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groTiming.Style.BorderBottomWidth = 1;
            this.groTiming.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groTiming.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groTiming.Style.BorderLeftWidth = 1;
            this.groTiming.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groTiming.Style.BorderRightWidth = 1;
            this.groTiming.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groTiming.Style.BorderTopWidth = 1;
            this.groTiming.Style.CornerDiameter = 4;
            this.groTiming.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groTiming.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groTiming.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groTiming.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groTiming.TabIndex = 12;
            this.groTiming.Text = "定时";
            this.groTiming.Visible = false;
            // 
            // txtTimingWaitSecond
            // 
            // 
            // 
            // 
            this.txtTimingWaitSecond.Border.Class = "TextBoxBorder";
            this.txtTimingWaitSecond.Location = new System.Drawing.Point(102, 93);
            this.txtTimingWaitSecond.MaxLength = 5;
            this.txtTimingWaitSecond.Name = "txtTimingWaitSecond";
            this.txtTimingWaitSecond.Size = new System.Drawing.Size(100, 21);
            this.txtTimingWaitSecond.TabIndex = 31;
            this.txtTimingWaitSecond.Text = "0";
            this.txtTimingWaitSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimingWaitSecond.Leave += new System.EventHandler(this.txtTimingWaitSecond_Leave);
            this.txtTimingWaitSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipMsgTime_KeyPress);
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Enabled = false;
            this.lblWait.Location = new System.Drawing.Point(39, 98);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(37, 16);
            this.lblWait.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.lblWait.TabIndex = 30;
            this.lblWait.Text = "等待:";
            // 
            // pnlTiming
            // 
            this.pnlTiming.Controls.Add(this.lblTimingDate);
            this.pnlTiming.Controls.Add(this.numTimingMinute);
            this.pnlTiming.Controls.Add(this.numTimingHour);
            this.pnlTiming.Controls.Add(this.lblTimingMinute);
            this.pnlTiming.Controls.Add(this.lblTimingHour);
            this.pnlTiming.Controls.Add(this.dateTiming);
            this.pnlTiming.Controls.Add(this.lblTimingTime);
            this.pnlTiming.Location = new System.Drawing.Point(102, 3);
            this.pnlTiming.Name = "pnlTiming";
            this.pnlTiming.Size = new System.Drawing.Size(237, 55);
            this.pnlTiming.TabIndex = 29;
            // 
            // lblTimingDate
            // 
            this.lblTimingDate.AutoSize = true;
            this.lblTimingDate.Location = new System.Drawing.Point(8, 8);
            this.lblTimingDate.Name = "lblTimingDate";
            this.lblTimingDate.Size = new System.Drawing.Size(37, 16);
            this.lblTimingDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.lblTimingDate.TabIndex = 32;
            this.lblTimingDate.Text = "日期:";
            // 
            // numTimingMinute
            // 
            this.numTimingMinute.Location = new System.Drawing.Point(163, 30);
            this.numTimingMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numTimingMinute.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numTimingMinute.Name = "numTimingMinute";
            this.numTimingMinute.Size = new System.Drawing.Size(37, 21);
            this.numTimingMinute.TabIndex = 31;
            this.numTimingMinute.ValueChanged += new System.EventHandler(this.numTimingMinute_ValueChanged);
            // 
            // numTimingHour
            // 
            this.numTimingHour.Location = new System.Drawing.Point(85, 30);
            this.numTimingHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numTimingHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numTimingHour.Name = "numTimingHour";
            this.numTimingHour.Size = new System.Drawing.Size(37, 21);
            this.numTimingHour.TabIndex = 30;
            this.numTimingHour.ValueChanged += new System.EventHandler(this.numTimingHour_ValueChanged);
            // 
            // lblTimingMinute
            // 
            this.lblTimingMinute.AutoSize = true;
            this.lblTimingMinute.Location = new System.Drawing.Point(202, 33);
            this.lblTimingMinute.Name = "lblTimingMinute";
            this.lblTimingMinute.Size = new System.Drawing.Size(19, 16);
            this.lblTimingMinute.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.lblTimingMinute.TabIndex = 28;
            this.lblTimingMinute.Text = "分";
            // 
            // lblTimingHour
            // 
            this.lblTimingHour.AutoSize = true;
            this.lblTimingHour.Location = new System.Drawing.Point(124, 33);
            this.lblTimingHour.Name = "lblTimingHour";
            this.lblTimingHour.Size = new System.Drawing.Size(19, 16);
            this.lblTimingHour.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.lblTimingHour.TabIndex = 29;
            this.lblTimingHour.Text = "时";
            // 
            // dateTiming
            // 
            this.dateTiming.Location = new System.Drawing.Point(83, 4);
            this.dateTiming.Name = "dateTiming";
            this.dateTiming.Size = new System.Drawing.Size(146, 21);
            this.dateTiming.TabIndex = 27;
            // 
            // lblTimingTime
            // 
            this.lblTimingTime.AutoSize = true;
            this.lblTimingTime.Location = new System.Drawing.Point(8, 33);
            this.lblTimingTime.Name = "lblTimingTime";
            this.lblTimingTime.Size = new System.Drawing.Size(37, 16);
            this.lblTimingTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.lblTimingTime.TabIndex = 26;
            this.lblTimingTime.Text = "时间:";
            // 
            // lblTimingWaitSecond
            // 
            this.lblTimingWaitSecond.AutoSize = true;
            this.lblTimingWaitSecond.Enabled = false;
            this.lblTimingWaitSecond.Location = new System.Drawing.Point(208, 98);
            this.lblTimingWaitSecond.Name = "lblTimingWaitSecond";
            this.lblTimingWaitSecond.Size = new System.Drawing.Size(118, 16);
            this.lblTimingWaitSecond.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.lblTimingWaitSecond.TabIndex = 28;
            this.lblTimingWaitSecond.Text = "秒（在任务执行前）";
            // 
            // lblTimingSecond
            // 
            this.lblTimingSecond.AutoSize = true;
            this.lblTimingSecond.Enabled = false;
            this.lblTimingSecond.Location = new System.Drawing.Point(208, 63);
            this.lblTimingSecond.Name = "lblTimingSecond";
            this.lblTimingSecond.Size = new System.Drawing.Size(19, 16);
            this.lblTimingSecond.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.lblTimingSecond.TabIndex = 28;
            this.lblTimingSecond.Text = "秒";
            // 
            // txtTimingReciprocalSecond
            // 
            // 
            // 
            // 
            this.txtTimingReciprocalSecond.Border.Class = "TextBoxBorder";
            this.txtTimingReciprocalSecond.Enabled = false;
            this.txtTimingReciprocalSecond.Location = new System.Drawing.Point(102, 61);
            this.txtTimingReciprocalSecond.MaxLength = 5;
            this.txtTimingReciprocalSecond.Name = "txtTimingReciprocalSecond";
            this.txtTimingReciprocalSecond.Size = new System.Drawing.Size(100, 21);
            this.txtTimingReciprocalSecond.TabIndex = 27;
            this.txtTimingReciprocalSecond.Text = "0";
            this.txtTimingReciprocalSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimingReciprocalSecond.Leave += new System.EventHandler(this.txtTimingWaitSecond_Leave);
            this.txtTimingReciprocalSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipMsgTime_KeyPress);
            // 
            // rdoTimingReciprocal
            // 
            this.rdoTimingReciprocal.AutoSize = true;
            this.rdoTimingReciprocal.Location = new System.Drawing.Point(21, 62);
            this.rdoTimingReciprocal.Name = "rdoTimingReciprocal";
            this.rdoTimingReciprocal.Size = new System.Drawing.Size(59, 16);
            this.rdoTimingReciprocal.TabIndex = 26;
            this.rdoTimingReciprocal.TabStop = true;
            this.rdoTimingReciprocal.Text = "倒计时";
            this.rdoTimingReciprocal.UseVisualStyleBackColor = true;
            // 
            // rdoTimingAppoint
            // 
            this.rdoTimingAppoint.AutoSize = true;
            this.rdoTimingAppoint.Checked = true;
            this.rdoTimingAppoint.Location = new System.Drawing.Point(21, 10);
            this.rdoTimingAppoint.Name = "rdoTimingAppoint";
            this.rdoTimingAppoint.Size = new System.Drawing.Size(71, 16);
            this.rdoTimingAppoint.TabIndex = 18;
            this.rdoTimingAppoint.TabStop = true;
            this.rdoTimingAppoint.Text = "指定时间";
            this.rdoTimingAppoint.UseVisualStyleBackColor = true;
            this.rdoTimingAppoint.CheckedChanged += new System.EventHandler(this.rdoTimingAppoint_CheckedChanged);
            // 
            // btnTimingConfirm
            // 
            this.btnTimingConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimingConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimingConfirm.Location = new System.Drawing.Point(205, 130);
            this.btnTimingConfirm.Name = "btnTimingConfirm";
            this.btnTimingConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnTimingConfirm.TabIndex = 9;
            this.btnTimingConfirm.Text = "确定";
            this.btnTimingConfirm.Click += new System.EventHandler(this.btnTimingConfirm_Click);
            // 
            // btnTimingCancel
            // 
            this.btnTimingCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimingCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimingCancel.Location = new System.Drawing.Point(286, 130);
            this.btnTimingCancel.Name = "btnTimingCancel";
            this.btnTimingCancel.Size = new System.Drawing.Size(75, 23);
            this.btnTimingCancel.TabIndex = 10;
            this.btnTimingCancel.Text = "取消";
            this.btnTimingCancel.Click += new System.EventHandler(this.btnTimingCancel_Click);
            // 
            // groProgram
            // 
            this.groProgram.CanvasColor = System.Drawing.SystemColors.Control;
            this.groProgram.Controls.Add(this.btnOpenDialog);
            this.groProgram.Controls.Add(this.btnProConfirm);
            this.groProgram.Controls.Add(this.btnProCancel);
            this.groProgram.Controls.Add(this.txtProgramPath);
            this.groProgram.Controls.Add(this.lblRunProgram);
            this.groProgram.Enabled = false;
            this.groProgram.Location = new System.Drawing.Point(366, 370);
            this.groProgram.Name = "groProgram";
            this.groProgram.Size = new System.Drawing.Size(370, 88);
            // 
            // 
            // 
            this.groProgram.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groProgram.Style.BackColorGradientAngle = 90;
            this.groProgram.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groProgram.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groProgram.Style.BorderBottomWidth = 1;
            this.groProgram.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groProgram.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groProgram.Style.BorderLeftWidth = 1;
            this.groProgram.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groProgram.Style.BorderRightWidth = 1;
            this.groProgram.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groProgram.Style.BorderTopWidth = 1;
            this.groProgram.Style.CornerDiameter = 4;
            this.groProgram.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groProgram.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groProgram.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groProgram.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groProgram.TabIndex = 11;
            this.groProgram.Text = "启动程序";
            this.groProgram.Visible = false;
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOpenDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenDialog.Location = new System.Drawing.Point(318, 12);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(36, 23);
            this.btnOpenDialog.TabIndex = 3;
            this.btnOpenDialog.Text = "....";
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // btnProConfirm
            // 
            this.btnProConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProConfirm.Location = new System.Drawing.Point(205, 38);
            this.btnProConfirm.Name = "btnProConfirm";
            this.btnProConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnProConfirm.TabIndex = 4;
            this.btnProConfirm.Text = "确定";
            this.btnProConfirm.Click += new System.EventHandler(this.btnProConfirm_Click);
            // 
            // btnProCancel
            // 
            this.btnProCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProCancel.Location = new System.Drawing.Point(286, 38);
            this.btnProCancel.Name = "btnProCancel";
            this.btnProCancel.Size = new System.Drawing.Size(75, 23);
            this.btnProCancel.TabIndex = 5;
            this.btnProCancel.Text = "取消";
            this.btnProCancel.Click += new System.EventHandler(this.btnProCancel_Click);
            // 
            // txtProgramPath
            // 
            this.txtProgramPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtProgramPath.Border.Class = "TextBoxBorder";
            this.txtProgramPath.Location = new System.Drawing.Point(59, 12);
            this.txtProgramPath.MaxLength = 30000;
            this.txtProgramPath.Name = "txtProgramPath";
            this.txtProgramPath.Size = new System.Drawing.Size(250, 21);
            this.txtProgramPath.TabIndex = 2;
            // 
            // lblRunProgram
            // 
            this.lblRunProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRunProgram.AutoSize = true;
            this.lblRunProgram.Location = new System.Drawing.Point(16, 14);
            this.lblRunProgram.Name = "lblRunProgram";
            this.lblRunProgram.Size = new System.Drawing.Size(37, 16);
            this.lblRunProgram.TabIndex = 1;
            this.lblRunProgram.Text = "程序:";
            // 
            // groMessage
            // 
            this.groMessage.CanvasColor = System.Drawing.SystemColors.Control;
            this.groMessage.Controls.Add(this.btnMsgConfirm);
            this.groMessage.Controls.Add(this.btnMsgCancel);
            this.groMessage.Controls.Add(this.txtTipMsg);
            this.groMessage.Controls.Add(this.lblTipMsg);
            this.groMessage.Controls.Add(this.lblMsgSecond);
            this.groMessage.Controls.Add(this.txtTipMsgTime);
            this.groMessage.Controls.Add(this.lblTipMsgTime);
            this.groMessage.Enabled = false;
            this.groMessage.Location = new System.Drawing.Point(221, 379);
            this.groMessage.Name = "groMessage";
            this.groMessage.Size = new System.Drawing.Size(370, 210);
            // 
            // 
            // 
            this.groMessage.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groMessage.Style.BackColorGradientAngle = 90;
            this.groMessage.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groMessage.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groMessage.Style.BorderBottomWidth = 1;
            this.groMessage.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groMessage.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groMessage.Style.BorderLeftWidth = 1;
            this.groMessage.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groMessage.Style.BorderRightWidth = 1;
            this.groMessage.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groMessage.Style.BorderTopWidth = 1;
            this.groMessage.Style.CornerDiameter = 4;
            this.groMessage.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groMessage.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groMessage.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groMessage.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groMessage.TabIndex = 10;
            this.groMessage.Text = "提示消息";
            this.groMessage.Visible = false;
            // 
            // btnMsgConfirm
            // 
            this.btnMsgConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMsgConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsgConfirm.Location = new System.Drawing.Point(205, 160);
            this.btnMsgConfirm.Name = "btnMsgConfirm";
            this.btnMsgConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnMsgConfirm.TabIndex = 9;
            this.btnMsgConfirm.Text = "确定";
            this.btnMsgConfirm.Click += new System.EventHandler(this.btnMsgConfirm_Click);
            // 
            // btnMsgCancel
            // 
            this.btnMsgCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMsgCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsgCancel.Location = new System.Drawing.Point(286, 160);
            this.btnMsgCancel.Name = "btnMsgCancel";
            this.btnMsgCancel.Size = new System.Drawing.Size(75, 23);
            this.btnMsgCancel.TabIndex = 10;
            this.btnMsgCancel.Text = "取消";
            this.btnMsgCancel.Click += new System.EventHandler(this.btnMsgCancel_Click);
            // 
            // txtTipMsg
            // 
            // 
            // 
            // 
            this.txtTipMsg.Border.Class = "TextBoxBorder";
            this.txtTipMsg.Location = new System.Drawing.Point(16, 64);
            this.txtTipMsg.Multiline = true;
            this.txtTipMsg.Name = "txtTipMsg";
            this.txtTipMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTipMsg.Size = new System.Drawing.Size(345, 90);
            this.txtTipMsg.TabIndex = 5;
            // 
            // lblTipMsg
            // 
            this.lblTipMsg.AutoSize = true;
            this.lblTipMsg.Location = new System.Drawing.Point(16, 42);
            this.lblTipMsg.Name = "lblTipMsg";
            this.lblTipMsg.Size = new System.Drawing.Size(62, 16);
            this.lblTipMsg.TabIndex = 4;
            this.lblTipMsg.Text = "提示内容:";
            // 
            // lblMsgSecond
            // 
            this.lblMsgSecond.AutoSize = true;
            this.lblMsgSecond.Location = new System.Drawing.Point(224, 15);
            this.lblMsgSecond.Name = "lblMsgSecond";
            this.lblMsgSecond.Size = new System.Drawing.Size(19, 16);
            this.lblMsgSecond.TabIndex = 3;
            this.lblMsgSecond.Text = "秒";
            // 
            // txtTipMsgTime
            // 
            // 
            // 
            // 
            this.txtTipMsgTime.Border.Class = "TextBoxBorder";
            this.txtTipMsgTime.Location = new System.Drawing.Point(130, 12);
            this.txtTipMsgTime.MaxLength = 3;
            this.txtTipMsgTime.Name = "txtTipMsgTime";
            this.txtTipMsgTime.Size = new System.Drawing.Size(81, 21);
            this.txtTipMsgTime.TabIndex = 2;
            this.txtTipMsgTime.Text = "0";
            this.txtTipMsgTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTipMsgTime.Leave += new System.EventHandler(this.txtTimingWaitSecond_Leave);
            this.txtTipMsgTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipMsgTime_KeyPress);
            // 
            // lblTipMsgTime
            // 
            this.lblTipMsgTime.AutoSize = true;
            this.lblTipMsgTime.Location = new System.Drawing.Point(16, 14);
            this.lblTipMsgTime.Name = "lblTipMsgTime";
            this.lblTipMsgTime.Size = new System.Drawing.Size(112, 16);
            this.lblTipMsgTime.TabIndex = 1;
            this.lblTipMsgTime.Text = "提示消息持续时间:";
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(280, 328);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.超级提示.SetSuperTooltip(this.btnStart, new DevComponents.DotNetBar.SuperTooltipInfo("启动程序", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(68, 24)));
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "启动程序";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnMin
            // 
            this.btnMin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMin.Location = new System.Drawing.Point(361, 328);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.超级提示.SetSuperTooltip(this.btnMin, new DevComponents.DotNetBar.SuperTooltipInfo("隐藏到系统托盘", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(107, 24)));
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "隐藏";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // groRunTime
            // 
            this.groRunTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groRunTime.CanvasColor = System.Drawing.SystemColors.Control;
            this.groRunTime.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groRunTime.Controls.Add(this.rdoTiming);
            this.groRunTime.Controls.Add(this.rdoImmediately);
            this.groRunTime.Controls.Add(this.btnTiming);
            this.groRunTime.Location = new System.Drawing.Point(175, 213);
            this.groRunTime.Name = "groRunTime";
            this.groRunTime.Size = new System.Drawing.Size(265, 109);
            // 
            // 
            // 
            this.groRunTime.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groRunTime.Style.BackColorGradientAngle = 90;
            this.groRunTime.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groRunTime.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groRunTime.Style.BorderBottomWidth = 1;
            this.groRunTime.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groRunTime.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groRunTime.Style.BorderLeftWidth = 1;
            this.groRunTime.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groRunTime.Style.BorderRightWidth = 1;
            this.groRunTime.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groRunTime.Style.BorderTopWidth = 1;
            this.groRunTime.Style.CornerDiameter = 4;
            this.groRunTime.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groRunTime.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groRunTime.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groRunTime.TabIndex = 5;
            this.groRunTime.Text = "时机";
            // 
            // rdoTiming
            // 
            this.rdoTiming.AutoSize = true;
            this.rdoTiming.Location = new System.Drawing.Point(14, 48);
            this.rdoTiming.Name = "rdoTiming";
            this.rdoTiming.Size = new System.Drawing.Size(47, 16);
            this.超级提示.SetSuperTooltip(this.rdoTiming, new DevComponents.DotNetBar.SuperTooltipInfo("定时指定操作", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(100, 24)));
            this.rdoTiming.TabIndex = 7;
            this.rdoTiming.TabStop = true;
            this.rdoTiming.Tag = "";
            this.rdoTiming.Text = "定时";
            this.rdoTiming.UseVisualStyleBackColor = true;
            this.rdoTiming.CheckedChanged += new System.EventHandler(this.rdoTiming_CheckedChanged);
            // 
            // rdoImmediately
            // 
            this.rdoImmediately.AutoSize = true;
            this.rdoImmediately.Checked = true;
            this.rdoImmediately.Location = new System.Drawing.Point(14, 15);
            this.rdoImmediately.Name = "rdoImmediately";
            this.rdoImmediately.Size = new System.Drawing.Size(47, 16);
            this.超级提示.SetSuperTooltip(this.rdoImmediately, new DevComponents.DotNetBar.SuperTooltipInfo("立即执行操作", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(100, 24)));
            this.rdoImmediately.TabIndex = 6;
            this.rdoImmediately.TabStop = true;
            this.rdoImmediately.Tag = "";
            this.rdoImmediately.Text = "立即";
            this.rdoImmediately.UseVisualStyleBackColor = true;
            // 
            // btnTiming
            // 
            this.btnTiming.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTiming.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTiming.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTiming.Enabled = false;
            this.btnTiming.Location = new System.Drawing.Point(176, 47);
            this.btnTiming.Name = "btnTiming";
            this.btnTiming.Size = new System.Drawing.Size(75, 23);
            this.超级提示.SetSuperTooltip(this.btnTiming, new DevComponents.DotNetBar.SuperTooltipInfo("指定时机执行操作", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(120, 24)));
            this.btnTiming.TabIndex = 3;
            this.btnTiming.Text = "定时...";
            this.btnTiming.Click += new System.EventHandler(this.btnTiming_Click);
            // 
            // groOption
            // 
            this.groOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groOption.CanvasColor = System.Drawing.SystemColors.Control;
            this.groOption.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groOption.Controls.Add(this.btnProgram);
            this.groOption.Controls.Add(this.chkRunProgram);
            this.groOption.Controls.Add(this.btnMsg);
            this.groOption.Controls.Add(this.chkTipMsg);
            this.groOption.Location = new System.Drawing.Point(175, 98);
            this.groOption.Name = "groOption";
            this.groOption.Size = new System.Drawing.Size(265, 101);
            // 
            // 
            // 
            this.groOption.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groOption.Style.BackColorGradientAngle = 90;
            this.groOption.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groOption.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groOption.Style.BorderBottomWidth = 1;
            this.groOption.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groOption.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groOption.Style.BorderLeftWidth = 1;
            this.groOption.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groOption.Style.BorderRightWidth = 1;
            this.groOption.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groOption.Style.BorderTopWidth = 1;
            this.groOption.Style.CornerDiameter = 4;
            this.groOption.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groOption.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groOption.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groOption.TabIndex = 4;
            this.groOption.Text = "选项";
            // 
            // btnProgram
            // 
            this.btnProgram.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProgram.Enabled = false;
            this.btnProgram.Location = new System.Drawing.Point(176, 42);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(75, 23);
            this.超级提示.SetSuperTooltip(this.btnProgram, new DevComponents.DotNetBar.SuperTooltipInfo("选择执行操作前所要运行的程序", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(194, 24)));
            this.btnProgram.TabIndex = 5;
            this.btnProgram.Text = "程序...";
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // chkRunProgram
            // 
            this.chkRunProgram.Location = new System.Drawing.Point(14, 44);
            this.chkRunProgram.Name = "chkRunProgram";
            this.chkRunProgram.Size = new System.Drawing.Size(75, 23);
            this.超级提示.SetSuperTooltip(this.chkRunProgram, new DevComponents.DotNetBar.SuperTooltipInfo("指定执行操作前所要运行的程序。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(206, 24)));
            this.chkRunProgram.TabIndex = 4;
            this.chkRunProgram.Text = "运行程序";
            this.chkRunProgram.CheckedChanged += new System.EventHandler(this.chkRunProgram_CheckedChanged);
            // 
            // btnMsg
            // 
            this.btnMsg.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsg.Enabled = false;
            this.btnMsg.Location = new System.Drawing.Point(176, 8);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(75, 23);
            this.超级提示.SetSuperTooltip(this.btnMsg, new DevComponents.DotNetBar.SuperTooltipInfo("设置执行操作前的提示信息。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(182, 24)));
            this.btnMsg.TabIndex = 3;
            this.btnMsg.Text = "消息...";
            this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
            // 
            // chkTipMsg
            // 
            this.chkTipMsg.Location = new System.Drawing.Point(14, 10);
            this.chkTipMsg.Name = "chkTipMsg";
            this.chkTipMsg.Size = new System.Drawing.Size(75, 23);
            this.超级提示.SetSuperTooltip(this.chkTipMsg, new DevComponents.DotNetBar.SuperTooltipInfo("指定执行操作前的提示信息。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(182, 24)));
            this.chkTipMsg.TabIndex = 0;
            this.chkTipMsg.Text = "提示消息";
            this.chkTipMsg.CheckedChanged += new System.EventHandler(this.chkTipMsg_CheckedChanged);
            // 
            // groAction
            // 
            this.groAction.CanvasColor = System.Drawing.SystemColors.Control;
            this.groAction.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groAction.Controls.Add(this.rdoNot);
            this.groAction.Controls.Add(this.rdoOpenDisplay);
            this.groAction.Controls.Add(this.rdoCloseDisplay);
            this.groAction.Controls.Add(this.rdoLock);
            this.groAction.Controls.Add(this.rdoDormant);
            this.groAction.Controls.Add(this.rdoStopWork);
            this.groAction.Controls.Add(this.rdoClosePower);
            this.groAction.Controls.Add(this.rdoCloseSystem);
            this.groAction.Controls.Add(this.rdoRestart);
            this.groAction.Controls.Add(this.rdoLogout);
            this.groAction.Location = new System.Drawing.Point(14, 94);
            this.groAction.Name = "groAction";
            this.groAction.Size = new System.Drawing.Size(141, 256);
            // 
            // 
            // 
            this.groAction.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groAction.Style.BackColorGradientAngle = 90;
            this.groAction.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groAction.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.groAction.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groAction.Style.BorderBottomWidth = 1;
            this.groAction.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groAction.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groAction.Style.BorderLeftWidth = 1;
            this.groAction.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groAction.Style.BorderRightWidth = 1;
            this.groAction.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groAction.Style.BorderTopWidth = 1;
            this.groAction.Style.CornerDiameter = 4;
            this.groAction.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groAction.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groAction.TabIndex = 3;
            this.groAction.Text = "动作";
            // 
            // rdoNot
            // 
            this.rdoNot.AutoSize = true;
            this.rdoNot.Location = new System.Drawing.Point(11, 211);
            this.rdoNot.Name = "rdoNot";
            this.rdoNot.Size = new System.Drawing.Size(59, 16);
            this.超级提示.SetSuperTooltip(this.rdoNot, new DevComponents.DotNetBar.SuperTooltipInfo("无操作", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(58, 24)));
            this.rdoNot.TabIndex = 10;
            this.rdoNot.Tag = "无操作";
            this.rdoNot.Text = "无动作";
            this.rdoNot.UseVisualStyleBackColor = true;
            // 
            // rdoOpenDisplay
            // 
            this.rdoOpenDisplay.AutoSize = true;
            this.rdoOpenDisplay.Location = new System.Drawing.Point(11, 189);
            this.rdoOpenDisplay.Name = "rdoOpenDisplay";
            this.rdoOpenDisplay.Size = new System.Drawing.Size(83, 16);
            this.超级提示.SetSuperTooltip(this.rdoOpenDisplay, new DevComponents.DotNetBar.SuperTooltipInfo("开启显示器", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(80, 24)));
            this.rdoOpenDisplay.TabIndex = 9;
            this.rdoOpenDisplay.Tag = "打开显示器";
            this.rdoOpenDisplay.Text = "打开显示器";
            this.rdoOpenDisplay.UseVisualStyleBackColor = true;
            // 
            // rdoCloseDisplay
            // 
            this.rdoCloseDisplay.AutoSize = true;
            this.rdoCloseDisplay.Checked = true;
            this.rdoCloseDisplay.Location = new System.Drawing.Point(11, 167);
            this.rdoCloseDisplay.Name = "rdoCloseDisplay";
            this.rdoCloseDisplay.Size = new System.Drawing.Size(83, 16);
            this.超级提示.SetSuperTooltip(this.rdoCloseDisplay, new DevComponents.DotNetBar.SuperTooltipInfo("关闭显示器，节约能源。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(157, 24)));
            this.rdoCloseDisplay.TabIndex = 8;
            this.rdoCloseDisplay.TabStop = true;
            this.rdoCloseDisplay.Tag = "关闭显示器";
            this.rdoCloseDisplay.Text = "关闭显示器";
            this.rdoCloseDisplay.UseVisualStyleBackColor = true;
            // 
            // rdoLock
            // 
            this.rdoLock.AutoSize = true;
            this.rdoLock.Location = new System.Drawing.Point(11, 146);
            this.rdoLock.Name = "rdoLock";
            this.rdoLock.Size = new System.Drawing.Size(47, 16);
            this.超级提示.SetSuperTooltip(this.rdoLock, new DevComponents.DotNetBar.SuperTooltipInfo("锁定该计算机。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(107, 24)));
            this.rdoLock.TabIndex = 6;
            this.rdoLock.Tag = "锁定";
            this.rdoLock.Text = "锁定";
            this.rdoLock.UseVisualStyleBackColor = true;
            // 
            // rdoDormant
            // 
            this.rdoDormant.AutoSize = true;
            this.rdoDormant.Location = new System.Drawing.Point(11, 124);
            this.rdoDormant.Name = "rdoDormant";
            this.rdoDormant.Size = new System.Drawing.Size(47, 16);
            this.超级提示.SetSuperTooltip(this.rdoDormant, new DevComponents.DotNetBar.SuperTooltipInfo("保存会话并关闭计算机。打开计算机时，系统会还原会话。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(343, 24)));
            this.rdoDormant.TabIndex = 5;
            this.rdoDormant.Tag = "休眠";
            this.rdoDormant.Text = "休眠";
            this.rdoDormant.UseVisualStyleBackColor = true;
            // 
            // rdoStopWork
            // 
            this.rdoStopWork.AutoSize = true;
            this.rdoStopWork.Location = new System.Drawing.Point(11, 102);
            this.rdoStopWork.Name = "rdoStopWork";
            this.rdoStopWork.Size = new System.Drawing.Size(47, 16);
            this.超级提示.SetSuperTooltip(this.rdoStopWork, new DevComponents.DotNetBar.SuperTooltipInfo("将会话保存在内存中并将计算机置于低功耗状态，这样即可快速恢复工作状态。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(454, 24)));
            this.rdoStopWork.TabIndex = 4;
            this.rdoStopWork.Tag = "待机";
            this.rdoStopWork.Text = "待机";
            this.rdoStopWork.UseVisualStyleBackColor = true;
            // 
            // rdoClosePower
            // 
            this.rdoClosePower.AutoSize = true;
            this.rdoClosePower.Location = new System.Drawing.Point(11, 80);
            this.rdoClosePower.Name = "rdoClosePower";
            this.rdoClosePower.Size = new System.Drawing.Size(71, 16);
            this.超级提示.SetSuperTooltip(this.rdoClosePower, new DevComponents.DotNetBar.SuperTooltipInfo("关闭所有打开的程序，然后关闭计算机。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(243, 24)));
            this.rdoClosePower.TabIndex = 3;
            this.rdoClosePower.Tag = "-s -t 0";
            this.rdoClosePower.Text = "关闭电源";
            this.rdoClosePower.UseVisualStyleBackColor = true;
            // 
            // rdoCloseSystem
            // 
            this.rdoCloseSystem.AutoSize = true;
            this.rdoCloseSystem.Location = new System.Drawing.Point(11, 58);
            this.rdoCloseSystem.Name = "rdoCloseSystem";
            this.rdoCloseSystem.Size = new System.Drawing.Size(71, 16);
            this.超级提示.SetSuperTooltip(this.rdoCloseSystem, new DevComponents.DotNetBar.SuperTooltipInfo("关闭所有打开的程序，然后关闭计算机。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(243, 24)));
            this.rdoCloseSystem.TabIndex = 2;
            this.rdoCloseSystem.Tag = "-s -t 0";
            this.rdoCloseSystem.Text = "关闭系统";
            this.rdoCloseSystem.UseVisualStyleBackColor = true;
            // 
            // rdoRestart
            // 
            this.rdoRestart.AutoSize = true;
            this.rdoRestart.Location = new System.Drawing.Point(11, 36);
            this.rdoRestart.Name = "rdoRestart";
            this.rdoRestart.Size = new System.Drawing.Size(71, 16);
            this.超级提示.SetSuperTooltip(this.rdoRestart, new DevComponents.DotNetBar.SuperTooltipInfo("关闭所有打开的程序，关闭计算机，然后重新启动计算机。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(343, 24)));
            this.rdoRestart.TabIndex = 1;
            this.rdoRestart.Tag = "-r -t 0";
            this.rdoRestart.Text = "重新启动";
            this.rdoRestart.UseVisualStyleBackColor = true;
            // 
            // rdoLogout
            // 
            this.rdoLogout.AutoSize = true;
            this.rdoLogout.Location = new System.Drawing.Point(11, 14);
            this.rdoLogout.Name = "rdoLogout";
            this.rdoLogout.Size = new System.Drawing.Size(71, 16);
            this.超级提示.SetSuperTooltip(this.rdoLogout, new DevComponents.DotNetBar.SuperTooltipInfo("关闭所有程序并注销。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(144, 24)));
            this.rdoLogout.TabIndex = 0;
            this.rdoLogout.Tag = "-f";
            this.rdoLogout.Text = "注销用户";
            this.rdoLogout.UseVisualStyleBackColor = true;
            // 
            // groSelectComputer
            // 
            this.groSelectComputer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groSelectComputer.BackColor = System.Drawing.Color.Transparent;
            this.groSelectComputer.Controls.Add(this.rdoLocalhost);
            this.groSelectComputer.Controls.Add(this.btnAppoint);
            this.groSelectComputer.Controls.Add(this.rdoLong);
            this.groSelectComputer.Location = new System.Drawing.Point(12, 38);
            this.groSelectComputer.Name = "groSelectComputer";
            this.groSelectComputer.Size = new System.Drawing.Size(428, 52);
            this.groSelectComputer.TabIndex = 2;
            this.groSelectComputer.TabStop = false;
            this.groSelectComputer.Text = "选择计算机";
            // 
            // rdoLocalhost
            // 
            this.rdoLocalhost.AutoSize = true;
            this.rdoLocalhost.Checked = true;
            this.rdoLocalhost.Location = new System.Drawing.Point(16, 24);
            this.rdoLocalhost.Name = "rdoLocalhost";
            this.rdoLocalhost.Size = new System.Drawing.Size(83, 16);
            this.超级提示.SetSuperTooltip(this.rdoLocalhost, new DevComponents.DotNetBar.SuperTooltipInfo("所做的操作都是基于本机的", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(169, 24)));
            this.rdoLocalhost.TabIndex = 0;
            this.rdoLocalhost.TabStop = true;
            this.rdoLocalhost.Text = "本地计算机";
            this.rdoLocalhost.UseVisualStyleBackColor = true;
            // 
            // btnAppoint
            // 
            this.btnAppoint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAppoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppoint.Enabled = false;
            this.btnAppoint.Location = new System.Drawing.Point(342, 17);
            this.btnAppoint.Name = "btnAppoint";
            this.btnAppoint.Size = new System.Drawing.Size(75, 23);
            this.超级提示.SetSuperTooltip(this.btnAppoint, new DevComponents.DotNetBar.SuperTooltipInfo("指定远程计算机", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(107, 24)));
            this.btnAppoint.TabIndex = 2;
            this.btnAppoint.Text = "指定...";
            this.btnAppoint.Click += new System.EventHandler(this.btnAppoint_Click_1);
            // 
            // rdoLong
            // 
            this.rdoLong.AutoSize = true;
            this.rdoLong.Location = new System.Drawing.Point(166, 24);
            this.rdoLong.Name = "rdoLong";
            this.rdoLong.Size = new System.Drawing.Size(83, 16);
            this.超级提示.SetSuperTooltip(this.rdoLong, new DevComponents.DotNetBar.SuperTooltipInfo("对于远程计算机的操作", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(144, 24)));
            this.rdoLong.TabIndex = 1;
            this.rdoLong.Text = "远程计算机";
            this.rdoLong.UseVisualStyleBackColor = true;
            this.rdoLong.CheckedChanged += new System.EventHandler(this.rdoLong_CheckedChanged);
            // 
            // picShowMe
            // 
            this.picShowMe.BackColor = System.Drawing.Color.Transparent;
            this.picShowMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShowMe.Location = new System.Drawing.Point(17, 95);
            this.picShowMe.Name = "picShowMe";
            this.picShowMe.Size = new System.Drawing.Size(155, 155);
            this.picShowMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.超级提示.SetSuperTooltip(this.picShowMe, new DevComponents.DotNetBar.SuperTooltipInfo("单击有序播放/单击无序播放。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(0, 0)));
            this.picShowMe.TabIndex = 10;
            this.picShowMe.TabStop = false;
            this.picShowMe.Click += new System.EventHandler(this.picShowMe_Click);
            // 
            // imgsShowMe
            // 
            this.imgsShowMe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgsShowMe.ImageStream")));
            this.imgsShowMe.TransparentColor = System.Drawing.Color.Transparent;
            this.imgsShowMe.Images.SetKeyName(0, "07-08-10_1911.jpg");
            this.imgsShowMe.Images.SetKeyName(1, "11-08-10_1210.jpg");
            this.imgsShowMe.Images.SetKeyName(2, "11-08-10_1211.jpg");
            this.imgsShowMe.Images.SetKeyName(3, "11-08-10_1213.jpg");
            this.imgsShowMe.Images.SetKeyName(4, "11-08-10_1215.jpg");
            this.imgsShowMe.Images.SetKeyName(5, "11-08-10_1216.jpg");
            this.imgsShowMe.Images.SetKeyName(6, "11-08-10_1218.jpg");
            this.imgsShowMe.Images.SetKeyName(7, "11-08-10_1705.jpg");
            this.imgsShowMe.Images.SetKeyName(8, "14-08-10_1720.jpg");
            this.imgsShowMe.Images.SetKeyName(9, "14-08-10_1721.jpg");
            this.imgsShowMe.Images.SetKeyName(10, "14-08-10_1810.jpg");
            this.imgsShowMe.Images.SetKeyName(11, "14-08-10_1811.jpg");
            this.imgsShowMe.Images.SetKeyName(12, "IMG0006A.jpg");
            this.imgsShowMe.Images.SetKeyName(13, "IMG0007A.jpg");
            this.imgsShowMe.Images.SetKeyName(14, "IMG0008A.jpg");
            this.imgsShowMe.Images.SetKeyName(15, "IMG0009A.jpg");
            this.imgsShowMe.Images.SetKeyName(16, "IMG0010A.jpg");
            this.imgsShowMe.Images.SetKeyName(17, "IMG0011A.jpg");
            this.imgsShowMe.Images.SetKeyName(18, "IMG0012A.jpg");
            this.imgsShowMe.Images.SetKeyName(19, "IMG0013A.jpg");
            this.imgsShowMe.Images.SetKeyName(20, "IMG0020A.jpg");
            this.imgsShowMe.Images.SetKeyName(21, "IMG0022A.jpg");
            this.imgsShowMe.Images.SetKeyName(22, "照片-0205.jpg");
            this.imgsShowMe.Images.SetKeyName(23, "照片-0212.jpg");
            this.imgsShowMe.Images.SetKeyName(24, "照片-0213.jpg");
            this.imgsShowMe.Images.SetKeyName(25, "照片-0214.jpg");
            this.imgsShowMe.Images.SetKeyName(26, "照片-0215.jpg");
            this.imgsShowMe.Images.SetKeyName(27, "照片-02151.jpg");
            this.imgsShowMe.Images.SetKeyName(28, "照片-02169.jpg");
            // 
            // openFile
            // 
            this.openFile.Filter = "可执行文件|*.exe|所有文件|*.*";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipTitle = "In fixed time shut down - 定时关机";
            this.notifyIcon.ContextMenuStrip = this.rmnuIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "In fixed time shut down - 定时关机";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // rmnuIcon
            // 
            this.rmnuIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rmnuRestore,
            this.toolStripMenuItem1,
            this.rmnuLogout,
            this.rmnuRestart,
            this.rmnuCloseSystem,
            this.rmnuWait,
            this.rmnuDormant,
            this.rmnuLock,
            this.rmnuCloseDisplay,
            this.toolStripMenuItem4,
            this.rmnuAutoPlay,
            this.toolStripMenuItem5,
            this.rmnuAutoRun,
            this.toolStripMenuItem2,
            this.rmnuBreak,
            this.toolStripMenuItem3,
            this.rmnuExit});
            this.rmnuIcon.Name = "rmnuIcon";
            this.rmnuIcon.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.rmnuIcon.Size = new System.Drawing.Size(149, 298);
            this.rmnuIcon.Opening += new System.ComponentModel.CancelEventHandler(this.rmnuIcon_Opening);
            // 
            // rmnuRestore
            // 
            this.rmnuRestore.Name = "rmnuRestore";
            this.rmnuRestore.Size = new System.Drawing.Size(148, 22);
            this.rmnuRestore.Text = "隐藏";
            this.rmnuRestore.Click += new System.EventHandler(this.rmnuRestore_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // rmnuLogout
            // 
            this.rmnuLogout.Name = "rmnuLogout";
            this.rmnuLogout.Size = new System.Drawing.Size(148, 22);
            this.rmnuLogout.Text = "注销用户";
            this.rmnuLogout.Click += new System.EventHandler(this.rmnuLogout_Click);
            // 
            // rmnuRestart
            // 
            this.rmnuRestart.Name = "rmnuRestart";
            this.rmnuRestart.Size = new System.Drawing.Size(148, 22);
            this.rmnuRestart.Text = "重新启动";
            this.rmnuRestart.Click += new System.EventHandler(this.rmnuRestart_Click);
            // 
            // rmnuCloseSystem
            // 
            this.rmnuCloseSystem.Name = "rmnuCloseSystem";
            this.rmnuCloseSystem.Size = new System.Drawing.Size(148, 22);
            this.rmnuCloseSystem.Text = "关闭系统";
            this.rmnuCloseSystem.Click += new System.EventHandler(this.rmnuCloseSystem_Click);
            // 
            // rmnuWait
            // 
            this.rmnuWait.Name = "rmnuWait";
            this.rmnuWait.Size = new System.Drawing.Size(148, 22);
            this.rmnuWait.Text = "待机";
            this.rmnuWait.Click += new System.EventHandler(this.rmnuWait_Click);
            // 
            // rmnuDormant
            // 
            this.rmnuDormant.Name = "rmnuDormant";
            this.rmnuDormant.Size = new System.Drawing.Size(148, 22);
            this.rmnuDormant.Text = "休眠";
            this.rmnuDormant.Click += new System.EventHandler(this.rmnuDormant_Click);
            // 
            // rmnuLock
            // 
            this.rmnuLock.Name = "rmnuLock";
            this.rmnuLock.Size = new System.Drawing.Size(148, 22);
            this.rmnuLock.Text = "锁定";
            this.rmnuLock.Click += new System.EventHandler(this.rmnuLock_Click);
            // 
            // rmnuCloseDisplay
            // 
            this.rmnuCloseDisplay.Name = "rmnuCloseDisplay";
            this.rmnuCloseDisplay.Size = new System.Drawing.Size(148, 22);
            this.rmnuCloseDisplay.Text = "关闭显示器";
            this.rmnuCloseDisplay.Click += new System.EventHandler(this.rmnuCloseDisplay_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(145, 6);
            // 
            // rmnuAutoPlay
            // 
            this.rmnuAutoPlay.Name = "rmnuAutoPlay";
            this.rmnuAutoPlay.Size = new System.Drawing.Size(148, 22);
            this.rmnuAutoPlay.Text = "现在报时";
            this.rmnuAutoPlay.Click += new System.EventHandler(this.rmnuAutoPlay_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(145, 6);
            // 
            // rmnuAutoRun
            // 
            this.rmnuAutoRun.Name = "rmnuAutoRun";
            this.rmnuAutoRun.Size = new System.Drawing.Size(148, 22);
            this.rmnuAutoRun.Text = "开机自动启动";
            this.rmnuAutoRun.CheckedChanged += new System.EventHandler(this.rmnuAutoRun_CheckedChanged);
            this.rmnuAutoRun.Click += new System.EventHandler(this.rmnuAutoRun_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 6);
            // 
            // rmnuBreak
            // 
            this.rmnuBreak.Enabled = false;
            this.rmnuBreak.Name = "rmnuBreak";
            this.rmnuBreak.Size = new System.Drawing.Size(148, 22);
            this.rmnuBreak.Text = "中止任务";
            this.rmnuBreak.Click += new System.EventHandler(this.rmnuBreak_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
            // 
            // rmnuExit
            // 
            this.rmnuExit.Name = "rmnuExit";
            this.rmnuExit.Size = new System.Drawing.Size(148, 22);
            this.rmnuExit.Text = "退出程序";
            this.rmnuExit.Click += new System.EventHandler(this.rmnuExit_Click);
            // 
            // timerMove
            // 
            this.timerMove.Enabled = true;
            this.timerMove.Interval = 1;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // rbcTitleBar
            // 
            this.rbcTitleBar.CaptionVisible = true;
            this.rbcTitleBar.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.rbcTitleBar.Location = new System.Drawing.Point(-25, 0);
            this.rbcTitleBar.Name = "rbcTitleBar";
            this.rbcTitleBar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.rbcTitleBar.Size = new System.Drawing.Size(554, 22);
            this.rbcTitleBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbcTitleBar.TabGroupHeight = 14;
            this.rbcTitleBar.TabIndex = 13;
            this.rbcTitleBar.TitleText = " ";
            // 
            // btnCtrlMin
            // 
            this.btnCtrlMin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCtrlMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCtrlMin.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnCtrlMin.Location = new System.Drawing.Point(388, 0);
            this.btnCtrlMin.Name = "btnCtrlMin";
            this.btnCtrlMin.Size = new System.Drawing.Size(34, 25);
            this.超级提示.SetSuperTooltip(this.btnCtrlMin, new DevComponents.DotNetBar.SuperTooltipInfo("隐藏到系统托盘", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(107, 24)));
            this.btnCtrlMin.TabIndex = 999;
            this.btnCtrlMin.TabStop = false;
            this.btnCtrlMin.Text = "▁";
            this.btnCtrlMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCtrlMin_MouseClick);
            this.btnCtrlMin.Enter += new System.EventHandler(this.btnCtrlClose_Enter);
            // 
            // btnCtrlClose
            // 
            this.btnCtrlClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCtrlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCtrlClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnCtrlClose.Checked = true;
            this.btnCtrlClose.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnCtrlClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCtrlClose.Location = new System.Drawing.Point(420, 0);
            this.btnCtrlClose.Name = "btnCtrlClose";
            this.btnCtrlClose.Size = new System.Drawing.Size(34, 25);
            this.超级提示.SetSuperTooltip(this.btnCtrlClose, new DevComponents.DotNetBar.SuperTooltipInfo("退出 In fixed time shut down - 定时关机", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(263, 24)));
            this.btnCtrlClose.TabIndex = 998;
            this.btnCtrlClose.TabStop = false;
            this.btnCtrlClose.Text = "ㄨ";
            this.btnCtrlClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCtrlClose_MouseClick);
            this.btnCtrlClose.Enter += new System.EventHandler(this.btnCtrlClose_Enter);
            // 
            // pnlFormBorder
            // 
            this.pnlFormBorder.AllowDrop = true;
            this.pnlFormBorder.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormBorder.Controls.Add(this.btnChangeSkin);
            this.pnlFormBorder.Controls.Add(this.btnMiddleLine);
            this.pnlFormBorder.Controls.Add(this.cmbControl);
            this.pnlFormBorder.Controls.Add(this.btnTimeNow);
            this.pnlFormBorder.Controls.Add(this.rbcTitleBar);
            this.pnlFormBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBorder.Name = "pnlFormBorder";
            this.pnlFormBorder.Size = new System.Drawing.Size(454, 658);
            this.pnlFormBorder.TabIndex = 1000;
            this.pnlFormBorder.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlFormBorder_DragDrop);
            this.pnlFormBorder.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlFormBorder_DragEnter);
            // 
            // btnChangeSkin
            // 
            this.btnChangeSkin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChangeSkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeSkin.AutoExpandOnClick = true;
            this.btnChangeSkin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChangeSkin.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeSkin.Image")));
            this.btnChangeSkin.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnChangeSkin.Location = new System.Drawing.Point(357, -2);
            this.btnChangeSkin.Name = "btnChangeSkin";
            this.btnChangeSkin.Size = new System.Drawing.Size(22, 21);
            this.btnChangeSkin.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSkinBlue,
            this.btnSkinGray,
            this.btnSkinBlack});
            this.超级提示.SetSuperTooltip(this.btnChangeSkin, new DevComponents.DotNetBar.SuperTooltipInfo("更换主题", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(70, 24)));
            this.btnChangeSkin.TabIndex = 19;
            this.btnChangeSkin.MouseLeave += new System.EventHandler(this.btnChangeSkin_MouseLeave);
            this.btnChangeSkin.Enter += new System.EventHandler(this.btnCtrlClose_Enter);
            this.btnChangeSkin.MouseEnter += new System.EventHandler(this.btnChangeSkin_MouseEnter);
            // 
            // btnSkinBlue
            // 
            this.btnSkinBlue.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnSkinBlue.GlobalItem = false;
            this.btnSkinBlue.ImagePaddingHorizontal = 8;
            this.btnSkinBlue.Name = "btnSkinBlue";
            this.btnSkinBlue.Text = "蓝色心情";
            this.btnSkinBlue.Click += new System.EventHandler(this.btnSkinBlue_Click);
            // 
            // btnSkinGray
            // 
            this.btnSkinGray.GlobalItem = false;
            this.btnSkinGray.ImagePaddingHorizontal = 8;
            this.btnSkinGray.Name = "btnSkinGray";
            this.btnSkinGray.Text = "灰色空间";
            this.btnSkinGray.Click += new System.EventHandler(this.btnSkinGray_Click);
            // 
            // btnSkinBlack
            // 
            this.btnSkinBlack.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnSkinBlack.GlobalItem = false;
            this.btnSkinBlack.ImagePaddingHorizontal = 8;
            this.btnSkinBlack.Name = "btnSkinBlack";
            this.btnSkinBlack.Text = "黑色星期天";
            this.btnSkinBlack.Click += new System.EventHandler(this.btnSkinBlack_Click);
            // 
            // btnMiddleLine
            // 
            this.btnMiddleLine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMiddleLine.Checked = true;
            this.btnMiddleLine.Location = new System.Drawing.Point(-25, 294);
            this.btnMiddleLine.Name = "btnMiddleLine";
            this.btnMiddleLine.Size = new System.Drawing.Size(499, 23);
            this.btnMiddleLine.TabIndex = 18;
            // 
            // cmbControl
            // 
            this.cmbControl.AutoHideTabTextAlwaysVisible = true;
            this.cmbControl.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.cmbControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cbtnTitle});
            this.cmbControl.Location = new System.Drawing.Point(4, -3);
            this.cmbControl.Name = "cmbControl";
            this.cmbControl.Size = new System.Drawing.Size(252, 31);
            this.cmbControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.cmbControl.TabIndex = 17;
            this.cmbControl.TabStop = false;
            // 
            // cbtnTitle
            // 
            this.cbtnTitle.AutoExpandOnClick = true;
            this.cbtnTitle.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.cbtnTitle.Checked = true;
            this.cbtnTitle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cbtnTitle.Image = ((System.Drawing.Image)(resources.GetObject("cbtnTitle.Image")));
            this.cbtnTitle.ImagePaddingHorizontal = 8;
            this.cbtnTitle.Name = "cbtnTitle";
            this.cbtnTitle.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.Unfold;
            this.cbtnTitle.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cbtnRestore,
            this.cbtnLogout,
            this.cbtnRestart,
            this.cbtnCloseSystem,
            this.cbtnWait,
            this.cbtnDormant,
            this.cbtnLock,
            this.cbtnCloseDisplay,
            this.cbtnAutoPlay,
            this.btnSoftCut,
            this.cbtnAutoRun,
            this.btnExit});
            this.cbtnTitle.Text = "In fixed time shut down - 定时关机";
            this.cbtnTitle.PopupOpen += new DevComponents.DotNetBar.DotNetBarManager.PopupOpenEventHandler(this.cbtnTitle_PopupOpen);
            // 
            // cbtnRestore
            // 
            this.cbtnRestore.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.cbtnRestore.ImagePaddingHorizontal = 8;
            this.cbtnRestore.Name = "cbtnRestore";
            this.超级提示.SetSuperTooltip(this.cbtnRestore, new DevComponents.DotNetBar.SuperTooltipInfo("隐藏到系统托盘", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(107, 24)));
            this.cbtnRestore.Text = "隐藏";
            this.cbtnRestore.Click += new System.EventHandler(this.rmnuRestore_Click);
            // 
            // cbtnLogout
            // 
            this.cbtnLogout.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.cbtnLogout.ImagePaddingHorizontal = 8;
            this.cbtnLogout.Name = "cbtnLogout";
            this.超级提示.SetSuperTooltip(this.cbtnLogout, new DevComponents.DotNetBar.SuperTooltipInfo("关闭所有程序并注销。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(144, 24)));
            this.cbtnLogout.Text = "注销用户";
            this.cbtnLogout.Click += new System.EventHandler(this.rmnuLogout_Click);
            // 
            // cbtnRestart
            // 
            this.cbtnRestart.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.cbtnRestart.ImagePaddingHorizontal = 8;
            this.cbtnRestart.Name = "cbtnRestart";
            this.超级提示.SetSuperTooltip(this.cbtnRestart, new DevComponents.DotNetBar.SuperTooltipInfo("关闭所有打开的程序，关闭计算机，然后重新启动计算机。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(343, 24)));
            this.cbtnRestart.Text = "重新启动";
            this.cbtnRestart.Click += new System.EventHandler(this.rmnuRestart_Click);
            // 
            // cbtnCloseSystem
            // 
            this.cbtnCloseSystem.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.cbtnCloseSystem.ImagePaddingHorizontal = 8;
            this.cbtnCloseSystem.Name = "cbtnCloseSystem";
            this.超级提示.SetSuperTooltip(this.cbtnCloseSystem, new DevComponents.DotNetBar.SuperTooltipInfo("关闭所有打开的程序，然后关闭计算机。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(243, 24)));
            this.cbtnCloseSystem.Text = "关闭系统";
            this.cbtnCloseSystem.Click += new System.EventHandler(this.rmnuCloseSystem_Click);
            // 
            // cbtnWait
            // 
            this.cbtnWait.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.cbtnWait.ImagePaddingHorizontal = 8;
            this.cbtnWait.Name = "cbtnWait";
            this.超级提示.SetSuperTooltip(this.cbtnWait, new DevComponents.DotNetBar.SuperTooltipInfo("将会话保存在内存中并将计算机置于低功耗状态，这样即可快速恢复工作状态。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(454, 24)));
            this.cbtnWait.Text = "待机";
            this.cbtnWait.Click += new System.EventHandler(this.rmnuWait_Click);
            // 
            // cbtnDormant
            // 
            this.cbtnDormant.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.cbtnDormant.ImagePaddingHorizontal = 8;
            this.cbtnDormant.Name = "cbtnDormant";
            this.超级提示.SetSuperTooltip(this.cbtnDormant, new DevComponents.DotNetBar.SuperTooltipInfo("保存会话并关闭计算机。打开计算机时，系统会还原会话。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(343, 24)));
            this.cbtnDormant.Text = "休眠";
            this.cbtnDormant.Click += new System.EventHandler(this.rmnuDormant_Click);
            // 
            // cbtnLock
            // 
            this.cbtnLock.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.cbtnLock.ImagePaddingHorizontal = 8;
            this.cbtnLock.Name = "cbtnLock";
            this.超级提示.SetSuperTooltip(this.cbtnLock, new DevComponents.DotNetBar.SuperTooltipInfo("锁定该计算机。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(107, 24)));
            this.cbtnLock.Text = "锁定";
            this.cbtnLock.Click += new System.EventHandler(this.rmnuLock_Click);
            // 
            // cbtnCloseDisplay
            // 
            this.cbtnCloseDisplay.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.cbtnCloseDisplay.ImagePaddingHorizontal = 8;
            this.cbtnCloseDisplay.Name = "cbtnCloseDisplay";
            this.超级提示.SetSuperTooltip(this.cbtnCloseDisplay, new DevComponents.DotNetBar.SuperTooltipInfo("关闭显示器，节约能源。", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(157, 24)));
            this.cbtnCloseDisplay.Text = "关闭显示器";
            this.cbtnCloseDisplay.Click += new System.EventHandler(this.rmnuCloseDisplay_Click);
            // 
            // cbtnAutoPlay
            // 
            this.cbtnAutoPlay.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.cbtnAutoPlay.ImagePaddingHorizontal = 8;
            this.cbtnAutoPlay.Name = "cbtnAutoPlay";
            this.超级提示.SetSuperTooltip(this.cbtnAutoPlay, new DevComponents.DotNetBar.SuperTooltipInfo("语音报时", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(70, 24)));
            this.cbtnAutoPlay.Text = "现在报时";
            this.cbtnAutoPlay.Click += new System.EventHandler(this.rmnuAutoPlay_Click);
            // 
            // btnSoftCut
            // 
            this.btnSoftCut.FontBold = true;
            this.btnSoftCut.ImagePaddingHorizontal = 8;
            this.btnSoftCut.Name = "btnSoftCut";
            this.超级提示.SetSuperTooltip(this.btnSoftCut, new DevComponents.DotNetBar.SuperTooltipInfo("快速截取 In fixed time shut down - 定时关机 的姿态！", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(343, 24)));
            this.btnSoftCut.Text = "软件快照";
            this.btnSoftCut.Click += new System.EventHandler(this.btnSoftCut_Click);
            // 
            // cbtnAutoRun
            // 
            this.cbtnAutoRun.ImagePaddingHorizontal = 8;
            this.cbtnAutoRun.Name = "cbtnAutoRun";
            this.超级提示.SetSuperTooltip(this.cbtnAutoRun, new DevComponents.DotNetBar.SuperTooltipInfo("设置开机自动启动 In fixed time shut down - 定时关机", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(337, 24)));
            this.cbtnAutoRun.Text = "开机自动启动";
            this.cbtnAutoRun.Click += new System.EventHandler(this.rmnuAutoRun_Click);
            // 
            // btnExit
            // 
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnExit.ImagePaddingHorizontal = 8;
            this.btnExit.Name = "btnExit";
            this.超级提示.SetSuperTooltip(this.btnExit, new DevComponents.DotNetBar.SuperTooltipInfo("退出 In fixed time shut down - 定时关机", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(263, 24)));
            this.btnExit.Text = "退出程序";
            this.btnExit.Click += new System.EventHandler(this.rmnuExit_Click);
            // 
            // btnTimeNow
            // 
            this.btnTimeNow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimeNow.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnTimeNow.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTimeNow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimeNow.Location = new System.Drawing.Point(18, 260);
            this.btnTimeNow.Name = "btnTimeNow";
            this.btnTimeNow.Size = new System.Drawing.Size(414, 23);
            this.btnTimeNow.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAutoPlay});
            this.超级提示.SetSuperTooltip(this.btnTimeNow, new DevComponents.DotNetBar.SuperTooltipInfo("点击 语音报时 ", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(101, 24)));
            this.btnTimeNow.TabIndex = 2;
            this.btnTimeNow.TabStop = false;
            this.btnTimeNow.Text = "yyyy年MM月dd日(星期日) hh时:mm分:ss秒";
            this.btnTimeNow.Click += new System.EventHandler(this.tsbTimeNow_ButtonClick);
            this.btnTimeNow.Enter += new System.EventHandler(this.btnCtrlClose_Enter);
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.AutoCheckOnClick = true;
            this.btnAutoPlay.Checked = true;
            this.btnAutoPlay.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground;
            this.btnAutoPlay.ImagePaddingHorizontal = 8;
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.超级提示.SetSuperTooltip(this.btnAutoPlay, new DevComponents.DotNetBar.SuperTooltipInfo("启用/禁用 整点、半点自动报时", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(194, 24)));
            this.btnAutoPlay.Text = "整点、半点 自动语音报时";
            // 
            // timerShow
            // 
            this.timerShow.Interval = 1;
            this.timerShow.Tick += new System.EventHandler(this.timerShow_Tick);
            // 
            // 超级提示
            // 
            this.超级提示.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(0, 0));
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "JPEG|*.jpg;*.jpeg;*.jpe;*.jfif";
            // 
            // FrmReportTime
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnMin;
            this.ClientSize = new System.Drawing.Size(454, 658);
            this.Controls.Add(this.btnCtrlClose);
            this.Controls.Add(this.btnCtrlMin);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.lblTotalHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.picShowMe);
            this.Controls.Add(this.pnlFormBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(454, 658);
            this.Name = "FrmReportTime";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In fixed time shut down - 定时关机";
            this.Load += new System.EventHandler(this.FrmReportTime_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReportTime_FormClosing);
            this.Resize += new System.EventHandler(this.FrmReportTime_Resize);
            this.pnlControl.ResumeLayout(false);
            this.groTiming.ResumeLayout(false);
            this.groTiming.PerformLayout();
            this.pnlTiming.ResumeLayout(false);
            this.pnlTiming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimingMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimingHour)).EndInit();
            this.groProgram.ResumeLayout(false);
            this.groProgram.PerformLayout();
            this.groMessage.ResumeLayout(false);
            this.groMessage.PerformLayout();
            this.groRunTime.ResumeLayout(false);
            this.groRunTime.PerformLayout();
            this.groOption.ResumeLayout(false);
            this.groAction.ResumeLayout(false);
            this.groAction.PerformLayout();
            this.groSelectComputer.ResumeLayout(false);
            this.groSelectComputer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowMe)).EndInit();
            this.rmnuIcon.ResumeLayout(false);
            this.pnlFormBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerTimeNow;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalHour;
        private DevComponents.DotNetBar.ExpandablePanel pnlControl;
        private System.Windows.Forms.PictureBox picShowMe;
        private System.Windows.Forms.ImageList imgsShowMe;
        private System.Windows.Forms.GroupBox groSelectComputer;
        private DevComponents.DotNetBar.Controls.GroupPanel groAction;
        private System.Windows.Forms.RadioButton rdoLogout;
        private System.Windows.Forms.RadioButton rdoRestart;
        private System.Windows.Forms.RadioButton rdoCloseSystem;
        private System.Windows.Forms.RadioButton rdoClosePower;
        private System.Windows.Forms.RadioButton rdoStopWork;
        private System.Windows.Forms.RadioButton rdoDormant;
        private System.Windows.Forms.RadioButton rdoLock;
        private System.Windows.Forms.RadioButton rdoNot;
        private System.Windows.Forms.RadioButton rdoOpenDisplay;
        private System.Windows.Forms.RadioButton rdoCloseDisplay;
        private DevComponents.DotNetBar.Controls.GroupPanel groOption;
        private DevComponents.DotNetBar.ButtonX btnProgram;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkRunProgram;
        private DevComponents.DotNetBar.Controls.GroupPanel groRunTime;
        private DevComponents.DotNetBar.ButtonX btnTiming;
        private System.Windows.Forms.RadioButton rdoImmediately;
        private System.Windows.Forms.RadioButton rdoTiming;
        private DevComponents.DotNetBar.ButtonX btnStart;
        private DevComponents.DotNetBar.ButtonX btnMin;
        private DevComponents.DotNetBar.Controls.GroupPanel groMessage;
        private DevComponents.DotNetBar.LabelX lblMsgSecond;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTipMsgTime;
        private DevComponents.DotNetBar.LabelX lblTipMsgTime;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTipMsg;
        private DevComponents.DotNetBar.LabelX lblTipMsg;
        private DevComponents.DotNetBar.ButtonX btnMsgConfirm;
        private DevComponents.DotNetBar.ButtonX btnMsgCancel;
        private DevComponents.DotNetBar.Controls.GroupPanel groProgram;
        private DevComponents.DotNetBar.ButtonX btnProConfirm;
        private DevComponents.DotNetBar.ButtonX btnProCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProgramPath;
        private DevComponents.DotNetBar.LabelX lblRunProgram;
        private DevComponents.DotNetBar.ButtonX btnOpenDialog;
        private System.Windows.Forms.OpenFileDialog openFile;
        private DevComponents.DotNetBar.Controls.GroupPanel groTiming;
        private DevComponents.DotNetBar.ButtonX btnTimingConfirm;
        private DevComponents.DotNetBar.ButtonX btnTimingCancel;
        private System.Windows.Forms.RadioButton rdoTimingAppoint;
        private System.Windows.Forms.RadioButton rdoTimingReciprocal;
        private DevComponents.DotNetBar.LabelX lblTimingSecond;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimingReciprocalSecond;
        private System.Windows.Forms.Panel pnlTiming;
        private DevComponents.DotNetBar.LabelX lblTimingDate;
        private System.Windows.Forms.NumericUpDown numTimingMinute;
        private System.Windows.Forms.NumericUpDown numTimingHour;
        private DevComponents.DotNetBar.LabelX lblTimingMinute;
        private DevComponents.DotNetBar.LabelX lblTimingHour;
        private System.Windows.Forms.DateTimePicker dateTiming;
        private DevComponents.DotNetBar.LabelX lblTimingTime;
        private DevComponents.DotNetBar.LabelX lblWait;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimingWaitSecond;
        private DevComponents.DotNetBar.LabelX lblTimingWaitSecond;
        private DevComponents.DotNetBar.ButtonX btnMsg;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTipMsg;
        private System.Windows.Forms.RadioButton rdoLocalhost;
        private DevComponents.DotNetBar.ButtonX btnAppoint;
        private System.Windows.Forms.RadioButton rdoLong;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip rmnuIcon;
        private System.Windows.Forms.ToolStripMenuItem rmnuRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rmnuLogout;
        private System.Windows.Forms.ToolStripMenuItem rmnuRestart;
        private System.Windows.Forms.ToolStripMenuItem rmnuCloseSystem;
        private System.Windows.Forms.ToolStripMenuItem rmnuWait;
        private System.Windows.Forms.ToolStripMenuItem rmnuDormant;
        private System.Windows.Forms.ToolStripMenuItem rmnuLock;
        private System.Windows.Forms.ToolStripMenuItem rmnuCloseDisplay;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem rmnuBreak;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem rmnuExit;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem rmnuAutoPlay;
        private System.Windows.Forms.ToolStripMenuItem rmnuAutoRun;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private DevComponents.DotNetBar.RibbonControl rbcTitleBar;
        private DevComponents.DotNetBar.ButtonX btnCtrlMin;
        private DevComponents.DotNetBar.ButtonX btnCtrlClose;
        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Timer timerShow;
        private DevComponents.DotNetBar.SuperTooltip 超级提示;
        private DevComponents.DotNetBar.ButtonX btnTimeNow;
        private DevComponents.DotNetBar.ButtonItem btnAutoPlay;
        private DevComponents.DotNetBar.ContextMenuBar cmbControl;
        private DevComponents.DotNetBar.ButtonItem cbtnTitle;
        private DevComponents.DotNetBar.ButtonItem cbtnRestore;
        private DevComponents.DotNetBar.ButtonItem cbtnLogout;
        private DevComponents.DotNetBar.ButtonItem cbtnRestart;
        private DevComponents.DotNetBar.ButtonItem cbtnCloseSystem;
        private DevComponents.DotNetBar.ButtonItem cbtnWait;
        private DevComponents.DotNetBar.ButtonItem cbtnLock;
        private DevComponents.DotNetBar.ButtonItem cbtnCloseDisplay;
        private DevComponents.DotNetBar.ButtonItem cbtnDormant;
        private DevComponents.DotNetBar.ButtonItem cbtnAutoPlay;
        private DevComponents.DotNetBar.ButtonItem cbtnAutoRun;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private DevComponents.DotNetBar.ButtonX btnMiddleLine;
        private DevComponents.DotNetBar.ButtonX btnChangeSkin;
        private DevComponents.DotNetBar.ButtonItem btnSkinBlue;
        private DevComponents.DotNetBar.ButtonItem btnSkinBlack;
        private DevComponents.DotNetBar.ButtonItem btnSkinGray;
        private DevComponents.DotNetBar.ButtonItem btnSoftCut;
        private System.Windows.Forms.SaveFileDialog saveDialog;
    }
}

