using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace FCIS_DIRECTIONS
{
    public partial class MemberReport : Form
    {
        CrystalReport2 cr;
        public MemberReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void MemberReport_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();
            cr.SetDatabaseLogon("scott", "tiger");

            crystalReportViewer1.ReportSource = cr;
        }
    }
}
