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
    public partial class frmPhrCstmr : Form
    {
        public frmPhrCstmr()
        {
            InitializeComponent();

            showData();
        }

        private void showData()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM HOSPITAL_CUSTOMER");
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = dt;
        }

        private void frmPhrCstmr_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM CUSTOMER WHERE Invoice_Number LIKE '" + txtSearch.text + "%' OR Pharmacy_Invoice_Number LIKE '" + txtSearch.text + "%' OR Patient_Id_Number LIKE '" + txtSearch.text + "%' OR Specialist_Doctor_Id LIKE '" + txtSearch.text + "%' OR Pharmacy_Staff_Id LIKE '" + txtSearch.text + "%' ");
            dgvCustomer.DataSource = dt;
        }

        private void dgvCustomer_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
