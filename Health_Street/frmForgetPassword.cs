using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Health_Street
{
    public partial class frmForgetPassword : Form
    {
        string resetCode;
        public static string mail;
        public frmForgetPassword()
        {
            InitializeComponent();
        }

        private void frmForgetPassword_Load(object sender, EventArgs e)
        {
            shadow.SetShadowForm(this);
            forgottenPassword.Start();
            txtResetCode.Enabled = false;
            lblCode.ForeColor = Color.FromArgb(209, 209, 209);
            txtResetCode.BorderColor = Color.FromArgb(209, 209, 209);
            txtResetCode.FocusedBorderColor = Color.FromArgb(209, 209, 209);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtGmail.Text))
            {
                txtGmail.FocusedLineColor = Color.FromArgb(232, 17, 35);
                txtGmail.LineColor = Color.FromArgb(232, 17, 35);
                lblGmail.Text = "*cannot be blank";
                txtGmail.Focus();
            }
            else if(!Regex.IsMatch(txtGmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                txtGmail.FocusedLineColor = Color.FromArgb(232, 17, 35);
                txtGmail.LineColor = Color.FromArgb(232, 17, 35);
                lblGmail.Text = "*Enter a valid email. Ex:name@gmail.com";
                txtGmail.Focus();
            }
            else
            {
                if (SQLConnectionManager.chek("SELECT * FROM ACCOUNT WHERE E_mail = '" + txtGmail.Text + "'") == 1)
                {
                    Random rand = new Random();
                    resetCode = (rand.Next(999999)).ToString();

                    MailMessage message = new MailMessage("health.street20@gmail.com", txtGmail.Text);
                    message.Subject = "Forgotten Password Code";
                    message.Body = "Your Password reset Code \n"+resetCode;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;

                    NetworkCredential nc = new NetworkCredential("health.street20@gmail.com", "health@street");
                    smtp.Credentials = nc;
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("send");
                        txtResetCode.Enabled = true;
                        lblCode.ForeColor = Color.FromArgb(105, 105, 105);
                        txtResetCode.BorderColor = Color.FromArgb(169, 169, 169);
                        txtResetCode.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                    }
                    catch(SmtpException)
                    {
                        MessageBox.Show("ERROR");
                    }
                    catch(Exception)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("DOESN'T MATCH");
                }
            }
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtGmail.Text) || Regex.IsMatch(txtGmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                txtGmail.FocusedLineColor = Color.FromArgb(50, 144, 156);
                txtGmail.LineColor = Color.Gainsboro;
                lblGmail.ResetText();
            }
        }

        private void txtResetCode_TextChanged(object sender, EventArgs e)
        {
            if(resetCode != txtResetCode.Text)
            {
                txtResetCode.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtResetCode.BorderColor = Color.FromArgb(232, 17, 35);
                lblResetCode.Text = "*Invalid Code";
            }
            else
            {
                mail = txtGmail.Text;
                txtResetCode.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                txtResetCode.BorderColor = Color.Gainsboro;
                lblResetCode.ResetText();
                this.Hide();
                new frmNewPassword().Show();
            }
        }
    }
}
