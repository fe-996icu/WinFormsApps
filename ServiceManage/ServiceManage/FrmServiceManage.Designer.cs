namespace ServiceManage
{
    partial class FrmServiceManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServiceManage));
            this.picMiniButton = new System.Windows.Forms.PictureBox();
            this.picCloseButton = new System.Windows.Forms.PictureBox();
            this.pnlTopTitle = new System.Windows.Forms.Panel();
            this.lblTitleText = new System.Windows.Forms.Label();
            this.pnlBottomBorder = new System.Windows.Forms.Panel();
            this.pnlLeftBorder = new System.Windows.Forms.Panel();
            this.pnlRightBorder = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.picSuperMode = new System.Windows.Forms.PictureBox();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            this.imgsCtrlPict = new System.Windows.Forms.ImageList(this.components);
            this.iconManage = new System.Windows.Forms.NotifyIcon(this.components);
            this.rmnuICON = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rmnuShowMain = new System.Windows.Forms.ToolStripMenuItem();
            this.rmnuLine2 = new System.Windows.Forms.ToolStripSeparator();
            this.rmnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.rmnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tsControlButtons = new System.Windows.Forms.ToolStrip();
            this.tssbOracle11g = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiOracleMainService = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOracleMainServiceStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOracleMainServicePause = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOracleMainServiceContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOracleMainServiceStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOracleServiceLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOracleMainServiceRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOracleListenerService = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOracleListenerServiceStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOracleListenerServiceStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOracleListenerLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOracleListenerServiceRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOracleLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOracleCorrectConfigurationFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOracleLine2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOracleTodeOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToadKeyGen = new System.Windows.Forms.ToolStripMenuItem();
            this.tscboToadKeyName = new System.Windows.Forms.ToolStripComboBox();
            this.tstxtToadKeyValue = new System.Windows.Forms.ToolStripTextBox();
            this.tssbSQL2005 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiSQL2005ServiceStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSQL2005ServicePause = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSQL2005ServiceContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSQL2005ServiceStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSQL2005Line2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSQL2005ServiceRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSQL2005Line1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSQL2005Open = new System.Windows.Forms.ToolStripMenuItem();
            this.tssbSQL2008 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiSQL2008ServiceStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSQL2008ServicePause = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSQL2008ServiceContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSQL2008ServiceStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSQL2008Line2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSQL2008ServiceRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSQL2008Line1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSQL2008Open = new System.Windows.Forms.ToolStripMenuItem();
            this.tssbMySQL = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiMySQLServiceStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMySQLServiceStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMySQLLine2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiMySQLServiceRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMySQLLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiMySQLOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMainLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbAllSoftware = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiStudaySoftware = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdobe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAboleDW4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdobeFB4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdobeFlash4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdobePS4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdobeReaderX = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMicrosoft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMSVS2005 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMSVS2008 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMSVS2010 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMSMSDN2005 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMSMSDN2008 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEclipse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEclipse6_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEclipse7_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEclipse8_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEclipseKeygen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudyLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiStudyOther = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditPlus3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXDict2008 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYZRF5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpFirefox = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpIE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiHelpPMLX = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpStuClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysSubTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysPaint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysWriter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysOSK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysMstsc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysSubToolLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSysTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysCleanmgr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysMSInfo32 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysCharmap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMgrCompmgmt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMgrDevmgmt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMgrDiskmgmt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMgrLusrmgr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMgrLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiMgrControl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMgrEventvwr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMgrTaskmgr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMgrInternetOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMgrRegedit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpCSS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpJ2EE_API = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpJ2EE5_0API_CN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpJAVA5_0API_CN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpJavaScript = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpJavaScriptHelp_CN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpJETSQL40 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpMySQL_CN_SC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpMySQL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMSOffice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOfficeAccess = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOfficeExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOfficeOutlook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOfficePPT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOfficeVisio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOfficeWord = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMainLine2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseButton)).BeginInit();
            this.pnlTopTitle.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuperMode)).BeginInit();
            this.rmnuICON.SuspendLayout();
            this.tsControlButtons.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMiniButton
            // 
            this.picMiniButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMiniButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMiniButton.BackgroundImage")));
            this.picMiniButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMiniButton.Location = new System.Drawing.Point(221, -1);
            this.picMiniButton.Name = "picMiniButton";
            this.picMiniButton.Size = new System.Drawing.Size(28, 20);
            this.picMiniButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMiniButton.TabIndex = 4;
            this.picMiniButton.TabStop = false;
            this.toolTip.SetToolTip(this.picMiniButton, "最小化");
            this.picMiniButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picMiniButton_MouseClick);
            this.picMiniButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMiniButton_MouseDown);
            this.picMiniButton.MouseEnter += new System.EventHandler(this.picMiniButton_MouseEnter);
            this.picMiniButton.MouseLeave += new System.EventHandler(this.picMiniButton_MouseLeave);
            // 
            // picCloseButton
            // 
            this.picCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCloseButton.BackgroundImage")));
            this.picCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCloseButton.Location = new System.Drawing.Point(249, -1);
            this.picCloseButton.Name = "picCloseButton";
            this.picCloseButton.Size = new System.Drawing.Size(39, 20);
            this.picCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCloseButton.TabIndex = 3;
            this.picCloseButton.TabStop = false;
            this.toolTip.SetToolTip(this.picCloseButton, "关闭");
            this.picCloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCloseButton_MouseClick);
            this.picCloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCloseButton_MouseDown);
            this.picCloseButton.MouseEnter += new System.EventHandler(this.picCloseButton_MouseEnter);
            this.picCloseButton.MouseLeave += new System.EventHandler(this.picCloseButton_MouseLeave);
            // 
            // pnlTopTitle
            // 
            this.pnlTopTitle.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTopTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTopTitle.BackgroundImage")));
            this.pnlTopTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTopTitle.Controls.Add(this.lblTitleText);
            this.pnlTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTopTitle.Name = "pnlTopTitle";
            this.pnlTopTitle.Size = new System.Drawing.Size(300, 25);
            this.pnlTopTitle.TabIndex = 8;
            // 
            // lblTitleText
            // 
            this.lblTitleText.AutoSize = true;
            this.lblTitleText.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitleText.ForeColor = System.Drawing.Color.LightCyan;
            this.lblTitleText.Location = new System.Drawing.Point(6, 4);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(199, 17);
            this.lblTitleText.TabIndex = 0;
            this.lblTitleText.Text = "ACCP Software Service Manage";
            // 
            // pnlBottomBorder
            // 
            this.pnlBottomBorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBottomBorder.BackgroundImage")));
            this.pnlBottomBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomBorder.Location = new System.Drawing.Point(0, 395);
            this.pnlBottomBorder.Name = "pnlBottomBorder";
            this.pnlBottomBorder.Size = new System.Drawing.Size(300, 5);
            this.pnlBottomBorder.TabIndex = 9;
            // 
            // pnlLeftBorder
            // 
            this.pnlLeftBorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLeftBorder.BackgroundImage")));
            this.pnlLeftBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftBorder.Location = new System.Drawing.Point(0, 25);
            this.pnlLeftBorder.Name = "pnlLeftBorder";
            this.pnlLeftBorder.Size = new System.Drawing.Size(5, 370);
            this.pnlLeftBorder.TabIndex = 10;
            // 
            // pnlRightBorder
            // 
            this.pnlRightBorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRightBorder.BackgroundImage")));
            this.pnlRightBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRightBorder.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlRightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightBorder.Location = new System.Drawing.Point(295, 25);
            this.pnlRightBorder.Name = "pnlRightBorder";
            this.pnlRightBorder.Size = new System.Drawing.Size(5, 370);
            this.pnlRightBorder.TabIndex = 11;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlStatus.Controls.Add(this.picSuperMode);
            this.pnlStatus.Controls.Add(this.lnkAbout);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(5, 373);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(290, 22);
            this.pnlStatus.TabIndex = 52;
            // 
            // picSuperMode
            // 
            this.picSuperMode.Location = new System.Drawing.Point(270, 2);
            this.picSuperMode.Name = "picSuperMode";
            this.picSuperMode.Size = new System.Drawing.Size(19, 19);
            this.picSuperMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSuperMode.TabIndex = 1;
            this.picSuperMode.TabStop = false;
            this.toolTip.SetToolTip(this.picSuperMode, resources.GetString("picSuperMode.ToolTip"));
            this.picSuperMode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picSuperMode_MouseClick);
            this.picSuperMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picSuperMode_MouseDown);
            this.picSuperMode.MouseLeave += new System.EventHandler(this.picSuperMode_MouseLeave);
            // 
            // lnkAbout
            // 
            this.lnkAbout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(112)))), ((int)(((byte)(235)))));
            this.lnkAbout.AutoSize = true;
            this.lnkAbout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAbout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(112)))), ((int)(((byte)(235)))));
            this.lnkAbout.Location = new System.Drawing.Point(3, 6);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(239, 12);
            this.lnkAbout.TabIndex = 0;
            this.lnkAbout.TabStop = true;
            this.lnkAbout.Text = "关于 北大青鸟-唐城中心 软件服务管理工具";
            this.lnkAbout.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(112)))), ((int)(((byte)(235)))));
            this.lnkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout_LinkClicked);
            this.lnkAbout.Enter += new System.EventHandler(this.lnkAbout_Enter);
            // 
            // imgsCtrlPict
            // 
            this.imgsCtrlPict.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgsCtrlPict.ImageStream")));
            this.imgsCtrlPict.TransparentColor = System.Drawing.Color.Transparent;
            this.imgsCtrlPict.Images.SetKeyName(0, "continue.png");
            this.imgsCtrlPict.Images.SetKeyName(1, "pause.png");
            this.imgsCtrlPict.Images.SetKeyName(2, "start.png");
            this.imgsCtrlPict.Images.SetKeyName(3, "stop.png");
            this.imgsCtrlPict.Images.SetKeyName(4, "mysql.png");
            this.imgsCtrlPict.Images.SetKeyName(5, "oracle11g.png");
            this.imgsCtrlPict.Images.SetKeyName(6, "sql2005.png");
            this.imgsCtrlPict.Images.SetKeyName(7, "sql2008.png");
            this.imgsCtrlPict.Images.SetKeyName(8, "open.png");
            this.imgsCtrlPict.Images.SetKeyName(9, "change.png");
            this.imgsCtrlPict.Images.SetKeyName(10, "restart.png");
            this.imgsCtrlPict.Images.SetKeyName(11, "toad.png");
            this.imgsCtrlPict.Images.SetKeyName(12, "toadkeygen.png");
            this.imgsCtrlPict.Images.SetKeyName(13, "mode_normal.png");
            this.imgsCtrlPict.Images.SetKeyName(14, "mode_normal_down.png");
            this.imgsCtrlPict.Images.SetKeyName(15, "mode_open.png");
            this.imgsCtrlPict.Images.SetKeyName(16, "mode_open_down.png");
            this.imgsCtrlPict.Images.SetKeyName(17, "othersoftware.png");
            this.imgsCtrlPict.Images.SetKeyName(18, "adobe.png");
            this.imgsCtrlPict.Images.SetKeyName(19, "dw4.png");
            this.imgsCtrlPict.Images.SetKeyName(20, "eclipse.png");
            this.imgsCtrlPict.Images.SetKeyName(21, "myeclipse6.5.png");
            this.imgsCtrlPict.Images.SetKeyName(22, "myeclipse7.5.png");
            this.imgsCtrlPict.Images.SetKeyName(23, "myeclipse8.5.png");
            this.imgsCtrlPict.Images.SetKeyName(24, "reader.png");
            this.imgsCtrlPict.Images.SetKeyName(25, "vs2008.png");
            this.imgsCtrlPict.Images.SetKeyName(26, "vs2010.png");
            this.imgsCtrlPict.Images.SetKeyName(27, "microsoft.png");
            this.imgsCtrlPict.Images.SetKeyName(28, "fb4.png");
            this.imgsCtrlPict.Images.SetKeyName(29, "Flash4.png");
            this.imgsCtrlPict.Images.SetKeyName(30, "fw4.png");
            this.imgsCtrlPict.Images.SetKeyName(31, "ps4.png");
            this.imgsCtrlPict.Images.SetKeyName(32, "editplus3.png");
            this.imgsCtrlPict.Images.SetKeyName(33, "macromediaflash8.png");
            this.imgsCtrlPict.Images.SetKeyName(34, "msdn.png");
            this.imgsCtrlPict.Images.SetKeyName(35, "xdict2008.png");
            this.imgsCtrlPict.Images.SetKeyName(36, "yzrf5.png");
            this.imgsCtrlPict.Images.SetKeyName(37, "calc.png");
            this.imgsCtrlPict.Images.SetKeyName(38, "cmd.png");
            this.imgsCtrlPict.Images.SetKeyName(39, "explorer.png");
            this.imgsCtrlPict.Images.SetKeyName(40, "paint.png");
            this.imgsCtrlPict.Images.SetKeyName(41, "writer.png");
            this.imgsCtrlPict.Images.SetKeyName(42, "notepad.png");
            this.imgsCtrlPict.Images.SetKeyName(43, "studyother.png");
            this.imgsCtrlPict.Images.SetKeyName(44, "excel.png");
            this.imgsCtrlPict.Images.SetKeyName(45, "msaccess.png");
            this.imgsCtrlPict.Images.SetKeyName(46, "office.png");
            this.imgsCtrlPict.Images.SetKeyName(47, "outlook.png");
            this.imgsCtrlPict.Images.SetKeyName(48, "powerpnt.png");
            this.imgsCtrlPict.Images.SetKeyName(49, "visio.png");
            this.imgsCtrlPict.Images.SetKeyName(50, "winword.png");
            this.imgsCtrlPict.Images.SetKeyName(51, "charmap.png");
            this.imgsCtrlPict.Images.SetKeyName(52, "cleanmgr.png");
            this.imgsCtrlPict.Images.SetKeyName(53, "perfmon.png");
            this.imgsCtrlPict.Images.SetKeyName(54, "msinfo32.png");
            this.imgsCtrlPict.Images.SetKeyName(55, "systool.png");
            this.imgsCtrlPict.Images.SetKeyName(56, "msconfig.png");
            this.imgsCtrlPict.Images.SetKeyName(57, "systool.png");
            this.imgsCtrlPict.Images.SetKeyName(58, "msconfig.png");
            this.imgsCtrlPict.Images.SetKeyName(59, "taskmgr.png");
            this.imgsCtrlPict.Images.SetKeyName(60, "magnify.png");
            this.imgsCtrlPict.Images.SetKeyName(61, "osk.png");
            this.imgsCtrlPict.Images.SetKeyName(62, "mstsc.png");
            this.imgsCtrlPict.Images.SetKeyName(63, "helpdoc.png");
            this.imgsCtrlPict.Images.SetKeyName(64, "subtool.png");
            this.imgsCtrlPict.Images.SetKeyName(65, "compmgr.png");
            this.imgsCtrlPict.Images.SetKeyName(66, "managetool.png");
            this.imgsCtrlPict.Images.SetKeyName(67, "control.png");
            this.imgsCtrlPict.Images.SetKeyName(68, "devmgmt.png");
            this.imgsCtrlPict.Images.SetKeyName(69, "diskmgmt.png");
            this.imgsCtrlPict.Images.SetKeyName(70, "eventvwr.png");
            this.imgsCtrlPict.Images.SetKeyName(71, "inetopt.png");
            this.imgsCtrlPict.Images.SetKeyName(72, "lusrmgr.png");
            this.imgsCtrlPict.Images.SetKeyName(73, "sysinfo.png");
            this.imgsCtrlPict.Images.SetKeyName(74, "regedit.png");
            this.imgsCtrlPict.Images.SetKeyName(75, "helptool.png");
            this.imgsCtrlPict.Images.SetKeyName(76, "studysoftware.png");
            this.imgsCtrlPict.Images.SetKeyName(77, "pmlx.png");
            this.imgsCtrlPict.Images.SetKeyName(78, "vs2005.png");
            this.imgsCtrlPict.Images.SetKeyName(79, "firefox.png");
            this.imgsCtrlPict.Images.SetKeyName(80, "ie.png");
            this.imgsCtrlPict.Images.SetKeyName(81, "eclipsekeygen.png");
            this.imgsCtrlPict.Images.SetKeyName(82, "stuclient.png");
            this.imgsCtrlPict.Images.SetKeyName(83, "helppdf.png");
            this.imgsCtrlPict.Images.SetKeyName(84, "helpchm.png");
            // 
            // iconManage
            // 
            this.iconManage.ContextMenuStrip = this.rmnuICON;
            this.iconManage.Icon = ((System.Drawing.Icon)(resources.GetObject("iconManage.Icon")));
            this.iconManage.Text = "ACCP Software Service Manage";
            this.iconManage.Visible = true;
            this.iconManage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iconManage_MouseClick);
            // 
            // rmnuICON
            // 
            this.rmnuICON.BackColor = System.Drawing.SystemColors.Control;
            this.rmnuICON.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rmnuShowMain,
            this.rmnuLine2,
            this.rmnuAbout,
            this.rmnuExit});
            this.rmnuICON.Name = "rmnuICON";
            this.rmnuICON.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.rmnuICON.Size = new System.Drawing.Size(137, 76);
            // 
            // rmnuShowMain
            // 
            this.rmnuShowMain.BackColor = System.Drawing.SystemColors.Control;
            this.rmnuShowMain.Name = "rmnuShowMain";
            this.rmnuShowMain.Size = new System.Drawing.Size(136, 22);
            this.rmnuShowMain.Text = "打开主界面";
            this.rmnuShowMain.Click += new System.EventHandler(this.rmnuShowMain_Click);
            // 
            // rmnuLine2
            // 
            this.rmnuLine2.Name = "rmnuLine2";
            this.rmnuLine2.Size = new System.Drawing.Size(133, 6);
            // 
            // rmnuAbout
            // 
            this.rmnuAbout.Name = "rmnuAbout";
            this.rmnuAbout.Size = new System.Drawing.Size(136, 22);
            this.rmnuAbout.Text = "关于";
            this.rmnuAbout.Click += new System.EventHandler(this.rmnuAbout_Click);
            // 
            // rmnuExit
            // 
            this.rmnuExit.Name = "rmnuExit";
            this.rmnuExit.Size = new System.Drawing.Size(136, 22);
            this.rmnuExit.Text = "退出";
            this.rmnuExit.Click += new System.EventHandler(this.rmnuExit_Click);
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // tsControlButtons
            // 
            this.tsControlButtons.BackColor = System.Drawing.Color.Transparent;
            this.tsControlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsControlButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControlButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbOracle11g,
            this.tssbSQL2005,
            this.tssbSQL2008,
            this.tssbMySQL,
            this.tsMainLine1,
            this.tssbAllSoftware,
            this.tsMainLine2});
            this.tsControlButtons.Location = new System.Drawing.Point(0, 0);
            this.tsControlButtons.Name = "tsControlButtons";
            this.tsControlButtons.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsControlButtons.Size = new System.Drawing.Size(258, 370);
            this.tsControlButtons.TabIndex = 5;
            this.tsControlButtons.Text = "toolStrip1";
            // 
            // tssbOracle11g
            // 
            this.tssbOracle11g.DropDownButtonWidth = 25;
            this.tssbOracle11g.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOracleMainService,
            this.tsmiOracleListenerService,
            this.tsmiOracleLine1,
            this.tsmiOracleCorrectConfigurationFile,
            this.tsmiOracleLine2,
            this.tsmiOracleTodeOpen,
            this.tsmiToadKeyGen});
            this.tssbOracle11g.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssbOracle11g.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssbOracle11g.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbOracle11g.Name = "tssbOracle11g";
            this.tssbOracle11g.Size = new System.Drawing.Size(255, 21);
            this.tssbOracle11g.Tag = "net start OracleOraDb11g_home1TNSListener ; net start OracleServiceACCP11G ; \"C:\\" +
                "Program Files\\Quest Software\\Toad for Oracle\\toad.exe\"";
            this.tssbOracle11g.Text = "Oracle DataBase ACCP11G";
            this.tssbOracle11g.ToolTipText = "Oracle 数据库 ACCP11G";
            this.tssbOracle11g.ButtonClick += new System.EventHandler(this.tssbOracle11g_ButtonClick);
            // 
            // tsmiOracleMainService
            // 
            this.tsmiOracleMainService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOracleMainServiceStart,
            this.tsmiOracleMainServicePause,
            this.tsmiOracleMainServiceContinue,
            this.tsmiOracleMainServiceStop,
            this.tsmiOracleServiceLine1,
            this.tsmiOracleMainServiceRestart});
            this.tsmiOracleMainService.Name = "tsmiOracleMainService";
            this.tsmiOracleMainService.Size = new System.Drawing.Size(283, 22);
            this.tsmiOracleMainService.Tag = "";
            this.tsmiOracleMainService.Text = "Oracle DataBase ACCP11G 主服务";
            this.tsmiOracleMainService.ToolTipText = "Oracle DataBase ACCP11G 主服务管理";
            // 
            // tsmiOracleMainServiceStart
            // 
            this.tsmiOracleMainServiceStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOracleMainServiceStart.Name = "tsmiOracleMainServiceStart";
            this.tsmiOracleMainServiceStart.Size = new System.Drawing.Size(136, 22);
            this.tsmiOracleMainServiceStart.Tag = "net start OracleServiceACCP11G";
            this.tsmiOracleMainServiceStart.Text = "开启主服务";
            this.tsmiOracleMainServiceStart.ToolTipText = "开启 Oracle数据库 ACCP11G 主服务";
            this.tsmiOracleMainServiceStart.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiOracleMainServicePause
            // 
            this.tsmiOracleMainServicePause.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOracleMainServicePause.Name = "tsmiOracleMainServicePause";
            this.tsmiOracleMainServicePause.Size = new System.Drawing.Size(136, 22);
            this.tsmiOracleMainServicePause.Tag = "net pause OracleServiceACCP11G";
            this.tsmiOracleMainServicePause.Text = "暂停主服务";
            this.tsmiOracleMainServicePause.ToolTipText = "暂停 Oracle数据库 ACCP11G 主服务";
            this.tsmiOracleMainServicePause.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiOracleMainServiceContinue
            // 
            this.tsmiOracleMainServiceContinue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOracleMainServiceContinue.Name = "tsmiOracleMainServiceContinue";
            this.tsmiOracleMainServiceContinue.Size = new System.Drawing.Size(136, 22);
            this.tsmiOracleMainServiceContinue.Tag = "net continue OracleServiceACCP11G";
            this.tsmiOracleMainServiceContinue.Text = "继续主服务";
            this.tsmiOracleMainServiceContinue.ToolTipText = "继续 Oracle数据库 ACCP11G 主服务";
            this.tsmiOracleMainServiceContinue.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiOracleMainServiceStop
            // 
            this.tsmiOracleMainServiceStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOracleMainServiceStop.Name = "tsmiOracleMainServiceStop";
            this.tsmiOracleMainServiceStop.Size = new System.Drawing.Size(136, 22);
            this.tsmiOracleMainServiceStop.Tag = "net stop OracleServiceACCP11G";
            this.tsmiOracleMainServiceStop.Text = "停止主服务";
            this.tsmiOracleMainServiceStop.ToolTipText = "停止 Oracle数据库 ACCP11G 主服务";
            this.tsmiOracleMainServiceStop.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiOracleServiceLine1
            // 
            this.tsmiOracleServiceLine1.Name = "tsmiOracleServiceLine1";
            this.tsmiOracleServiceLine1.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmiOracleMainServiceRestart
            // 
            this.tsmiOracleMainServiceRestart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOracleMainServiceRestart.Name = "tsmiOracleMainServiceRestart";
            this.tsmiOracleMainServiceRestart.Size = new System.Drawing.Size(136, 22);
            this.tsmiOracleMainServiceRestart.Tag = "net stop OracleServiceACCP11G ; net start OracleServiceACCP11G";
            this.tsmiOracleMainServiceRestart.Text = "重启主服务";
            this.tsmiOracleMainServiceRestart.ToolTipText = "重新启动 Oracle数据库 ACCP11G 主服务";
            this.tsmiOracleMainServiceRestart.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiOracleListenerService
            // 
            this.tsmiOracleListenerService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOracleListenerServiceStart,
            this.tsmiOracleListenerServiceStop,
            this.tsmiOracleListenerLine1,
            this.tsmiOracleListenerServiceRestart});
            this.tsmiOracleListenerService.Name = "tsmiOracleListenerService";
            this.tsmiOracleListenerService.Size = new System.Drawing.Size(283, 22);
            this.tsmiOracleListenerService.Tag = "";
            this.tsmiOracleListenerService.Text = "Oracle DataBase ACCP11G 监听服务";
            this.tsmiOracleListenerService.ToolTipText = "Oracle DataBase ACCP11G 监听服务管理";
            // 
            // tsmiOracleListenerServiceStart
            // 
            this.tsmiOracleListenerServiceStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOracleListenerServiceStart.Name = "tsmiOracleListenerServiceStart";
            this.tsmiOracleListenerServiceStart.Size = new System.Drawing.Size(148, 22);
            this.tsmiOracleListenerServiceStart.Tag = "net start OracleOraDb11g_home1TNSListener";
            this.tsmiOracleListenerServiceStart.Text = "开启监听服务";
            this.tsmiOracleListenerServiceStart.ToolTipText = "开启 Oracle数据库 ACCP11G 监听服务";
            this.tsmiOracleListenerServiceStart.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiOracleListenerServiceStop
            // 
            this.tsmiOracleListenerServiceStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOracleListenerServiceStop.Name = "tsmiOracleListenerServiceStop";
            this.tsmiOracleListenerServiceStop.Size = new System.Drawing.Size(148, 22);
            this.tsmiOracleListenerServiceStop.Tag = "net stop OracleOraDb11g_home1TNSListener";
            this.tsmiOracleListenerServiceStop.Text = "停止监听服务";
            this.tsmiOracleListenerServiceStop.ToolTipText = "停止 Oracle数据库 ACCP11G 监听服务";
            this.tsmiOracleListenerServiceStop.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiOracleListenerLine1
            // 
            this.tsmiOracleListenerLine1.Name = "tsmiOracleListenerLine1";
            this.tsmiOracleListenerLine1.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmiOracleListenerServiceRestart
            // 
            this.tsmiOracleListenerServiceRestart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOracleListenerServiceRestart.Name = "tsmiOracleListenerServiceRestart";
            this.tsmiOracleListenerServiceRestart.Size = new System.Drawing.Size(148, 22);
            this.tsmiOracleListenerServiceRestart.Tag = "net stop OracleOraDb11g_home1TNSListener ; net start OracleOraDb11g_home1TNSListe" +
                "ner";
            this.tsmiOracleListenerServiceRestart.Text = "重启监听服务";
            this.tsmiOracleListenerServiceRestart.ToolTipText = "重新启动 Oracle数据库 ACCP11G 监听服务";
            this.tsmiOracleListenerServiceRestart.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiOracleLine1
            // 
            this.tsmiOracleLine1.Name = "tsmiOracleLine1";
            this.tsmiOracleLine1.Size = new System.Drawing.Size(280, 6);
            // 
            // tsmiOracleCorrectConfigurationFile
            // 
            this.tsmiOracleCorrectConfigurationFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOracleCorrectConfigurationFile.Name = "tsmiOracleCorrectConfigurationFile";
            this.tsmiOracleCorrectConfigurationFile.Size = new System.Drawing.Size(283, 22);
            this.tsmiOracleCorrectConfigurationFile.Text = "Oracle 11g 配置文件更正";
            this.tsmiOracleCorrectConfigurationFile.ToolTipText = "更正 Oracle 11g 配置文件 listener.ora 、tnsnames.ora";
            this.tsmiOracleCorrectConfigurationFile.Click += new System.EventHandler(this.tsmiOracleCorrectConfigFile_Click);
            // 
            // tsmiOracleLine2
            // 
            this.tsmiOracleLine2.Name = "tsmiOracleLine2";
            this.tsmiOracleLine2.Size = new System.Drawing.Size(280, 6);
            // 
            // tsmiOracleTodeOpen
            // 
            this.tsmiOracleTodeOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOracleTodeOpen.Name = "tsmiOracleTodeOpen";
            this.tsmiOracleTodeOpen.Size = new System.Drawing.Size(283, 22);
            this.tsmiOracleTodeOpen.Tag = "C:\\Program Files\\Quest Software\\Toad for Oracle\\toad.exe";
            this.tsmiOracleTodeOpen.Text = "运行蛤蟆工具";
            this.tsmiOracleTodeOpen.ToolTipText = "运行 Toad for Oracle 9.6.1";
            this.tsmiOracleTodeOpen.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiToadKeyGen
            // 
            this.tsmiToadKeyGen.AutoToolTip = true;
            this.tsmiToadKeyGen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscboToadKeyName,
            this.tstxtToadKeyValue});
            this.tsmiToadKeyGen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiToadKeyGen.Name = "tsmiToadKeyGen";
            this.tsmiToadKeyGen.Size = new System.Drawing.Size(283, 22);
            this.tsmiToadKeyGen.Text = "蛤蟆注册码";
            this.tsmiToadKeyGen.ToolTipText = "显示 Toad 无限期注册码";
            // 
            // tscboToadKeyName
            // 
            this.tscboToadKeyName.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.tscboToadKeyName.Name = "tscboToadKeyName";
            this.tscboToadKeyName.Size = new System.Drawing.Size(190, 28);
            this.tscboToadKeyName.ToolTipText = "Site Message 注册名";
            this.tscboToadKeyName.SelectedIndexChanged += new System.EventHandler(this.tscboToadKeyName_SelectedIndexChanged);
            this.tscboToadKeyName.TextChanged += new System.EventHandler(this.tscboToadKeyName_TextChanged);
            // 
            // tstxtToadKeyValue
            // 
            this.tstxtToadKeyValue.AcceptsReturn = true;
            this.tstxtToadKeyValue.BackColor = System.Drawing.SystemColors.Control;
            this.tstxtToadKeyValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tstxtToadKeyValue.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.tstxtToadKeyValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tstxtToadKeyValue.Name = "tstxtToadKeyValue";
            this.tstxtToadKeyValue.ReadOnly = true;
            this.tstxtToadKeyValue.Size = new System.Drawing.Size(200, 18);
            this.tstxtToadKeyValue.Text = "0-63920-02273-29060-01749";
            this.tstxtToadKeyValue.ToolTipText = "Authorization key 注册码";
            // 
            // tssbSQL2005
            // 
            this.tssbSQL2005.DropDownButtonWidth = 25;
            this.tssbSQL2005.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSQL2005ServiceStart,
            this.tsmiSQL2005ServicePause,
            this.tsmiSQL2005ServiceContinue,
            this.tsmiSQL2005ServiceStop,
            this.tsmiSQL2005Line2,
            this.tsmiSQL2005ServiceRestart,
            this.tsmiSQL2005Line1,
            this.tsmiSQL2005Open});
            this.tssbSQL2005.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssbSQL2005.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSQL2005.Name = "tssbSQL2005";
            this.tssbSQL2005.Size = new System.Drawing.Size(255, 21);
            this.tssbSQL2005.Tag = "net start mssqlserver ; \"sqlwb.exe\"";
            this.tssbSQL2005.Text = "SQL Server Management Studio 2005";
            this.tssbSQL2005.ButtonClick += new System.EventHandler(this.tssbSQL2005_ButtonClick);
            // 
            // tsmiSQL2005ServiceStart
            // 
            this.tsmiSQL2005ServiceStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSQL2005ServiceStart.Name = "tsmiSQL2005ServiceStart";
            this.tsmiSQL2005ServiceStart.Size = new System.Drawing.Size(322, 22);
            this.tsmiSQL2005ServiceStart.Tag = "net start mssqlserver";
            this.tsmiSQL2005ServiceStart.Text = "开启 SQL 2005 服务";
            this.tsmiSQL2005ServiceStart.ToolTipText = "开启 Microsoft SQL Server 2005 服务";
            this.tsmiSQL2005ServiceStart.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiSQL2005ServicePause
            // 
            this.tsmiSQL2005ServicePause.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSQL2005ServicePause.Name = "tsmiSQL2005ServicePause";
            this.tsmiSQL2005ServicePause.Size = new System.Drawing.Size(322, 22);
            this.tsmiSQL2005ServicePause.Tag = "net pause mssqlserver";
            this.tsmiSQL2005ServicePause.Text = "暂停 SQL 2005 服务";
            this.tsmiSQL2005ServicePause.ToolTipText = "暂停 Microsoft SQL Server 2005 服务";
            this.tsmiSQL2005ServicePause.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiSQL2005ServiceContinue
            // 
            this.tsmiSQL2005ServiceContinue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSQL2005ServiceContinue.Name = "tsmiSQL2005ServiceContinue";
            this.tsmiSQL2005ServiceContinue.Size = new System.Drawing.Size(322, 22);
            this.tsmiSQL2005ServiceContinue.Tag = "net continue mssqlserver";
            this.tsmiSQL2005ServiceContinue.Text = "继续 SQL 2005 服务";
            this.tsmiSQL2005ServiceContinue.ToolTipText = "继续 Microsoft SQL Server 2005 服务";
            this.tsmiSQL2005ServiceContinue.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiSQL2005ServiceStop
            // 
            this.tsmiSQL2005ServiceStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSQL2005ServiceStop.Name = "tsmiSQL2005ServiceStop";
            this.tsmiSQL2005ServiceStop.Size = new System.Drawing.Size(322, 22);
            this.tsmiSQL2005ServiceStop.Tag = "net stop mssqlserver";
            this.tsmiSQL2005ServiceStop.Text = "停止 SQL 2005 服务";
            this.tsmiSQL2005ServiceStop.ToolTipText = "停止 Microsoft SQL Server 2005 服务";
            this.tsmiSQL2005ServiceStop.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiSQL2005Line2
            // 
            this.tsmiSQL2005Line2.Name = "tsmiSQL2005Line2";
            this.tsmiSQL2005Line2.Size = new System.Drawing.Size(319, 6);
            // 
            // tsmiSQL2005ServiceRestart
            // 
            this.tsmiSQL2005ServiceRestart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSQL2005ServiceRestart.Name = "tsmiSQL2005ServiceRestart";
            this.tsmiSQL2005ServiceRestart.Size = new System.Drawing.Size(322, 22);
            this.tsmiSQL2005ServiceRestart.Tag = "net stop mssqlserver ; net start mssqlserver";
            this.tsmiSQL2005ServiceRestart.Text = "重启 SQL 2005 服务";
            this.tsmiSQL2005ServiceRestart.ToolTipText = "重新启动 Microsoft SQL Server 2005 服务";
            this.tsmiSQL2005ServiceRestart.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiSQL2005Line1
            // 
            this.tsmiSQL2005Line1.Name = "tsmiSQL2005Line1";
            this.tsmiSQL2005Line1.Size = new System.Drawing.Size(319, 6);
            // 
            // tsmiSQL2005Open
            // 
            this.tsmiSQL2005Open.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSQL2005Open.Name = "tsmiSQL2005Open";
            this.tsmiSQL2005Open.Size = new System.Drawing.Size(322, 22);
            this.tsmiSQL2005Open.Tag = "sqlwb.exe";
            this.tsmiSQL2005Open.Text = "运行 SQL Server Management Studio 2005";
            this.tsmiSQL2005Open.ToolTipText = "运行  Microsoft SQL Server Management Studio 2005";
            this.tsmiSQL2005Open.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tssbSQL2008
            // 
            this.tssbSQL2008.DropDownButtonWidth = 25;
            this.tssbSQL2008.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSQL2008ServiceStart,
            this.tsmiSQL2008ServicePause,
            this.tsmiSQL2008ServiceContinue,
            this.tsmiSQL2008ServiceStop,
            this.tsmiSQL2008Line2,
            this.tsmiSQL2008ServiceRestart,
            this.tsmiSQL2008Line1,
            this.tsmiSQL2008Open});
            this.tssbSQL2008.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssbSQL2008.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSQL2008.Name = "tssbSQL2008";
            this.tssbSQL2008.Size = new System.Drawing.Size(255, 21);
            this.tssbSQL2008.Tag = "net start mssqlserver ; \"ssms.exe\"";
            this.tssbSQL2008.Text = "SQL Server Management Studio 2008";
            this.tssbSQL2008.ButtonClick += new System.EventHandler(this.tssbSQL2008_ButtonClick);
            // 
            // tsmiSQL2008ServiceStart
            // 
            this.tsmiSQL2008ServiceStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSQL2008ServiceStart.Name = "tsmiSQL2008ServiceStart";
            this.tsmiSQL2008ServiceStart.Size = new System.Drawing.Size(322, 22);
            this.tsmiSQL2008ServiceStart.Tag = "net start mssql$sql2008";
            this.tsmiSQL2008ServiceStart.Text = "开启 SQL 2008 服务";
            this.tsmiSQL2008ServiceStart.ToolTipText = "开启 Microsoft SQL Server 2008 服务";
            this.tsmiSQL2008ServiceStart.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiSQL2008ServicePause
            // 
            this.tsmiSQL2008ServicePause.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSQL2008ServicePause.Name = "tsmiSQL2008ServicePause";
            this.tsmiSQL2008ServicePause.Size = new System.Drawing.Size(322, 22);
            this.tsmiSQL2008ServicePause.Tag = "net pause mssql$sql2008";
            this.tsmiSQL2008ServicePause.Text = "暂停 SQL 2008 服务";
            this.tsmiSQL2008ServicePause.ToolTipText = "暂停 Microsoft SQL Server 2008 服务";
            this.tsmiSQL2008ServicePause.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiSQL2008ServiceContinue
            // 
            this.tsmiSQL2008ServiceContinue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSQL2008ServiceContinue.Name = "tsmiSQL2008ServiceContinue";
            this.tsmiSQL2008ServiceContinue.Size = new System.Drawing.Size(322, 22);
            this.tsmiSQL2008ServiceContinue.Tag = "net continue mssql$sql2008";
            this.tsmiSQL2008ServiceContinue.Text = "继续 SQL 2008 服务";
            this.tsmiSQL2008ServiceContinue.ToolTipText = "继续 Microsoft SQL Server 2008 服务";
            this.tsmiSQL2008ServiceContinue.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiSQL2008ServiceStop
            // 
            this.tsmiSQL2008ServiceStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSQL2008ServiceStop.Name = "tsmiSQL2008ServiceStop";
            this.tsmiSQL2008ServiceStop.Size = new System.Drawing.Size(322, 22);
            this.tsmiSQL2008ServiceStop.Tag = "net stop mssql$sql2008";
            this.tsmiSQL2008ServiceStop.Text = "停止 SQL 2008 服务";
            this.tsmiSQL2008ServiceStop.ToolTipText = "停止 Microsoft SQL Server 2008 服务";
            this.tsmiSQL2008ServiceStop.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiSQL2008Line2
            // 
            this.tsmiSQL2008Line2.Name = "tsmiSQL2008Line2";
            this.tsmiSQL2008Line2.Size = new System.Drawing.Size(319, 6);
            // 
            // tsmiSQL2008ServiceRestart
            // 
            this.tsmiSQL2008ServiceRestart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSQL2008ServiceRestart.Name = "tsmiSQL2008ServiceRestart";
            this.tsmiSQL2008ServiceRestart.Size = new System.Drawing.Size(322, 22);
            this.tsmiSQL2008ServiceRestart.Tag = "net stop mssql$sql2008 ; net start mssql$sql2008";
            this.tsmiSQL2008ServiceRestart.Text = "重启 SQL 2008 服务";
            this.tsmiSQL2008ServiceRestart.ToolTipText = "重新启动 Microsoft SQL Server 2008 服务";
            this.tsmiSQL2008ServiceRestart.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiSQL2008Line1
            // 
            this.tsmiSQL2008Line1.Name = "tsmiSQL2008Line1";
            this.tsmiSQL2008Line1.Size = new System.Drawing.Size(319, 6);
            // 
            // tsmiSQL2008Open
            // 
            this.tsmiSQL2008Open.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSQL2008Open.Name = "tsmiSQL2008Open";
            this.tsmiSQL2008Open.Size = new System.Drawing.Size(322, 22);
            this.tsmiSQL2008Open.Tag = "ssms.exe";
            this.tsmiSQL2008Open.Text = "运行 SQL Server Management Studio 2008";
            this.tsmiSQL2008Open.ToolTipText = "运行 Microsoft SQL Server Management Studio 2008";
            this.tsmiSQL2008Open.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tssbMySQL
            // 
            this.tssbMySQL.DropDownButtonWidth = 25;
            this.tssbMySQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMySQLServiceStart,
            this.tsmiMySQLServiceStop,
            this.tsmiMySQLLine2,
            this.tsmiMySQLServiceRestart,
            this.tsmiMySQLLine1,
            this.tsmiMySQLOpen});
            this.tssbMySQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssbMySQL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssbMySQL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbMySQL.Name = "tssbMySQL";
            this.tssbMySQL.Size = new System.Drawing.Size(255, 21);
            this.tssbMySQL.Tag = "net start mysql6 ; \"C:\\Program Files\\PremiumSoft\\Navicat 8.0 MySQL\\navicat.exe\"";
            this.tssbMySQL.Text = "Navicat for MySQL";
            this.tssbMySQL.ButtonClick += new System.EventHandler(this.tssbMySQL_ButtonClick);
            // 
            // tsmiMySQLServiceStart
            // 
            this.tsmiMySQLServiceStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMySQLServiceStart.Name = "tsmiMySQLServiceStart";
            this.tsmiMySQLServiceStart.Size = new System.Drawing.Size(217, 22);
            this.tsmiMySQLServiceStart.Tag = "net start mysql6";
            this.tsmiMySQLServiceStart.Text = "开启 My SQL 服务";
            this.tsmiMySQLServiceStart.ToolTipText = "开启 My SQL 服务";
            this.tsmiMySQLServiceStart.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiMySQLServiceStop
            // 
            this.tsmiMySQLServiceStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMySQLServiceStop.Name = "tsmiMySQLServiceStop";
            this.tsmiMySQLServiceStop.Size = new System.Drawing.Size(217, 22);
            this.tsmiMySQLServiceStop.Tag = "net stop mysql6";
            this.tsmiMySQLServiceStop.Text = "停止 My SQL 服务";
            this.tsmiMySQLServiceStop.ToolTipText = "停止 My SQL 服务";
            this.tsmiMySQLServiceStop.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiMySQLLine2
            // 
            this.tsmiMySQLLine2.Name = "tsmiMySQLLine2";
            this.tsmiMySQLLine2.Size = new System.Drawing.Size(214, 6);
            // 
            // tsmiMySQLServiceRestart
            // 
            this.tsmiMySQLServiceRestart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMySQLServiceRestart.Name = "tsmiMySQLServiceRestart";
            this.tsmiMySQLServiceRestart.Size = new System.Drawing.Size(217, 22);
            this.tsmiMySQLServiceRestart.Tag = "net stop mysql6 ; net start mysql6";
            this.tsmiMySQLServiceRestart.Text = "重启 My SQL 服务";
            this.tsmiMySQLServiceRestart.ToolTipText = "重新启动 My SQL 服务";
            this.tsmiMySQLServiceRestart.Click += new System.EventHandler(this.ServerManage_Click);
            // 
            // tsmiMySQLLine1
            // 
            this.tsmiMySQLLine1.Name = "tsmiMySQLLine1";
            this.tsmiMySQLLine1.Size = new System.Drawing.Size(214, 6);
            // 
            // tsmiMySQLOpen
            // 
            this.tsmiMySQLOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMySQLOpen.Name = "tsmiMySQLOpen";
            this.tsmiMySQLOpen.Size = new System.Drawing.Size(217, 22);
            this.tsmiMySQLOpen.Tag = "C:\\Program Files\\PremiumSoft\\Navicat 8.0 MySQL\\navicat.exe";
            this.tsmiMySQLOpen.Text = "运行 Navicat for My SQL";
            this.tsmiMySQLOpen.ToolTipText = "运行 Navicat for My SQL";
            this.tsmiMySQLOpen.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsMainLine1
            // 
            this.tsMainLine1.Name = "tsMainLine1";
            this.tsMainLine1.Size = new System.Drawing.Size(255, 6);
            // 
            // tssbAllSoftware
            // 
            this.tssbAllSoftware.DropDownButtonWidth = 240;
            this.tssbAllSoftware.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStudaySoftware,
            this.tsmiHelpTool,
            this.tsmiSysSubTool,
            this.tsmiManager,
            this.tsmiHelpDoc,
            this.tsmiMSOffice});
            this.tssbAllSoftware.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssbAllSoftware.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssbAllSoftware.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbAllSoftware.Name = "tssbAllSoftware";
            this.tssbAllSoftware.Size = new System.Drawing.Size(255, 21);
            this.tssbAllSoftware.Text = " ";
            this.tssbAllSoftware.ToolTipText = "其他软件";
            // 
            // tsmiStudaySoftware
            // 
            this.tsmiStudaySoftware.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdobe,
            this.tsmiMicrosoft,
            this.tsmiEclipse,
            this.tsmiStudyLine1,
            this.tsmiStudyOther});
            this.tsmiStudaySoftware.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiStudaySoftware.Name = "tsmiStudaySoftware";
            this.tsmiStudaySoftware.Size = new System.Drawing.Size(170, 22);
            this.tsmiStudaySoftware.Text = "学习软件";
            this.tsmiStudaySoftware.ToolTipText = "学习软件";
            // 
            // tsmiAdobe
            // 
            this.tsmiAdobe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAboleDW4,
            this.tsmiAdobeFB4,
            this.tsmiAdobeFlash4,
            this.tsmiAdobePS4,
            this.tsmiAdobeReaderX});
            this.tsmiAdobe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAdobe.Name = "tsmiAdobe";
            this.tsmiAdobe.Size = new System.Drawing.Size(132, 22);
            this.tsmiAdobe.Text = "Adobe";
            this.tsmiAdobe.ToolTipText = "关于 Adobe 的软件";
            // 
            // tsmiAboleDW4
            // 
            this.tsmiAboleDW4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAboleDW4.Name = "tsmiAboleDW4";
            this.tsmiAboleDW4.Size = new System.Drawing.Size(285, 22);
            this.tsmiAboleDW4.Tag = "C:\\Program Files\\Adobe\\Adobe Dreamweaver CS4\\Dreamweaver.exe";
            this.tsmiAboleDW4.Text = "Adobe Dreamweaver CS4简体中文版";
            this.tsmiAboleDW4.ToolTipText = "运行 Adobe Dreamweaver CS4简体中文版";
            this.tsmiAboleDW4.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiAdobeFB4
            // 
            this.tsmiAdobeFB4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAdobeFB4.Name = "tsmiAdobeFB4";
            this.tsmiAdobeFB4.Size = new System.Drawing.Size(285, 22);
            this.tsmiAdobeFB4.Tag = "C:\\Program Files\\Genuitec\\MyEclipse 8.5\\dropins\\eclipse-host-distro\\eclipse.exe";
            this.tsmiAdobeFB4.Text = "Adobe Flash Builder 4 Plug-in";
            this.tsmiAdobeFB4.ToolTipText = "运行 Adobe Flash Builder 4 Plug-in";
            this.tsmiAdobeFB4.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiAdobeFlash4
            // 
            this.tsmiAdobeFlash4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAdobeFlash4.Name = "tsmiAdobeFlash4";
            this.tsmiAdobeFlash4.Size = new System.Drawing.Size(285, 22);
            this.tsmiAdobeFlash4.Tag = "C:\\Program Files\\Adobe\\Adobe Flash CS4\\Flash.exe";
            this.tsmiAdobeFlash4.Text = "Adobe Flash CS4 Professional";
            this.tsmiAdobeFlash4.ToolTipText = "运行 Adobe Flash CS4 Professional";
            this.tsmiAdobeFlash4.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiAdobePS4
            // 
            this.tsmiAdobePS4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAdobePS4.Name = "tsmiAdobePS4";
            this.tsmiAdobePS4.Size = new System.Drawing.Size(285, 22);
            this.tsmiAdobePS4.Tag = "C:\\Program Files\\Adobe Photoshop CS4\\Photoshop.exe";
            this.tsmiAdobePS4.Text = "Adobe Photoshop CS4";
            this.tsmiAdobePS4.ToolTipText = "运行 Adobe Photoshop CS4";
            this.tsmiAdobePS4.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiAdobeReaderX
            // 
            this.tsmiAdobeReaderX.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAdobeReaderX.Name = "tsmiAdobeReaderX";
            this.tsmiAdobeReaderX.Size = new System.Drawing.Size(285, 22);
            this.tsmiAdobeReaderX.Tag = "C:\\Program Files\\Adobe\\Reader 9.0\\Reader\\AcroRd32.exe";
            this.tsmiAdobeReaderX.Text = "Adobe Reader X";
            this.tsmiAdobeReaderX.ToolTipText = "运行 Adobe Reader X";
            this.tsmiAdobeReaderX.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMicrosoft
            // 
            this.tsmiMicrosoft.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMSVS2005,
            this.tsmiMSVS2008,
            this.tsmiMSVS2010,
            this.tsmiMSMSDN2005,
            this.tsmiMSMSDN2008});
            this.tsmiMicrosoft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMicrosoft.Name = "tsmiMicrosoft";
            this.tsmiMicrosoft.Size = new System.Drawing.Size(132, 22);
            this.tsmiMicrosoft.Text = "Microsoft";
            this.tsmiMicrosoft.ToolTipText = "关于 Microsoft 的软件";
            // 
            // tsmiMSVS2005
            // 
            this.tsmiMSVS2005.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMSVS2005.Name = "tsmiMSVS2005";
            this.tsmiMSVS2005.Size = new System.Drawing.Size(342, 22);
            this.tsmiMSVS2005.Tag = "C:\\Program Files\\Microsoft Visual Studio 8\\Common7\\IDE\\devenv.exe";
            this.tsmiMSVS2005.Text = "Microsoft Visual Studio 2005";
            this.tsmiMSVS2005.ToolTipText = "运行 Microsoft Visual Studio 2005";
            this.tsmiMSVS2005.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMSVS2008
            // 
            this.tsmiMSVS2008.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMSVS2008.Name = "tsmiMSVS2008";
            this.tsmiMSVS2008.Size = new System.Drawing.Size(342, 22);
            this.tsmiMSVS2008.Tag = "C:\\Program Files\\Microsoft Visual Studio 9.0\\Common7\\IDE\\devenv.exe";
            this.tsmiMSVS2008.Text = "Microsoft Visual Studio 2008";
            this.tsmiMSVS2008.ToolTipText = "运行 Microsoft Visual Studio 2008";
            this.tsmiMSVS2008.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMSVS2010
            // 
            this.tsmiMSVS2010.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMSVS2010.Name = "tsmiMSVS2010";
            this.tsmiMSVS2010.Size = new System.Drawing.Size(342, 22);
            this.tsmiMSVS2010.Tag = "C:\\Program Files\\Microsoft Visual Studio 10.0\\Common7\\IDE\\devenv.exe";
            this.tsmiMSVS2010.Text = "Microsoft Visual Studio 2010";
            this.tsmiMSVS2010.ToolTipText = "运行 Microsoft Visual Studio 2010";
            this.tsmiMSVS2010.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMSMSDN2005
            // 
            this.tsmiMSMSDN2005.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMSMSDN2005.Name = "tsmiMSMSDN2005";
            this.tsmiMSMSDN2005.Size = new System.Drawing.Size(342, 22);
            this.tsmiMSMSDN2005.Tag = "C:\\Documents and Settings\\All Users\\「开始」菜单\\程序\\Microsoft Developer Network\\MSDN Li" +
                "brary for Visual Studio 2005.lnk";
            this.tsmiMSMSDN2005.Text = "MSDN Library for Visual Studio 2005";
            this.tsmiMSMSDN2005.ToolTipText = "启动 MSDN Library for Visual Studio 2005";
            this.tsmiMSMSDN2005.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMSMSDN2008
            // 
            this.tsmiMSMSDN2008.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMSMSDN2008.Name = "tsmiMSMSDN2008";
            this.tsmiMSMSDN2008.Size = new System.Drawing.Size(342, 22);
            this.tsmiMSMSDN2008.Tag = "C:\\Documents and Settings\\All Users\\「开始」菜单\\程序\\Microsoft Developer Network\\MSDN Li" +
                "brary for Visual Studio 2008 简体中文.lnk";
            this.tsmiMSMSDN2008.Text = "MSDN Library for Visual Studio 2008 简体中文";
            this.tsmiMSMSDN2008.ToolTipText = "启动 MSDN Library for Visual Studio 2008 简体中文";
            this.tsmiMSMSDN2008.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiEclipse
            // 
            this.tsmiEclipse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEclipse6_5,
            this.tsmiEclipse7_5,
            this.tsmiEclipse8_5,
            this.tsmiEclipseKeygen});
            this.tsmiEclipse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEclipse.Name = "tsmiEclipse";
            this.tsmiEclipse.Size = new System.Drawing.Size(132, 22);
            this.tsmiEclipse.Text = "Eclipse";
            this.tsmiEclipse.ToolTipText = "关于 Eclipse 的软件";
            // 
            // tsmiEclipse6_5
            // 
            this.tsmiEclipse6_5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEclipse6_5.Name = "tsmiEclipse6_5";
            this.tsmiEclipse6_5.Size = new System.Drawing.Size(169, 22);
            this.tsmiEclipse6_5.Tag = "C:\\MyEclipse6.5\\MyEclipse 6.5.lnk";
            this.tsmiEclipse6_5.Text = "MyEclipse 6.5";
            this.tsmiEclipse6_5.ToolTipText = "运行 MyEclipse 6.5";
            this.tsmiEclipse6_5.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiEclipse7_5
            // 
            this.tsmiEclipse7_5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEclipse7_5.Name = "tsmiEclipse7_5";
            this.tsmiEclipse7_5.Size = new System.Drawing.Size(169, 22);
            this.tsmiEclipse7_5.Tag = "C:\\Program Files\\Genuitec\\MyEclipse 7.5\\myeclipse.exe";
            this.tsmiEclipse7_5.Text = "MyEclipse 7.5";
            this.tsmiEclipse7_5.ToolTipText = "运行 MyEclipse 7.5";
            this.tsmiEclipse7_5.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiEclipse8_5
            // 
            this.tsmiEclipse8_5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEclipse8_5.Name = "tsmiEclipse8_5";
            this.tsmiEclipse8_5.Size = new System.Drawing.Size(169, 22);
            this.tsmiEclipse8_5.Tag = "C:\\Program Files\\Genuitec\\MyEclipse 8.5\\myeclipse.exe";
            this.tsmiEclipse8_5.Text = "MyEclipse 8.5";
            this.tsmiEclipse8_5.ToolTipText = "运行 MyEclipse 8.5";
            this.tsmiEclipse8_5.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiEclipseKeygen
            // 
            this.tsmiEclipseKeygen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEclipseKeygen.Name = "tsmiEclipseKeygen";
            this.tsmiEclipseKeygen.Size = new System.Drawing.Size(169, 22);
            this.tsmiEclipseKeygen.Tag = "C:\\Eclipse3.3算号器\\MyEclipseKeyGen.jar";
            this.tsmiEclipseKeygen.Text = "Eclipse6.5算号器";
            this.tsmiEclipseKeygen.Visible = false;
            this.tsmiEclipseKeygen.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiStudyLine1
            // 
            this.tsmiStudyLine1.Name = "tsmiStudyLine1";
            this.tsmiStudyLine1.Size = new System.Drawing.Size(129, 6);
            // 
            // tsmiStudyOther
            // 
            this.tsmiStudyOther.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditPlus3,
            this.tsmiXDict2008,
            this.tsmiYZRF5});
            this.tsmiStudyOther.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiStudyOther.Name = "tsmiStudyOther";
            this.tsmiStudyOther.Size = new System.Drawing.Size(132, 22);
            this.tsmiStudyOther.Text = "Other";
            this.tsmiStudyOther.ToolTipText = "其他学习软件";
            // 
            // tsmiEditPlus3
            // 
            this.tsmiEditPlus3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEditPlus3.Name = "tsmiEditPlus3";
            this.tsmiEditPlus3.Size = new System.Drawing.Size(226, 22);
            this.tsmiEditPlus3.Tag = "C:\\Program Files\\EditPlus 3\\editplus.exe";
            this.tsmiEditPlus3.Text = "EditPlus 3";
            this.tsmiEditPlus3.ToolTipText = "打开 EditPlus 3";
            this.tsmiEditPlus3.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiXDict2008
            // 
            this.tsmiXDict2008.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiXDict2008.Name = "tsmiXDict2008";
            this.tsmiXDict2008.Size = new System.Drawing.Size(226, 22);
            this.tsmiXDict2008.Tag = "C:\\Program Files\\powerword2008\\Iciba\\XDict.exe";
            this.tsmiXDict2008.Text = "金山词霸 2008 Beta 个人版";
            this.tsmiXDict2008.ToolTipText = "打开 金山词霸 2008 Beta 个人版";
            this.tsmiXDict2008.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiYZRF5
            // 
            this.tsmiYZRF5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiYZRF5.Name = "tsmiYZRF5";
            this.tsmiYZRF5.Size = new System.Drawing.Size(226, 22);
            this.tsmiYZRF5.Tag = "C:\\Program Files\\运指如飞5\\运指如飞5.exe";
            this.tsmiYZRF5.Text = "运指如飞5";
            this.tsmiYZRF5.ToolTipText = "打开 运指如飞5";
            this.tsmiYZRF5.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiHelpTool
            // 
            this.tsmiHelpTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelpFirefox,
            this.tsmiHelpIE,
            this.tsmiHelpLine1,
            this.tsmiHelpPMLX,
            this.tsmiHelpStuClient});
            this.tsmiHelpTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpTool.Name = "tsmiHelpTool";
            this.tsmiHelpTool.Size = new System.Drawing.Size(170, 22);
            this.tsmiHelpTool.Text = "辅助工具";
            this.tsmiHelpTool.ToolTipText = "辅助工具";
            // 
            // tsmiHelpFirefox
            // 
            this.tsmiHelpFirefox.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpFirefox.Name = "tsmiHelpFirefox";
            this.tsmiHelpFirefox.Size = new System.Drawing.Size(174, 22);
            this.tsmiHelpFirefox.Tag = "C:\\Program Files\\Mozilla Firefox\\firefox.exe";
            this.tsmiHelpFirefox.Text = "Mozilla Firefox";
            this.tsmiHelpFirefox.ToolTipText = "运行 Mozilla Firefox";
            this.tsmiHelpFirefox.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiHelpIE
            // 
            this.tsmiHelpIE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpIE.Name = "tsmiHelpIE";
            this.tsmiHelpIE.Size = new System.Drawing.Size(174, 22);
            this.tsmiHelpIE.Tag = "C:\\Program Files\\Internet Explorer\\IEXPLORE.EXE";
            this.tsmiHelpIE.Text = "Internet Explorer";
            this.tsmiHelpIE.ToolTipText = "运行 Internet Explorer";
            this.tsmiHelpIE.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiHelpLine1
            // 
            this.tsmiHelpLine1.Name = "tsmiHelpLine1";
            this.tsmiHelpLine1.Size = new System.Drawing.Size(171, 6);
            // 
            // tsmiHelpPMLX
            // 
            this.tsmiHelpPMLX.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpPMLX.Name = "tsmiHelpPMLX";
            this.tsmiHelpPMLX.Size = new System.Drawing.Size(174, 22);
            this.tsmiHelpPMLX.Tag = "C:\\Program Files\\屏幕录像专家\\屏录专家.exe";
            this.tsmiHelpPMLX.Text = "屏幕录像专家";
            this.tsmiHelpPMLX.ToolTipText = "运行 屏幕录像专家";
            this.tsmiHelpPMLX.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiHelpStuClient
            // 
            this.tsmiHelpStuClient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpStuClient.Name = "tsmiHelpStuClient";
            this.tsmiHelpStuClient.Size = new System.Drawing.Size(174, 22);
            this.tsmiHelpStuClient.Tag = "C:\\Program Files\\Lingbo\\NetClass\\NCStu.exe";
            this.tsmiHelpStuClient.Text = "凌波多媒体学生端";
            this.tsmiHelpStuClient.ToolTipText = "运行 凌波多媒体学生端";
            this.tsmiHelpStuClient.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiSysSubTool
            // 
            this.tsmiSysSubTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSysPaint,
            this.tsmiSysCalc,
            this.tsmiSysNotepad,
            this.tsmiSysWriter,
            this.tsmiSysZoom,
            this.tsmiSysOSK,
            this.tsmiSysCmd,
            this.tsmiSysExplorer,
            this.tsmiSysMstsc,
            this.tsmiSysSubToolLine1,
            this.tsmiSysTools});
            this.tsmiSysSubTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysSubTool.Name = "tsmiSysSubTool";
            this.tsmiSysSubTool.Size = new System.Drawing.Size(170, 22);
            this.tsmiSysSubTool.Text = "附件工具";
            this.tsmiSysSubTool.ToolTipText = "系统附件工具";
            // 
            // tsmiSysPaint
            // 
            this.tsmiSysPaint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysPaint.Name = "tsmiSysPaint";
            this.tsmiSysPaint.Size = new System.Drawing.Size(148, 22);
            this.tsmiSysPaint.Tag = "mspaint.exe";
            this.tsmiSysPaint.Text = "画图";
            this.tsmiSysPaint.ToolTipText = "打开 画图";
            this.tsmiSysPaint.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiSysCalc
            // 
            this.tsmiSysCalc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysCalc.Name = "tsmiSysCalc";
            this.tsmiSysCalc.Size = new System.Drawing.Size(148, 22);
            this.tsmiSysCalc.Tag = "calc.exe";
            this.tsmiSysCalc.Text = "计算器";
            this.tsmiSysCalc.ToolTipText = "打开 计算器";
            this.tsmiSysCalc.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiSysNotepad
            // 
            this.tsmiSysNotepad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysNotepad.Name = "tsmiSysNotepad";
            this.tsmiSysNotepad.Size = new System.Drawing.Size(148, 22);
            this.tsmiSysNotepad.Tag = "notepad.exe";
            this.tsmiSysNotepad.Text = "记事本";
            this.tsmiSysNotepad.ToolTipText = "打开 记事本";
            this.tsmiSysNotepad.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiSysWriter
            // 
            this.tsmiSysWriter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysWriter.Name = "tsmiSysWriter";
            this.tsmiSysWriter.Size = new System.Drawing.Size(148, 22);
            this.tsmiSysWriter.Tag = "write.exe";
            this.tsmiSysWriter.Text = "写字板";
            this.tsmiSysWriter.ToolTipText = "打开 写字板";
            this.tsmiSysWriter.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiSysZoom
            // 
            this.tsmiSysZoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysZoom.Name = "tsmiSysZoom";
            this.tsmiSysZoom.Size = new System.Drawing.Size(148, 22);
            this.tsmiSysZoom.Tag = "Magnify.exe";
            this.tsmiSysZoom.Text = "放大镜";
            this.tsmiSysZoom.ToolTipText = "启动 放大镜";
            this.tsmiSysZoom.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiSysOSK
            // 
            this.tsmiSysOSK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysOSK.Name = "tsmiSysOSK";
            this.tsmiSysOSK.Size = new System.Drawing.Size(148, 22);
            this.tsmiSysOSK.Tag = "osk.exe";
            this.tsmiSysOSK.Text = "屏幕键盘";
            this.tsmiSysOSK.ToolTipText = "启动 屏幕键盘";
            this.tsmiSysOSK.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiSysCmd
            // 
            this.tsmiSysCmd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysCmd.Name = "tsmiSysCmd";
            this.tsmiSysCmd.Size = new System.Drawing.Size(148, 22);
            this.tsmiSysCmd.Tag = "cmd.exe";
            this.tsmiSysCmd.Text = "命令提示符";
            this.tsmiSysCmd.ToolTipText = "打开 命令提示符";
            this.tsmiSysCmd.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiSysExplorer
            // 
            this.tsmiSysExplorer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysExplorer.Name = "tsmiSysExplorer";
            this.tsmiSysExplorer.Size = new System.Drawing.Size(148, 22);
            this.tsmiSysExplorer.Tag = "explorer.exe";
            this.tsmiSysExplorer.Text = "资源管理器";
            this.tsmiSysExplorer.ToolTipText = "打开 资源管理器";
            this.tsmiSysExplorer.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiSysMstsc
            // 
            this.tsmiSysMstsc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysMstsc.Name = "tsmiSysMstsc";
            this.tsmiSysMstsc.Size = new System.Drawing.Size(148, 22);
            this.tsmiSysMstsc.Tag = "mstsc.exe";
            this.tsmiSysMstsc.Text = "远程桌面连接";
            this.tsmiSysMstsc.ToolTipText = "启动 远程桌面连接";
            this.tsmiSysMstsc.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiSysSubToolLine1
            // 
            this.tsmiSysSubToolLine1.Name = "tsmiSysSubToolLine1";
            this.tsmiSysSubToolLine1.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmiSysTools
            // 
            this.tsmiSysTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSysCleanmgr,
            this.tsmiSysMSInfo32,
            this.tsmiSysConfig,
            this.tsmiSysCharmap});
            this.tsmiSysTools.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysTools.Name = "tsmiSysTools";
            this.tsmiSysTools.Size = new System.Drawing.Size(148, 22);
            this.tsmiSysTools.Text = "系统工具";
            this.tsmiSysTools.ToolTipText = "系统工具";
            // 
            // tsmiSysCleanmgr
            // 
            this.tsmiSysCleanmgr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysCleanmgr.Name = "tsmiSysCleanmgr";
            this.tsmiSysCleanmgr.Size = new System.Drawing.Size(136, 22);
            this.tsmiSysCleanmgr.Tag = "Cleanmgr.exe";
            this.tsmiSysCleanmgr.Text = "磁盘清理";
            this.tsmiSysCleanmgr.ToolTipText = "启动 磁盘清理";
            this.tsmiSysCleanmgr.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiSysMSInfo32
            // 
            this.tsmiSysMSInfo32.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysMSInfo32.Name = "tsmiSysMSInfo32";
            this.tsmiSysMSInfo32.Size = new System.Drawing.Size(136, 22);
            this.tsmiSysMSInfo32.Tag = "msinfo32.exe";
            this.tsmiSysMSInfo32.Text = "系统信息";
            this.tsmiSysMSInfo32.ToolTipText = "查看 系统信息";
            this.tsmiSysMSInfo32.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiSysConfig
            // 
            this.tsmiSysConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysConfig.Name = "tsmiSysConfig";
            this.tsmiSysConfig.Size = new System.Drawing.Size(136, 22);
            this.tsmiSysConfig.Tag = "msconfig.exe";
            this.tsmiSysConfig.Text = "系统配置";
            this.tsmiSysConfig.ToolTipText = "查看 系统配置";
            this.tsmiSysConfig.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiSysCharmap
            // 
            this.tsmiSysCharmap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSysCharmap.Name = "tsmiSysCharmap";
            this.tsmiSysCharmap.Size = new System.Drawing.Size(136, 22);
            this.tsmiSysCharmap.Tag = "Charmap.exe";
            this.tsmiSysCharmap.Text = "字符映射表";
            this.tsmiSysCharmap.ToolTipText = "打开 字符映射表";
            this.tsmiSysCharmap.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiManager
            // 
            this.tsmiManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMgrCompmgmt,
            this.tsmiMgrDevmgmt,
            this.tsmiMgrDiskmgmt,
            this.tsmiMgrLusrmgr,
            this.tsmiMgrLine1,
            this.tsmiMgrControl,
            this.tsmiMgrEventvwr,
            this.tsmiMgrTaskmgr,
            this.tsmiMgrInternetOpt,
            this.tsmiMgrRegedit});
            this.tsmiManager.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiManager.Name = "tsmiManager";
            this.tsmiManager.Size = new System.Drawing.Size(170, 22);
            this.tsmiManager.Text = "管理工具";
            this.tsmiManager.ToolTipText = "系统管理工具";
            // 
            // tsmiMgrCompmgmt
            // 
            this.tsmiMgrCompmgmt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMgrCompmgmt.Name = "tsmiMgrCompmgmt";
            this.tsmiMgrCompmgmt.Size = new System.Drawing.Size(149, 22);
            this.tsmiMgrCompmgmt.Tag = "compmgmt.msc";
            this.tsmiMgrCompmgmt.Text = "计算机管理";
            this.tsmiMgrCompmgmt.ToolTipText = "打开 计算机管理";
            this.tsmiMgrCompmgmt.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMgrDevmgmt
            // 
            this.tsmiMgrDevmgmt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMgrDevmgmt.Name = "tsmiMgrDevmgmt";
            this.tsmiMgrDevmgmt.Size = new System.Drawing.Size(149, 22);
            this.tsmiMgrDevmgmt.Tag = "devmgmt.msc";
            this.tsmiMgrDevmgmt.Text = "设备管理器";
            this.tsmiMgrDevmgmt.ToolTipText = "打开 设备管理器";
            this.tsmiMgrDevmgmt.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMgrDiskmgmt
            // 
            this.tsmiMgrDiskmgmt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMgrDiskmgmt.Name = "tsmiMgrDiskmgmt";
            this.tsmiMgrDiskmgmt.Size = new System.Drawing.Size(149, 22);
            this.tsmiMgrDiskmgmt.Tag = "diskmgmt.msc";
            this.tsmiMgrDiskmgmt.Text = "磁盘管理";
            this.tsmiMgrDiskmgmt.ToolTipText = "打开 磁盘管理";
            this.tsmiMgrDiskmgmt.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMgrLusrmgr
            // 
            this.tsmiMgrLusrmgr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMgrLusrmgr.Name = "tsmiMgrLusrmgr";
            this.tsmiMgrLusrmgr.Size = new System.Drawing.Size(149, 22);
            this.tsmiMgrLusrmgr.Tag = "lusrmgr.msc";
            this.tsmiMgrLusrmgr.Text = "本地用户和组";
            this.tsmiMgrLusrmgr.ToolTipText = "打开 本地用户和组";
            this.tsmiMgrLusrmgr.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMgrLine1
            // 
            this.tsmiMgrLine1.Name = "tsmiMgrLine1";
            this.tsmiMgrLine1.Size = new System.Drawing.Size(146, 6);
            // 
            // tsmiMgrControl
            // 
            this.tsmiMgrControl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMgrControl.Name = "tsmiMgrControl";
            this.tsmiMgrControl.Size = new System.Drawing.Size(149, 22);
            this.tsmiMgrControl.Tag = "control.exe";
            this.tsmiMgrControl.Text = "控制面板";
            this.tsmiMgrControl.ToolTipText = "打开 控制面板";
            this.tsmiMgrControl.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMgrEventvwr
            // 
            this.tsmiMgrEventvwr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMgrEventvwr.Name = "tsmiMgrEventvwr";
            this.tsmiMgrEventvwr.Size = new System.Drawing.Size(149, 22);
            this.tsmiMgrEventvwr.Tag = "eventvwr.exe";
            this.tsmiMgrEventvwr.Text = "事件查看器";
            this.tsmiMgrEventvwr.ToolTipText = "打开 事件查看器";
            this.tsmiMgrEventvwr.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMgrTaskmgr
            // 
            this.tsmiMgrTaskmgr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMgrTaskmgr.Name = "tsmiMgrTaskmgr";
            this.tsmiMgrTaskmgr.Size = new System.Drawing.Size(149, 22);
            this.tsmiMgrTaskmgr.Tag = "taskmgr.exe";
            this.tsmiMgrTaskmgr.Text = "任务管理器";
            this.tsmiMgrTaskmgr.ToolTipText = "打开 任务管理器";
            this.tsmiMgrTaskmgr.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMgrInternetOpt
            // 
            this.tsmiMgrInternetOpt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMgrInternetOpt.Name = "tsmiMgrInternetOpt";
            this.tsmiMgrInternetOpt.Size = new System.Drawing.Size(149, 22);
            this.tsmiMgrInternetOpt.Tag = "inetcpl.cpl";
            this.tsmiMgrInternetOpt.Text = "Internet 选项";
            this.tsmiMgrInternetOpt.ToolTipText = "打开 Internet 选项";
            this.tsmiMgrInternetOpt.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMgrRegedit
            // 
            this.tsmiMgrRegedit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMgrRegedit.Name = "tsmiMgrRegedit";
            this.tsmiMgrRegedit.Size = new System.Drawing.Size(149, 22);
            this.tsmiMgrRegedit.Tag = "regedit.exe";
            this.tsmiMgrRegedit.Text = "注册表编辑器";
            this.tsmiMgrRegedit.ToolTipText = "打开 注册表编辑器";
            this.tsmiMgrRegedit.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiHelpDoc
            // 
            this.tsmiHelpDoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelpCSS,
            this.tsmiHelpJ2EE_API,
            this.tsmiHelpJ2EE5_0API_CN,
            this.tsmiHelpJAVA5_0API_CN,
            this.tsmiHelpJavaScript,
            this.tsmiHelpJavaScriptHelp_CN,
            this.tsmiHelpJETSQL40,
            this.tsmiHelpMySQL_CN_SC,
            this.tsmiHelpMySQL});
            this.tsmiHelpDoc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpDoc.Name = "tsmiHelpDoc";
            this.tsmiHelpDoc.Size = new System.Drawing.Size(170, 22);
            this.tsmiHelpDoc.Text = "帮助文档";
            this.tsmiHelpDoc.ToolTipText = "帮助文档";
            // 
            // tsmiHelpCSS
            // 
            this.tsmiHelpCSS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpCSS.Name = "tsmiHelpCSS";
            this.tsmiHelpCSS.Size = new System.Drawing.Size(184, 22);
            this.tsmiHelpCSS.Tag = "C:\\帮助文档\\CSS参考手册.chm";
            this.tsmiHelpCSS.Text = "CSS参考手册";
            this.tsmiHelpCSS.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiHelpJ2EE_API
            // 
            this.tsmiHelpJ2EE_API.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpJ2EE_API.Name = "tsmiHelpJ2EE_API";
            this.tsmiHelpJ2EE_API.Size = new System.Drawing.Size(184, 22);
            this.tsmiHelpJ2EE_API.Tag = "C:\\帮助文档\\J2EE_API.chm";
            this.tsmiHelpJ2EE_API.Text = "J2EE_API";
            this.tsmiHelpJ2EE_API.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiHelpJ2EE5_0API_CN
            // 
            this.tsmiHelpJ2EE5_0API_CN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpJ2EE5_0API_CN.Name = "tsmiHelpJ2EE5_0API_CN";
            this.tsmiHelpJ2EE5_0API_CN.Size = new System.Drawing.Size(184, 22);
            this.tsmiHelpJ2EE5_0API_CN.Tag = "C:\\帮助文档\\J2SE5.0API_CN.chm";
            this.tsmiHelpJ2EE5_0API_CN.Text = "J2SE5.0API_CN";
            this.tsmiHelpJ2EE5_0API_CN.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiHelpJAVA5_0API_CN
            // 
            this.tsmiHelpJAVA5_0API_CN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpJAVA5_0API_CN.Name = "tsmiHelpJAVA5_0API_CN";
            this.tsmiHelpJAVA5_0API_CN.Size = new System.Drawing.Size(184, 22);
            this.tsmiHelpJAVA5_0API_CN.Tag = "C:\\帮助文档\\JAVA5.0API_CN.CHM";
            this.tsmiHelpJAVA5_0API_CN.Text = "JAVA5.0API_CN";
            this.tsmiHelpJAVA5_0API_CN.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiHelpJavaScript
            // 
            this.tsmiHelpJavaScript.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpJavaScript.Name = "tsmiHelpJavaScript";
            this.tsmiHelpJavaScript.Size = new System.Drawing.Size(184, 22);
            this.tsmiHelpJavaScript.Tag = "C:\\帮助文档\\JavaScript DOM.chm";
            this.tsmiHelpJavaScript.Text = "JavaScript DOM";
            this.tsmiHelpJavaScript.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiHelpJavaScriptHelp_CN
            // 
            this.tsmiHelpJavaScriptHelp_CN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpJavaScriptHelp_CN.Name = "tsmiHelpJavaScriptHelp_CN";
            this.tsmiHelpJavaScriptHelp_CN.Size = new System.Drawing.Size(184, 22);
            this.tsmiHelpJavaScriptHelp_CN.Tag = "C:\\帮助文档\\JavaScriptHelp_cn.chm";
            this.tsmiHelpJavaScriptHelp_CN.Text = "JavaScriptHelp_CN";
            this.tsmiHelpJavaScriptHelp_CN.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiHelpJETSQL40
            // 
            this.tsmiHelpJETSQL40.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpJETSQL40.Name = "tsmiHelpJETSQL40";
            this.tsmiHelpJETSQL40.Size = new System.Drawing.Size(184, 22);
            this.tsmiHelpJETSQL40.Tag = "C:\\帮助文档\\JETSQL40.chm";
            this.tsmiHelpJETSQL40.Text = "JETSQL40";
            this.tsmiHelpJETSQL40.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiHelpMySQL_CN_SC
            // 
            this.tsmiHelpMySQL_CN_SC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpMySQL_CN_SC.Name = "tsmiHelpMySQL_CN_SC";
            this.tsmiHelpMySQL_CN_SC.Size = new System.Drawing.Size(184, 22);
            this.tsmiHelpMySQL_CN_SC.Tag = "C:\\帮助文档\\mysql_cn_sc.chm";
            this.tsmiHelpMySQL_CN_SC.Text = "MySQL_CN_SC";
            this.tsmiHelpMySQL_CN_SC.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiHelpMySQL
            // 
            this.tsmiHelpMySQL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelpMySQL.Name = "tsmiHelpMySQL";
            this.tsmiHelpMySQL.Size = new System.Drawing.Size(184, 22);
            this.tsmiHelpMySQL.Tag = "C:\\帮助文档\\MySQL参考手册.chm";
            this.tsmiHelpMySQL.Text = "MySQL参考手册";
            this.tsmiHelpMySQL.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiMSOffice
            // 
            this.tsmiMSOffice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOfficeAccess,
            this.tsmiOfficeExcel,
            this.tsmiOfficeOutlook,
            this.tsmiOfficePPT,
            this.tsmiOfficeVisio,
            this.tsmiOfficeWord});
            this.tsmiMSOffice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMSOffice.Name = "tsmiMSOffice";
            this.tsmiMSOffice.Size = new System.Drawing.Size(170, 22);
            this.tsmiMSOffice.Text = "Microsoft Office";
            this.tsmiMSOffice.ToolTipText = "Microsoft Office";
            // 
            // tsmiOfficeAccess
            // 
            this.tsmiOfficeAccess.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOfficeAccess.Name = "tsmiOfficeAccess";
            this.tsmiOfficeAccess.Size = new System.Drawing.Size(239, 22);
            this.tsmiOfficeAccess.Tag = "msaccess.exe";
            this.tsmiOfficeAccess.Text = "Microsoft Office Access";
            this.tsmiOfficeAccess.ToolTipText = "运行 Microsoft Office Access";
            this.tsmiOfficeAccess.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiOfficeExcel
            // 
            this.tsmiOfficeExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOfficeExcel.Name = "tsmiOfficeExcel";
            this.tsmiOfficeExcel.Size = new System.Drawing.Size(239, 22);
            this.tsmiOfficeExcel.Tag = "excel.exe";
            this.tsmiOfficeExcel.Text = "Microsoft Office Excel";
            this.tsmiOfficeExcel.ToolTipText = "运行 Microsoft Office Excel";
            this.tsmiOfficeExcel.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiOfficeOutlook
            // 
            this.tsmiOfficeOutlook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOfficeOutlook.Name = "tsmiOfficeOutlook";
            this.tsmiOfficeOutlook.Size = new System.Drawing.Size(239, 22);
            this.tsmiOfficeOutlook.Tag = "outlook.exe";
            this.tsmiOfficeOutlook.Text = "Microsoft Office Outlook";
            this.tsmiOfficeOutlook.ToolTipText = "运行 Microsoft Office Outlook";
            this.tsmiOfficeOutlook.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiOfficePPT
            // 
            this.tsmiOfficePPT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOfficePPT.Name = "tsmiOfficePPT";
            this.tsmiOfficePPT.Size = new System.Drawing.Size(239, 22);
            this.tsmiOfficePPT.Tag = "powerpnt.exe";
            this.tsmiOfficePPT.Text = "Microsoft Office PowerPoint";
            this.tsmiOfficePPT.ToolTipText = "运行 Microsoft Office PowerPoint";
            this.tsmiOfficePPT.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiOfficeVisio
            // 
            this.tsmiOfficeVisio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOfficeVisio.Name = "tsmiOfficeVisio";
            this.tsmiOfficeVisio.Size = new System.Drawing.Size(239, 22);
            this.tsmiOfficeVisio.Tag = "C:\\Program Files\\Microsoft Office\\Visio11\\VISIO.EXE";
            this.tsmiOfficeVisio.Text = "Microsoft Office Visio";
            this.tsmiOfficeVisio.ToolTipText = "运行 Microsoft Office Visio";
            this.tsmiOfficeVisio.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsmiOfficeWord
            // 
            this.tsmiOfficeWord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOfficeWord.Name = "tsmiOfficeWord";
            this.tsmiOfficeWord.Size = new System.Drawing.Size(239, 22);
            this.tsmiOfficeWord.Tag = "winword.exe";
            this.tsmiOfficeWord.Text = "Microsoft Office Word";
            this.tsmiOfficeWord.ToolTipText = "运行 Microsoft Office Word";
            this.tsmiOfficeWord.Click += new System.EventHandler(this.OpenProgram_Click);
            // 
            // tsMainLine2
            // 
            this.tsMainLine2.Name = "tsMainLine2";
            this.tsMainLine2.Size = new System.Drawing.Size(255, 6);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContent.BackgroundImage")));
            this.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContent.Controls.Add(this.tsControlButtons);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(5, 25);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(290, 370);
            this.pnlContent.TabIndex = 51;
            // 
            // FrmServiceManage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.ControlBox = false;
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlRightBorder);
            this.Controls.Add(this.pnlLeftBorder);
            this.Controls.Add(this.pnlBottomBorder);
            this.Controls.Add(this.picMiniButton);
            this.Controls.Add(this.picCloseButton);
            this.Controls.Add(this.pnlTopTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "FrmServiceManage";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "北大青鸟-唐城中心 软件服务管理工具";
            this.TopMost = true;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmServiceManage_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmServiceManage_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picMiniButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseButton)).EndInit();
            this.pnlTopTitle.ResumeLayout(false);
            this.pnlTopTitle.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuperMode)).EndInit();
            this.rmnuICON.ResumeLayout(false);
            this.tsControlButtons.ResumeLayout(false);
            this.tsControlButtons.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMiniButton;
        private System.Windows.Forms.PictureBox picCloseButton;
        private System.Windows.Forms.Panel pnlTopTitle;
        private System.Windows.Forms.Panel pnlBottomBorder;
        private System.Windows.Forms.Panel pnlLeftBorder;
        private System.Windows.Forms.Panel pnlRightBorder;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.LinkLabel lnkAbout;
        private System.Windows.Forms.Label lblTitleText;
        private System.Windows.Forms.ImageList imgsCtrlPict;
        private System.Windows.Forms.NotifyIcon iconManage;
        private System.Windows.Forms.PictureBox picSuperMode;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip rmnuICON;
        private System.Windows.Forms.ToolStripMenuItem rmnuShowMain;
        private System.Windows.Forms.ToolStripMenuItem rmnuExit;
        private System.Windows.Forms.ToolStrip tsControlButtons;
        private System.Windows.Forms.ToolStripSplitButton tssbOracle11g;
        private System.Windows.Forms.ToolStripMenuItem tsmiOracleMainService;
        private System.Windows.Forms.ToolStripMenuItem tsmiOracleMainServiceStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiOracleMainServicePause;
        private System.Windows.Forms.ToolStripMenuItem tsmiOracleMainServiceContinue;
        private System.Windows.Forms.ToolStripMenuItem tsmiOracleMainServiceStop;
        private System.Windows.Forms.ToolStripSeparator tsmiOracleServiceLine1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOracleMainServiceRestart;
        private System.Windows.Forms.ToolStripMenuItem tsmiOracleListenerService;
        private System.Windows.Forms.ToolStripMenuItem tsmiOracleListenerServiceStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiOracleListenerServiceStop;
        private System.Windows.Forms.ToolStripSeparator tsmiOracleListenerLine1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOracleListenerServiceRestart;
        private System.Windows.Forms.ToolStripSeparator tsmiOracleLine1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOracleCorrectConfigurationFile;
        private System.Windows.Forms.ToolStripSeparator tsmiOracleLine2;
        private System.Windows.Forms.ToolStripMenuItem tsmiOracleTodeOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiToadKeyGen;
        private System.Windows.Forms.ToolStripComboBox tscboToadKeyName;
        private System.Windows.Forms.ToolStripTextBox tstxtToadKeyValue;
        private System.Windows.Forms.ToolStripSplitButton tssbSQL2005;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQL2005ServiceStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQL2005ServicePause;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQL2005ServiceContinue;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQL2005ServiceStop;
        private System.Windows.Forms.ToolStripSeparator tsmiSQL2005Line2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQL2005ServiceRestart;
        private System.Windows.Forms.ToolStripSeparator tsmiSQL2005Line1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQL2005Open;
        private System.Windows.Forms.ToolStripSplitButton tssbSQL2008;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQL2008ServiceStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQL2008ServicePause;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQL2008ServiceContinue;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQL2008ServiceStop;
        private System.Windows.Forms.ToolStripSeparator tsmiSQL2008Line2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQL2008ServiceRestart;
        private System.Windows.Forms.ToolStripSeparator tsmiSQL2008Line1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQL2008Open;
        private System.Windows.Forms.ToolStripSplitButton tssbMySQL;
        private System.Windows.Forms.ToolStripMenuItem tsmiMySQLServiceStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiMySQLServiceStop;
        private System.Windows.Forms.ToolStripSeparator tsmiMySQLLine2;
        private System.Windows.Forms.ToolStripMenuItem tsmiMySQLServiceRestart;
        private System.Windows.Forms.ToolStripSeparator tsmiMySQLLine1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMySQLOpen;
        private System.Windows.Forms.ToolStripSeparator tsMainLine1;
        private System.Windows.Forms.ToolStripSplitButton tssbAllSoftware;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudaySoftware;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdobe;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboleDW4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdobeFB4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdobeFlash4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdobePS4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdobeReaderX;
        private System.Windows.Forms.ToolStripMenuItem tsmiMicrosoft;
        private System.Windows.Forms.ToolStripMenuItem tsmiMSVS2005;
        private System.Windows.Forms.ToolStripMenuItem tsmiMSVS2008;
        private System.Windows.Forms.ToolStripMenuItem tsmiMSVS2010;
        private System.Windows.Forms.ToolStripMenuItem tsmiMSMSDN2008;
        private System.Windows.Forms.ToolStripMenuItem tsmiEclipse;
        private System.Windows.Forms.ToolStripMenuItem tsmiEclipse6_5;
        private System.Windows.Forms.ToolStripMenuItem tsmiEclipse7_5;
        private System.Windows.Forms.ToolStripMenuItem tsmiEclipse8_5;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudyOther;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPlus3;
        private System.Windows.Forms.ToolStripMenuItem tsmiXDict2008;
        private System.Windows.Forms.ToolStripMenuItem tsmiYZRF5;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpPMLX;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysSubTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysPaint;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysCalc;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysNotepad;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysWriter;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysZoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysOSK;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysCmd;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysExplorer;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysMstsc;
        private System.Windows.Forms.ToolStripSeparator tsmiSysSubToolLine1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysCleanmgr;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysMSInfo32;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysCharmap;
        private System.Windows.Forms.ToolStripMenuItem tsmiManager;
        protected System.Windows.Forms.ToolStripMenuItem tsmiMgrCompmgmt;
        protected System.Windows.Forms.ToolStripMenuItem tsmiMgrDevmgmt;
        protected System.Windows.Forms.ToolStripMenuItem tsmiMgrDiskmgmt;
        protected System.Windows.Forms.ToolStripMenuItem tsmiMgrLusrmgr;
        protected System.Windows.Forms.ToolStripSeparator tsmiMgrLine1;
        protected System.Windows.Forms.ToolStripMenuItem tsmiMgrControl;
        protected System.Windows.Forms.ToolStripMenuItem tsmiMgrEventvwr;
        protected System.Windows.Forms.ToolStripMenuItem tsmiMgrTaskmgr;
        protected System.Windows.Forms.ToolStripMenuItem tsmiMgrInternetOpt;
        private System.Windows.Forms.ToolStripMenuItem tsmiMgrRegedit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpDoc;
        private System.Windows.Forms.ToolStripMenuItem tsmiMSOffice;
        private System.Windows.Forms.ToolStripMenuItem tsmiOfficeAccess;
        private System.Windows.Forms.ToolStripMenuItem tsmiOfficeExcel;
        private System.Windows.Forms.ToolStripMenuItem tsmiOfficeOutlook;
        private System.Windows.Forms.ToolStripMenuItem tsmiOfficePPT;
        private System.Windows.Forms.ToolStripMenuItem tsmiOfficeVisio;
        private System.Windows.Forms.ToolStripMenuItem tsmiOfficeWord;
        private System.Windows.Forms.ToolStripSeparator tsMainLine2;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripSeparator rmnuLine2;
        private System.Windows.Forms.ToolStripMenuItem rmnuAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiMSMSDN2005;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpFirefox;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpIE;
        private System.Windows.Forms.ToolStripMenuItem tsmiEclipseKeygen;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpStuClient;
        private System.Windows.Forms.ToolStripSeparator tsmiHelpLine1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpCSS;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpJ2EE_API;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpJ2EE5_0API_CN;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpJAVA5_0API_CN;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpJavaScript;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpJavaScriptHelp_CN;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpJETSQL40;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpMySQL_CN_SC;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpMySQL;
        private System.Windows.Forms.ToolStripSeparator tsmiStudyLine1;
    }
}

