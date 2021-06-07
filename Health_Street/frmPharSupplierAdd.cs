using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.IO;

namespace Health_Street
{
    public partial class frmPharSupplierAdd : Form
    {
        public frmPharSupplierAdd(/*Form frm*/)
        {
            InitializeComponent();
            tmrDateTime.Start();
            txtSuppName.Focus();
        }

        public delegate void UpdateDelegate(Object sender, UpdateEvenetArgs args);
        public event UpdateDelegate UpdateEvenetHanler;

        public class UpdateEvenetArgs : EventArgs
        {
            public string Data { get; set; }
        }

        private void insert()
        {
            UpdateEvenetArgs args = new UpdateEvenetArgs();
            UpdateEvenetHanler.Invoke(this, args);
        }

        private void ManufaRegNumber()
        {
            txtManufaRegNumber.BorderColor = Color.FromArgb(232, 17, 35);
            txtManufaRegNumber.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblManuRegNumber.Text = "*cannot be blank";
        }

        private void ManufaCountry()
        {
            txtManufaCountry.BorderColor = Color.FromArgb(232, 17, 35);
            txtManufaCountry.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblManuCountry.Text = "*cannot be blank";
        }

        private void SuppName()
        {
            txtSuppName.BorderColor = Color.FromArgb(232, 17, 35);
            txtSuppName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblSuppName.Text = "*cannot be blank";
        }
        private void ManufaCompany()
        {
            txtManufaCompany.BorderColor = Color.FromArgb(232, 17, 35);
            txtManufaCompany.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblManuCompany.Text = "*cannot be blank";
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        [Obsolete]
        private void btnPSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSuppName.Text) && string.IsNullOrEmpty(txtManufaRegNumber.Text) && string.IsNullOrEmpty(txtManufaCountry.Text) && string.IsNullOrEmpty(txtManufaCompany.Text))
            {
                ManufaRegNumber();
                ManufaCountry();
                SuppName();
                ManufaCompany();
                txtSuppName.Focus();
            }
            else if (string.IsNullOrEmpty(txtSuppName.Text))
            {
                SuppName();
            }
            else if (string.IsNullOrEmpty(txtManufaRegNumber.Text))
            {
                ManufaRegNumber();
            }
            else if (string.IsNullOrEmpty(txtManufaCountry.Text))
            {
                ManufaCountry();
            }
            else if (string.IsNullOrEmpty(txtManufaCompany.Text))
            {
                ManufaCompany();
            }
            else if (txtSuppName.Text.Any(char.IsDigit))
            {
                SuppName();
            }
            else
            {

                int i = SQLConnectionManager.insrtUpdteDelt("INSERT INTO DRUG_SUPPLIER VALUES('" + txtSuppName.Text + "','" + txtManufaCompany.Text + "','" + txtManufaCountry.Text + "','" + txtManufaRegNumber.Text + "')");

                if (i == 1)
                {
                    HSMessageBox.Show("DATA ADDED SUCCESSFULY", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("DATA ADDED UNSUCCESSFULL", "ERROR");
                }
                insert();


            }
        }
        private void txtApNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSuppName.Text) && !txtSuppName.Text.Any(char.IsDigit))
            {
                txtSuppName.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                txtSuppName.BorderColor = Color.Silver;
                lblSuppName.ResetText();
            }
            else if (txtManufaRegNumber.Text.Any(char.IsDigit))
            {
                txtSuppName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtSuppName.BorderColor = Color.FromArgb(232, 17, 35);
                lblSuppName.Text = "CAN'T HAVE NUMBERS";
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDrugPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
