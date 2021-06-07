namespace Health_Street
{
    partial class frmXrayOutpatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXrayOutpatient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lblGuardians = new Guna.UI.WinForms.GunaLabel();
            this.dgvXrayOutPatient = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Out_Patient_Xray_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient_Id_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X_Ray = new System.Windows.Forms.DataGridViewImageColumn();
            this.Issue_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Issue_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXrayOutPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.AutoScroll = true;
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel1.BackgroundImage")));
            this.gunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel1.Controls.Add(this.btnDelete);
            this.gunaPanel1.Controls.Add(this.btnAdd);
            this.gunaPanel1.Controls.Add(this.txtSearch);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Controls.Add(this.lblGuardians);
            this.gunaPanel1.Controls.Add(this.dgvXrayOutPatient);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1112, 763);
            this.gunaPanel1.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ErrorImage = null;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = null;
            this.btnDelete.InitialImage = null;
            this.btnDelete.Location = new System.Drawing.Point(457, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 47);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 21;
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
            this.btnAdd.Location = new System.Drawing.Point(410, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 47);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 20;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(38, 136);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(343, 36);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.txtSearch_OnTextChange);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(33, -2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(111, 105);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 7;
            this.gunaPictureBox1.TabStop = false;
            // 
            // lblGuardians
            // 
            this.lblGuardians.AutoSize = true;
            this.lblGuardians.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGuardians.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.lblGuardians.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.lblGuardians.Location = new System.Drawing.Point(150, 6);
            this.lblGuardians.Name = "lblGuardians";
            this.lblGuardians.Size = new System.Drawing.Size(559, 78);
            this.lblGuardians.TabIndex = 6;
            this.lblGuardians.Text = "X-Ray Out Patients";
            // 
            // dgvXrayOutPatient
            // 
            this.dgvXrayOutPatient.AllowUserToAddRows = false;
            this.dgvXrayOutPatient.AllowUserToDeleteRows = false;
            this.dgvXrayOutPatient.AllowUserToResizeColumns = false;
            this.dgvXrayOutPatient.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvXrayOutPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXrayOutPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvXrayOutPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXrayOutPatient.BackgroundColor = System.Drawing.Color.White;
            this.dgvXrayOutPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvXrayOutPatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvXrayOutPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXrayOutPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXrayOutPatient.ColumnHeadersHeight = 52;
            this.dgvXrayOutPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Out_Patient_Xray_No,
            this.Patient_Id_Number,
            this.X_Ray,
            this.Issue_Date,
            this.Issue_Time});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXrayOutPatient.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvXrayOutPatient.EnableHeadersVisualStyles = false;
            this.dgvXrayOutPatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvXrayOutPatient.Location = new System.Drawing.Point(38, 190);
            this.dgvXrayOutPatient.Name = "dgvXrayOutPatient";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXrayOutPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvXrayOutPatient.RowHeadersVisible = false;
            this.dgvXrayOutPatient.RowHeadersWidth = 51;
            this.dgvXrayOutPatient.RowTemplate.Height = 24;
            this.dgvXrayOutPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXrayOutPatient.Size = new System.Drawing.Size(972, 434);
            this.dgvXrayOutPatient.TabIndex = 3;
            this.dgvXrayOutPatient.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal;
            this.dgvXrayOutPatient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvXrayOutPatient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvXrayOutPatient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvXrayOutPatient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvXrayOutPatient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvXrayOutPatient.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvXrayOutPatient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvXrayOutPatient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.dgvXrayOutPatient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvXrayOutPatient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvXrayOutPatient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvXrayOutPatient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvXrayOutPatient.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvXrayOutPatient.ThemeStyle.ReadOnly = false;
            this.dgvXrayOutPatient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgvXrayOutPatient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvXrayOutPatient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvXrayOutPatient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvXrayOutPatient.ThemeStyle.RowsStyle.Height = 24;
            this.dgvXrayOutPatient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.dgvXrayOutPatient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvXrayOutPatient.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvXrayOutPatient_DataError);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Out_Patient_Xray_No
            // 
            this.Out_Patient_Xray_No.DataPropertyName = "Out_Patient_Xray_No";
            this.Out_Patient_Xray_No.HeaderText = "Xray No";
            this.Out_Patient_Xray_No.MinimumWidth = 6;
            this.Out_Patient_Xray_No.Name = "Out_Patient_Xray_No";
            this.Out_Patient_Xray_No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Out_Patient_Xray_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Patient_Id_Number
            // 
            this.Patient_Id_Number.DataPropertyName = "Patient_Id_Number";
            this.Patient_Id_Number.HeaderText = "Patient Id Number";
            this.Patient_Id_Number.MinimumWidth = 6;
            this.Patient_Id_Number.Name = "Patient_Id_Number";
            // 
            // X_Ray
            // 
            this.X_Ray.DataPropertyName = "X_Ray";
            this.X_Ray.HeaderText = "X Ray";
            this.X_Ray.MinimumWidth = 6;
            this.X_Ray.Name = "X_Ray";
            this.X_Ray.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.X_Ray.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // frmXrayOutpatient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1112, 763);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXrayOutpatient";
            this.Text = "frmDctDash";
            this.Load += new System.EventHandler(this.frmWdRoom_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXrayOutPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaDataGridView dgvXrayOutPatient;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel lblGuardians;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out_Patient_Xray_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient_Id_Number;
        private System.Windows.Forms.DataGridViewImageColumn X_Ray;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issue_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issue_Time;
    }
}