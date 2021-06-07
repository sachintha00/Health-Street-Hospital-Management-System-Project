namespace Health_Street
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.elips = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.pnlDctSettingsChild = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.pbIcon = new Guna.UI.WinForms.GunaPictureBox();
            this.lblSubSetings = new Guna.UI.WinForms.GunaLabel();
            this.lblSetings = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.btnAccount = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnContactUs = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnStngLogin = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // elips
            // 
            this.elips.ElipseRadius = 5;
            this.elips.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.AutoScroll = true;
            this.gunaPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel1.BackgroundImage")));
            this.gunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel1.Controls.Add(this.pnlDctSettingsChild);
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1265, 764);
            this.gunaPanel1.TabIndex = 6;
            // 
            // pnlDctSettingsChild
            // 
            this.pnlDctSettingsChild.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlDctSettingsChild.BackColor = System.Drawing.Color.Transparent;
            this.pnlDctSettingsChild.BaseColor = System.Drawing.Color.Transparent;
            this.pnlDctSettingsChild.Location = new System.Drawing.Point(62, 199);
            this.pnlDctSettingsChild.Name = "pnlDctSettingsChild";
            this.pnlDctSettingsChild.ShadowColor = System.Drawing.Color.Black;
            this.pnlDctSettingsChild.ShadowShift = 0;
            this.pnlDctSettingsChild.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal;
            this.pnlDctSettingsChild.Size = new System.Drawing.Size(1191, 421);
            this.pnlDctSettingsChild.TabIndex = 1;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.pbIcon);
            this.gunaPanel2.Controls.Add(this.lblSubSetings);
            this.gunaPanel2.Controls.Add(this.lblSetings);
            this.gunaPanel2.Controls.Add(this.gunaPanel3);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1265, 198);
            this.gunaPanel2.TabIndex = 0;
            // 
            // pbIcon
            // 
            this.pbIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.BaseColor = System.Drawing.Color.Transparent;
            this.pbIcon.Location = new System.Drawing.Point(93, 32);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(99, 85);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 3;
            this.pbIcon.TabStop = false;
            // 
            // lblSubSetings
            // 
            this.lblSubSetings.AutoSize = true;
            this.lblSubSetings.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.lblSubSetings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(80)))), ((int)(((byte)(119)))));
            this.lblSubSetings.Location = new System.Drawing.Point(388, 39);
            this.lblSubSetings.Name = "lblSubSetings";
            this.lblSubSetings.Size = new System.Drawing.Size(157, 78);
            this.lblSubSetings.TabIndex = 2;
            this.lblSubSetings.Text = "User";
            // 
            // lblSetings
            // 
            this.lblSetings.AutoSize = true;
            this.lblSetings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSetings.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.lblSetings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.lblSetings.Location = new System.Drawing.Point(198, 39);
            this.lblSetings.Name = "lblSetings";
            this.lblSetings.Size = new System.Drawing.Size(260, 78);
            this.lblSetings.TabIndex = 1;
            this.lblSetings.Text = "Settings";
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.btnAccount);
            this.gunaPanel3.Controls.Add(this.btnContactUs);
            this.gunaPanel3.Controls.Add(this.btnStngLogin);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 81);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(1265, 117);
            this.gunaPanel3.TabIndex = 0;
            // 
            // btnAccount
            // 
            this.btnAccount.AnimationHoverSpeed = 0.07F;
            this.btnAccount.AnimationSpeed = 0.03F;
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.BaseColor = System.Drawing.Color.Transparent;
            this.btnAccount.BorderColor = System.Drawing.Color.Black;
            this.btnAccount.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnAccount.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnAccount.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAccount.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnAccount.CheckedImage = null;
            this.btnAccount.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccount.FocusedColor = System.Drawing.Color.Empty;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnAccount.Image = null;
            this.btnAccount.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAccount.LineBottom = 4;
            this.btnAccount.LineColor = System.Drawing.Color.Transparent;
            this.btnAccount.Location = new System.Drawing.Point(198, 63);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnAccount.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAccount.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.btnAccount.OnHoverImage = null;
            this.btnAccount.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnAccount.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnAccount.Radius = 2;
            this.btnAccount.Size = new System.Drawing.Size(130, 54);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnContactUs
            // 
            this.btnContactUs.AnimationHoverSpeed = 0.07F;
            this.btnContactUs.AnimationSpeed = 0.03F;
            this.btnContactUs.BackColor = System.Drawing.Color.Transparent;
            this.btnContactUs.BaseColor = System.Drawing.Color.Transparent;
            this.btnContactUs.BorderColor = System.Drawing.Color.Black;
            this.btnContactUs.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnContactUs.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnContactUs.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnContactUs.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnContactUs.CheckedImage = null;
            this.btnContactUs.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnContactUs.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnContactUs.FocusedColor = System.Drawing.Color.Empty;
            this.btnContactUs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnContactUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnContactUs.Image = null;
            this.btnContactUs.ImageSize = new System.Drawing.Size(20, 20);
            this.btnContactUs.LineBottom = 4;
            this.btnContactUs.LineColor = System.Drawing.Color.Transparent;
            this.btnContactUs.Location = new System.Drawing.Point(334, 63);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnContactUs.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnContactUs.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.btnContactUs.OnHoverImage = null;
            this.btnContactUs.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnContactUs.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnContactUs.Radius = 2;
            this.btnContactUs.Size = new System.Drawing.Size(130, 54);
            this.btnContactUs.TabIndex = 0;
            this.btnContactUs.Text = "Contact Us";
            this.btnContactUs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnContactUs.Click += new System.EventHandler(this.btnContactUs_Click);
            // 
            // btnStngLogin
            // 
            this.btnStngLogin.AnimationHoverSpeed = 0.07F;
            this.btnStngLogin.AnimationSpeed = 0.03F;
            this.btnStngLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnStngLogin.BaseColor = System.Drawing.Color.Transparent;
            this.btnStngLogin.BorderColor = System.Drawing.Color.Black;
            this.btnStngLogin.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnStngLogin.Checked = true;
            this.btnStngLogin.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnStngLogin.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnStngLogin.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnStngLogin.CheckedImage = null;
            this.btnStngLogin.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnStngLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStngLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnStngLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStngLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnStngLogin.Image = null;
            this.btnStngLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStngLogin.LineBottom = 4;
            this.btnStngLogin.LineColor = System.Drawing.Color.Transparent;
            this.btnStngLogin.Location = new System.Drawing.Point(62, 63);
            this.btnStngLogin.Name = "btnStngLogin";
            this.btnStngLogin.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnStngLogin.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnStngLogin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.btnStngLogin.OnHoverImage = null;
            this.btnStngLogin.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnStngLogin.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnStngLogin.Radius = 2;
            this.btnStngLogin.Size = new System.Drawing.Size(130, 54);
            this.btnStngLogin.TabIndex = 0;
            this.btnStngLogin.Text = "User";
            this.btnStngLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStngLogin.Click += new System.EventHandler(this.btnStngLogin_Click);
            // 
            // frmDctSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1265, 764);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDctSettings";
            this.Text = "frmPhrDash";
            this.Load += new System.EventHandler(this.frmDctSettings_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.gunaPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elips;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaAdvenceButton btnStngLogin;
        private Guna.UI.WinForms.GunaAdvenceButton btnAccount;
        private Guna.UI.WinForms.GunaAdvenceButton btnContactUs;
        private Guna.UI.WinForms.GunaShadowPanel pnlDctSettingsChild;
        private Guna.UI.WinForms.GunaLabel lblSetings;
        private Guna.UI.WinForms.GunaLabel lblSubSetings;
        private Guna.UI.WinForms.GunaPictureBox pbIcon;
    }
}