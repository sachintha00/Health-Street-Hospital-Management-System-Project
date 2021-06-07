namespace Health_Street
{
    partial class frmLabAddOut
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
            this.elips = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlTheme = new Guna.UI.WinForms.GunaPanel();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.lblSample = new Guna.UI.WinForms.GunaLabel();
            this.cmbSample = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.btnPSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.lblTime = new Guna.UI.WinForms.GunaLabel();
            this.lblDate = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.lblPatientId = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtRoomNo = new Guna.UI.WinForms.GunaTextBox();
            this.txtWardNo = new Guna.UI.WinForms.GunaTextBox();
            this.txtDctName = new Guna.UI.WinForms.GunaTextBox();
            this.txtPatientId = new Guna.UI.WinForms.GunaTextBox();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.Animate = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.pnlTheme.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elips
            // 
            this.elips.Radius = 0;
            this.elips.TargetControl = this;
            // 
            // pnlTheme
            // 
            this.pnlTheme.AutoScroll = true;
            this.pnlTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTheme.Controls.Add(this.btnClose);
            this.pnlTheme.Controls.Add(this.gunaLabel18);
            this.pnlTheme.Controls.Add(this.gunaGroupBox1);
            this.pnlTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheme.Location = new System.Drawing.Point(0, 0);
            this.pnlTheme.Name = "pnlTheme";
            this.pnlTheme.Size = new System.Drawing.Size(633, 727);
            this.pnlTheme.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(555, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.btnClose.Size = new System.Drawing.Size(79, 43);
            this.btnClose.TabIndex = 4;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.AutoSize = true;
            this.gunaLabel18.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.gunaLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.gunaLabel18.Location = new System.Drawing.Point(31, 46);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(581, 67);
            this.gunaLabel18.TabIndex = 1;
            this.gunaLabel18.Text = "Add Sample Outpatient";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.lblSample);
            this.gunaGroupBox1.Controls.Add(this.cmbSample);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel8);
            this.gunaGroupBox1.Controls.Add(this.btnPSave);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel13);
            this.gunaGroupBox1.Controls.Add(this.lblTime);
            this.gunaGroupBox1.Controls.Add(this.lblDate);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel14);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox1.Controls.Add(this.lblPatientId);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.txtRoomNo);
            this.gunaGroupBox1.Controls.Add(this.txtWardNo);
            this.gunaGroupBox1.Controls.Add(this.txtDctName);
            this.gunaGroupBox1.Controls.Add(this.txtPatientId);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaGroupBox1.LineTop = 40;
            this.gunaGroupBox1.Location = new System.Drawing.Point(43, 148);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(535, 539);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Add X-Ray";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblSample.Location = new System.Drawing.Point(277, 136);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(0, 20);
            this.lblSample.TabIndex = 9;
            // 
            // cmbSample
            // 
            this.cmbSample.BackColor = System.Drawing.Color.Transparent;
            this.cmbSample.BaseColor = System.Drawing.Color.White;
            this.cmbSample.BorderColor = System.Drawing.Color.Silver;
            this.cmbSample.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSample.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSample.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.cmbSample.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSample.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbSample.FormattingEnabled = true;
            this.cmbSample.Items.AddRange(new object[] {
            "BLOOD",
            "URINE",
            "MARROW",
            "SWAB"});
            this.cmbSample.Location = new System.Drawing.Point(277, 101);
            this.cmbSample.Name = "cmbSample";
            this.cmbSample.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.cmbSample.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbSample.Size = new System.Drawing.Size(172, 31);
            this.cmbSample.TabIndex = 8;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel8.Location = new System.Drawing.Point(273, 72);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(113, 23);
            this.gunaLabel8.TabIndex = 7;
            this.gunaLabel8.Text = "Sample Type";
            // 
            // btnPSave
            // 
            this.btnPSave.AnimationHoverSpeed = 0.07F;
            this.btnPSave.AnimationSpeed = 0.03F;
            this.btnPSave.BackColor = System.Drawing.Color.Transparent;
            this.btnPSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnPSave.BorderColor = System.Drawing.Color.Black;
            this.btnPSave.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPSave.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPSave.CheckedForeColor = System.Drawing.Color.White;
            this.btnPSave.CheckedImage = null;
            this.btnPSave.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnPSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPSave.ForeColor = System.Drawing.Color.White;
            this.btnPSave.Image = null;
            this.btnPSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPSave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPSave.Location = new System.Drawing.Point(165, 422);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnPSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPSave.OnHoverImage = null;
            this.btnPSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnPSave.Radius = 22;
            this.btnPSave.Size = new System.Drawing.Size(183, 71);
            this.btnPSave.TabIndex = 5;
            this.btnPSave.Text = "Save";
            this.btnPSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel13.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel13.Location = new System.Drawing.Point(68, 356);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(53, 23);
            this.gunaLabel13.TabIndex = 1;
            this.gunaLabel13.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(413, 356);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 23);
            this.lblTime.TabIndex = 1;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(127, 356);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 23);
            this.lblDate.TabIndex = 1;
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel14.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel14.Location = new System.Drawing.Point(358, 356);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(55, 23);
            this.gunaLabel14.TabIndex = 1;
            this.gunaLabel14.Text = "Time:";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.gunaLabel6.Location = new System.Drawing.Point(24, 519);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(0, 20);
            this.gunaLabel6.TabIndex = 6;
            // 
            // lblPatientId
            // 
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPatientId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblPatientId.Location = new System.Drawing.Point(68, 141);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(0, 20);
            this.lblPatientId.TabIndex = 6;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel5.Location = new System.Drawing.Point(64, 248);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(117, 23);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "Doctor Name";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel4.Location = new System.Drawing.Point(273, 161);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(90, 23);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Room No:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel3.Location = new System.Drawing.Point(63, 161);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(86, 23);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Ward No:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel1.Location = new System.Drawing.Point(64, 72);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(159, 23);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Patient Id Number";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.BaseColor = System.Drawing.Color.White;
            this.txtRoomNo.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo.Enabled = false;
            this.txtRoomNo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRoomNo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtRoomNo.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRoomNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRoomNo.Location = new System.Drawing.Point(277, 187);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.PasswordChar = '\0';
            this.txtRoomNo.ReadOnly = true;
            this.txtRoomNo.SelectedText = "";
            this.txtRoomNo.Size = new System.Drawing.Size(172, 39);
            this.txtRoomNo.TabIndex = 0;
            // 
            // txtWardNo
            // 
            this.txtWardNo.BaseColor = System.Drawing.Color.White;
            this.txtWardNo.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtWardNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWardNo.Enabled = false;
            this.txtWardNo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtWardNo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtWardNo.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtWardNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtWardNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtWardNo.Location = new System.Drawing.Point(67, 187);
            this.txtWardNo.Name = "txtWardNo";
            this.txtWardNo.PasswordChar = '\0';
            this.txtWardNo.ReadOnly = true;
            this.txtWardNo.SelectedText = "";
            this.txtWardNo.Size = new System.Drawing.Size(165, 39);
            this.txtWardNo.TabIndex = 0;
            // 
            // txtDctName
            // 
            this.txtDctName.BaseColor = System.Drawing.Color.White;
            this.txtDctName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtDctName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDctName.Enabled = false;
            this.txtDctName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDctName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtDctName.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDctName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDctName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDctName.Location = new System.Drawing.Point(68, 274);
            this.txtDctName.Name = "txtDctName";
            this.txtDctName.PasswordChar = '\0';
            this.txtDctName.ReadOnly = true;
            this.txtDctName.SelectedText = "";
            this.txtDctName.Size = new System.Drawing.Size(381, 39);
            this.txtDctName.TabIndex = 0;
            // 
            // txtPatientId
            // 
            this.txtPatientId.BaseColor = System.Drawing.Color.White;
            this.txtPatientId.BorderColor = System.Drawing.Color.Silver;
            this.txtPatientId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPatientId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtPatientId.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPatientId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPatientId.Location = new System.Drawing.Point(68, 98);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.PasswordChar = '\0';
            this.txtPatientId.SelectedText = "";
            this.txtPatientId.Size = new System.Drawing.Size(164, 39);
            this.txtPatientId.TabIndex = 0;
            this.txtPatientId.TextChanged += new System.EventHandler(this.txtApNumber_TextChanged);
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // Animate
            // 
            this.Animate.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.Animate.Interval = 800;
            this.Animate.TargetControl = this;
            // 
            // frmLabAddOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(633, 727);
            this.Controls.Add(this.pnlTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLabAddOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmADAddmitPatient";
            this.pnlTheme.ResumeLayout(false);
            this.pnlTheme.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elips;
        private Guna.UI.WinForms.GunaPanel pnlTheme;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtPatientId;
        private Guna.UI.WinForms.GunaLabel lblTime;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private System.Windows.Forms.Timer tmrDateTime;
        private Guna.UI.WinForms.GunaLabel lblDate;
        private Guna.UI.WinForms.GunaAdvenceButton btnPSave;
        private Guna.UI.WinForms.GunaLabel lblPatientId;
        private Guna.UI.WinForms.GunaAnimateWindow Animate;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtRoomNo;
        private Guna.UI.WinForms.GunaTextBox txtWardNo;
        private Guna.UI.WinForms.GunaTextBox txtDctName;
        private Guna.UI.WinForms.GunaLabel lblSample;
        private Guna.UI.WinForms.GunaComboBox cmbSample;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
    }
}