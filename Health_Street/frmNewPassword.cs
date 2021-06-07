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
    public partial class frmNewPassword : Form
    {
        string gmail = frmForgetPassword.mail;
        public frmNewPassword()
        {
            InitializeComponent();
            txtnewPassword.Focus();
        }

        private void frmNewPassword_Load(object sender, EventArgs e)
        {
            shadow.SetShadowForm(this);
            newPassword.Start();
            txtnewPassword.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtnewPassword.Text) && string.IsNullOrEmpty(txtComfrmPassword.Text))
            {
                txtnewPassword.LineColor = Color.FromArgb(232, 17, 35);
                txtnewPassword.FocusedLineColor = Color.FromArgb(232, 17, 35);
                txtComfrmPassword.LineColor = Color.FromArgb(232, 17, 35);
                txtComfrmPassword.FocusedLineColor = Color.FromArgb(232, 17, 35);
                lblNewPassword.Text = "*cannot be blank";
                lblComfirmPassword.Text = "*cannot be blank";
                txtnewPassword.Focus();

            }
            else if(txtnewPassword.Text != txtComfrmPassword.Text)
            {
                txtComfrmPassword.LineColor = Color.FromArgb(232, 17, 35);
                txtComfrmPassword.FocusedLineColor = Color.FromArgb(232, 17, 35);
                lblComfirmPassword.Text = "*password doesn't match";
                txtComfrmPassword.Focus();
            }
            else
            {
                string sqlcmd = "UPDATE ACCOUNT SET Login_Password = '" + txtComfrmPassword.Text + "' WHERE E_mail = '"+gmail+"'";
                if (SQLConnectionManager.insrtUpdteDelt(sqlcmd) == 1)
                {
                    MessageBox.Show("SUCCESSFULL");
                    new frmLogin().Show();
                    this.Close();
                }
            }
        }

        private void txtnewPassword_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtnewPassword.Text))
            {
                txtnewPassword.LineColor = Color.Gainsboro;
                txtnewPassword.FocusedLineColor = Color.FromArgb(50, 144, 156);
                lblNewPassword.ResetText();
            }
        }

        private void txtComfrmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtComfrmPassword.Text))
            {
                txtComfrmPassword.LineColor = Color.Gainsboro;
                txtComfrmPassword.FocusedLineColor = Color.FromArgb(50, 144, 156);
                lblComfirmPassword.ResetText();
            }
        }

        private void btnShwComfirmPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtnewPassword.PasswordChar = '\0';
            txtComfrmPassword.PasswordChar = '\0';
        }

        private void btnShwComfirmPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtnewPassword.PasswordChar = '●';
            txtComfrmPassword.PasswordChar = '●';
        }
    }
}
