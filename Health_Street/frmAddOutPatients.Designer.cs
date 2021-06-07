namespace Health_Street
{
    partial class frmAddOutPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOutPatients));
            this.elips = new Guna.UI.WinForms.GunaElipse(this.components);
            this.drag = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pbTheme = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.frmChngAnimate = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.lblReason = new Guna.UI.WinForms.GunaLabel();
            this.lblAge = new Guna.UI.WinForms.GunaLabel();
            this.lblTPNumber = new Guna.UI.WinForms.GunaLabel();
            this.lblGuardianNic = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtReason = new Guna.UI.WinForms.GunaTextBox();
            this.txtAge = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtGuardianTP = new Guna.UI.WinForms.GunaTextBox();
            this.txtGuardianNic = new Guna.UI.WinForms.GunaTextBox();
            this.txtPatientName = new Guna.UI.WinForms.GunaTextBox();
            this.btnSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCancel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elips
            // 
            this.elips.Radius = 20;
            this.elips.TargetControl = this;
            // 
            // drag
            // 
            this.drag.TargetControl = this.pbTheme;
            // 
            // pbTheme
            // 
            this.pbTheme.BackColor = System.Drawing.Color.Transparent;
            this.pbTheme.BaseColor = System.Drawing.Color.Black;
            this.pbTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTheme.Image = ((System.Drawing.Image)(resources.GetObject("pbTheme.Image")));
            this.pbTheme.Location = new System.Drawing.Point(0, 0);
            this.pbTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbTheme.Name = "pbTheme";
            this.pbTheme.Size = new System.Drawing.Size(645, 936);
            this.pbTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTheme.TabIndex = 5;
            this.pbTheme.TabStop = false;
            // 
            // frmChngAnimate
            // 
            this.frmChngAnimate.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.frmChngAnimate.Interval = 600;
            this.frmChngAnimate.TargetControl = this;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel7.Location = new System.Drawing.Point(37, 243);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(249, 114);
            this.gunaLabel7.TabIndex = 11;
            this.gunaLabel7.Text = "  Add New \r\n       Patient";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblReason.Location = new System.Drawing.Point(43, 760);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(0, 20);
            this.lblReason.TabIndex = 10;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblAge.Location = new System.Drawing.Point(359, 573);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(0, 20);
            this.lblAge.TabIndex = 10;
            // 
            // lblTPNumber
            // 
            this.lblTPNumber.AutoSize = true;
            this.lblTPNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTPNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblTPNumber.Location = new System.Drawing.Point(43, 573);
            this.lblTPNumber.Name = "lblTPNumber";
            this.lblTPNumber.Size = new System.Drawing.Size(0, 20);
            this.lblTPNumber.TabIndex = 10;
            // 
            // lblGuardianNic
            // 
            this.lblGuardianNic.AutoSize = true;
            this.lblGuardianNic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGuardianNic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblGuardianNic.Location = new System.Drawing.Point(359, 464);
            this.lblGuardianNic.Name = "lblGuardianNic";
            this.lblGuardianNic.Size = new System.Drawing.Size(0, 20);
            this.lblGuardianNic.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblName.Location = new System.Drawing.Point(43, 464);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 10;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel5.Location = new System.Drawing.Point(42, 597);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(76, 25);
            this.gunaLabel5.TabIndex = 8;
            this.gunaLabel5.Text = "Reason";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel4.Location = new System.Drawing.Point(340, 494);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(47, 25);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Age";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel3.Location = new System.Drawing.Point(24, 494);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(160, 25);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "Guardian TP No.";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel2.Location = new System.Drawing.Point(339, 385);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(133, 25);
            this.gunaLabel2.TabIndex = 8;
            this.gunaLabel2.Text = "Guardian NIC";
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.Transparent;
            this.txtReason.BaseColor = System.Drawing.Color.White;
            this.txtReason.BorderColor = System.Drawing.Color.Silver;
            this.txtReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReason.FocusedBaseColor = System.Drawing.Color.White;
            this.txtReason.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.txtReason.FocusedForeColor = System.Drawing.SystemColors.GrayText;
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReason.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtReason.Location = new System.Drawing.Point(29, 624);
            this.txtReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.PasswordChar = '\0';
            this.txtReason.Radius = 16;
            this.txtReason.SelectedText = "";
            this.txtReason.Size = new System.Drawing.Size(443, 121);
            this.txtReason.TabIndex = 7;
            this.txtReason.UseSystemPasswordChar = true;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Transparent;
            this.txtAge.BaseColor = System.Drawing.Color.White;
            this.txtAge.BorderColor = System.Drawing.Color.Silver;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAge.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.txtAge.FocusedForeColor = System.Drawing.SystemColors.GrayText;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAge.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtAge.Location = new System.Drawing.Point(344, 527);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.Radius = 16;
            this.txtAge.SelectedText = "";
            this.txtAge.Size = new System.Drawing.Size(281, 44);
            this.txtAge.TabIndex = 7;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel1.Location = new System.Drawing.Point(24, 385);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(132, 25);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Patient Name";
            // 
            // txtGuardianTP
            // 
            this.txtGuardianTP.BackColor = System.Drawing.Color.Transparent;
            this.txtGuardianTP.BaseColor = System.Drawing.Color.White;
            this.txtGuardianTP.BorderColor = System.Drawing.Color.Silver;
            this.txtGuardianTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuardianTP.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGuardianTP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.txtGuardianTP.FocusedForeColor = System.Drawing.SystemColors.GrayText;
            this.txtGuardianTP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGuardianTP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtGuardianTP.Location = new System.Drawing.Point(28, 527);
            this.txtGuardianTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGuardianTP.Name = "txtGuardianTP";
            this.txtGuardianTP.PasswordChar = '\0';
            this.txtGuardianTP.Radius = 16;
            this.txtGuardianTP.SelectedText = "";
            this.txtGuardianTP.Size = new System.Drawing.Size(284, 44);
            this.txtGuardianTP.TabIndex = 7;
            this.txtGuardianTP.TextChanged += new System.EventHandler(this.txtGuardianTP_TextChanged);
            // 
            // txtGuardianNic
            // 
            this.txtGuardianNic.BackColor = System.Drawing.Color.Transparent;
            this.txtGuardianNic.BaseColor = System.Drawing.Color.White;
            this.txtGuardianNic.BorderColor = System.Drawing.Color.Silver;
            this.txtGuardianNic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuardianNic.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGuardianNic.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.txtGuardianNic.FocusedForeColor = System.Drawing.SystemColors.GrayText;
            this.txtGuardianNic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGuardianNic.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtGuardianNic.Location = new System.Drawing.Point(341, 418);
            this.txtGuardianNic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGuardianNic.Name = "txtGuardianNic";
            this.txtGuardianNic.PasswordChar = '\0';
            this.txtGuardianNic.Radius = 16;
            this.txtGuardianNic.SelectedText = "";
            this.txtGuardianNic.Size = new System.Drawing.Size(284, 44);
            this.txtGuardianNic.TabIndex = 7;
            this.txtGuardianNic.TextChanged += new System.EventHandler(this.txtGuardianNic_TextChanged);
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.Transparent;
            this.txtPatientName.BaseColor = System.Drawing.Color.White;
            this.txtPatientName.BorderColor = System.Drawing.Color.Silver;
            this.txtPatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPatientName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.txtPatientName.FocusedForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPatientName.Location = new System.Drawing.Point(28, 418);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.PasswordChar = '\0';
            this.txtPatientName.Radius = 16;
            this.txtPatientName.SelectedText = "";
            this.txtPatientName.Size = new System.Drawing.Size(284, 44);
            this.txtPatientName.TabIndex = 7;
            this.txtPatientName.TextChanged += new System.EventHandler(this.txtPatientName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnSave.BorderSize = 2;
            this.btnSave.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSave.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSave.CheckedForeColor = System.Drawing.Color.White;
            this.btnSave.CheckedImage = null;
            this.btnSave.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.LineColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(47, 793);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 25;
            this.btnSave.Size = new System.Drawing.Size(199, 78);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnCancel.BorderSize = 2;
            this.btnCancel.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCancel.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnCancel.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancel.CheckedImage = null;
            this.btnCancel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.LineColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(363, 793);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Radius = 25;
            this.btnCancel.Size = new System.Drawing.Size(199, 78);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(425, 204);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(173, 169);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 12;
            this.gunaPictureBox1.TabStop = false;
            // 
            // frmAddOutPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 936);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblTPNumber);
            this.Controls.Add(this.lblGuardianNic);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtGuardianTP);
            this.Controls.Add(this.txtGuardianNic);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddOutPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elips;
        private Guna.UI.WinForms.GunaDragControl drag;
        private Guna.UI.WinForms.GunaAnimateWindow frmChngAnimate;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancel;
        private Guna.UI.WinForms.GunaTransfarantPictureBox pbTheme;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtReason;
        private Guna.UI.WinForms.GunaTextBox txtAge;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtGuardianTP;
        private Guna.UI.WinForms.GunaTextBox txtGuardianNic;
        private Guna.UI.WinForms.GunaTextBox txtPatientName;
        private Guna.UI.WinForms.GunaLabel lblReason;
        private Guna.UI.WinForms.GunaLabel lblAge;
        private Guna.UI.WinForms.GunaLabel lblTPNumber;
        private Guna.UI.WinForms.GunaLabel lblGuardianNic;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaAdvenceButton btnSave;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}