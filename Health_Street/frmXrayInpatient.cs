using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Street
{
    public partial class frmXrayInpatient : Form
    {
        public frmXrayInpatient()
        {
            InitializeComponent();
            for (int i = 1; i <= 8; i++)
            {
                dgvRooms.Columns[i].ReadOnly = true;
            }
            show();
        }

        private void show()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM IN_PATIENT_XRAY");
            dgvRooms.AutoGenerateColumns = false;
            dgvRooms.DataSource = dt;
        }

        private void frm_UpdateXray(object sender, frmXrayAdd.UpdateEvenetArgs args)
        {
            show();
        }

        private void frmWdRoom_Load(object sender, EventArgs e)
        {
            show();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM IN_PATIENT_XRAY WHERE In_Patient_X_Ray_No LIKE '" + txtSearch.text + "%' OR Admission_Number LIKE '" + txtSearch.text + "%' OR Ward_Number LIKE '" + txtSearch.text + "%' OR Room_Number LIKE '" + txtSearch.text + "%'");
            dgvRooms.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmXrayAdd frm = new frmXrayAdd();
            frm.UpdateEvenetHanler+= frm_UpdateXray;
            new Health_Street.frmTranceparentBG(frm);
        }

        private void dgvRooms_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //if(e.Exception.Message =="")
            //{

            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int n = 0, c = 0;
            foreach (DataGridViewRow dgr in dgvRooms.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[0].Value) == true)
                {
                    string sId = dgr.Cells[1].Value.ToString();

                    n = SQLConnectionManager.insrtUpdteDelt("DELETE FROM IN_PATIENT_XRAY WHERE In_Patient_X_Ray_No = '" + sId + "'");
                    c += 1;
                }
            }
            show();
            if (n == 1)
            {
                HSMessageBox.Show(c + " DATA DELETED SUCCESSFULLY ", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }
    }
}
