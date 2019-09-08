using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace FCIS_DIRECTIONS
{
    public partial class Adminlogin : Form
    {

        public Adminlogin()
        {
            InitializeComponent();
            txtpassword.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Adminlogin_Load(object sender, EventArgs e)
        {
            txtusername.Text = "Admin";
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adminlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            if ((txtusername.Text == "Admin" || txtusername.Text == "Abdo") && txtpassword.Text == "12345")
            {
                this.Hide();
                adminwork admin = new adminwork();
                admin.Show();
            }

            else
            {
                MessageBox.Show("Invalid Password");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
