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
    public partial class showpar : Form
    {
        CrystalReport4 cr4;
        public showpar()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            cr4 = new CrystalReport4();
            foreach (ParameterDiscreteValue v in cr4.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cr4.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr4;
        }
    }
}
