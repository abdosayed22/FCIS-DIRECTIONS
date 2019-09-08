using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
namespace FCIS_DIRECTIONS
{
    public partial class halls : Form
    {
        string ordb = "data source=orcl ; user id=scott ;password=tiger;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder bulider;
        DataSet ds;
        public halls()
        {
            InitializeComponent();
        }

        private void halls_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void halls_Load(object sender, EventArgs e)
        {
        
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from HALLS";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbHallName.Items.Add(dr[0]);
               // dataGridView1.Rows.Add(dr[0].ToString());

            }
            dr.Close();

            //disconnected
            adapter = new OracleDataAdapter("select HALLNAME,USERNAME from HALLS", ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void ModifyhallLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Picmodifyhall.Image = Image.FromFile(ofd.FileName);
                Picmodifyhall.ImageLocation = ofd.FileName;
            }
        }

        private void btnInserthallLocation_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PicAddhall.Image = Image.FromFile(ofd.FileName);
                PicAddhall.ImageLocation = ofd.FileName;
            }*/
        }

        private void btnModifyDepart_Click(object sender, EventArgs e)
        {
             OracleCommand com = new OracleCommand();
            com.Connection = conn;
            com.CommandText = "UPDATE_HALLS";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("Name", cmbHallName.Text);
            com.Parameters.Add("location", Picmodifyhall.ImageLocation.ToString());
            com.ExecuteNonQuery();
            MessageBox.Show("Hall Location modified");
        }

        private void btnInserthall_Click(object sender, EventArgs e)
        {
            OracleCommand com = new OracleCommand();
            com.Connection = conn;
            com.CommandText = "INSERT_HALL";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("memName", txtInserthallName.Text);
            com.Parameters.Add("memlocation", Picmodifyhall.ImageLocation.ToString());
            com.ExecuteNonQuery();
            MessageBox.Show("Successfully added ");
            cmbHallName.Items.Add(txtInserthallName.Text);
        }

        private void btndeletehall_Click(object sender, EventArgs e)
        {
            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;
            c2.CommandText = "delete_hall";
            c2.Parameters.Add("namee", cmbHallName.Text);
            c2.CommandType = CommandType.StoredProcedure;
           c2.ExecuteNonQuery();
            
                MessageBox.Show("Hall deleted");
                cmbHallName.Items.RemoveAt(cmbHallName.SelectedIndex);
                txtInserthallName.Text = "";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowHallsReport shh = new ShowHallsReport();
            shh.Show();
        }

        private void btnSavechanges_Click(object sender, EventArgs e)
        {
            bulider = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("done");
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminwork admin = new adminwork();
            admin.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Picmodifyhall_Click(object sender, EventArgs e)
        {

        }
    }
}
