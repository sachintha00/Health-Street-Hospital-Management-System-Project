using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Street
{
    public partial class frmTranceparentBG : Form
    {
        Form _child = null;
        public frmTranceparentBG(Form parent, Form child)
        {
            InitializeComponent();
            _child = child;

            
            this.Size = parent.Size;
            this.Location = parent.Location;
            this.ShowDialog();
        }

        public frmTranceparentBG(Form child)
        {
            InitializeComponent();
            _child = child;

            this.WindowState = FormWindowState.Maximized;
            this.ShowDialog();
        }

        private void frmTranceparentBG_Load(object sender, EventArgs e)
        {
            frmBGanimate.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            formLouncher.Stop();
            _child.ShowDialog();
            this.Close();
        }
    }
}
