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
    public partial class frmXrayOutpatient : Form
    {
        public frmXrayOutpatient()
        {
            InitializeComponent();
            for (int i = 1; i <= 5; i++)
            {
                dgvXrayOutPatient.Columns[i].ReadOnly = true;
            }
            show();
        }

        private void frm_updateOutxray(object sender, frmXrayAddOut.UpdateEvenetArgs args)
        {
            show();
        }

        private void show()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM OUT_PATIENT_XRAY");
            dgvXrayOutPatient.AutoGenerateColumns = false;
            dgvXrayOutPatient.DataSource = dt;
        }

        private void frmWdRoom_Load(object sender, EventArgs e)
        {
            show();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM OUT_PATIENT_XRAY WHERE Out_Patient_Xray_No LIKE '" + txtSearch.text + "%' OR Patient_Id_Number LIKE '" + txtSearch.text + "%'");
            dgvXrayOutPatient.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmXrayAddOut frm = new frmXrayAddOut();
            frm.UpdateEvenetHanler += frm_updateOutxray;
            new Health_Street.frmTranceparentBG(frm);
        }

        private void dgvXrayOutPatient_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int n = 0, c = 0;
            foreach (DataGridViewRow dgr in dgvXrayOutPatient.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[0].Value) == true)
                {
                    string sId = dgr.Cells[1].Value.ToString();

                    n = SQLConnectionManager.insrtUpdteDelt("DELETE FROM OUT_PATIENT_XRAY WHERE Out_Patient_Xray_No = '" + sId + "'");
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
