namespace Health_Street
{
    partial class frmPharmacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPharmacy));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlPhr = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlPhrChild = new Guna.UI.WinForms.GunaElipsePanel();
            this.pnlPhrLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnlCmm = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSettings = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnOfficer = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnlCmSubBtn = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSupp = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCus = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCmt = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnMed = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnlPhrLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMinimize = new Guna.UI.WinForms.GunaControlBox();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.btnMaximize = new Guna.UI.WinForms.GunaControlBox();
            this.dragPhr = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.phrAnimate = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.pnlPhr.SuspendLayout();
            this.pnlPhrLeft.SuspendLayout();
            this.pnlCmm.SuspendLayout();
            this.pnlCmSubBtn.SuspendLayout();
            this.pnlPhrLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlPhr
            // 
            this.pnlPhr.Controls.Add(this.pnlPhrChild);
            this.pnlPhr.Controls.Add(this.pnlPhrLeft);
            this.pnlPhr.Controls.Add(this.btnMinimize);
            this.pnlPhr.Controls.Add(this.btnClose);
            this.pnlPhr.Controls.Add(this.btnMaximize);
            this.pnlPhr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhr.Location = new System.Drawing.Point(0, 0);
            this.pnlPhr.Name = "pnlPhr";
            this.pnlPhr.ShadowDecoration.Parent = this.pnlPhr;
            this.pnlPhr.Size = new System.Drawing.Size(1942, 1102);
            this.pnlPhr.TabIndex = 0;
            // 
            // pnlPhrChild
            // 
            this.pnlPhrChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPhrChild.BackColor = System.Drawing.Color.Transparent;
            this.pnlPhrChild.BaseColor = System.Drawing.SystemColors.Control;
            this.pnlPhrChild.Location = new System.Drawing.Point(321, 48);
            this.pnlPhrChild.Name = "pnlPhrChild";
            this.pnlPhrChild.Size = new System.Drawing.Size(1609, 1042);
            this.pnlPhrChild.TabIndex = 6;
            // 
            // pnlPhrLeft
            // 
            this.pnlPhrLeft.Controls.Add(this.btnLogout);
            this.pnlPhrLeft.Controls.Add(this.pnlCmm);
            this.pnlPhrLeft.Controls.Add(this.pnlPhrLogo);
            this.pnlPhrLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPhrLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlPhrLeft.Name = "pnlPhrLeft";
            this.pnlPhrLeft.ShadowDecoration.Parent = this.pnlPhrLeft;
            this.pnlPhrLeft.Size = new System.Drawing.Size(322, 1102);
            this.pnlPhrLeft.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnLogout.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.CheckedImage")));
            this.btnLogout.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(23, 23);
            this.btnLogout.LineColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(71, 1021);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnLogout.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.OnHoverImage")));
            this.btnLogout.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnLogout.Size = new System.Drawing.Size(180, 48);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlCmm
            // 
            this.pnlCmm.Controls.Add(this.btnSettings);
            this.pnlCmm.Controls.Add(this.btnOfficer);
            this.pnlCmm.Controls.Add(this.pnlCmSubBtn);
            this.pnlCmm.Controls.Add(this.btnCmt);
            this.pnlCmm.Controls.Add(this.btnMed);
            this.pnlCmm.Controls.Add(this.btnDashboard);
            this.pnlCmm.Location = new System.Drawing.Point(46, 284);
            this.pnlCmm.Name = "pnlCmm";
            this.pnlCmm.ShadowDecoration.Parent = this.pnlCmm;
            this.pnlCmm.Size = new System.Drawing.Size(258, 433);
            this.pnlCmm.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.AnimationHoverSpeed = 0.07F;
            this.btnSettings.AnimationSpeed = 0.03F;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BaseColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnSettings.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSettings.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSettings.CheckedForeColor = System.Drawing.Color.White;
            this.btnSettings.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.CheckedImage")));
            this.btnSettings.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FocusedColor = System.Drawing.Color.Empty;
            this.btnSettings.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSettings.LineColor = System.Drawing.Color.Transparent;
            this.btnSettings.Location = new System.Drawing.Point(0, 369);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnSettings.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnSettings.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSettings.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.OnHoverImage")));
            this.btnSettings.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnSettings.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(81)))));
            this.btnSettings.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnSettings.Radius = 23;
            this.btnSettings.Size = new System.Drawing.Size(258, 61);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnOfficer
            // 
            this.btnOfficer.AnimationHoverSpeed = 0.07F;
            this.btnOfficer.AnimationSpeed = 0.03F;
            this.btnOfficer.BackColor = System.Drawing.Color.Transparent;
            this.btnOfficer.BaseColor = System.Drawing.Color.Transparent;
            this.btnOfficer.BorderColor = System.Drawing.Color.Transparent;
            this.btnOfficer.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnOfficer.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnOfficer.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnOfficer.CheckedForeColor = System.Drawing.Color.White;
            this.btnOfficer.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnOfficer.CheckedImage")));
            this.btnOfficer.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnOfficer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOfficer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOfficer.FocusedColor = System.Drawing.Color.Empty;
            this.btnOfficer.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnOfficer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnOfficer.Image = ((System.Drawing.Image)(resources.GetObject("btnOfficer.Image")));
            this.btnOfficer.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOfficer.LineColor = System.Drawing.Color.Transparent;
            this.btnOfficer.Location = new System.Drawing.Point(0, 308);
            this.btnOfficer.Name = "btnOfficer";
            this.btnOfficer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnOfficer.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnOfficer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOfficer.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnOfficer.OnHoverImage")));
            this.btnOfficer.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnOfficer.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(81)))));
            this.btnOfficer.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnOfficer.Radius = 23;
            this.btnOfficer.Size = new System.Drawing.Size(258, 61);
            this.btnOfficer.TabIndex = 6;
            this.btnOfficer.Text = "Officer";
            this.btnOfficer.Click += new System.EventHandler(this.btnPchas_Click);
            // 
            // pnlCmSubBtn
            // 
            this.pnlCmSubBtn.BackColor = System.Drawing.Color.White;
            this.pnlCmSubBtn.Controls.Add(this.btnSupp);
            this.pnlCmSubBtn.Controls.Add(this.btnCus);
            this.pnlCmSubBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCmSubBtn.Location = new System.Drawing.Point(0, 183);
            this.pnlCmSubBtn.Name = "pnlCmSubBtn";
            this.pnlCmSubBtn.ShadowDecoration.Parent = this.pnlCmSubBtn;
            this.pnlCmSubBtn.Size = new System.Drawing.Size(258, 125);
            this.pnlCmSubBtn.TabIndex = 9;
            this.pnlCmSubBtn.Visible = false;
            // 
            // btnSupp
            // 
            this.btnSupp.AnimationHoverSpeed = 0.07F;
            this.btnSupp.AnimationSpeed = 0.03F;
            this.btnSupp.BackColor = System.Drawing.Color.Transparent;
            this.btnSupp.BaseColor = System.Drawing.Color.Transparent;
            this.btnSupp.BorderColor = System.Drawing.Color.Transparent;
            this.btnSupp.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnSupp.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSupp.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSupp.CheckedForeColor = System.Drawing.Color.White;
            this.btnSupp.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSupp.CheckedImage")));
            this.btnSupp.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSupp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSupp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupp.FocusedColor = System.Drawing.Color.Empty;
            this.btnSupp.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnSupp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSupp.Image = ((System.Drawing.Image)(resources.GetObject("btnSupp.Image")));
            this.btnSupp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupp.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSupp.LineColor = System.Drawing.Color.Transparent;
            this.btnSupp.Location = new System.Drawing.Point(0, 61);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnSupp.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnSupp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSupp.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSupp.OnHoverImage")));
            this.btnSupp.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnSupp.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(81)))));
            this.btnSupp.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnSupp.Radius = 23;
            this.btnSupp.Size = new System.Drawing.Size(258, 61);
            this.btnSupp.TabIndex = 4;
            this.btnSupp.Text = "Suppliers";
            this.btnSupp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnCus
            // 
            this.btnCus.AnimationHoverSpeed = 0.07F;
            this.btnCus.AnimationSpeed = 0.03F;
            this.btnCus.BackColor = System.Drawing.Color.Transparent;
            this.btnCus.BaseColor = System.Drawing.Color.Transparent;
            this.btnCus.BorderColor = System.Drawing.Color.Transparent;
            this.btnCus.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnCus.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnCus.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnCus.CheckedForeColor = System.Drawing.Color.White;
            this.btnCus.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCus.CheckedImage")));
            this.btnCus.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnCus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCus.FocusedColor = System.Drawing.Color.Empty;
            this.btnCus.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnCus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnCus.Image = ((System.Drawing.Image)(resources.GetObject("btnCus.Image")));
            this.btnCus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCus.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCus.LineColor = System.Drawing.Color.Transparent;
            this.btnCus.Location = new System.Drawing.Point(0, 0);
            this.btnCus.Name = "btnCus";
            this.btnCus.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnCus.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnCus.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCus.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnCus.OnHoverImage")));
            this.btnCus.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnCus.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(81)))));
            this.btnCus.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnCus.Radius = 23;
            this.btnCus.Size = new System.Drawing.Size(258, 61);
            this.btnCus.TabIndex = 5;
            this.btnCus.Text = "Customers";
            this.btnCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // btnCmt
            // 
            this.btnCmt.AnimationHoverSpeed = 0.07F;
            this.btnCmt.AnimationSpeed = 0.03F;
            this.btnCmt.BackColor = System.Drawing.Color.Transparent;
            this.btnCmt.BaseColor = System.Drawing.Color.Transparent;
            this.btnCmt.BorderColor = System.Drawing.Color.Transparent;
            this.btnCmt.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnCmt.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnCmt.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnCmt.CheckedForeColor = System.Drawing.Color.White;
            this.btnCmt.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCmt.CheckedImage")));
            this.btnCmt.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnCmt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCmt.FocusedColor = System.Drawing.Color.Empty;
            this.btnCmt.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnCmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnCmt.Image = ((System.Drawing.Image)(resources.GetObject("btnCmt.Image")));
            this.btnCmt.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCmt.LineColor = System.Drawing.Color.Transparent;
            this.btnCmt.Location = new System.Drawing.Point(0, 122);
            this.btnCmt.Name = "btnCmt";
            this.btnCmt.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnCmt.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnCmt.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCmt.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnCmt.OnHoverImage")));
            this.btnCmt.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnCmt.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(81)))));
            this.btnCmt.Radius = 22;
            this.btnCmt.Size = new System.Drawing.Size(258, 61);
            this.btnCmt.TabIndex = 4;
            this.btnCmt.Text = "Community";
            this.btnCmt.Click += new System.EventHandler(this.btnCmt_Click);
            // 
            // btnMed
            // 
            this.btnMed.AnimationHoverSpeed = 0.07F;
            this.btnMed.AnimationSpeed = 0.03F;
            this.btnMed.BackColor = System.Drawing.Color.Transparent;
            this.btnMed.BaseColor = System.Drawing.Color.Transparent;
            this.btnMed.BorderColor = System.Drawing.Color.Transparent;
            this.btnMed.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnMed.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnMed.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnMed.CheckedForeColor = System.Drawing.Color.White;
            this.btnMed.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMed.CheckedImage")));
            this.btnMed.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnMed.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMed.FocusedColor = System.Drawing.Color.Empty;
            this.btnMed.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnMed.Image = ((System.Drawing.Image)(resources.GetObject("btnMed.Image")));
            this.btnMed.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMed.LineColor = System.Drawing.Color.Transparent;
            this.btnMed.Location = new System.Drawing.Point(0, 61);
            this.btnMed.Name = "btnMed";
            this.btnMed.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnMed.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnMed.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMed.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnMed.OnHoverImage")));
            this.btnMed.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnMed.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(81)))));
            this.btnMed.Radius = 22;
            this.btnMed.Size = new System.Drawing.Size(258, 61);
            this.btnMed.TabIndex = 3;
            this.btnMed.Text = "Medicines";
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BaseColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnDashboard.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnDashboard.CheckedForeColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.CheckedImage")));
            this.btnDashboard.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashboard.LineColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.OnHoverImage")));
            this.btnDashboard.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(81)))));
            this.btnDashboard.Radius = 22;
            this.btnDashboard.Size = new System.Drawing.Size(258, 61);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlPhrLogo
            // 
            this.pnlPhrLogo.Controls.Add(this.guna2PictureBox1);
            this.pnlPhrLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPhrLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlPhrLogo.Name = "pnlPhrLogo";
            this.pnlPhrLogo.ShadowDecoration.Parent = this.pnlPhrLogo;
            this.pnlPhrLogo.Size = new System.Drawing.Size(322, 256);
            this.pnlPhrLogo.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(29, 28);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(266, 250);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconSize = 15F;
            this.btnMinimize.Location = new System.Drawing.Point(1757, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.btnMinimize.OnHoverIconColor = System.Drawing.Color.Black;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnMinimize.Size = new System.Drawing.Size(54, 43);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(1864, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.btnClose.Size = new System.Drawing.Size(79, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.AnimationHoverSpeed = 0.07F;
            this.btnMaximize.AnimationSpeed = 0.03F;
            this.btnMaximize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconSize = 15F;
            this.btnMaximize.Location = new System.Drawing.Point(1808, -1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.btnMaximize.OnHoverIconColor = System.Drawing.Color.Black;
            this.btnMaximize.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnMaximize.Size = new System.Drawing.Size(59, 43);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // dragPhr
            // 
            this.dragPhr.Fixed = true;
            this.dragPhr.Horizontal = true;
            this.dragPhr.TargetControl = this.pnlPhr;
            this.dragPhr.Vertical = true;
            // 
            // phrAnimate
            // 
            this.phrAnimate.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            this.phrAnimate.Interval = 700;
            this.phrAnimate.TargetControl = this;
            // 
            // frmPharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.pnlPhr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPharmacy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPharmacy";
            this.Load += new System.EventHandler(this.frmPharmacy_Load);
            this.pnlPhr.ResumeLayout(false);
            this.pnlPhrLeft.ResumeLayout(false);
            this.pnlCmm.ResumeLayout(false);
            this.pnlCmSubBtn.ResumeLayout(false);
            this.pnlPhrLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlPhr;
        private Guna.UI.WinForms.GunaControlBox btnMinimize;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaControlBox btnMaximize;
        private Guna.UI2.WinForms.Guna2Panel pnlPhrLeft;
        private Guna.UI2.WinForms.Guna2Panel pnlPhrLogo;
        private Guna.UI.WinForms.GunaElipsePanel pnlPhrChild;
        private Guna.UI.WinForms.GunaAdvenceButton btnMed;
        private Guna.UI.WinForms.GunaAdvenceButton btnDashboard;
        private Guna.UI.WinForms.GunaAdvenceButton btnCmt;
        private Guna.UI2.WinForms.Guna2Panel pnlCmm;
        private Guna.UI.WinForms.GunaAdvenceButton btnSettings;
        private Guna.UI2.WinForms.Guna2Panel pnlCmSubBtn;
        private Guna.UI.WinForms.GunaAdvenceButton btnOfficer;
        private Guna.UI.WinForms.GunaAdvenceButton btnCus;
        private Guna.UI.WinForms.GunaAdvenceButton btnSupp;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogout;
        private Bunifu.Framework.UI.BunifuDragControl dragPhr;
        private Guna.UI.WinForms.GunaAnimateWindow phrAnimate;
    }
}