namespace Health_Street
{
    partial class frmPharSupplierAdd
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
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtManufaCountry = new Guna.UI.WinForms.GunaTextBox();
            this.txtManufaCompany = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtManufaRegNumber = new Guna.UI.WinForms.GunaTextBox();
            this.btnPSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.lblTime = new Guna.UI.WinForms.GunaLabel();
            this.lblDate = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.lblManuRegNumber = new Guna.UI.WinForms.GunaLabel();
            this.lblManuCountry = new Guna.UI.WinForms.GunaLabel();
            this.lblManuCompany = new Guna.UI.WinForms.GunaLabel();
            this.lblSuppName = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtSuppName = new Guna.UI.WinForms.GunaTextBox();
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
            this.pnlTheme.Size = new System.Drawing.Size(871, 607);
            this.pnlTheme.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(793, 0);
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
            this.gunaLabel18.Location = new System.Drawing.Point(30, 27);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(603, 67);
            this.gunaLabel18.TabIndex = 1;
            this.gunaLabel18.Text = "Add Pharmacy Suppliers";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel7);
            this.gunaGroupBox1.Controls.Add(this.txtManufaCountry);
            this.gunaGroupBox1.Controls.Add(this.txtManufaCompany);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.txtManufaRegNumber);
            this.gunaGroupBox1.Controls.Add(this.btnPSave);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel13);
            this.gunaGroupBox1.Controls.Add(this.lblTime);
            this.gunaGroupBox1.Controls.Add(this.lblDate);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel14);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox1.Controls.Add(this.lblManuRegNumber);
            this.gunaGroupBox1.Controls.Add(this.lblManuCountry);
            this.gunaGroupBox1.Controls.Add(this.lblManuCompany);
            this.gunaGroupBox1.Controls.Add(this.lblSuppName);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.txtSuppName);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaGroupBox1.LineTop = 40;
            this.gunaGroupBox1.Location = new System.Drawing.Point(52, 127);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(764, 468);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Add Suppliers";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel4.Location = new System.Drawing.Point(15, 180);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(182, 23);
            this.gunaLabel4.TabIndex = 16;
            this.gunaLabel4.Text = "Manufacture Country";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel7.Location = new System.Drawing.Point(427, 71);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(193, 23);
            this.gunaLabel7.TabIndex = 17;
            this.gunaLabel7.Text = "Manufacture Company";
            // 
            // txtManufaCountry
            // 
            this.txtManufaCountry.BaseColor = System.Drawing.Color.White;
            this.txtManufaCountry.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtManufaCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManufaCountry.FocusedBaseColor = System.Drawing.Color.White;
            this.txtManufaCountry.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtManufaCountry.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtManufaCountry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtManufaCountry.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtManufaCountry.Location = new System.Drawing.Point(19, 206);
            this.txtManufaCountry.Name = "txtManufaCountry";
            this.txtManufaCountry.PasswordChar = '\0';
            this.txtManufaCountry.SelectedText = "";
            this.txtManufaCountry.Size = new System.Drawing.Size(342, 39);
            this.txtManufaCountry.TabIndex = 12;
            // 
            // txtManufaCompany
            // 
            this.txtManufaCompany.BaseColor = System.Drawing.Color.White;
            this.txtManufaCompany.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtManufaCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManufaCompany.FocusedBaseColor = System.Drawing.Color.White;
            this.txtManufaCompany.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtManufaCompany.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtManufaCompany.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtManufaCompany.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtManufaCompany.Location = new System.Drawing.Point(431, 97);
            this.txtManufaCompany.Name = "txtManufaCompany";
            this.txtManufaCompany.PasswordChar = '\0';
            this.txtManufaCompany.SelectedText = "";
            this.txtManufaCompany.Size = new System.Drawing.Size(302, 39);
            this.txtManufaCompany.TabIndex = 13;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel5.Location = new System.Drawing.Point(427, 180);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(219, 23);
            this.gunaLabel5.TabIndex = 11;
            this.gunaLabel5.Text = "Manufacture Reg Number";
            // 
            // txtManufaRegNumber
            // 
            this.txtManufaRegNumber.BaseColor = System.Drawing.Color.White;
            this.txtManufaRegNumber.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtManufaRegNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManufaRegNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtManufaRegNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtManufaRegNumber.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtManufaRegNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtManufaRegNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtManufaRegNumber.Location = new System.Drawing.Point(431, 206);
            this.txtManufaRegNumber.Name = "txtManufaRegNumber";
            this.txtManufaRegNumber.PasswordChar = '\0';
            this.txtManufaRegNumber.SelectedText = "";
            this.txtManufaRegNumber.Size = new System.Drawing.Size(302, 39);
            this.txtManufaRegNumber.TabIndex = 10;
            this.txtManufaRegNumber.TextChanged += new System.EventHandler(this.txtDrugPrice_TextChanged);
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
            this.btnPSave.Location = new System.Drawing.Point(550, 347);
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
            this.gunaLabel13.Location = new System.Drawing.Point(29, 377);
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
            this.lblTime.Location = new System.Drawing.Point(426, 377);
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
            this.lblDate.Location = new System.Drawing.Point(88, 377);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 23);
            this.lblDate.TabIndex = 1;
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel14.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel14.Location = new System.Drawing.Point(365, 377);
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
            // lblManuRegNumber
            // 
            this.lblManuRegNumber.AutoSize = true;
            this.lblManuRegNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblManuRegNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblManuRegNumber.Location = new System.Drawing.Point(437, 248);
            this.lblManuRegNumber.Name = "lblManuRegNumber";
            this.lblManuRegNumber.Size = new System.Drawing.Size(0, 20);
            this.lblManuRegNumber.TabIndex = 6;
            // 
            // lblManuCountry
            // 
            this.lblManuCountry.AutoSize = true;
            this.lblManuCountry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblManuCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblManuCountry.Location = new System.Drawing.Point(19, 248);
            this.lblManuCountry.Name = "lblManuCountry";
            this.lblManuCountry.Size = new System.Drawing.Size(0, 20);
            this.lblManuCountry.TabIndex = 6;
            // 
            // lblManuCompany
            // 
            this.lblManuCompany.AutoSize = true;
            this.lblManuCompany.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblManuCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblManuCompany.Location = new System.Drawing.Point(437, 140);
            this.lblManuCompany.Name = "lblManuCompany";
            this.lblManuCompany.Size = new System.Drawing.Size(0, 20);
            this.lblManuCompany.TabIndex = 6;
            // 
            // lblSuppName
            // 
            this.lblSuppName.AutoSize = true;
            this.lblSuppName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSuppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblSuppName.Location = new System.Drawing.Point(19, 140);
            this.lblSuppName.Name = "lblSuppName";
            this.lblSuppName.Size = new System.Drawing.Size(0, 20);
            this.lblSuppName.TabIndex = 6;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel1.Location = new System.Drawing.Point(15, 71);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(130, 23);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Supplier Name";
            // 
            // txtSuppName
            // 
            this.txtSuppName.BaseColor = System.Drawing.Color.White;
            this.txtSuppName.BorderColor = System.Drawing.Color.Silver;
            this.txtSuppName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuppName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSuppName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtSuppName.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSuppName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSuppName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSuppName.Location = new System.Drawing.Point(19, 97);
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.PasswordChar = '\0';
            this.txtSuppName.SelectedText = "";
            this.txtSuppName.Size = new System.Drawing.Size(342, 39);
            this.txtSuppName.TabIndex = 0;
            this.txtSuppName.TextChanged += new System.EventHandler(this.txtApNumber_TextChanged);
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
            // frmPharSupplierAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(871, 607);
            this.Controls.Add(this.pnlTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPharSupplierAdd";
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
        private Guna.UI.WinForms.GunaTextBox txtSuppName;
        private Guna.UI.WinForms.GunaLabel lblTime;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private System.Windows.Forms.Timer tmrDateTime;
        private Guna.UI.WinForms.GunaLabel lblDate;
        private Guna.UI.WinForms.GunaAdvenceButton btnPSave;
        private Guna.UI.WinForms.GunaLabel lblSuppName;
        private Guna.UI.WinForms.GunaAnimateWindow Animate;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtManufaRegNumber;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtManufaCountry;
        private Guna.UI.WinForms.GunaTextBox txtManufaCompany;
        private Guna.UI.WinForms.GunaLabel lblManuCompany;
        private Guna.UI.WinForms.GunaLabel lblManuRegNumber;
        private Guna.UI.WinForms.GunaLabel lblManuCountry;
    }
}