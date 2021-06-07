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
    public partial class frmLabSmplOutpatient : Form
    {
        public frmLabSmplOutpatient()
        {
            InitializeComponent();

            showData();
        }

        private void showData()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM OUT_SAMPLE");
            dgvOutSample.AutoGenerateColumns = false;
            dgvOutSample.DataSource = dt;
        }

        private void frmPhrCstmr_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM OUT_SAMPLE WHERE Sample_Out_Number LIKE '" + txtSearch.text + "%' OR Patient_Id_Number LIKE '" + txtSearch.text + "%' OR Sample_Type LIKE '" + txtSearch.text + "%' OR Specialist_Doctor_Id LIKE '" + txtSearch.text + "%' OR Laboratory_Staff_Id LIKE '" + txtSearch.text + "%' ");
            dgvOutSample.DataSource = dt;
        }

        private void dgvOutSample_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void frm_Updater(object sender, frmLabAddOut.UpdateEvenetArgs args)
        {
            showData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmLabAddOut frm = new frmLabAddOut();
            frm.UpdateEvenetHanler += frm_Updater;
            new Health_Street.frmTranceparentBG(frm);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int n = 0, c = 0;
            foreach (DataGridViewRow dgr in dgvOutSample.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[0].Value) == true)
                {
                    string sId = dgr.Cells[1].Value.ToString();

                    n = SQLConnectionManager.insrtUpdteDelt("DELETE FROM OUT_SAMPLE WHERE Sample_Out_Number = '" + sId + "'");
                    c += 1;
                }
            }
            showData();
            if (n == 1)
            {
                HSMessageBox.Show(c + " DATA DELETED SUCCESSFULLY ", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }
    }
}
