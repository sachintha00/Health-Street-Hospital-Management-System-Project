namespace Health_Street
{
    partial class frmMessageError
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
            Guna.UI.WinForms.GunaElipse Elips;
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageError));
            this.DragCtrl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnlDrag = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblCaption = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.pnlMessage = new Guna.UI.WinForms.GunaElipsePanel();
            this.PictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblMessage = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            Elips = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.pnlMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Elips
            // 
            Elips.Radius = 0;
            Elips.TargetControl = this;
            // 
            // DragCtrl
            // 
            this.DragCtrl.TargetControl = this.pnlDrag;
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.Color.Transparent;
            this.pnlDrag.BaseColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlDrag.Controls.Add(this.lblCaption);
            this.pnlDrag.Controls.Add(this.gunaCirclePictureBox1);
            this.pnlDrag.Controls.Add(this.pnlMessage);
            this.gunaTransition1.SetDecoration(this.pnlDrag, Guna.UI.Animation.DecorationType.None);
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Radius = 20;
            this.pnlDrag.Size = new System.Drawing.Size(600, 285);
            this.pnlDrag.TabIndex = 0;
            this.pnlDrag.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrag_Paint);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.lblCaption, Guna.UI.Animation.DecorationType.None);
            this.lblCaption.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.lblCaption.Location = new System.Drawing.Point(62, 10);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(94, 30);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "Caption";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTransition1.SetDecoration(this.gunaCirclePictureBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(13, 11);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(43, 29);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 1;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // pnlMessage
            // 
            this.pnlMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMessage.BackColor = System.Drawing.Color.Transparent;
            this.pnlMessage.BaseColor = System.Drawing.Color.White;
            this.pnlMessage.Controls.Add(this.PictureBox);
            this.pnlMessage.Controls.Add(this.btnOk);
            this.pnlMessage.Controls.Add(this.lblMessage);
            this.gunaTransition1.SetDecoration(this.pnlMessage, Guna.UI.Animation.DecorationType.None);
            this.pnlMessage.Location = new System.Drawing.Point(12, 55);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Radius = 10;
            this.pnlMessage.Size = new System.Drawing.Size(576, 218);
            this.pnlMessage.TabIndex = 0;
            this.pnlMessage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMessage_Paint);
            // 
            // PictureBox
            // 
            this.PictureBox.BaseColor = System.Drawing.Color.White;
            this.gunaTransition1.SetDecoration(this.PictureBox, Guna.UI.Animation.DecorationType.None);
            this.PictureBox.Image = global::Health_Street.Properties.Resources.Error;
            this.PictureBox.Location = new System.Drawing.Point(21, 17);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(123, 105);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaTransition1.SetDecoration(this.btnOk, Guna.UI.Animation.DecorationType.None);
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(191)))), ((int)(((byte)(198)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOk.Location = new System.Drawing.Point(279, 141);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(138, 60);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            this.btnOk.MouseHover += new System.EventHandler(this.btnYes_MouseHover_1);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.lblMessage, Guna.UI.Animation.DecorationType.None);
            this.lblMessage.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.lblMessage.Location = new System.Drawing.Point(150, 27);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(91, 24);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message";
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.gunaTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation2;
            // 
            // frmMessageError
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(600, 285);
            this.Controls.Add(this.pnlDrag);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessageError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMessageQuestion";
            this.Load += new System.EventHandler(this.frmMessageQuestion_Load);
            this.pnlDrag.ResumeLayout(false);
            this.pnlDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl DragCtrl;
        private Guna.UI.WinForms.GunaElipsePanel pnlDrag;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private Guna.UI.WinForms.GunaElipsePanel pnlMessage;
        private Guna.UI.WinForms.GunaLabel lblCaption;
        private Guna.UI.WinForms.GunaLabel lblMessage;
        private System.Windows.Forms.Button btnOk;
        private Guna.UI.WinForms.GunaPictureBox PictureBox;
    }
}