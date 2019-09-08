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
    public partial class ModifiyMembers : Form
    {
        string ordb = "data source=orcl ; user id=scott ;password=tiger;";
        OracleConnection conn;
        OracleDataAdapter adapter,adapter2;
        OracleCommandBuilder bulider;
        DataSet ds;
        CrystalReport2 cr2;
        public ModifiyMembers()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModifyMemberLocation_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PicmodifyLocation.Image = Image.FromFile(ofd.FileName);
                PicmodifyLocation.ImageLocation = ofd.FileName;
            }*/
        }

        private void btnInsertmemberLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Choose Image(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (of.ShowDialog() == DialogResult.OK)
            {
               PicAddLoaction.Image = Image.FromFile(of.FileName);
                PicAddLoaction.ImageLocation = of.FileName;
                
            }

            adapter = new OracleDataAdapter("select MEMBERSNAME FROM members where LOACTION =:name ", ordb);
            adapter.SelectCommand.Parameters.Add("name", PicAddLoaction.ImageLocation.ToString());
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void ModifiyMembers_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * FROM members";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbMembersName.Items.Add(dr[0]);
               // dataGridView1.Rows.Add(dr[0].ToString());
            }
            dr.Close();

            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Abdo");

            //disconnected
            adapter = new OracleDataAdapter("select MEMBERSNAME,USERNAME FROM members", ordb);
            ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            cr2 = new CrystalReport2();
        
        }

        private void btnModifyMember_Click(object sender, EventArgs e)
        {
            OracleCommand com = new OracleCommand();
            com.Connection = conn;
            com.CommandText = "Update_Member";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("Name", cmbMembersName.Text);
            com.Parameters.Add("location", PicAddLoaction.ImageLocation.ToString());
             com.ExecuteNonQuery();
            MessageBox.Show("Member Location modified");

        }

        private void btnInsertMember_Click(object sender, EventArgs e)
        {

            OracleCommand com = new OracleCommand();
            com.Connection = conn;
            com.CommandText = "Insert_Member";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("memName",txtInsertmemberName.Text);
            com.Parameters.Add("memlocation", PicAddLoaction.ImageLocation.ToString());
           // com.Parameters.Add("userr", comboBox1.SelectedItem.ToString());
            com.ExecuteNonQuery();
            MessageBox.Show("Successfully added ");
            cmbMembersName.Items.Add(txtInsertmemberName.Text);
        }

        private void ModifiyMembers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btndeleteMember_Click(object sender, EventArgs e)
        {
            OracleCommand com = new OracleCommand();
            com.Connection = conn;
            com.CommandText = "DELETE_MEMBER";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("name", cmbMembersName.Text);
            com.ExecuteNonQuery();
          
                MessageBox.Show("Member deleted");
                cmbMembersName.Items.RemoveAt(cmbMembersName.SelectedIndex);
                txtInsertmemberName.Text = "";
               
            

        }

        private void cmbMembersName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtInsertmemberName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberReport mr = new MemberReport();

            mr.Show();
        }

        private void btnsaveChanges_Click(object sender, EventArgs e)
        {
            
            bulider = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("done");
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

        private void PicAddLoaction_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showpar sh = new showpar();
            sh.Show();
        }
    }
}
