namespace Health_Street
{
    partial class frmBillDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillDash));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elips = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvOrgniz = new Guna.UI.WinForms.GunaDataGridView();
            this.Goverment_Reg_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblGuardian = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblOrganization = new Guna.UI.WinForms.GunaLabel();
            this.pnlBanner = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblBillOfficer = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrgniz)).BeginInit();
            this.gunaShadowPanel2.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.pnlBanner.SuspendLayout();
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
            this.gunaPanel1.Controls.Add(this.gunaGroupBox2);
            this.gunaPanel1.Controls.Add(this.gunaShadowPanel2);
            this.gunaPanel1.Controls.Add(this.gunaShadowPanel1);
            this.gunaPanel1.Controls.Add(this.pnlBanner);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1265, 764);
            this.gunaPanel1.TabIndex = 6;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.dgvOrgniz);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaGroupBox2.LineTop = 40;
            this.gunaGroupBox2.Location = new System.Drawing.Point(21, 272);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(726, 350);
            this.gunaGroupBox2.TabIndex = 9;
            this.gunaGroupBox2.Text = "Organization";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvOrgniz
            // 
            this.dgvOrgniz.AllowUserToAddRows = false;
            this.dgvOrgniz.AllowUserToDeleteRows = false;
            this.dgvOrgniz.AllowUserToResizeColumns = false;
            this.dgvOrgniz.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvOrgniz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrgniz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrgniz.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrgniz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrgniz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrgniz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrgniz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrgniz.ColumnHeadersHeight = 52;
            this.dgvOrgniz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrgniz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Goverment_Reg_Number,
            this.Organization_Name,
            this.Organization_Address});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrgniz.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrgniz.EnableHeadersVisualStyles = false;
            this.dgvOrgniz.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvOrgniz.Location = new System.Drawing.Point(0, 38);
            this.dgvOrgniz.Name = "dgvOrgniz";
            this.dgvOrgniz.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrgniz.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrgniz.RowHeadersVisible = false;
            this.dgvOrgniz.RowHeadersWidth = 51;
            this.dgvOrgniz.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrgniz.RowTemplate.Height = 24;
            this.dgvOrgniz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrgniz.Size = new System.Drawing.Size(726, 312);
            this.dgvOrgniz.TabIndex = 11;
            this.dgvOrgniz.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal;
            this.dgvOrgniz.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvOrgniz.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOrgniz.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrgniz.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOrgniz.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOrgniz.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvOrgniz.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvOrgniz.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.dgvOrgniz.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrgniz.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrgniz.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrgniz.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrgniz.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvOrgniz.ThemeStyle.ReadOnly = true;
            this.dgvOrgniz.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgvOrgniz.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrgniz.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrgniz.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOrgniz.ThemeStyle.RowsStyle.Height = 24;
            this.dgvOrgniz.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.dgvOrgniz.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrgniz.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvOrgniz_DataError);
            // 
            // Goverment_Reg_Number
            // 
            this.Goverment_Reg_Number.DataPropertyName = "Goverment_Reg_Number";
            this.Goverment_Reg_Number.HeaderText = "Goverment Reg Number";
            this.Goverment_Reg_Number.MinimumWidth = 6;
            this.Goverment_Reg_Number.Name = "Goverment_Reg_Number";
            this.Goverment_Reg_Number.ReadOnly = true;
            // 
            // Organization_Name
            // 
            this.Organization_Name.DataPropertyName = "Organization_Name";
            this.Organization_Name.HeaderText = "Organization Name";
            this.Organization_Name.MinimumWidth = 6;
            this.Organization_Name.Name = "Organization_Name";
            this.Organization_Name.ReadOnly = true;
            // 
            // Organization_Address
            // 
            this.Organization_Address.DataPropertyName = "Organization_Address";
            this.Organization_Address.HeaderText = "Organization Address";
            this.Organization_Address.MinimumWidth = 6;
            this.Organization_Address.Name = "Organization_Address";
            this.Organization_Address.ReadOnly = true;
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.gunaLabel3);
            this.gunaShadowPanel2.Controls.Add(this.lblGuardian);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(997, 19);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 10;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.ShadowDepth = 15;
            this.gunaShadowPanel2.ShadowShift = 10;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(249, 247);
            this.gunaShadowPanel2.TabIndex = 6;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaLabel3.Location = new System.Drawing.Point(34, 139);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(190, 45);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Guardians";
            // 
            // lblGuardian
            // 
            this.lblGuardian.AutoSize = true;
            this.lblGuardian.Font = new System.Drawing.Font("Bahnschrift SemiBold", 40F, System.Drawing.FontStyle.Bold);
            this.lblGuardian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.lblGuardian.Location = new System.Drawing.Point(28, 33);
            this.lblGuardian.Name = "lblGuardian";
            this.lblGuardian.Size = new System.Drawing.Size(142, 81);
            this.lblGuardian.TabIndex = 0;
            this.lblGuardian.Text = "+78";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel1);
            this.gunaShadowPanel1.Controls.Add(this.lblOrganization);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(723, 19);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowDepth = 15;
            this.gunaShadowPanel1.ShadowShift = 10;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(249, 247);
            this.gunaShadowPanel1.TabIndex = 7;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaLabel1.Location = new System.Drawing.Point(10, 139);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(230, 45);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Organization";
            // 
            // lblOrganization
            // 
            this.lblOrganization.AutoSize = true;
            this.lblOrganization.Font = new System.Drawing.Font("Bahnschrift SemiBold", 40F, System.Drawing.FontStyle.Bold);
            this.lblOrganization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.lblOrganization.Location = new System.Drawing.Point(30, 33);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(114, 81);
            this.lblOrganization.TabIndex = 0;
            this.lblOrganization.Text = "+11";
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.Color.Transparent;
            this.pnlBanner.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.pnlBanner.Controls.Add(this.gunaLabel2);
            this.pnlBanner.Controls.Add(this.lblBillOfficer);
            this.pnlBanner.Location = new System.Drawing.Point(21, 64);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Radius = 10;
            this.pnlBanner.ShadowColor = System.Drawing.Color.Black;
            this.pnlBanner.ShadowShift = 10;
            this.pnlBanner.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal;
            this.pnlBanner.Size = new System.Drawing.Size(684, 202);
            this.pnlBanner.TabIndex = 8;
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
            this.lblBillOfficer.Size = new System.Drawing.Size(163, 28);
            this.lblBillOfficer.TabIndex = 0;
            this.lblBillOfficer.Text = "Hi, Welcome";
            // 
            // frmBillDash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1265, 764);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBillDash";
            this.Text = "frmPhrDash";
            this.Load += new System.EventHandler(this.frmPhrDash_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrgniz)).EndInit();
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel2.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.pnlBanner.ResumeLayout(false);
            this.pnlBanner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elips;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private Guna.UI.WinForms.GunaLabel lblGuardian;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel lblOrganization;
        private Guna.UI.WinForms.GunaShadowPanel pnlBanner;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblBillOfficer;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvOrgniz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goverment_Reg_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organization_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organization_Address;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}