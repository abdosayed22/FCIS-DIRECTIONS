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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // timer1.Enabled = true;
           // this.Hide();
            //Form1 form = new Form1();
            //form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value = progressBar1.Value + 5;
            if (progressBar1.Value > 99)
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
                timer1.Enabled = false;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           

        }

        private void Welcome_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void Welcome_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }


    }
}
