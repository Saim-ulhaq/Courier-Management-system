using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Courier_Management_system
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            ShowStaff();
        }
        private void ShowStaff()
        {
            con.Open();
            string Query = "select * from Staff";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView9.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Clear()
        {
            textid.Text = "";
            SName.Text = "";
            Email.Text = "";
            textid.Text = "";
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DIFSIEP\SQLEXPRESS;Initial Catalog=Project2;Integrated Security=True");
        private void button37_Click(object sender, EventArgs e)
        {

            if (textid.Text == "" || SName.Text == "" || Email.Text == "")
            {
                MessageBox.Show("Information is missing");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Staff(StaffId,SName,SEmail)values(@IC,@SN,@SE)", con);
                    cmd.Parameters.AddWithValue("@IC",int.Parse(textid.Text));
                    cmd.Parameters.AddWithValue("@SN", SName.Text);
                    cmd.Parameters.AddWithValue("@SE", Email.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" information is Added");





                    con.Close();
                    ShowStaff();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textid.Text = dataGridView9.CurrentRow.Cells[1].Value.ToString();
            SName.Text = dataGridView9.CurrentRow.Cells[2].Value.ToString();
            Email.Text = dataGridView9.CurrentRow.Cells[3].Value.ToString();

            if (SName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView9.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (textid.Text == "" || SName.Text == "" || Email.Text == "")
            {
                MessageBox.Show("Information is missing");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Staff set SName=@SN,SEmail=@SE where StaffId=@IC", con);
                    
                    cmd.Parameters.AddWithValue("@SN", SName.Text);
                    cmd.Parameters.AddWithValue("@SE", Email.Text);
                    cmd.Parameters.AddWithValue("@IC", int.Parse(textid.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" information is updated");





                    con.Close();
                    ShowStaff();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            
               
                
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Staff where StaffId=@IC", con);
                    cmd.Parameters.AddWithValue("@IC", int.Parse(textid.Text));


                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" information is Deleted");





                    con.Close();
                    ShowStaff();
                    Clear();
                }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            coustmer obj = new coustmer();
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Courier obj = new Courier();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Delieveryman obj = new Delieveryman();
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }
              
    }
}
