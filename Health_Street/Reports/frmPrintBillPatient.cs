using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Street.Reports
{
    public partial class frmPrintBillPatient : Form
    {
        public frmPrintBillPatient()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrintBillPatient_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM GUARDIAN WHERE Guardian_Id_Number = '" + frmGuardian.guardianId + "'");
            ReportDataSource dataSource = new ReportDataSource("GuardianData", dt);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            

        }

        private void txtGuardianId_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM GUARDIAN");
            foreach(DataRow dr in dt.Rows)
            {
                if(dr["Billing_Officer_Id"].ToString()==null)
                {
                    string billingOffId = SQLConnectionManager.getValue("SELECT * FROM BILLING_OFFICER", frmLogin.passingRoll, 9, 1);
                    int i = SQLConnectionManager.insrtUpdteDelt("UPDATE GUARDIAN SET Billing_Officer_Id = '" + billingOffId + "' WHERE Guardian_Id_Number = '" + frmGuardian.guardianId + "'");
                }
            }
            this.Close();
        }
    }
}
