namespace Health_Street
{
    partial class frmChanlAdd
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
            this.btnPSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblTPnumber = new Guna.UI.WinForms.GunaLabel();
            this.lblSpecialist = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.lblTime = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.lblDate = new Guna.UI.WinForms.GunaLabel();
            this.lblHsptlFee = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.lblPatientName = new Guna.UI.WinForms.GunaLabel();
            this.lblDctFee = new Guna.UI.WinForms.GunaLabel();
            this.txtTpNumber = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.lblApNumber = new Guna.UI.WinForms.GunaLabel();
            this.cmbSpecialist = new Guna.UI.WinForms.GunaComboBox();
            this.dtpSessionDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtHsptlFee = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtPatientName = new Guna.UI.WinForms.GunaTextBox();
            this.txtDctFee = new Guna.UI.WinForms.GunaTextBox();
            this.txtApNumber = new Guna.UI.WinForms.GunaTextBox();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.Animate = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.lblSessionDate = new Guna.UI.WinForms.GunaLabel();
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
            this.pnlTheme.Size = new System.Drawing.Size(892, 1061);
            this.pnlTheme.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(814, 0);
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
            this.gunaLabel18.Size = new System.Drawing.Size(388, 67);
            this.gunaLabel18.TabIndex = 1;
            this.gunaLabel18.Text = "Add Customers";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.btnPSave);
            this.gunaGroupBox1.Controls.Add(this.lblTPnumber);
            this.gunaGroupBox1.Controls.Add(this.lblSessionDate);
            this.gunaGroupBox1.Controls.Add(this.lblSpecialist);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel13);
            this.gunaGroupBox1.Controls.Add(this.lblTime);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.lblDate);
            this.gunaGroupBox1.Controls.Add(this.lblHsptlFee);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel14);
            this.gunaGroupBox1.Controls.Add(this.lblPatientName);
            this.gunaGroupBox1.Controls.Add(this.lblDctFee);
            this.gunaGroupBox1.Controls.Add(this.txtTpNumber);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel9);
            this.gunaGroupBox1.Controls.Add(this.lblApNumber);
            this.gunaGroupBox1.Controls.Add(this.cmbSpecialist);
            this.gunaGroupBox1.Controls.Add(this.dtpSessionDate);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel8);
            this.gunaGroupBox1.Controls.Add(this.txtHsptlFee);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel12);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.txtPatientName);
            this.gunaGroupBox1.Controls.Add(this.txtDctFee);
            this.gunaGroupBox1.Controls.Add(this.txtApNumber);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaGroupBox1.LineTop = 40;
            this.gunaGroupBox1.Location = new System.Drawing.Point(43, 335);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(800, 539);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Add Customers";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
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
            this.btnPSave.Location = new System.Drawing.Point(609, 443);
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
            // lblTPnumber
            // 
            this.lblTPnumber.AutoSize = true;
            this.lblTPnumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTPnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblTPnumber.Location = new System.Drawing.Point(22, 412);
            this.lblTPnumber.Name = "lblTPnumber";
            this.lblTPnumber.Size = new System.Drawing.Size(0, 20);
            this.lblTPnumber.TabIndex = 6;
            // 
            // lblSpecialist
            // 
            this.lblSpecialist.AutoSize = true;
            this.lblSpecialist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSpecialist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblSpecialist.Location = new System.Drawing.Point(368, 239);
            this.lblSpecialist.Name = "lblSpecialist";
            this.lblSpecialist.Size = new System.Drawing.Size(0, 20);
            this.lblSpecialist.TabIndex = 6;
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel13.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel13.Location = new System.Drawing.Point(15, 491);
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
            this.lblTime.Location = new System.Drawing.Point(412, 491);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 23);
            this.lblTime.TabIndex = 1;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel5.Location = new System.Drawing.Point(15, 344);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(143, 23);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "Contact Number";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(74, 491);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 23);
            this.lblDate.TabIndex = 1;
            // 
            // lblHsptlFee
            // 
            this.lblHsptlFee.AutoSize = true;
            this.lblHsptlFee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHsptlFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblHsptlFee.Location = new System.Drawing.Point(371, 324);
            this.lblHsptlFee.Name = "lblHsptlFee";
            this.lblHsptlFee.Size = new System.Drawing.Size(0, 20);
            this.lblHsptlFee.TabIndex = 6;
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel14.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel14.Location = new System.Drawing.Point(351, 491);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(55, 23);
            this.gunaLabel14.TabIndex = 1;
            this.gunaLabel14.Text = "Time:";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblPatientName.Location = new System.Drawing.Point(437, 139);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(0, 20);
            this.lblPatientName.TabIndex = 6;
            // 
            // lblDctFee
            // 
            this.lblDctFee.AutoSize = true;
            this.lblDctFee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDctFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblDctFee.Location = new System.Drawing.Point(22, 323);
            this.lblDctFee.Name = "lblDctFee";
            this.lblDctFee.Size = new System.Drawing.Size(0, 20);
            this.lblDctFee.TabIndex = 6;
            // 
            // txtTpNumber
            // 
            this.txtTpNumber.BaseColor = System.Drawing.Color.White;
            this.txtTpNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtTpNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTpNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTpNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtTpNumber.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTpNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTpNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTpNumber.Location = new System.Drawing.Point(19, 370);
            this.txtTpNumber.Name = "txtTpNumber";
            this.txtTpNumber.PasswordChar = '\0';
            this.txtTpNumber.SelectedText = "";
            this.txtTpNumber.Size = new System.Drawing.Size(374, 39);
            this.txtTpNumber.TabIndex = 0;
            this.txtTpNumber.TextChanged += new System.EventHandler(this.txtTpNumber_TextChanged);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel9.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel9.Location = new System.Drawing.Point(364, 254);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(109, 23);
            this.gunaLabel9.TabIndex = 1;
            this.gunaLabel9.Text = "Hospital Fee";
            // 
            // lblApNumber
            // 
            this.lblApNumber.AutoSize = true;
            this.lblApNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblApNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblApNumber.Location = new System.Drawing.Point(19, 140);
            this.lblApNumber.Name = "lblApNumber";
            this.lblApNumber.Size = new System.Drawing.Size(0, 20);
            this.lblApNumber.TabIndex = 6;
            // 
            // cmbSpecialist
            // 
            this.cmbSpecialist.BackColor = System.Drawing.Color.Transparent;
            this.cmbSpecialist.BaseColor = System.Drawing.Color.White;
            this.cmbSpecialist.BorderColor = System.Drawing.Color.Silver;
            this.cmbSpecialist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSpecialist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecialist.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.cmbSpecialist.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbSpecialist.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbSpecialist.FormattingEnabled = true;
            this.cmbSpecialist.Location = new System.Drawing.Point(368, 193);
            this.cmbSpecialist.Name = "cmbSpecialist";
            this.cmbSpecialist.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.cmbSpecialist.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbSpecialist.Size = new System.Drawing.Size(396, 35);
            this.cmbSpecialist.TabIndex = 3;
            this.cmbSpecialist.SelectedIndexChanged += new System.EventHandler(this.cmbSpecialist_SelectedIndexChanged);
            // 
            // dtpSessionDate
            // 
            this.dtpSessionDate.BaseColor = System.Drawing.Color.White;
            this.dtpSessionDate.BorderColor = System.Drawing.Color.Silver;
            this.dtpSessionDate.CustomFormat = null;
            this.dtpSessionDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpSessionDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.dtpSessionDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpSessionDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpSessionDate.Location = new System.Drawing.Point(19, 184);
            this.dtpSessionDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSessionDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSessionDate.Name = "dtpSessionDate";
            this.dtpSessionDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpSessionDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.dtpSessionDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.dtpSessionDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpSessionDate.Size = new System.Drawing.Size(277, 44);
            this.dtpSessionDate.TabIndex = 2;
            this.dtpSessionDate.Text = "Monday, October 5, 2020";
            this.dtpSessionDate.Value = new System.DateTime(2020, 10, 5, 10, 13, 37, 597);
            this.dtpSessionDate.ValueChanged += new System.EventHandler(this.dtpDOF_ValueChanged);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel8.Location = new System.Drawing.Point(364, 157);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(138, 23);
            this.gunaLabel8.TabIndex = 1;
            this.gunaLabel8.Text = "Specialist Name";
            // 
            // txtHsptlFee
            // 
            this.txtHsptlFee.BaseColor = System.Drawing.Color.White;
            this.txtHsptlFee.BorderColor = System.Drawing.Color.Silver;
            this.txtHsptlFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHsptlFee.FocusedBaseColor = System.Drawing.Color.White;
            this.txtHsptlFee.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtHsptlFee.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtHsptlFee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHsptlFee.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtHsptlFee.Location = new System.Drawing.Point(368, 281);
            this.txtHsptlFee.Name = "txtHsptlFee";
            this.txtHsptlFee.PasswordChar = '\0';
            this.txtHsptlFee.SelectedText = "";
            this.txtHsptlFee.Size = new System.Drawing.Size(280, 39);
            this.txtHsptlFee.TabIndex = 0;
            this.txtHsptlFee.TextChanged += new System.EventHandler(this.txtHsptlFee_TextChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel4.Location = new System.Drawing.Point(15, 157);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(111, 23);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Session Date";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel12.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel12.Location = new System.Drawing.Point(15, 255);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(97, 23);
            this.gunaLabel12.TabIndex = 1;
            this.gunaLabel12.Text = "Doctor Fee";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel3.Location = new System.Drawing.Point(428, 71);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(119, 23);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Patient Name";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel1.Location = new System.Drawing.Point(15, 71);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(189, 23);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Appointment Number";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BaseColor = System.Drawing.Color.White;
            this.txtPatientName.BorderColor = System.Drawing.Color.Silver;
            this.txtPatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPatientName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtPatientName.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPatientName.Location = new System.Drawing.Point(432, 97);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.PasswordChar = '\0';
            this.txtPatientName.SelectedText = "";
            this.txtPatientName.Size = new System.Drawing.Size(332, 39);
            this.txtPatientName.TabIndex = 0;
            this.txtPatientName.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtDctFee
            // 
            this.txtDctFee.BaseColor = System.Drawing.Color.White;
            this.txtDctFee.BorderColor = System.Drawing.Color.Silver;
            this.txtDctFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDctFee.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDctFee.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtDctFee.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDctFee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDctFee.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDctFee.Location = new System.Drawing.Point(19, 281);
            this.txtDctFee.Name = "txtDctFee";
            this.txtDctFee.PasswordChar = '\0';
            this.txtDctFee.SelectedText = "";
            this.txtDctFee.Size = new System.Drawing.Size(277, 39);
            this.txtDctFee.TabIndex = 0;
            this.txtDctFee.TextChanged += new System.EventHandler(this.txtDctFee_TextChanged);
            // 
            // txtApNumber
            // 
            this.txtApNumber.BaseColor = System.Drawing.Color.White;
            this.txtApNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtApNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtApNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtApNumber.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtApNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtApNumber.Location = new System.Drawing.Point(19, 97);
            this.txtApNumber.Name = "txtApNumber";
            this.txtApNumber.PasswordChar = '\0';
            this.txtApNumber.SelectedText = "";
            this.txtApNumber.Size = new System.Drawing.Size(374, 39);
            this.txtApNumber.TabIndex = 0;
            this.txtApNumber.TextChanged += new System.EventHandler(this.txtApNumber_TextChanged);
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
            // lblSessionDate
            // 
            this.lblSessionDate.AutoSize = true;
            this.lblSessionDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSessionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblSessionDate.Location = new System.Drawing.Point(22, 235);
            this.lblSessionDate.Name = "lblSessionDate";
            this.lblSessionDate.Size = new System.Drawing.Size(0, 20);
            this.lblSessionDate.TabIndex = 6;
            // 
            // frmChanlAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(892, 1061);
            this.Controls.Add(this.pnlTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChanlAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmADAddmitPatient";
            this.Load += new System.EventHandler(this.frmADAddmitPatient_Load);
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
        private Guna.UI.WinForms.GunaDateTimePicker dtpSessionDate;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtPatientName;
        private Guna.UI.WinForms.GunaTextBox txtApNumber;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaTextBox txtDctFee;
        private Guna.UI.WinForms.GunaLabel lblTime;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private System.Windows.Forms.Timer tmrDateTime;
        private Guna.UI.WinForms.GunaLabel lblDate;
        private Guna.UI.WinForms.GunaAdvenceButton btnPSave;
        private Guna.UI.WinForms.GunaTextBox txtTpNumber;
        private Guna.UI.WinForms.GunaTextBox txtHsptlFee;
        private Guna.UI.WinForms.GunaComboBox cmbSpecialist;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel lblTPnumber;
        private Guna.UI.WinForms.GunaLabel lblHsptlFee;
        private Guna.UI.WinForms.GunaLabel lblDctFee;
        private Guna.UI.WinForms.GunaLabel lblSpecialist;
        private Guna.UI.WinForms.GunaLabel lblPatientName;
        private Guna.UI.WinForms.GunaLabel lblApNumber;
        private Guna.UI.WinForms.GunaAnimateWindow Animate;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaLabel lblSessionDate;
    }
}