using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Street
{
    public partial class frmPhrDash : Form
    {
        public frmPhrDash()
        {
            InitializeComponent();
            show();
            if (SQLConnectionManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                SqlDataReader reader1 = SQLConnectionManager.readAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblPharmacy.Text = "Hi, " + reader1[2].ToString();

                }
            }

            rowCountMedicinet();
            rowCountSupplier();
        }

        private void rowCountMedicinet()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM DRUG");
            lblMedicine.Text = "+" + dt.Rows.Count.ToString();
        }
        private void rowCountSupplier()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM DRUG_SUPPLIER");
            lblSupplier.Text = "+" + dt.Rows.Count.ToString();
        }

        private void show()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM DRUG");
            dgvMedicine.AutoGenerateColumns = false;
            dgvMedicine.DataSource = dt;

            DataTable dt2 = new DataTable();
            dt2 = SQLConnectionManager.getdata("SELECT * FROM DRUG_SUPPLIER");
            dgvSupplier.AutoGenerateColumns = false;
            dgvSupplier.DataSource = dt2;
        }

        private void frmPhrDash_Load(object sender, EventArgs e)
        {
            show();
            rowCountMedicinet();
            rowCountSupplier();
        }

        private void dgvMedicine_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvSupplier_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
