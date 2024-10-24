namespace proxifyre_tray
{
    partial class FormMain
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
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.listBoxProxies = new System.Windows.Forms.ListBox();
            this.labelProxies = new System.Windows.Forms.Label();
            this.comboBoxLogLevel = new System.Windows.Forms.ComboBox();
            this.listBoxApps = new System.Windows.Forms.ListBox();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelIp = new System.Windows.Forms.Label();
            this.labelApps = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.checkBoxTcp = new System.Windows.Forms.CheckBox();
            this.checkBoxUdp = new System.Windows.Forms.CheckBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxApp = new System.Windows.Forms.TextBox();
            this.labelConfiguration = new System.Windows.Forms.Label();
            this.openFileDialogApp = new System.Windows.Forms.OpenFileDialog();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonAppsDel = new System.Windows.Forms.Button();
            this.buttonAppsAdd = new System.Windows.Forms.Button();
            this.buttonProxiesDel = new System.Windows.Forms.Button();
            this.buttonProxiesAdd = new System.Windows.Forms.Button();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStartup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.toolTipApp = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOutput.HideSelection = false;
            this.richTextBoxOutput.Location = new System.Drawing.Point(12, 140);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(610, 82);
            this.richTextBoxOutput.TabIndex = 22;
            this.richTextBoxOutput.Text = "";
            this.richTextBoxOutput.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxOutput_LinkClicked);
            // 
            // listBoxProxies
            // 
            this.listBoxProxies.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProxies.FormattingEnabled = true;
            this.listBoxProxies.ItemHeight = 15;
            this.listBoxProxies.Location = new System.Drawing.Point(12, 31);
            this.listBoxProxies.Name = "listBoxProxies";
            this.listBoxProxies.Size = new System.Drawing.Size(156, 79);
            this.listBoxProxies.TabIndex = 4;
            this.listBoxProxies.SelectedIndexChanged += new System.EventHandler(this.listBoxProxies_SelectedIndexChanged);
            // 
            // labelProxies
            // 
            this.labelProxies.AutoSize = true;
            this.labelProxies.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProxies.Location = new System.Drawing.Point(12, 9);
            this.labelProxies.Name = "labelProxies";
            this.labelProxies.Size = new System.Drawing.Size(72, 19);
            this.labelProxies.TabIndex = 1;
            this.labelProxies.Text = "Proxies";
            // 
            // comboBoxLogLevel
            // 
            this.comboBoxLogLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLogLevel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLogLevel.FormattingEnabled = true;
            this.comboBoxLogLevel.Location = new System.Drawing.Point(12, 228);
            this.comboBoxLogLevel.Name = "comboBoxLogLevel";
            this.comboBoxLogLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLogLevel.TabIndex = 23;
            this.comboBoxLogLevel.Validated += new System.EventHandler(this.comboBoxLogLevel_Validated);
            // 
            // listBoxApps
            // 
            this.listBoxApps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxApps.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxApps.FormattingEnabled = true;
            this.listBoxApps.ItemHeight = 15;
            this.listBoxApps.Location = new System.Drawing.Point(174, 31);
            this.listBoxApps.Name = "listBoxApps";
            this.listBoxApps.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxApps.Size = new System.Drawing.Size(166, 79);
            this.listBoxApps.TabIndex = 7;
            this.listBoxApps.SelectedIndexChanged += new System.EventHandler(this.listBoxApps_SelectedIndexChanged);
            this.listBoxApps.MouseHover += new System.EventHandler(this.listBoxApps_MouseHover);
            // 
            // textBoxIp
            // 
            this.textBoxIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIp.Location = new System.Drawing.Point(415, 31);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(115, 23);
            this.textBoxIp.TabIndex = 13;
            this.textBoxIp.Validated += new System.EventHandler(this.textBoxIp_Validated);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(415, 57);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(207, 23);
            this.textBoxUsername.TabIndex = 17;
            this.textBoxUsername.Validated += new System.EventHandler(this.textBoxUsername_Validated);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(415, 86);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(207, 23);
            this.textBoxPassword.TabIndex = 19;
            this.textBoxPassword.Validated += new System.EventHandler(this.textBoxPassword_Validated);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(351, 60);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(63, 15);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.Text = "Username";
            // 
            // labelIp
            // 
            this.labelIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIp.AutoSize = true;
            this.labelIp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIp.Location = new System.Drawing.Point(393, 34);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(21, 15);
            this.labelIp.TabIndex = 12;
            this.labelIp.Text = "IP";
            // 
            // labelApps
            // 
            this.labelApps.AutoSize = true;
            this.labelApps.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApps.Location = new System.Drawing.Point(170, 9);
            this.labelApps.Name = "labelApps";
            this.labelApps.Size = new System.Drawing.Size(45, 19);
            this.labelApps.TabIndex = 2;
            this.labelApps.Text = "Apps";
            // 
            // labelPort
            // 
            this.labelPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(541, 34);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 15);
            this.labelPort.TabIndex = 14;
            this.labelPort.Text = "Port";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(351, 89);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 15);
            this.labelPassword.TabIndex = 18;
            this.labelPassword.Text = "Password";
            // 
            // checkBoxTcp
            // 
            this.checkBoxTcp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTcp.AutoSize = true;
            this.checkBoxTcp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTcp.Location = new System.Drawing.Point(506, 115);
            this.checkBoxTcp.Name = "checkBoxTcp";
            this.checkBoxTcp.Size = new System.Drawing.Size(55, 23);
            this.checkBoxTcp.TabIndex = 20;
            this.checkBoxTcp.Text = "TCP";
            this.checkBoxTcp.UseVisualStyleBackColor = true;
            this.checkBoxTcp.Validated += new System.EventHandler(this.checkBoxTcp_Validated);
            // 
            // checkBoxUdp
            // 
            this.checkBoxUdp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUdp.AutoSize = true;
            this.checkBoxUdp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUdp.Location = new System.Drawing.Point(567, 115);
            this.checkBoxUdp.Name = "checkBoxUdp";
            this.checkBoxUdp.Size = new System.Drawing.Size(55, 23);
            this.checkBoxUdp.TabIndex = 21;
            this.checkBoxUdp.Text = "UDP";
            this.checkBoxUdp.UseVisualStyleBackColor = true;
            this.checkBoxUdp.Validated += new System.EventHandler(this.checkBoxUdp_Validated);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPort.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.Location = new System.Drawing.Point(577, 31);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(45, 23);
            this.textBoxPort.TabIndex = 15;
            this.textBoxPort.Validated += new System.EventHandler(this.textBoxPort_Validated);
            // 
            // textBoxApp
            // 
            this.textBoxApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxApp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApp.Location = new System.Drawing.Point(174, 111);
            this.textBoxApp.Name = "textBoxApp";
            this.textBoxApp.Size = new System.Drawing.Size(89, 23);
            this.textBoxApp.TabIndex = 8;
            this.textBoxApp.Resize += new System.EventHandler(this.textBoxApp_Resize);
            // 
            // labelConfiguration
            // 
            this.labelConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConfiguration.AutoSize = true;
            this.labelConfiguration.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfiguration.Location = new System.Drawing.Point(496, 9);
            this.labelConfiguration.Name = "labelConfiguration";
            this.labelConfiguration.Size = new System.Drawing.Size(126, 19);
            this.labelConfiguration.TabIndex = 3;
            this.labelConfiguration.Text = "Configuration";
            // 
            // openFileDialogApp
            // 
            this.openFileDialogApp.Title = "Select app to proxy";
            this.openFileDialogApp.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogApp_FileOk);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Image = global::proxifyre_tray.Properties.Resources.icons8_stop_16;
            this.buttonStop.Location = new System.Drawing.Point(561, 228);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(61, 23);
            this.buttonStop.TabIndex = 26;
            this.buttonStop.Text = "Stop";
            this.buttonStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Image = global::proxifyre_tray.Properties.Resources.icons8_next_16;
            this.buttonStart.Location = new System.Drawing.Point(424, 228);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(131, 23);
            this.buttonStart.TabIndex = 25;
            this.buttonStart.Text = "Save and Start";
            this.buttonStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Image = global::proxifyre_tray.Properties.Resources.icons8_save_16;
            this.buttonSave.Location = new System.Drawing.Point(343, 228);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.BackgroundImage = global::proxifyre_tray.Properties.Resources.icons8_folder_16;
            this.buttonBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBrowse.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(263, 111);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(23, 23);
            this.buttonBrowse.TabIndex = 9;
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonAppsDel
            // 
            this.buttonAppsDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAppsDel.BackgroundImage = global::proxifyre_tray.Properties.Resources.icons8_cross_26;
            this.buttonAppsDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAppsDel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppsDel.Location = new System.Drawing.Point(318, 111);
            this.buttonAppsDel.Name = "buttonAppsDel";
            this.buttonAppsDel.Size = new System.Drawing.Size(23, 23);
            this.buttonAppsDel.TabIndex = 11;
            this.buttonAppsDel.UseVisualStyleBackColor = true;
            this.buttonAppsDel.Click += new System.EventHandler(this.buttonAppsDel_Click);
            // 
            // buttonAppsAdd
            // 
            this.buttonAppsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAppsAdd.BackgroundImage = global::proxifyre_tray.Properties.Resources.icons8_plus_26;
            this.buttonAppsAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAppsAdd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppsAdd.Location = new System.Drawing.Point(295, 111);
            this.buttonAppsAdd.Name = "buttonAppsAdd";
            this.buttonAppsAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonAppsAdd.TabIndex = 10;
            this.buttonAppsAdd.UseVisualStyleBackColor = true;
            this.buttonAppsAdd.Click += new System.EventHandler(this.buttonAppsAdd_Click);
            // 
            // buttonProxiesDel
            // 
            this.buttonProxiesDel.BackgroundImage = global::proxifyre_tray.Properties.Resources.icons8_cross_26;
            this.buttonProxiesDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProxiesDel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProxiesDel.Location = new System.Drawing.Point(146, 111);
            this.buttonProxiesDel.Name = "buttonProxiesDel";
            this.buttonProxiesDel.Size = new System.Drawing.Size(23, 23);
            this.buttonProxiesDel.TabIndex = 6;
            this.buttonProxiesDel.UseVisualStyleBackColor = true;
            this.buttonProxiesDel.Click += new System.EventHandler(this.buttonProxiesDel_Click);
            // 
            // buttonProxiesAdd
            // 
            this.buttonProxiesAdd.BackgroundImage = global::proxifyre_tray.Properties.Resources.icons8_plus_26;
            this.buttonProxiesAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProxiesAdd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProxiesAdd.Location = new System.Drawing.Point(123, 111);
            this.buttonProxiesAdd.Name = "buttonProxiesAdd";
            this.buttonProxiesAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonProxiesAdd.TabIndex = 5;
            this.buttonProxiesAdd.UseVisualStyleBackColor = true;
            this.buttonProxiesAdd.Click += new System.EventHandler(this.buttonProxiesAdd_Click);
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIconTray.Text = "ProxiFyre";
            this.notifyIconTray.Visible = true;
            this.notifyIconTray.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemStartup,
            this.toolStripMenuItemExit});
            this.contextMenuStripTray.Name = "contextMenuStripTray";
            this.contextMenuStripTray.ShowCheckMargin = true;
            this.contextMenuStripTray.ShowImageMargin = false;
            this.contextMenuStripTray.Size = new System.Drawing.Size(171, 70);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // toolStripMenuItemStartup
            // 
            this.toolStripMenuItemStartup.Name = "toolStripMenuItemStartup";
            this.toolStripMenuItemStartup.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemStartup.Text = "Launch on startup";
            this.toolStripMenuItemStartup.Click += new System.EventHandler(this.toolStripMenuItemStartup_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Image = global::proxifyre_tray.Properties.Resources.icons8_info_popup_16;
            this.buttonAbout.Location = new System.Drawing.Point(311, 228);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(23, 23);
            this.buttonAbout.TabIndex = 27;
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelConfiguration);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxApp);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.checkBoxUdp);
            this.Controls.Add(this.checkBoxTcp);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelApps);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.buttonAppsDel);
            this.Controls.Add(this.buttonAppsAdd);
            this.Controls.Add(this.buttonProxiesDel);
            this.Controls.Add(this.buttonProxiesAdd);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxIp);
            this.Controls.Add(this.listBoxApps);
            this.Controls.Add(this.comboBoxLogLevel);
            this.Controls.Add(this.labelProxies);
            this.Controls.Add(this.listBoxProxies);
            this.Controls.Add(this.richTextBoxOutput);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(560, 215);
            this.Name = "FormMain";
            this.Text = "ProxiFyre Tray";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.contextMenuStripTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.ListBox listBoxProxies;
        private System.Windows.Forms.Label labelProxies;
        private System.Windows.Forms.ComboBox comboBoxLogLevel;
        private System.Windows.Forms.ListBox listBoxApps;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonProxiesAdd;
        private System.Windows.Forms.Button buttonProxiesDel;
        private System.Windows.Forms.Button buttonAppsAdd;
        private System.Windows.Forms.Button buttonAppsDel;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.Label labelApps;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckBox checkBoxTcp;
        private System.Windows.Forms.CheckBox checkBoxUdp;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxApp;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelConfiguration;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialogApp;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStartup;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.ToolTip toolTipApp;
    }
}

