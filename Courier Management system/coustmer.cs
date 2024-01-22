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
    public partial class coustmer : Form
    {
        public coustmer()
        {
            InitializeComponent();
        }

        private void label51_Click(object sender, EventArgs e)
        {
         
        }

        private void coustmer_Load(object sender, EventArgs e)
        {

        }

        private void SName_TextChanged(object sender, EventArgs e)
        {

        }
       
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DIFSIEP\SQLEXPRESS;Initial Catalog=Project2;Integrated Security=True");
        private void button77_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd= new SqlCommand("insert into Customer(CustId,CustName,CustAddress,CustPhoneno,CustEmail)values(@Cid,@Cname,@CAD,@CPN,@CEM)",con);
            cmd.Parameters.AddWithValue("@Cid",textid.Text);
            cmd.Parameters.AddWithValue("@Cname",textname.Text);
            cmd.Parameters.AddWithValue("@CAD",textadress.Text);
            cmd.Parameters.AddWithValue("@CPN",textphone.Text);
            cmd.Parameters.AddWithValue("@CEM",Email.Text);
            cmd.ExecuteNonQuery();
            con.Close();
              MessageBox.Show("successfully saved");
              BindData();
        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select * from Customer",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView56.DataSource = dt;
        }
       

             private void button78_Click(object sender, EventArgs e)
             {
                 con.Open();
                 SqlCommand cmd = new SqlCommand("update Customer set CustId=@Cid,CustName=@Cname,CustAddress=@CAD,CustPhoneno=@CPN,CustEmail=@CEM)", con);
                 cmd.Parameters.AddWithValue("@Cid", textid.Text);
                 cmd.Parameters.AddWithValue("@Cname", textname.Text);
                 cmd.Parameters.AddWithValue("@CAD", textadress.Text);
                 cmd.Parameters.AddWithValue("@CPN", textphone.Text);
                 cmd.Parameters.AddWithValue("@CEM", Email.Text);
                 cmd.ExecuteNonQuery();
                 con.Close();
                 MessageBox.Show("successfully updated");
                 BindData();
             }

             private void button79_Click_1(object sender, EventArgs e)
             {
                 con.Open();
                 SqlCommand cmd = new SqlCommand("delete Coustomer where CustId= @Cid", con);
                 cmd.Parameters.AddWithValue("@Cid", textid.Text);
                 cmd.ExecuteNonQuery();

                 con.Close();
                 MessageBox.Show("successfully deleted");
                 BindData();
             }

             private void pictureBox1_Click(object sender, EventArgs e)
             {

                 Staff obj = new Staff();
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

