using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Street
{
    public partial class frmMessageQuestion : Form
    {
        [DllImport("Gdi32.dll",EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect, // x-coordinate of upper-left corner
                int nTopRect, // y-coordinate of upper-left corner
                int nRightRect, // x-coordinate of lower-right corner
                int nBottomRect, // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
            );
        public frmMessageQuestion()
        {
            InitializeComponent();
        }

        private const int CS_Dropshadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_Dropshadow;
                return cp;
            }
        }

        public Image ImageBoxIcon
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

        public String Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }

        public string Caption
        {
            get { return lblCaption.Text; }
            set { lblCaption.Text = value; }
        }

        private void pnlMessage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnYes_MouseHover_1(object sender, EventArgs e)
        {
            btnYes.ForeColor = Color.White;
        }

        private void btnNo_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnNo_MouseLeave(object sender, EventArgs e)
        {
        }

        private void frmMessageQuestion_Load(object sender, EventArgs e)
        {
            btnYes.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,btnYes.Width,btnYes.Height,21,21));
            btnNo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNo.Width, btnNo.Height, 21, 21));
        }
    }
}
