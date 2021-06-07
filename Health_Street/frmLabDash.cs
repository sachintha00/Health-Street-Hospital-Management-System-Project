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
    public partial class frmLabDash : Form
    {
        public frmLabDash()
        {
            InitializeComponent();

            dataShow();
            DashName();
            rowCountInpatient();
            rowCountOutpatient();
        }

        private void rowCountInpatient()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM IN_SAMPLE");
            lblInpatient.Text = "+" + dt.Rows.Count.ToString();
        }
        private void rowCountOutpatient()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM OUT_SAMPLE");
            lblOutpatient.Text = "+" + dt.Rows.Count.ToString();
        }

        private void frmLabDash_Load(object sender, EventArgs e)
        {
            dataShow();
        }

        private void DashName()
        {
            if (SQLConnectionManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                SqlDataReader reader1 = SQLConnectionManager.readAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblLabOfficer.Text = "Hi, " + reader1[2].ToString();

                }
            }
        }

        private void dataShow()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM LABORATORY_STAFF");
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.DataSource = dt;

            DataTable dt2 = new DataTable();
            dt2 = SQLConnectionManager.getdata("SELECT * FROM IN_SAMPLE");
            dgvSample.AutoGenerateColumns = false;
            dgvSample.DataSource = dt2;
        }

        private void dgvStaff_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvSample_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
