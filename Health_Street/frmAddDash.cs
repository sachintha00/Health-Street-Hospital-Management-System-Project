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
    public partial class frmAddDash : Form
    {
        public frmAddDash()
        {
            InitializeComponent();
            ShowData();
            rowCount();

            if (SQLConnectionManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                 SqlDataReader reader1 = SQLConnectionManager.readAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblAddmitionOfficer.Text = "Hi, " + reader1[2].ToString();

                }
            }
        }

        private void rowCount()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT Room_Availability FROM ROOM WHERE Room_Availability='YES'");
            lblSoledRoom.Text = "+" + dt.Rows.Count.ToString();

            DataTable dt2 = new DataTable();
            dt2 = SQLConnectionManager.getdata("SELECT Room_Availability FROM ROOM WHERE Room_Availability='NO'");
            lblAvailbaleRoom.Text = "+" + dt2.Rows.Count.ToString();
        }

        private void ShowData()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM ROOM");
            dgvRoom.AutoGenerateColumns = false;
            dgvRoom.DataSource = dt;

            DataTable dt2 = new DataTable();
            dt2 = SQLConnectionManager.getdata("SELECT * FROM WARD");
            dgvWard.AutoGenerateColumns = false;
            dgvWard.DataSource = dt2;
        }

        private void frmPhrDash_Load(object sender, EventArgs e)
        {
            ShowData();
            rowCount();
        }

        private void dgvRoom_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvWard_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
