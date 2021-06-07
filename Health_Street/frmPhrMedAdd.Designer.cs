namespace Health_Street
{
    partial class frmPhrMedAdd
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
            this.txtStorePlace = new Guna.UI.WinForms.GunaTextBox();
            this.txtTradeNumber = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtDrugPrice = new Guna.UI.WinForms.GunaTextBox();
            this.btnPSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.lblTime = new Guna.UI.WinForms.GunaLabel();
            this.lblDate = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.lblDrugPrice = new Guna.UI.WinForms.GunaLabel();
            this.lblStorePlcae = new Guna.UI.WinForms.GunaLabel();
            this.lblTradeNumber = new Guna.UI.WinForms.GunaLabel();
            this.lblDrugName = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtDrugName = new Guna.UI.WinForms.GunaTextBox();
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
            this.gunaLabel18.Size = new System.Drawing.Size(623, 67);
            this.gunaLabel18.TabIndex = 1;
            this.gunaLabel18.Text = "Add Pharmacy Medicines";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel7);
            this.gunaGroupBox1.Controls.Add(this.txtStorePlace);
            this.gunaGroupBox1.Controls.Add(this.txtTradeNumber);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.txtDrugPrice);
            this.gunaGroupBox1.Controls.Add(this.btnPSave);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel13);
            this.gunaGroupBox1.Controls.Add(this.lblTime);
            this.gunaGroupBox1.Controls.Add(this.lblDate);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel14);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox1.Controls.Add(this.lblDrugPrice);
            this.gunaGroupBox1.Controls.Add(this.lblStorePlcae);
            this.gunaGroupBox1.Controls.Add(this.lblTradeNumber);
            this.gunaGroupBox1.Controls.Add(this.lblDrugName);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.txtDrugName);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaGroupBox1.LineTop = 40;
            this.gunaGroupBox1.Location = new System.Drawing.Point(52, 127);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(764, 468);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Add Medicine";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel4.Location = new System.Drawing.Point(15, 180);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(99, 23);
            this.gunaLabel4.TabIndex = 16;
            this.gunaLabel4.Text = "Store Place";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel7.Location = new System.Drawing.Point(427, 71);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(126, 23);
            this.gunaLabel7.TabIndex = 17;
            this.gunaLabel7.Text = "Trade Number";
            // 
            // txtStorePlace
            // 
            this.txtStorePlace.BaseColor = System.Drawing.Color.White;
            this.txtStorePlace.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtStorePlace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStorePlace.FocusedBaseColor = System.Drawing.Color.White;
            this.txtStorePlace.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtStorePlace.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtStorePlace.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStorePlace.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtStorePlace.Location = new System.Drawing.Point(19, 206);
            this.txtStorePlace.Name = "txtStorePlace";
            this.txtStorePlace.PasswordChar = '\0';
            this.txtStorePlace.SelectedText = "";
            this.txtStorePlace.Size = new System.Drawing.Size(342, 39);
            this.txtStorePlace.TabIndex = 12;
            // 
            // txtTradeNumber
            // 
            this.txtTradeNumber.BaseColor = System.Drawing.Color.White;
            this.txtTradeNumber.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtTradeNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTradeNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTradeNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtTradeNumber.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTradeNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTradeNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTradeNumber.Location = new System.Drawing.Point(431, 97);
            this.txtTradeNumber.Name = "txtTradeNumber";
            this.txtTradeNumber.PasswordChar = '\0';
            this.txtTradeNumber.SelectedText = "";
            this.txtTradeNumber.Size = new System.Drawing.Size(302, 39);
            this.txtTradeNumber.TabIndex = 13;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel5.Location = new System.Drawing.Point(427, 180);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(95, 23);
            this.gunaLabel5.TabIndex = 11;
            this.gunaLabel5.Text = "Drug Price";
            // 
            // txtDrugPrice
            // 
            this.txtDrugPrice.BaseColor = System.Drawing.Color.White;
            this.txtDrugPrice.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtDrugPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDrugPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDrugPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtDrugPrice.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDrugPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDrugPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDrugPrice.Location = new System.Drawing.Point(431, 206);
            this.txtDrugPrice.Name = "txtDrugPrice";
            this.txtDrugPrice.PasswordChar = '\0';
            this.txtDrugPrice.SelectedText = "";
            this.txtDrugPrice.Size = new System.Drawing.Size(302, 39);
            this.txtDrugPrice.TabIndex = 10;
            this.txtDrugPrice.TextChanged += new System.EventHandler(this.txtDrugPrice_TextChanged);
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
            // lblDrugPrice
            // 
            this.lblDrugPrice.AutoSize = true;
            this.lblDrugPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDrugPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblDrugPrice.Location = new System.Drawing.Point(437, 248);
            this.lblDrugPrice.Name = "lblDrugPrice";
            this.lblDrugPrice.Size = new System.Drawing.Size(0, 20);
            this.lblDrugPrice.TabIndex = 6;
            // 
            // lblStorePlcae
            // 
            this.lblStorePlcae.AutoSize = true;
            this.lblStorePlcae.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStorePlcae.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblStorePlcae.Location = new System.Drawing.Point(19, 248);
            this.lblStorePlcae.Name = "lblStorePlcae";
            this.lblStorePlcae.Size = new System.Drawing.Size(0, 20);
            this.lblStorePlcae.TabIndex = 6;
            // 
            // lblTradeNumber
            // 
            this.lblTradeNumber.AutoSize = true;
            this.lblTradeNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTradeNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblTradeNumber.Location = new System.Drawing.Point(437, 140);
            this.lblTradeNumber.Name = "lblTradeNumber";
            this.lblTradeNumber.Size = new System.Drawing.Size(0, 20);
            this.lblTradeNumber.TabIndex = 6;
            // 
            // lblDrugName
            // 
            this.lblDrugName.AutoSize = true;
            this.lblDrugName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDrugName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblDrugName.Location = new System.Drawing.Point(19, 140);
            this.lblDrugName.Name = "lblDrugName";
            this.lblDrugName.Size = new System.Drawing.Size(0, 20);
            this.lblDrugName.TabIndex = 6;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel1.Location = new System.Drawing.Point(15, 71);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(103, 23);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Drug Name";
            // 
            // txtDrugName
            // 
            this.txtDrugName.BaseColor = System.Drawing.Color.White;
            this.txtDrugName.BorderColor = System.Drawing.Color.Silver;
            this.txtDrugName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDrugName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDrugName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtDrugName.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDrugName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDrugName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDrugName.Location = new System.Drawing.Point(19, 97);
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.PasswordChar = '\0';
            this.txtDrugName.SelectedText = "";
            this.txtDrugName.Size = new System.Drawing.Size(342, 39);
            this.txtDrugName.TabIndex = 0;
            this.txtDrugName.TextChanged += new System.EventHandler(this.txtApNumber_TextChanged);
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
            // frmPhrMedAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(871, 607);
            this.Controls.Add(this.pnlTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhrMedAdd";
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
        private Guna.UI.WinForms.GunaTextBox txtDrugName;
        private Guna.UI.WinForms.GunaLabel lblTime;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private System.Windows.Forms.Timer tmrDateTime;
        private Guna.UI.WinForms.GunaLabel lblDate;
        private Guna.UI.WinForms.GunaAdvenceButton btnPSave;
        private Guna.UI.WinForms.GunaLabel lblDrugName;
        private Guna.UI.WinForms.GunaAnimateWindow Animate;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtDrugPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtStorePlace;
        private Guna.UI.WinForms.GunaTextBox txtTradeNumber;
        private Guna.UI.WinForms.GunaLabel lblTradeNumber;
        private Guna.UI.WinForms.GunaLabel lblDrugPrice;
        private Guna.UI.WinForms.GunaLabel lblStorePlcae;
    }
}