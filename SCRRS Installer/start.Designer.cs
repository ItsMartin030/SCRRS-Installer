namespace SCRRS_Installer
{
    partial class start
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.folderpath = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button0 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.installbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.uninstallbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.updateui = new System.Windows.Forms.Timer(this.components);
            this.standardfolderbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.versiontxt = new System.Windows.Forms.Label();
            this.downloadprogressbar = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.button2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button3 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button4 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button5 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SCRRS_Installer.Properties.Resources.SCRRS;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(159, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 76);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 14;
            this.bunifuElipse1.TargetControl = this;
            // 
            // folderpath
            // 
            this.folderpath.AcceptsReturn = false;
            this.folderpath.AcceptsTab = false;
            this.folderpath.AnimationSpeed = 200;
            this.folderpath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.folderpath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.folderpath.AutoSizeHeight = true;
            this.folderpath.BackColor = System.Drawing.Color.Transparent;
            this.folderpath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("folderpath.BackgroundImage")));
            this.folderpath.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(230)))));
            this.folderpath.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.folderpath.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(230)))));
            this.folderpath.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.folderpath.BorderRadius = 5;
            this.folderpath.BorderThickness = 1;
            this.folderpath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.folderpath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.folderpath.DefaultFont = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderpath.DefaultText = "";
            this.folderpath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.folderpath.ForeColor = System.Drawing.Color.White;
            this.folderpath.HideSelection = true;
            this.folderpath.IconLeft = null;
            this.folderpath.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.folderpath.IconPadding = 10;
            this.folderpath.IconRight = null;
            this.folderpath.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.folderpath.Lines = new string[0];
            this.folderpath.Location = new System.Drawing.Point(26, 222);
            this.folderpath.MaxLength = 32767;
            this.folderpath.MinimumSize = new System.Drawing.Size(1, 1);
            this.folderpath.Modified = false;
            this.folderpath.Multiline = false;
            this.folderpath.Name = "folderpath";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(230)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.folderpath.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.folderpath.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(230)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.folderpath.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.folderpath.OnIdleState = stateProperties4;
            this.folderpath.Padding = new System.Windows.Forms.Padding(3);
            this.folderpath.PasswordChar = '\0';
            this.folderpath.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.folderpath.PlaceholderText = "Dateipfad...";
            this.folderpath.ReadOnly = true;
            this.folderpath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.folderpath.SelectedText = "";
            this.folderpath.SelectionLength = 0;
            this.folderpath.SelectionStart = 0;
            this.folderpath.ShortcutsEnabled = true;
            this.folderpath.Size = new System.Drawing.Size(501, 22);
            this.folderpath.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.folderpath.TabIndex = 10;
            this.folderpath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.folderpath.TextMarginBottom = 0;
            this.folderpath.TextMarginLeft = 3;
            this.folderpath.TextMarginTop = 1;
            this.folderpath.TextPlaceholder = "Dateipfad...";
            this.folderpath.UseSystemPasswordChar = false;
            this.folderpath.WordWrap = true;
            this.folderpath.Click += new System.EventHandler(this.folderpath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "SaltyChat Realistic Radio Sounds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(185, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Automatische Installation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bitte wähle Deinen TS3Client Ordner aus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Version auswählen:";
            // 
            // button0
            // 
            this.button0.ActiveBorderThickness = 1;
            this.button0.ActiveCornerRadius = 5;
            this.button0.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button0.ActiveForecolor = System.Drawing.Color.White;
            this.button0.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button0.BackgroundImage")));
            this.button0.ButtonText = "0";
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.button0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(107)))), ((int)(((byte)(224)))));
            this.button0.IdleBorderThickness = 1;
            this.button0.IdleCornerRadius = 5;
            this.button0.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button0.IdleForecolor = System.Drawing.Color.White;
            this.button0.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button0.Location = new System.Drawing.Point(26, 323);
            this.button0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(501, 36);
            this.button0.TabIndex = 54;
            this.button0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // installbtn
            // 
            this.installbtn.ActiveBorderThickness = 1;
            this.installbtn.ActiveCornerRadius = 5;
            this.installbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.installbtn.ActiveForecolor = System.Drawing.Color.White;
            this.installbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.installbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.installbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("installbtn.BackgroundImage")));
            this.installbtn.ButtonText = "Installieren";
            this.installbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.installbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.installbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(107)))), ((int)(((byte)(224)))));
            this.installbtn.IdleBorderThickness = 1;
            this.installbtn.IdleCornerRadius = 5;
            this.installbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.installbtn.IdleForecolor = System.Drawing.Color.White;
            this.installbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.installbtn.Location = new System.Drawing.Point(312, 537);
            this.installbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.installbtn.Name = "installbtn";
            this.installbtn.Size = new System.Drawing.Size(215, 36);
            this.installbtn.TabIndex = 55;
            this.installbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.installbtn.Visible = false;
            this.installbtn.Click += new System.EventHandler(this.installbtn_Click);
            // 
            // uninstallbtn
            // 
            this.uninstallbtn.ActiveBorderThickness = 1;
            this.uninstallbtn.ActiveCornerRadius = 5;
            this.uninstallbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.uninstallbtn.ActiveForecolor = System.Drawing.Color.White;
            this.uninstallbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.uninstallbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.uninstallbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uninstallbtn.BackgroundImage")));
            this.uninstallbtn.ButtonText = "Deinstallieren";
            this.uninstallbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uninstallbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.uninstallbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(107)))), ((int)(((byte)(224)))));
            this.uninstallbtn.IdleBorderThickness = 1;
            this.uninstallbtn.IdleCornerRadius = 5;
            this.uninstallbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.uninstallbtn.IdleForecolor = System.Drawing.Color.White;
            this.uninstallbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.uninstallbtn.Location = new System.Drawing.Point(26, 537);
            this.uninstallbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uninstallbtn.Name = "uninstallbtn";
            this.uninstallbtn.Size = new System.Drawing.Size(215, 36);
            this.uninstallbtn.TabIndex = 56;
            this.uninstallbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uninstallbtn.Visible = false;
            this.uninstallbtn.Click += new System.EventHandler(this.uninstallbtn_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 5;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "X";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(107)))), ((int)(((byte)(224)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 5;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(524, -7);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(32, 36);
            this.bunifuThinButton21.TabIndex = 57;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // button1
            // 
            this.button1.ActiveBorderThickness = 1;
            this.button1.ActiveCornerRadius = 5;
            this.button1.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button1.ActiveForecolor = System.Drawing.Color.White;
            this.button1.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ButtonText = "1";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(107)))), ((int)(((byte)(224)))));
            this.button1.IdleBorderThickness = 1;
            this.button1.IdleCornerRadius = 5;
            this.button1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button1.IdleForecolor = System.Drawing.Color.White;
            this.button1.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button1.Location = new System.Drawing.Point(26, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(501, 36);
            this.button1.TabIndex = 58;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateui
            // 
            this.updateui.Enabled = true;
            this.updateui.Interval = 500;
            this.updateui.Tick += new System.EventHandler(this.updateui_Tick);
            // 
            // standardfolderbtn
            // 
            this.standardfolderbtn.ActiveBorderThickness = 1;
            this.standardfolderbtn.ActiveCornerRadius = 5;
            this.standardfolderbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.standardfolderbtn.ActiveForecolor = System.Drawing.Color.White;
            this.standardfolderbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.standardfolderbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.standardfolderbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("standardfolderbtn.BackgroundImage")));
            this.standardfolderbtn.ButtonText = "Standardpfad auswählen";
            this.standardfolderbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.standardfolderbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.standardfolderbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(107)))), ((int)(((byte)(224)))));
            this.standardfolderbtn.IdleBorderThickness = 1;
            this.standardfolderbtn.IdleCornerRadius = 5;
            this.standardfolderbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.standardfolderbtn.IdleForecolor = System.Drawing.Color.White;
            this.standardfolderbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.standardfolderbtn.Location = new System.Drawing.Point(312, 245);
            this.standardfolderbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.standardfolderbtn.Name = "standardfolderbtn";
            this.standardfolderbtn.Size = new System.Drawing.Size(215, 36);
            this.standardfolderbtn.TabIndex = 60;
            this.standardfolderbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.standardfolderbtn.Click += new System.EventHandler(this.standardfolderbtn_Click);
            // 
            // versiontxt
            // 
            this.versiontxt.Font = new System.Drawing.Font("Microsoft PhagsPa", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versiontxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.versiontxt.Location = new System.Drawing.Point(496, 572);
            this.versiontxt.Name = "versiontxt";
            this.versiontxt.Size = new System.Drawing.Size(51, 20);
            this.versiontxt.TabIndex = 61;
            this.versiontxt.Text = "Version";
            this.versiontxt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // downloadprogressbar
            // 
            this.downloadprogressbar.AllowAnimations = false;
            this.downloadprogressbar.Animation = 0;
            this.downloadprogressbar.AnimationSpeed = 220;
            this.downloadprogressbar.AnimationStep = 10;
            this.downloadprogressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.downloadprogressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downloadprogressbar.BackgroundImage")));
            this.downloadprogressbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.downloadprogressbar.BorderRadius = 9;
            this.downloadprogressbar.BorderThickness = 1;
            this.downloadprogressbar.Location = new System.Drawing.Point(27, 548);
            this.downloadprogressbar.Maximum = 100;
            this.downloadprogressbar.MaximumValue = 100;
            this.downloadprogressbar.Minimum = 0;
            this.downloadprogressbar.MinimumValue = 0;
            this.downloadprogressbar.Name = "downloadprogressbar";
            this.downloadprogressbar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.downloadprogressbar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.downloadprogressbar.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.downloadprogressbar.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.downloadprogressbar.Size = new System.Drawing.Size(500, 14);
            this.downloadprogressbar.TabIndex = 62;
            this.downloadprogressbar.Value = 0;
            this.downloadprogressbar.ValueByTransition = 0;
            this.downloadprogressbar.Visible = false;
            // 
            // button2
            // 
            this.button2.ActiveBorderThickness = 1;
            this.button2.ActiveCornerRadius = 5;
            this.button2.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button2.ActiveForecolor = System.Drawing.Color.White;
            this.button2.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.ButtonText = "2";
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(107)))), ((int)(((byte)(224)))));
            this.button2.IdleBorderThickness = 1;
            this.button2.IdleCornerRadius = 5;
            this.button2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button2.IdleForecolor = System.Drawing.Color.White;
            this.button2.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button2.Location = new System.Drawing.Point(26, 385);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(501, 36);
            this.button2.TabIndex = 63;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ActiveBorderThickness = 1;
            this.button3.ActiveCornerRadius = 5;
            this.button3.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button3.ActiveForecolor = System.Drawing.Color.White;
            this.button3.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.ButtonText = "3";
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(107)))), ((int)(((byte)(224)))));
            this.button3.IdleBorderThickness = 1;
            this.button3.IdleCornerRadius = 5;
            this.button3.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button3.IdleForecolor = System.Drawing.Color.White;
            this.button3.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button3.Location = new System.Drawing.Point(26, 416);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(501, 36);
            this.button3.TabIndex = 64;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ActiveBorderThickness = 1;
            this.button4.ActiveCornerRadius = 5;
            this.button4.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button4.ActiveForecolor = System.Drawing.Color.White;
            this.button4.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.ButtonText = "4";
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(107)))), ((int)(((byte)(224)))));
            this.button4.IdleBorderThickness = 1;
            this.button4.IdleCornerRadius = 5;
            this.button4.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button4.IdleForecolor = System.Drawing.Color.White;
            this.button4.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button4.Location = new System.Drawing.Point(26, 447);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(501, 36);
            this.button4.TabIndex = 65;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ActiveBorderThickness = 1;
            this.button5.ActiveCornerRadius = 5;
            this.button5.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button5.ActiveForecolor = System.Drawing.Color.White;
            this.button5.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.ButtonText = "5";
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(107)))), ((int)(((byte)(224)))));
            this.button5.IdleBorderThickness = 1;
            this.button5.IdleCornerRadius = 5;
            this.button5.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.button5.IdleForecolor = System.Drawing.Color.White;
            this.button5.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.button5.Location = new System.Drawing.Point(26, 478);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(501, 36);
            this.button5.TabIndex = 66;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(552, 585);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.downloadprogressbar);
            this.Controls.Add(this.versiontxt);
            this.Controls.Add(this.standardfolderbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.uninstallbtn);
            this.Controls.Add(this.installbtn);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderpath);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCRRS Installer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.start_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTextBox folderpath;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 uninstallbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 installbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 button0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 button1;
        private System.Windows.Forms.Timer updateui;
        private Bunifu.Framework.UI.BunifuThinButton2 standardfolderbtn;
        private System.Windows.Forms.Label versiontxt;
        private Bunifu.UI.WinForms.BunifuProgressBar downloadprogressbar;
        private Bunifu.Framework.UI.BunifuThinButton2 button5;
        private Bunifu.Framework.UI.BunifuThinButton2 button4;
        private Bunifu.Framework.UI.BunifuThinButton2 button3;
        private Bunifu.Framework.UI.BunifuThinButton2 button2;
    }
}

