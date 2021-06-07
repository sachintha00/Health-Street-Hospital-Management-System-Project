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
    public partial class frmPhrMedAdd : Form
    {
        public frmPhrMedAdd(/*Form frm*/)
        {
            InitializeComponent();
            tmrDateTime.Start();
            txtDrugName.Focus();
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

        private void DrugPrice()
        {
            txtDrugPrice.BorderColor = Color.FromArgb(232, 17, 35);
            txtDrugPrice.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblDrugPrice.Text = "*cannot be blank";
        }

        private void StorePlace()
        {
            txtStorePlace.BorderColor = Color.FromArgb(232, 17, 35);
            txtStorePlace.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblStorePlcae.Text = "*cannot be blank";
        }

        private void DrugName()
        {
            txtDrugName.BorderColor = Color.FromArgb(232, 17, 35);
            txtDrugName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblDrugName.Text = "*cannot be blank";
        }
        private void TradeNumber()
        {
            txtTradeNumber.BorderColor = Color.FromArgb(232, 17, 35);
            txtTradeNumber.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblTradeNumber.Text = "*cannot be blank";
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
            if (string.IsNullOrEmpty(txtDrugName.Text) && string.IsNullOrEmpty(txtDrugPrice.Text) && string.IsNullOrEmpty(txtStorePlace.Text) && string.IsNullOrEmpty(txtTradeNumber.Text))
            {
                DrugPrice();
                StorePlace();
                DrugName();
                TradeNumber();
                txtDrugName.Focus();
            }
            else if (string.IsNullOrEmpty(txtDrugName.Text))
            {
                DrugName();
            }
            else if (string.IsNullOrEmpty(txtDrugPrice.Text))
            {
                DrugPrice();
            }
            else if (string.IsNullOrEmpty(txtStorePlace.Text))
            {
                StorePlace();
            }
            else if (string.IsNullOrEmpty(txtTradeNumber.Text))
            {
                TradeNumber();
            }
            else if (!txtDrugPrice.Text.Any(char.IsDigit))
            {
                DrugPrice();
                lblDrugPrice.Text = "*CAN'T HAVE STRINGS";
            }
            else
            {

                int i = SQLConnectionManager.insrtUpdteDelt("INSERT INTO DRUG VALUES('" + txtDrugName.Text + "','" + txtTradeNumber.Text + "','" + txtStorePlace.Text + "','" + txtDrugPrice.Text + "')");

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
            if (!string.IsNullOrEmpty(txtDrugPrice.Text) && txtDrugPrice.Text.Any(char.IsDigit))
            {
                txtDrugPrice.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                txtDrugPrice.BorderColor = Color.Silver;
                lblDrugPrice.ResetText();
            }
            else if (!txtDrugPrice.Text.Any(char.IsDigit))
            {
                txtDrugPrice.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtDrugPrice.BorderColor = Color.FromArgb(232, 17, 35);
                lblDrugPrice.Text = "CAN'T HAVE STRINGS";
            }
        }
    }
}
