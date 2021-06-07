namespace Health_Street
{
    partial class frmForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgetPassword));
            this.elips = new Guna.UI.WinForms.GunaElipse(this.components);
            this.shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.drag = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnlDrag = new Guna.UI.WinForms.GunaLinePanel();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.lblCode = new Guna.UI.WinForms.GunaLabel();
            this.txtResetCode = new Guna.UI.WinForms.GunaTextBox();
            this.lblResetCode = new Guna.UI.WinForms.GunaLabel();
            this.lblGmail = new Guna.UI.WinForms.GunaLabel();
            this.btnSend = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.txtGmail = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.forgottenPassword = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.pnlDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elips
            // 
            this.elips.Radius = 0;
            this.elips.TargetControl = this;
            // 
            // drag
            // 
            this.drag.TargetControl = this.pnlDrag;
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.Color.White;
            this.pnlDrag.Controls.Add(this.btnClose);
            this.pnlDrag.Controls.Add(this.lblCode);
            this.pnlDrag.Controls.Add(this.txtResetCode);
            this.pnlDrag.Controls.Add(this.lblResetCode);
            this.pnlDrag.Controls.Add(this.lblGmail);
            this.pnlDrag.Controls.Add(this.btnSend);
            this.pnlDrag.Controls.Add(this.gunaGradientPanel1);
            this.pnlDrag.Controls.Add(this.txtGmail);
            this.pnlDrag.Controls.Add(this.gunaLabel3);
            this.pnlDrag.Controls.Add(this.gunaLabel2);
            this.pnlDrag.Controls.Add(this.gunaLabel1);
            this.pnlDrag.Controls.Add(this.gunaLabel4);
            this.pnlDrag.Controls.Add(this.gunaPictureBox1);
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDrag.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.pnlDrag.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(1090, 590);
            this.pnlDrag.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(1011, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.btnClose.Size = new System.Drawing.Size(79, 43);
            this.btnClose.TabIndex = 9;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCode.Location = new System.Drawing.Point(26, 439);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(138, 23);
            this.lblCode.TabIndex = 16;
            this.lblCode.Text = "Enter Code here";
            // 
            // txtResetCode
            // 
            this.txtResetCode.BaseColor = System.Drawing.Color.White;
            this.txtResetCode.BorderColor = System.Drawing.Color.DarkGray;
            this.txtResetCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResetCode.FocusedBaseColor = System.Drawing.Color.White;
            this.txtResetCode.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.txtResetCode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResetCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResetCode.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtResetCode.Location = new System.Drawing.Point(25, 465);
            this.txtResetCode.Name = "txtResetCode";
            this.txtResetCode.PasswordChar = '\0';
            this.txtResetCode.SelectedText = "";
            this.txtResetCode.Size = new System.Drawing.Size(233, 49);
            this.txtResetCode.TabIndex = 15;
            this.txtResetCode.TextChanged += new System.EventHandler(this.txtResetCode_TextChanged);
            // 
            // lblResetCode
            // 
            this.lblResetCode.AutoSize = true;
            this.lblResetCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResetCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblResetCode.Location = new System.Drawing.Point(30, 486);
            this.lblResetCode.Name = "lblResetCode";
            this.lblResetCode.Size = new System.Drawing.Size(0, 20);
            this.lblResetCode.TabIndex = 14;
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblGmail.Location = new System.Drawing.Point(30, 316);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(0, 20);
            this.lblGmail.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.AnimationHoverSpeed = 0.07F;
            this.btnSend.AnimationSpeed = 0.03F;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSend.BorderColor = System.Drawing.Color.Black;
            this.btnSend.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSend.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSend.CheckedForeColor = System.Drawing.Color.White;
            this.btnSend.CheckedImage = null;
            this.btnSend.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend.FocusedColor = System.Drawing.Color.Empty;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = null;
            this.btnSend.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSend.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSend.Location = new System.Drawing.Point(299, 342);
            this.btnSend.Name = "btnSend";
            this.btnSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSend.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSend.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSend.OnHoverImage = null;
            this.btnSend.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSend.OnPressedColor = System.Drawing.Color.Black;
            this.btnSend.Radius = 22;
            this.btnSend.Size = new System.Drawing.Size(152, 61);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.Maroon;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.OrangeRed;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(465, 125);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(170, 6);
            this.gunaGradientPanel1.TabIndex = 12;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // txtGmail
            // 
            this.txtGmail.BackColor = System.Drawing.Color.White;
            this.txtGmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGmail.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.txtGmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGmail.LineColor = System.Drawing.Color.Gainsboro;
            this.txtGmail.Location = new System.Drawing.Point(25, 268);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.PasswordChar = '\0';
            this.txtGmail.SelectedText = "";
            this.txtGmail.Size = new System.Drawing.Size(426, 43);
            this.txtGmail.TabIndex = 11;
            this.txtGmail.TextChanged += new System.EventHandler(this.txtGmail_TextChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gunaLabel3.Location = new System.Drawing.Point(330, 144);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(384, 40);
            this.gunaLabel3.TabIndex = 10;
            this.gunaLabel3.Text = "If you need help resetting your password, we can help by\r\n                   send" +
    "ing you a code to reset it.";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel2.Location = new System.Drawing.Point(25, 240);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(170, 25);
            this.gunaLabel2.TabIndex = 8;
            this.gunaLabel2.Text = "Enter Your G-mail";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaLabel1.Location = new System.Drawing.Point(573, 55);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(252, 67);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Password";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(105)))), ((int)(((byte)(158)))));
            this.gunaLabel4.Location = new System.Drawing.Point(313, 55);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(263, 67);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Forgotten";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(455, 190);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(643, 364);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 6;
            this.gunaPictureBox1.TabStop = false;
            // 
            // forgottenPassword
            // 
            this.forgottenPassword.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            this.forgottenPassword.Interval = 800;
            this.forgottenPassword.TargetControl = this;
            // 
            // frmForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 590);
            this.Controls.Add(this.pnlDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmForgetPassword";
            this.Load += new System.EventHandler(this.frmForgetPassword_Load);
            this.pnlDrag.ResumeLayout(false);
            this.pnlDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elips;
        private Guna.UI2.WinForms.Guna2ShadowForm shadow;
        private Guna.UI.WinForms.GunaDragControl drag;
        private Guna.UI.WinForms.GunaLinePanel pnlDrag;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaLineTextBox txtGmail;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnSend;
        private Guna.UI.WinForms.GunaLabel lblGmail;
        private Guna.UI.WinForms.GunaTextBox txtResetCode;
        private Guna.UI.WinForms.GunaLabel lblResetCode;
        private Guna.UI.WinForms.GunaLabel lblCode;
        private Guna.UI.WinForms.GunaAnimateWindow forgottenPassword;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}