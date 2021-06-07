namespace Health_Street
{
    partial class frmScanOutpatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScanOutpatient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlTheme = new Guna.UI.WinForms.GunaPanel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblMedicine = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvOutScan = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Out_Patient_Scan_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient_Id_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scan_Report = new System.Windows.Forms.DataGridViewImageColumn();
            this.Issue_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Issue_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialist_Doctor_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutScan)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlTheme
            // 
            this.pnlTheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTheme.BackgroundImage")));
            this.pnlTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTheme.Controls.Add(this.btnDelete);
            this.pnlTheme.Controls.Add(this.btnAdd);
            this.pnlTheme.Controls.Add(this.lblMedicine);
            this.pnlTheme.Controls.Add(this.gunaPictureBox1);
            this.pnlTheme.Controls.Add(this.txtSearch);
            this.pnlTheme.Controls.Add(this.dgvOutScan);
            this.pnlTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheme.Location = new System.Drawing.Point(0, 0);
            this.pnlTheme.Name = "pnlTheme";
            this.pnlTheme.Size = new System.Drawing.Size(1510, 943);
            this.pnlTheme.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ErrorImage = null;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = null;
            this.btnDelete.InitialImage = null;
            this.btnDelete.Location = new System.Drawing.Point(504, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 47);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 25;
            this.btnDelete.TabStop = false;
            this.btnDelete.Zoom = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.ErrorImage = null;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.InitialImage = null;
            this.btnAdd.Location = new System.Drawing.Point(459, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 47);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 24;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMedicine
            // 
            this.lblMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMedicine.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold);
            this.lblMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.lblMedicine.Location = new System.Drawing.Point(238, -25);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(886, 112);
            this.lblMedicine.TabIndex = 15;
            this.lblMedicine.Text = "Out Patients Samples";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(25, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(200, 120);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 14;
            this.gunaPictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(25, 198);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(420, 44);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.txtSearch_OnTextChange);
            // 
            // dgvOutScan
            // 
            this.dgvOutScan.AllowUserToAddRows = false;
            this.dgvOutScan.AllowUserToDeleteRows = false;
            this.dgvOutScan.AllowUserToResizeColumns = false;
            this.dgvOutScan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvOutScan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOutScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvOutScan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutScan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOutScan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOutScan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOutScan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOutScan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOutScan.ColumnHeadersHeight = 52;
            this.dgvOutScan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOutScan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Out_Patient_Scan_No,
            this.Patient_Id_Number,
            this.Scan_Report,
            this.Issue_Date,
            this.Issue_Time,
            this.Specialist_Doctor_Id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOutScan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOutScan.EnableHeadersVisualStyles = false;
            this.dgvOutScan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvOutScan.Location = new System.Drawing.Point(25, 265);
            this.dgvOutScan.Name = "dgvOutScan";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOutScan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOutScan.RowHeadersVisible = false;
            this.dgvOutScan.RowHeadersWidth = 51;
            this.dgvOutScan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOutScan.RowTemplate.Height = 24;
            this.dgvOutScan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutScan.Size = new System.Drawing.Size(1278, 486);
            this.dgvOutScan.TabIndex = 10;
            this.dgvOutScan.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal;
            this.dgvOutScan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvOutScan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOutScan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOutScan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOutScan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOutScan.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvOutScan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvOutScan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.dgvOutScan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOutScan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvOutScan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOutScan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOutScan.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvOutScan.ThemeStyle.ReadOnly = false;
            this.dgvOutScan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgvOutScan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOutScan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvOutScan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOutScan.ThemeStyle.RowsStyle.Height = 24;
            this.dgvOutScan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.dgvOutScan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOutScan.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvOutScan_DataError);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Out_Patient_Scan_No
            // 
            this.Out_Patient_Scan_No.DataPropertyName = "Out_Patient_Scan_No";
            this.Out_Patient_Scan_No.HeaderText = "Out Patient Scan No";
            this.Out_Patient_Scan_No.MinimumWidth = 6;
            this.Out_Patient_Scan_No.Name = "Out_Patient_Scan_No";
            // 
            // Patient_Id_Number
            // 
            this.Patient_Id_Number.DataPropertyName = "Patient_Id_Number";
            this.Patient_Id_Number.HeaderText = "Patient Id Number";
            this.Patient_Id_Number.MinimumWidth = 6;
            this.Patient_Id_Number.Name = "Patient_Id_Number";
            // 
            // Scan_Report
            // 
            this.Scan_Report.DataPropertyName = "Scan_Report";
            this.Scan_Report.HeaderText = "Scan Report";
            this.Scan_Report.MinimumWidth = 6;
            this.Scan_Report.Name = "Scan_Report";
            this.Scan_Report.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Scan_Report.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Issue_Date
            // 
            this.Issue_Date.DataPropertyName = "Issue_Date";
            this.Issue_Date.HeaderText = "Issue Date";
            this.Issue_Date.MinimumWidth = 6;
            this.Issue_Date.Name = "Issue_Date";
            // 
            // Issue_Time
            // 
            this.Issue_Time.DataPropertyName = "Issue_Time";
            this.Issue_Time.HeaderText = "Issue Time";
            this.Issue_Time.MinimumWidth = 6;
            this.Issue_Time.Name = "Issue_Time";
            // 
            // Specialist_Doctor_Id
            // 
            this.Specialist_Doctor_Id.DataPropertyName = "Specialist_Doctor_Id";
            this.Specialist_Doctor_Id.HeaderText = "Specialist Doctor Id";
            this.Specialist_Doctor_Id.MinimumWidth = 6;
            this.Specialist_Doctor_Id.Name = "Specialist_Doctor_Id";
            // 
            // frmScanOutpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 943);
            this.Controls.Add(this.pnlTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmScanOutpatient";
            this.Text = "frmPhrCstmr";
            this.Load += new System.EventHandler(this.frmPhrCstmr_Load);
            this.pnlTheme.ResumeLayout(false);
            this.pnlTheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutScan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI.WinForms.GunaPanel pnlTheme;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private Guna.UI.WinForms.GunaDataGridView dgvOutScan;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel lblMedicine;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out_Patient_Scan_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient_Id_Number;
        private System.Windows.Forms.DataGridViewImageColumn Scan_Report;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issue_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issue_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialist_Doctor_Id;
    }
}