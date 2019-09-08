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
    public partial class Department : Form
    {
        string ordb = "data source=orcl ; user id=scott ;password=tiger;";
        OracleConnection conn;

        OracleDataAdapter adapter;
        OracleCommandBuilder bulider;
        DataSet ds;
        public Department()
        {
            InitializeComponent();
        }

        private void Department_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();


        }

        private void Department_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from department";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbDepartName.Items.Add(dr[0]);
               // dataGridView1.Rows.Add(dr[0].ToString());

            }
            dr.Close();

            //disconnected
            adapter = new OracleDataAdapter("select DEPNAME FROM department", ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnModifyDepart_Click(object sender, EventArgs e)
        {
            OracleCommand com = new OracleCommand();
            com.Connection = conn;
            com.CommandText = "UPDATE_DEPART";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("Name", cmbDepartName.Text);
            com.Parameters.Add("location", PicAddDepart.ImageLocation.ToString());
            com.ExecuteNonQuery();
            MessageBox.Show("Department Location modified");
        }

        private void ModifyaDepartLocation_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PicmodifyDepart.Image = Image.FromFile(ofd.FileName);
                PicmodifyDepart.ImageLocation = ofd.FileName;
            }*/
        }

        private void btnInsertdepartLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PicAddDepart.Image = Image.FromFile(ofd.FileName);
                PicAddDepart.ImageLocation = ofd.FileName;
            }
        }

        private void cmbDepartName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertDepart_Click(object sender, EventArgs e)
        {
            OracleCommand com = new OracleCommand();
            com.Connection = conn;
            com.CommandText = "INSERT_DEPART";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("memName", txtInsertDepartName.Text);
            com.Parameters.Add("memlocation", PicAddDepart.ImageLocation.ToString());
            com.ExecuteNonQuery();
            MessageBox.Show("Successfully added ");
            cmbDepartName.Items.Add(txtInsertDepartName.Text);
        }

        private void btndeleteDepartment_Click(object sender, EventArgs e)
        {
            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;
            c2.CommandText = "DELETE_DEPATMENT";
            c2.Parameters.Add("dname", cmbDepartName.Text);
            c2.CommandType = CommandType.StoredProcedure;

            c2.ExecuteNonQuery();
                MessageBox.Show("Department deleted");
                cmbDepartName.Items.RemoveAt(cmbDepartName.SelectedIndex);
                txtInsertDepartName.Text = "";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showDepartmentReport Shd = new showDepartmentReport();
            Shd.Show();
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminwork admin = new adminwork();
            admin.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
        }
    }
}
