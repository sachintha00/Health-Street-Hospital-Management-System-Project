using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Health_Street
{
    public partial class frmBillDash : Form
    {
        public frmBillDash()
        {
            InitializeComponent();
            ShowData();

            if (SQLConnectionManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                 SqlDataReader reader1 = SQLConnectionManager.readAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblBillOfficer.Text = "Hi, " + reader1[2].ToString();

                }
            }

            rowCountGuardian();
            rowCountOrganzation();
        }

        private void rowCountGuardian()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM GUARDIAN");
            lblGuardian.Text = "+" + dt.Rows.Count.ToString();
        }
        private void rowCountOrganzation()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM ORGANIZATION");
            lblOrganization.Text = "+" + dt.Rows.Count.ToString();
        }

        private void ShowData()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM ORGANIZATION");
            dgvOrgniz.AutoGenerateColumns = false;
            dgvOrgniz.DataSource = dt;
        }

        private void frmPhrDash_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dgvOrgniz_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
