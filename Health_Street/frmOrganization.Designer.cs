namespace Health_Street
{
    partial class frmOrganization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrganization));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elips = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlTheme = new Guna.UI.WinForms.GunaPanel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvPatient = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Goverment_Reg_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Billing_Officer_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lblPatient = new Guna.UI.WinForms.GunaLabel();
            this.pnlTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elips
            // 
            this.elips.Radius = 0;
            this.elips.TargetControl = this;
            // 
            // pnlTheme
            // 
            this.pnlTheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTheme.BackgroundImage")));
            this.pnlTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTheme.Controls.Add(this.btnDelete);
            this.pnlTheme.Controls.Add(this.btnAdd);
            this.pnlTheme.Controls.Add(this.txtSearch);
            this.pnlTheme.Controls.Add(this.dgvPatient);
            this.pnlTheme.Controls.Add(this.gunaPictureBox1);
            this.pnlTheme.Controls.Add(this.lblPatient);
            this.pnlTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheme.Location = new System.Drawing.Point(0, 0);
            this.pnlTheme.Name = "pnlTheme";
            this.pnlTheme.Size = new System.Drawing.Size(1420, 951);
            this.pnlTheme.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ErrorImage = null;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = null;
            this.btnDelete.InitialImage = null;
            this.btnDelete.Location = new System.Drawing.Point(502, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 38);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 15;
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
            this.btnAdd.Location = new System.Drawing.Point(458, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 38);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 12;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(22, 185);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(420, 44);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.txtSearch_OnTextChange);
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.AllowUserToResizeColumns = false;
            this.dgvPatient.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatient.ColumnHeadersHeight = 52;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Goverment_Reg_Number,
            this.Organization_Name,
            this.Organization_Address,
            this.Bill_Number,
            this.Billing_Officer_Id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatient.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatient.EnableHeadersVisualStyles = false;
            this.dgvPatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvPatient.Location = new System.Drawing.Point(22, 252);
            this.dgvPatient.Name = "dgvPatient";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatient.RowHeadersVisible = false;
            this.dgvPatient.RowHeadersWidth = 60;
            this.dgvPatient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPatient.RowTemplate.Height = 24;
            this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.Size = new System.Drawing.Size(1303, 513);
            this.dgvPatient.TabIndex = 10;
            this.dgvPatient.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal;
            this.dgvPatient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvPatient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPatient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPatient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPatient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPatient.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvPatient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvPatient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.dgvPatient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPatient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPatient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPatient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPatient.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvPatient.ThemeStyle.ReadOnly = false;
            this.dgvPatient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgvPatient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPatient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPatient.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPatient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.dgvPatient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellContentClick);
            this.dgvPatient.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellContentDoubleClick);
            this.dgvPatient.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPatient_DataError);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 57.08379F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Goverment_Reg_Number
            // 
            this.Goverment_Reg_Number.DataPropertyName = "Goverment_Reg_Number";
            this.Goverment_Reg_Number.HeaderText = "Goverment Reg Number";
            this.Goverment_Reg_Number.MinimumWidth = 6;
            this.Goverment_Reg_Number.Name = "Goverment_Reg_Number";
            // 
            // Organization_Name
            // 
            this.Organization_Name.DataPropertyName = "Organization_Name";
            this.Organization_Name.HeaderText = "Organization Name";
            this.Organization_Name.MinimumWidth = 6;
            this.Organization_Name.Name = "Organization_Name";
            // 
            // Organization_Address
            // 
            this.Organization_Address.DataPropertyName = "Organization_Address";
            this.Organization_Address.HeaderText = "Organization Address";
            this.Organization_Address.MinimumWidth = 6;
            this.Organization_Address.Name = "Organization_Address";
            // 
            // Bill_Number
            // 
            this.Bill_Number.DataPropertyName = "Bill_Number";
            this.Bill_Number.HeaderText = "Bill Number";
            this.Bill_Number.MinimumWidth = 6;
            this.Bill_Number.Name = "Bill_Number";
            // 
            // Billing_Officer_Id
            // 
            this.Billing_Officer_Id.DataPropertyName = "Billing_Officer_Id";
            this.Billing_Officer_Id.HeaderText = "Billing Officer Id";
            this.Billing_Officer_Id.MinimumWidth = 6;
            this.Billing_Officer_Id.Name = "Billing_Officer_Id";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Health_Street.Properties.Resources.doctor_consulting_with_patient;
            this.gunaPictureBox1.Location = new System.Drawing.Point(22, 33);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(149, 145);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 9;
            this.gunaPictureBox1.TabStop = false;
            // 
            // lblPatient
            // 
            this.lblPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPatient.AutoSize = true;
            this.lblPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPatient.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.lblPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.lblPatient.Location = new System.Drawing.Point(165, 46);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(517, 78);
            this.lblPatient.TabIndex = 8;
            this.lblPatient.Text = "ORGANIZATIONS";
            // 
            // frmOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 951);
            this.Controls.Add(this.pnlTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrganization";
            this.Text = "frmADaddmitPatient";
            this.Load += new System.EventHandler(this.frmADaddmitPatient_Load);
            this.pnlTheme.ResumeLayout(false);
            this.pnlTheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elips;
        private Guna.UI.WinForms.GunaPanel pnlTheme;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel lblPatient;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private Guna.UI.WinForms.GunaDataGridView dgvPatient;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goverment_Reg_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organization_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organization_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Billing_Officer_Id;
    }
}