using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
namespace FCIS_DIRECTIONS
{
    public partial class adminwork : Form
    {
       // string ordb = "data source=orcl ; user id=scott ;password=tiger;";
        //OracleConnection conn;
        public adminwork()
        {
            InitializeComponent();
        }

        private void adminwork_Load(object sender, EventArgs e)
        {
           

        }

        private void btnModifyMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifiyMembers members = new ModifiyMembers();
           members.Show();
        }

        private void btnModifyHalls_Click(object sender, EventArgs e)
        {
            this.Hide();
            halls hall = new halls();
            hall.Show();
        }

        private void adminwork_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();


        }

        private void btnModifyManagment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Managements mang = new Managements();
            mang.Show();
        }

        private void btnModifyDepart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department dep = new Department();
            dep.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminlogin admin = new Adminlogin();
            admin.Show();

        }
    }
}
