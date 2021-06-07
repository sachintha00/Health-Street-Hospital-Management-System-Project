namespace Health_Street
{
    partial class frmXrayAdd
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
            this.pctbXray = new Guna.UI.WinForms.GunaPictureBox();
            this.btnAddPic = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.lblTime = new Guna.UI.WinForms.GunaLabel();
            this.lblDate = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.lblApNumber = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtRoomNo = new Guna.UI.WinForms.GunaTextBox();
            this.txtWardNo = new Guna.UI.WinForms.GunaTextBox();
            this.txtDctName = new Guna.UI.WinForms.GunaTextBox();
            this.txtXrayPath = new Guna.UI.WinForms.GunaTextBox();
            this.txtADNumber = new Guna.UI.WinForms.GunaTextBox();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.Animate = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.lblXrayPath = new Guna.UI.WinForms.GunaLabel();
            this.pnlTheme.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbXray)).BeginInit();
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
            this.pnlTheme.Size = new System.Drawing.Size(892, 727);
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
            this.gunaLabel18.Size = new System.Drawing.Size(507, 67);
            this.gunaLabel18.TabIndex = 1;
            this.gunaLabel18.Text = "Add X-Ray Inpatient";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.pctbXray);
            this.gunaGroupBox1.Controls.Add(this.btnAddPic);
            this.gunaGroupBox1.Controls.Add(this.btnPSave);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel13);
            this.gunaGroupBox1.Controls.Add(this.lblTime);
            this.gunaGroupBox1.Controls.Add(this.lblDate);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel14);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox1.Controls.Add(this.lblXrayPath);
            this.gunaGroupBox1.Controls.Add(this.lblApNumber);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.txtRoomNo);
            this.gunaGroupBox1.Controls.Add(this.txtWardNo);
            this.gunaGroupBox1.Controls.Add(this.txtDctName);
            this.gunaGroupBox1.Controls.Add(this.txtXrayPath);
            this.gunaGroupBox1.Controls.Add(this.txtADNumber);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaGroupBox1.LineTop = 40;
            this.gunaGroupBox1.Location = new System.Drawing.Point(43, 148);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(800, 539);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Add X-Ray";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // pctbXray
            // 
            this.pctbXray.BaseColor = System.Drawing.Color.White;
            this.pctbXray.Location = new System.Drawing.Point(414, 97);
            this.pctbXray.Name = "pctbXray";
            this.pctbXray.Size = new System.Drawing.Size(367, 278);
            this.pctbXray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbXray.TabIndex = 7;
            this.pctbXray.TabStop = false;
            // 
            // btnAddPic
            // 
            this.btnAddPic.AnimationHoverSpeed = 0.07F;
            this.btnAddPic.AnimationSpeed = 0.03F;
            this.btnAddPic.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPic.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnAddPic.BorderColor = System.Drawing.Color.Black;
            this.btnAddPic.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddPic.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddPic.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddPic.CheckedImage = null;
            this.btnAddPic.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddPic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPic.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddPic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPic.ForeColor = System.Drawing.Color.White;
            this.btnAddPic.Image = null;
            this.btnAddPic.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddPic.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddPic.Location = new System.Drawing.Point(356, 187);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnAddPic.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddPic.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddPic.OnHoverImage = null;
            this.btnAddPic.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddPic.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddPic.Size = new System.Drawing.Size(49, 39);
            this.btnAddPic.TabIndex = 5;
            this.btnAddPic.Text = "...";
            this.btnAddPic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
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
            this.btnPSave.Location = new System.Drawing.Point(550, 419);
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
            this.gunaLabel13.Location = new System.Drawing.Point(14, 467);
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
            this.lblTime.Location = new System.Drawing.Point(411, 467);
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
            this.lblDate.Location = new System.Drawing.Point(73, 467);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 23);
            this.lblDate.TabIndex = 1;
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel14.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel14.Location = new System.Drawing.Point(350, 467);
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
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel5.Location = new System.Drawing.Point(15, 341);
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
            this.gunaLabel4.Location = new System.Drawing.Point(224, 254);
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
            this.gunaLabel3.Location = new System.Drawing.Point(14, 254);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(86, 23);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Ward No:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel2.Location = new System.Drawing.Point(14, 161);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(98, 23);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "X-Ray Path";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel1.Location = new System.Drawing.Point(15, 71);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(168, 23);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Addmition Number";
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
            this.txtRoomNo.Location = new System.Drawing.Point(228, 280);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.PasswordChar = '\0';
            this.txtRoomNo.ReadOnly = true;
            this.txtRoomNo.SelectedText = "";
            this.txtRoomNo.Size = new System.Drawing.Size(165, 39);
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
            this.txtWardNo.Location = new System.Drawing.Point(18, 280);
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
            this.txtDctName.Location = new System.Drawing.Point(19, 367);
            this.txtDctName.Name = "txtDctName";
            this.txtDctName.PasswordChar = '\0';
            this.txtDctName.ReadOnly = true;
            this.txtDctName.SelectedText = "";
            this.txtDctName.Size = new System.Drawing.Size(374, 39);
            this.txtDctName.TabIndex = 0;
            // 
            // txtXrayPath
            // 
            this.txtXrayPath.BaseColor = System.Drawing.Color.White;
            this.txtXrayPath.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtXrayPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXrayPath.Enabled = false;
            this.txtXrayPath.FocusedBaseColor = System.Drawing.Color.White;
            this.txtXrayPath.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtXrayPath.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtXrayPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtXrayPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtXrayPath.Location = new System.Drawing.Point(18, 187);
            this.txtXrayPath.Name = "txtXrayPath";
            this.txtXrayPath.PasswordChar = '\0';
            this.txtXrayPath.ReadOnly = true;
            this.txtXrayPath.SelectedText = "";
            this.txtXrayPath.Size = new System.Drawing.Size(332, 39);
            this.txtXrayPath.TabIndex = 0;
            // 
            // txtADNumber
            // 
            this.txtADNumber.BaseColor = System.Drawing.Color.White;
            this.txtADNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtADNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtADNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtADNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtADNumber.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtADNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtADNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtADNumber.Location = new System.Drawing.Point(19, 97);
            this.txtADNumber.Name = "txtADNumber";
            this.txtADNumber.PasswordChar = '\0';
            this.txtADNumber.SelectedText = "";
            this.txtADNumber.Size = new System.Drawing.Size(374, 39);
            this.txtADNumber.TabIndex = 0;
            this.txtADNumber.TextChanged += new System.EventHandler(this.txtApNumber_TextChanged);
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
            // lblXrayPath
            // 
            this.lblXrayPath.AutoSize = true;
            this.lblXrayPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblXrayPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblXrayPath.Location = new System.Drawing.Point(19, 229);
            this.lblXrayPath.Name = "lblXrayPath";
            this.lblXrayPath.Size = new System.Drawing.Size(0, 20);
            this.lblXrayPath.TabIndex = 6;
            // 
            // frmXrayAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(892, 727);
            this.Controls.Add(this.pnlTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXrayAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmADAddmitPatient";
            this.pnlTheme.ResumeLayout(false);
            this.pnlTheme.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbXray)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elips;
        private Guna.UI.WinForms.GunaPanel pnlTheme;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtADNumber;
        private Guna.UI.WinForms.GunaLabel lblTime;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private System.Windows.Forms.Timer tmrDateTime;
        private Guna.UI.WinForms.GunaLabel lblDate;
        private Guna.UI.WinForms.GunaAdvenceButton btnPSave;
        private Guna.UI.WinForms.GunaLabel lblApNumber;
        private Guna.UI.WinForms.GunaAnimateWindow Animate;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaPictureBox pctbXray;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddPic;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtXrayPath;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtRoomNo;
        private Guna.UI.WinForms.GunaTextBox txtWardNo;
        private Guna.UI.WinForms.GunaTextBox txtDctName;
        private Guna.UI.WinForms.GunaLabel lblXrayPath;
    }
}