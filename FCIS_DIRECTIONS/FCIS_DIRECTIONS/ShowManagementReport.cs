using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCIS_DIRECTIONS
{
    public partial class ShowManagementReport : Form
    {
        ManagementReport sh;
        public ShowManagementReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ShowManagementReport_Load(object sender, EventArgs e)
        {
            sh = new ManagementReport();
            sh.SetDatabaseLogon("scott", "tiger");

            crystalReportViewer1.ReportSource = sh;
        }
    }
}
