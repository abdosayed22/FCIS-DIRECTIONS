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
    public partial class Managements : Form
    {
        string ordb = "data source=orcl ; user id=scott ;password=tiger;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder bulider;
        DataSet ds;
        public Managements()
        {
            InitializeComponent();
        }

        private void Managements_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Managements_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from MANAGMENT";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbManagName.Items.Add(dr[0]);
              //  dataGridView1.Rows.Add(dr[0].ToString());

            }
            dr.Close();

            //disconnected
            adapter = new OracleDataAdapter("select MANGMENTNAME from MANAGMENT", ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ModifyManageLocation_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PicmodifyManage.Image = Image.FromFile(ofd.FileName);
                PicmodifyManage.ImageLocation = ofd.FileName;
            }*/
        }

        private void btnInsertManageLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PicAddManage.Image = Image.FromFile(ofd.FileName);
                PicAddManage.ImageLocation = ofd.FileName;
            }
        }

        private void btnModifyManage_Click(object sender, EventArgs e)
        {
            OracleCommand com = new OracleCommand();
            com.Connection = conn;
            com.CommandText = "UPDATE_MANGEMENT";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("Name", cmbManagName.Text);
            com.Parameters.Add("location", PicAddManage.ImageLocation.ToString());
            com.ExecuteNonQuery();
            MessageBox.Show("Management Location modified");
        }

        private void btnInsertManage_Click(object sender, EventArgs e)
        {
            OracleCommand com = new OracleCommand();
            com.Connection = conn;
            com.CommandText = "INSERT_MANAGEMENT";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("memName", txtInsertManageName.Text);
            com.Parameters.Add("memlocation", PicAddManage.ImageLocation.ToString());
            com.ExecuteNonQuery();
            MessageBox.Show("Successfully added ");
            cmbManagName.Items.Add(txtInsertManageName.Text);
        }

        private void btndeleteManage_Click(object sender, EventArgs e)
        {
            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;
            c2.CommandText = "DELETE_MANAGEMENT";
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("mangname", cmbManagName.Text);
            c2.ExecuteNonQuery();
            
                MessageBox.Show("Management deleted");
                cmbManagName.Items.RemoveAt(cmbManagName.SelectedIndex);
                txtInsertManageName.Text = "";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowManagementReport sh = new ShowManagementReport();
            sh.Show();
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

        private void go_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminwork admin = new adminwork();
            admin.Show();
        }
        }
    }

