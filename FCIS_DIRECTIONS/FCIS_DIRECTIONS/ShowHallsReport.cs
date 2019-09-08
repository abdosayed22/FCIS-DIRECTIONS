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
    public partial class ShowHallsReport : Form
    {
        HallsReport hr;
        public ShowHallsReport()
        {
            InitializeComponent();
        }

        private void ShowHallsReport_Load(object sender, EventArgs e)
        {
            hr = new HallsReport();
            hr.SetDatabaseLogon("scott", "tiger");

            crystalReportViewer1.ReportSource = hr;
        }
    }
}
