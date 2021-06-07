namespace Health_Street
{
    partial class frmDctInpatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDctInpatient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elips = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lblGuardians = new Guna.UI.WinForms.GunaLabel();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvInpatient = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Admission_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient_First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient_Middle_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient_Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blood_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Of_Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ward_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guardian_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gurdian_Tele_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guardian_NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInpatient)).BeginInit();
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
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Controls.Add(this.lblGuardians);
            this.gunaPanel1.Controls.Add(this.txtSearch);
            this.gunaPanel1.Controls.Add(this.dgvInpatient);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1265, 764);
            this.gunaPanel1.TabIndex = 6;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(36, 6);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(111, 105);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 5;
            this.gunaPictureBox1.TabStop = false;
            // 
            // lblGuardians
            // 
            this.lblGuardians.AutoSize = true;
            this.lblGuardians.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGuardians.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.lblGuardians.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.lblGuardians.Location = new System.Drawing.Point(153, 14);
            this.lblGuardians.Name = "lblGuardians";
            this.lblGuardians.Size = new System.Drawing.Size(328, 78);
            this.lblGuardians.TabIndex = 4;
            this.lblGuardians.Text = "In Patients";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(31, 120);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(343, 36);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.txtSearch_OnTextChange);
            // 
            // dgvInpatient
            // 
            this.dgvInpatient.AllowUserToAddRows = false;
            this.dgvInpatient.AllowUserToDeleteRows = false;
            this.dgvInpatient.AllowUserToResizeColumns = false;
            this.dgvInpatient.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvInpatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInpatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvInpatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInpatient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInpatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInpatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInpatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInpatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInpatient.ColumnHeadersHeight = 52;
            this.dgvInpatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Admission_Number,
            this.Patient_First_Name,
            this.Patient_Middle_Name,
            this.Patient_Last_Name,
            this.Gender,
            this.Blood_Group,
            this.Date_Of_Birth,
            this.Room_Number,
            this.Ward_Number,
            this.Reason,
            this.Guardian_Name,
            this.Relationship,
            this.Gurdian_Tele_No,
            this.Guardian_NIC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInpatient.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInpatient.EnableHeadersVisualStyles = false;
            this.dgvInpatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvInpatient.Location = new System.Drawing.Point(31, 173);
            this.dgvInpatient.Name = "dgvInpatient";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInpatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInpatient.RowHeadersVisible = false;
            this.dgvInpatient.RowHeadersWidth = 51;
            this.dgvInpatient.RowTemplate.Height = 24;
            this.dgvInpatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInpatient.Size = new System.Drawing.Size(1123, 432);
            this.dgvInpatient.TabIndex = 2;
            this.dgvInpatient.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal;
            this.dgvInpatient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvInpatient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInpatient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInpatient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInpatient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInpatient.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvInpatient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvInpatient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.dgvInpatient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInpatient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvInpatient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInpatient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInpatient.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvInpatient.ThemeStyle.ReadOnly = false;
            this.dgvInpatient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgvInpatient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInpatient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvInpatient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvInpatient.ThemeStyle.RowsStyle.Height = 24;
            this.dgvInpatient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.dgvInpatient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInpatient.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGurdiance_CellMouseDoubleClick);
            this.dgvInpatient.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvInpatient_DataError);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 59.01547F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Admission_Number
            // 
            this.Admission_Number.DataPropertyName = "Admission_Number";
            this.Admission_Number.FillWeight = 94.31937F;
            this.Admission_Number.HeaderText = "Admision No";
            this.Admission_Number.MinimumWidth = 6;
            this.Admission_Number.Name = "Admission_Number";
            // 
            // Patient_First_Name
            // 
            this.Patient_First_Name.DataPropertyName = "Patient_First_Name";
            this.Patient_First_Name.FillWeight = 94.31937F;
            this.Patient_First_Name.HeaderText = "First Name";
            this.Patient_First_Name.MinimumWidth = 6;
            this.Patient_First_Name.Name = "Patient_First_Name";
            // 
            // Patient_Middle_Name
            // 
            this.Patient_Middle_Name.DataPropertyName = "Patient_Middle_Name";
            this.Patient_Middle_Name.FillWeight = 94.31937F;
            this.Patient_Middle_Name.HeaderText = "Middle Name";
            this.Patient_Middle_Name.MinimumWidth = 6;
            this.Patient_Middle_Name.Name = "Patient_Middle_Name";
            // 
            // Patient_Last_Name
            // 
            this.Patient_Last_Name.DataPropertyName = "Patient_Last_Name";
            this.Patient_Last_Name.FillWeight = 94.31937F;
            this.Patient_Last_Name.HeaderText = "Surname";
            this.Patient_Last_Name.MinimumWidth = 6;
            this.Patient_Last_Name.Name = "Patient_Last_Name";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.FillWeight = 94.31937F;
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // Blood_Group
            // 
            this.Blood_Group.DataPropertyName = "Blood_Group";
            this.Blood_Group.FillWeight = 94.31937F;
            this.Blood_Group.HeaderText = "Blood Group";
            this.Blood_Group.MinimumWidth = 6;
            this.Blood_Group.Name = "Blood_Group";
            // 
            // Date_Of_Birth
            // 
            this.Date_Of_Birth.DataPropertyName = "Date_Of_Birth";
            this.Date_Of_Birth.FillWeight = 94.31937F;
            this.Date_Of_Birth.HeaderText = "Date Of Birth";
            this.Date_Of_Birth.MinimumWidth = 6;
            this.Date_Of_Birth.Name = "Date_Of_Birth";
            // 
            // Room_Number
            // 
            this.Room_Number.DataPropertyName = "Room_Number";
            this.Room_Number.FillWeight = 94.31937F;
            this.Room_Number.HeaderText = "Room No";
            this.Room_Number.MinimumWidth = 6;
            this.Room_Number.Name = "Room_Number";
            // 
            // Ward_Number
            // 
            this.Ward_Number.DataPropertyName = "Ward_Number";
            this.Ward_Number.FillWeight = 94.31937F;
            this.Ward_Number.HeaderText = "Ward No";
            this.Ward_Number.MinimumWidth = 6;
            this.Ward_Number.Name = "Ward_Number";
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.FillWeight = 94.31937F;
            this.Reason.HeaderText = "Reason";
            this.Reason.MinimumWidth = 6;
            this.Reason.Name = "Reason";
            // 
            // Guardian_Name
            // 
            this.Guardian_Name.DataPropertyName = "Guardian_Name";
            this.Guardian_Name.FillWeight = 94.31937F;
            this.Guardian_Name.HeaderText = "Guardian Name";
            this.Guardian_Name.MinimumWidth = 6;
            this.Guardian_Name.Name = "Guardian_Name";
            // 
            // Relationship
            // 
            this.Relationship.DataPropertyName = "Relationship";
            this.Relationship.FillWeight = 94.31937F;
            this.Relationship.HeaderText = "Relationship";
            this.Relationship.MinimumWidth = 6;
            this.Relationship.Name = "Relationship";
            // 
            // Gurdian_Tele_No
            // 
            this.Gurdian_Tele_No.DataPropertyName = "Gurdian_Tele_No";
            this.Gurdian_Tele_No.FillWeight = 94.31937F;
            this.Gurdian_Tele_No.HeaderText = "Guardian TP No";
            this.Gurdian_Tele_No.MinimumWidth = 6;
            this.Gurdian_Tele_No.Name = "Gurdian_Tele_No";
            // 
            // Guardian_NIC
            // 
            this.Guardian_NIC.DataPropertyName = "Guardian_NIC";
            this.Guardian_NIC.FillWeight = 94.31937F;
            this.Guardian_NIC.HeaderText = "Guardian NIC";
            this.Guardian_NIC.MinimumWidth = 6;
            this.Guardian_NIC.Name = "Guardian_NIC";
            // 
            // frmDctInpatient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1265, 764);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDctInpatient";
            this.Text = "frmPhrDash";
            this.Load += new System.EventHandler(this.frmDctGuardian_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInpatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elips;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private Guna.UI.WinForms.GunaDataGridView dgvInpatient;
        private Guna.UI.WinForms.GunaLabel lblGuardians;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admission_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient_First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient_Middle_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient_Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blood_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Of_Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ward_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guardian_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gurdian_Tele_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guardian_NIC;
    }
}