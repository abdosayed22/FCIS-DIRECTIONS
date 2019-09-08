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
using System.Drawing.Printing;
using System.IO;
namespace FCIS_DIRECTIONS
{
    public partial class Form1 : Form
    {
        string ordb = "data source=orcl ; user id=scott ;password=tiger;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder bulider;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Filling Comboboxes in User form
            string constr = "data source=orcl ; user id=scott ;password=tiger;"; //disconnected
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            OracleCommand cmd2 = new OracleCommand();
            OracleCommand cmd3 = new OracleCommand();
            OracleCommand cmd4 = new OracleCommand();
           

            cmd.Connection = conn;
            cmd.CommandText = "GetmembersName";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MEMBERSNAME", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbShowmembers.Items.Add(dr[0]);
            }
            dr.Close();

            cmd2.Connection = conn;
            cmd2.CommandText = "select * FROM halls";
            cmd2.CommandType = CommandType.Text;

            OracleDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbShowhalls.Items.Add(dr2[0]);
            }
            dr2.Close();

            cmd3.Connection = conn;
            cmd3.CommandText = "select * FROM department";
            cmd3.CommandType = CommandType.Text;

            OracleDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                cmbShowDepart.Items.Add(dr3[0]);
            }
            dr3.Close();
            


            cmd4.Connection = conn;
            cmd4.CommandText = "select * FROM managment";
            cmd4.CommandType = CommandType.Text;

            OracleDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                cmbShowMangament.Items.Add(dr4[0]);
            }
            dr2.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbShowMangament.Text = (" ");
            cmbShowDepart.Text = " ";
            cmbShowhalls.Text = " ";

            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            {
                txtShowname.Text = cmbShowmembers.SelectedItem.ToString();
                c.CommandText = "GetImage";
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.Add("memname", cmbShowmembers.SelectedItem.ToString());
                c.Parameters.Add("imagee", OracleDbType.Varchar2, ParameterDirection.Output);
                c.ExecuteNonQuery();
               showloacation.ImageLocation =(c.Parameters["imagee"].Value.ToString()) ;

             
        
            }
        
        }

        private void goadmin_Click(object sender, EventArgs e)
        {
           this.Hide();
            Adminlogin admin = new Adminlogin();
            admin.Show();
            
        }

        private void showLocation_Click(object sender, EventArgs e)
        {
           
           
        }
        private void cmbShowMangament_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbShowDepart.Text = " ";
            cmbShowhalls.Text = " ";
            cmbShowmembers.Text = " ";

            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            {
                txtShowname.Text = cmbShowMangament.SelectedItem.ToString();
                c.CommandText = "select  loaction from managment where mangmentname=:name";
                c.CommandType = CommandType.Text;
                c.Parameters.Add("name", cmbShowMangament.SelectedItem.ToString());
                OracleDataReader reader = c.ExecuteReader();
                if (reader.Read())
                {
                    showloacation.ImageLocation = reader[0].ToString();

                }


            }
           
        }

        private void cmbShowhalls_SelectedIndexChanged(object sender, EventArgs e)
        {


            cmbShowMangament.Text = " ";
            cmbShowDepart.Text = " ";
            cmbShowmembers.Text = " ";

            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            {
                txtShowname.Text = cmbShowhalls.SelectedItem.ToString();
                c.CommandText = "select loaction from halls where hallname=:name";
                c.CommandType = CommandType.Text;
                c.Parameters.Add("name", cmbShowhalls.SelectedItem.ToString());
                OracleDataReader reader = c.ExecuteReader();
                if (reader.Read())
                {
                    showloacation.ImageLocation = reader[0].ToString();

                }

            }
          
        }

        private void cmbShowDepart_SelectedIndexChanged(object sender, EventArgs e)
        {


            cmbShowMangament.Text = " ";
            cmbShowhalls.Text = " ";
            cmbShowmembers.Text = " ";

            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            {
                txtShowname.Text = cmbShowDepart.SelectedItem.ToString();
                c.CommandText = "select loaction from DEPARTMENT where depname=:name";
                c.CommandType = CommandType.Text;
                c.Parameters.Add("name", cmbShowDepart.SelectedItem.ToString());
                OracleDataReader reader = c.ExecuteReader();
                if (reader.Read())
                {
                    showloacation.ImageLocation = reader[0].ToString();
                    

                  //  cmbShowDepart.Text = " ";
                    //txtShowname.Text = " ";

                }

            }

           
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            txtShowname.Text = " ";

            showloacation.ImageLocation = "C:\\Users\\DELL\\Desktop\\defaultMap.jpg";
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();

 
        }

        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(showloacation.Width, showloacation.Height);
            showloacation.DrawToBitmap(bm, new Rectangle(0, 0, showloacation.Width, showloacation.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtShowname_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bt = new Bitmap(this.showloacation.Width, this.showloacation.Height);
            showloacation.DrawToBitmap(bt, new Rectangle(0, 0, this.showloacation.Width, this.showloacation.Height));
            e.Graphics.DrawImage(bt, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void go_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminlogin admin = new Adminlogin();
            admin.Show();
        }
    } 
    
}
