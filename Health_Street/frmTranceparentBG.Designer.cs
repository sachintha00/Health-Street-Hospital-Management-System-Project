namespace Health_Street
{
    partial class frmTranceparentBG
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
            this.formLouncher = new System.Windows.Forms.Timer(this.components);
            this.frmBGanimate = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.SuspendLayout();
            // 
            // formLouncher
            // 
            this.formLouncher.Enabled = true;
            this.formLouncher.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBGanimate
            // 
            this.frmBGanimate.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            this.frmBGanimate.Interval = 500;
            this.frmBGanimate.TargetControl = null;
            // 
            // frmTranceparentBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(831, 486);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTranceparentBG";
            this.Opacity = 0.9D;
            this.Text = "frmTranceparentBG";
            this.Load += new System.EventHandler(this.frmTranceparentBG_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer formLouncher;
        private Guna.UI.WinForms.GunaAnimateWindow frmBGanimate;
    }
}