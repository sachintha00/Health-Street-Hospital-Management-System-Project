using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Street
{
    class clsOpnChild
    {
        public Form activeForm = null;
        public void openChild(Form child, Panel pnl)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnl.Controls.Add(child);
            child.BringToFront();
            child.BackColor = Color.FromArgb(240, 240, 240);
            child.Show();
        }
    }
}
