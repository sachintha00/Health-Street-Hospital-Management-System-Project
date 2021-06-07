namespace Health_Street
{
    partial class frmWdDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWdDash));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvRooms = new Guna.UI.WinForms.GunaDataGridView();
            this.Room_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ward_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvPatient = new Guna.UI.WinForms.GunaDataGridView();
            this.Admission_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialist_Doctor_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel3 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblWards = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblRooms = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblPatient = new Guna.UI.WinForms.GunaLabel();
            this.pnlBanner = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblBillOfficer = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.gunaShadowPanel3.SuspendLayout();
            this.gunaShadowPanel2.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.pnlBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel1.BackgroundImage")));
            this.gunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel1.Controls.Add(this.gunaGroupBox2);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaShadowPanel3);
            this.gunaPanel1.Controls.Add(this.gunaShadowPanel2);
            this.gunaPanel1.Controls.Add(this.gunaShadowPanel1);
            this.gunaPanel1.Controls.Add(this.pnlBanner);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1296, 809);
            this.gunaPanel1.TabIndex = 10;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.dgvRooms);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaGroupBox2.LineTop = 40;
            this.gunaGroupBox2.Location = new System.Drawing.Point(18, 300);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(599, 298);
            this.gunaGroupBox2.TabIndex = 17;
            this.gunaGroupBox2.Text = "Rooms";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AllowUserToResizeColumns = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRooms.ColumnHeadersHeight = 52;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Room_Number,
            this.Room_Name,
            this.Room_Type,
            this.Room_Availability,
            this.Ward_Number});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRooms.EnableHeadersVisualStyles = false;
            this.dgvRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvRooms.Location = new System.Drawing.Point(0, 38);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowHeadersWidth = 51;
            this.dgvRooms.RowTemplate.Height = 24;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(599, 260);
            this.dgvRooms.TabIndex = 11;
            this.dgvRooms.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal;
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRooms.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvRooms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvRooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.dgvRooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRooms.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvRooms.ThemeStyle.ReadOnly = true;
            this.dgvRooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgvRooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRooms.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.dgvRooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRooms.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvRooms_DataError);
            // 
            // Room_Number
            // 
            this.Room_Number.DataPropertyName = "Room_Number";
            this.Room_Number.HeaderText = "Room Number";
            this.Room_Number.MinimumWidth = 6;
            this.Room_Number.Name = "Room_Number";
            this.Room_Number.ReadOnly = true;
            // 
            // Room_Name
            // 
            this.Room_Name.DataPropertyName = "Room_Name";
            this.Room_Name.HeaderText = "Room Name";
            this.Room_Name.MinimumWidth = 6;
            this.Room_Name.Name = "Room_Name";
            this.Room_Name.ReadOnly = true;
            // 
            // Room_Type
            // 
            this.Room_Type.DataPropertyName = "Room_Type";
            this.Room_Type.HeaderText = "Room Type";
            this.Room_Type.MinimumWidth = 6;
            this.Room_Type.Name = "Room_Type";
            this.Room_Type.ReadOnly = true;
            // 
            // Room_Availability
            // 
            this.Room_Availability.DataPropertyName = "Room_Availability";
            this.Room_Availability.HeaderText = "Availability";
            this.Room_Availability.MinimumWidth = 6;
            this.Room_Availability.Name = "Room_Availability";
            this.Room_Availability.ReadOnly = true;
            // 
            // Ward_Number
            // 
            this.Ward_Number.DataPropertyName = "Ward_Number";
            this.Ward_Number.HeaderText = "Ward Number";
            this.Ward_Number.MinimumWidth = 6;
            this.Ward_Number.Name = "Ward_Number";
            this.Ward_Number.ReadOnly = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.dgvPatient);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaGroupBox1.LineTop = 40;
            this.gunaGroupBox1.Location = new System.Drawing.Point(632, 300);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(637, 298);
            this.gunaGroupBox1.TabIndex = 18;
            this.gunaGroupBox1.Text = "Patient";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.AllowUserToResizeColumns = false;
            this.dgvPatient.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPatient.ColumnHeadersHeight = 52;
            this.dgvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Admission_Number,
            this.Specialist_Doctor_Id});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatient.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPatient.EnableHeadersVisualStyles = false;
            this.dgvPatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvPatient.Location = new System.Drawing.Point(0, 38);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPatient.RowHeadersVisible = false;
            this.dgvPatient.RowHeadersWidth = 51;
            this.dgvPatient.RowTemplate.Height = 24;
            this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.Size = new System.Drawing.Size(637, 260);
            this.dgvPatient.TabIndex = 11;
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
            this.dgvPatient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPatient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPatient.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvPatient.ThemeStyle.ReadOnly = true;
            this.dgvPatient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgvPatient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPatient.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPatient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.dgvPatient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPatient.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPatient_DataError);
            // 
            // Admission_Number
            // 
            this.Admission_Number.DataPropertyName = "Admission_Number";
            this.Admission_Number.HeaderText = "Admission Number";
            this.Admission_Number.MinimumWidth = 6;
            this.Admission_Number.Name = "Admission_Number";
            this.Admission_Number.ReadOnly = true;
            // 
            // Specialist_Doctor_Id
            // 
            this.Specialist_Doctor_Id.DataPropertyName = "Specialist_Doctor_Id";
            this.Specialist_Doctor_Id.HeaderText = "Specialist Doctor ID";
            this.Specialist_Doctor_Id.MinimumWidth = 6;
            this.Specialist_Doctor_Id.Name = "Specialist_Doctor_Id";
            this.Specialist_Doctor_Id.ReadOnly = true;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.Location = new System.Drawing.Point(12, 263);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(245, 34);
            this.gunaLabel5.TabIndex = 16;
            this.gunaLabel5.Text = "Patient analytics";
            // 
            // gunaShadowPanel3
            // 
            this.gunaShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel3.Controls.Add(this.gunaLabel8);
            this.gunaShadowPanel3.Controls.Add(this.lblWards);
            this.gunaShadowPanel3.Location = new System.Drawing.Point(1075, 17);
            this.gunaShadowPanel3.Name = "gunaShadowPanel3";
            this.gunaShadowPanel3.Radius = 10;
            this.gunaShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel3.ShadowDepth = 15;
            this.gunaShadowPanel3.ShadowShift = 10;
            this.gunaShadowPanel3.Size = new System.Drawing.Size(209, 247);
            this.gunaShadowPanel3.TabIndex = 14;
            // 
            // lblWards
            // 
            this.lblWards.AutoSize = true;
            this.lblWards.Font = new System.Drawing.Font("Bahnschrift SemiBold", 40F, System.Drawing.FontStyle.Bold);
            this.lblWards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.lblWards.Location = new System.Drawing.Point(28, 33);
            this.lblWards.Name = "lblWards";
            this.lblWards.Size = new System.Drawing.Size(142, 81);
            this.lblWards.TabIndex = 0;
            this.lblWards.Text = "+78";
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.gunaLabel7);
            this.gunaShadowPanel2.Controls.Add(this.lblRooms);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(850, 17);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 10;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.ShadowDepth = 15;
            this.gunaShadowPanel2.ShadowShift = 10;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(209, 247);
            this.gunaShadowPanel2.TabIndex = 14;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Bahnschrift SemiBold", 40F, System.Drawing.FontStyle.Bold);
            this.lblRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.lblRooms.Location = new System.Drawing.Point(28, 33);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(142, 81);
            this.lblRooms.TabIndex = 0;
            this.lblRooms.Text = "+78";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel1);
            this.gunaShadowPanel1.Controls.Add(this.lblPatient);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(626, 17);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowDepth = 15;
            this.gunaShadowPanel1.ShadowShift = 10;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(209, 247);
            this.gunaShadowPanel1.TabIndex = 15;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Bahnschrift SemiBold", 40F, System.Drawing.FontStyle.Bold);
            this.lblPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.lblPatient.Location = new System.Drawing.Point(30, 33);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(114, 81);
            this.lblPatient.TabIndex = 0;
            this.lblPatient.Text = "+11";
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.Color.Transparent;
            this.pnlBanner.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.pnlBanner.Controls.Add(this.gunaLabel2);
            this.pnlBanner.Controls.Add(this.lblBillOfficer);
            this.pnlBanner.Location = new System.Drawing.Point(12, 66);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Radius = 10;
            this.pnlBanner.ShadowColor = System.Drawing.Color.Black;
            this.pnlBanner.ShadowShift = 10;
            this.pnlBanner.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal;
            this.pnlBanner.Size = new System.Drawing.Size(584, 198);
            this.pnlBanner.TabIndex = 13;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel2.Location = new System.Drawing.Point(35, 92);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(365, 46);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "You have been doing your whole work plan for\r\nthe last two months, Way to go";
            // 
            // lblBillOfficer
            // 
            this.lblBillOfficer.AutoSize = true;
            this.lblBillOfficer.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold);
            this.lblBillOfficer.ForeColor = System.Drawing.Color.White;
            this.lblBillOfficer.Location = new System.Drawing.Point(34, 42);
            this.lblBillOfficer.Name = "lblBillOfficer";
            this.lblBillOfficer.Size = new System.Drawing.Size(139, 28);
            this.lblBillOfficer.TabIndex = 0;
            this.lblBillOfficer.Text = "Hi, Doctor";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.gunaLabel1.Location = new System.Drawing.Point(18, 136);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(176, 51);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Patients";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaLabel7.Location = new System.Drawing.Point(33, 141);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(152, 51);
            this.gunaLabel7.TabIndex = 0;
            this.gunaLabel7.Text = "Rooms";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaLabel8.Location = new System.Drawing.Point(33, 136);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(142, 51);
            this.gunaLabel8.TabIndex = 0;
            this.gunaLabel8.Text = "Wards";
            // 
            // frmWdDash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1296, 809);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWdDash";
            this.Text = "frmDctDash";
            this.Load += new System.EventHandler(this.frmWdDash_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.gunaShadowPanel3.ResumeLayout(false);
            this.gunaShadowPanel3.PerformLayout();
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel2.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.pnlBanner.ResumeLayout(false);
            this.pnlBanner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private Guna.UI.WinForms.GunaLabel lblRooms;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel lblPatient;
        private Guna.UI.WinForms.GunaShadowPanel pnlBanner;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblBillOfficer;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvRooms;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaDataGridView dgvPatient;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel3;
        private Guna.UI.WinForms.GunaLabel lblWards;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ward_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admission_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialist_Doctor_Id;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}