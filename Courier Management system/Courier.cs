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
    public partial class Courier : Form
    {
        public Courier()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DIFSIEP\SQLEXPRESS;Initial Catalog=Project2;Integrated Security=True");

        private void button71_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd= new SqlCommand("insert into Courier(CourierId,CWeight,Cdeliverydate,CAddress)values(@CId,@CW,@Cdate,@CA)",con);
            cmd.Parameters.AddWithValue("@CId",textcd.Text);
            cmd.Parameters.AddWithValue("@CW",textcweight.Text);
            cmd.Parameters.AddWithValue("@CDate",dateTimePicker2.Value.Date);
            cmd.Parameters.AddWithValue("@CA",textadress.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("successfully saved");
            BindData();
        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select * from Courier", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView55.DataSource = dt;
        }
       

         private void button72_Click_1(object sender, EventArgs e)
         {
             con.Open();
             SqlCommand cmd = new SqlCommand("update Courier set CWeight=@CW,Cdeliverydate=@CDate,CAddress=@CA where CourierId=@CId", con);
             cmd.Parameters.AddWithValue("@CId", textcd.Text);
             cmd.Parameters.AddWithValue("@CW", textcweight.Text);
             cmd.Parameters.AddWithValue("@CDate", dateTimePicker2.Value.Date);
             cmd.Parameters.AddWithValue("@CA", textadress.Text);
             cmd.ExecuteNonQuery();

             con.Close();
             MessageBox.Show("successfully updated");
             BindData();
         }

         private void button73_Click_1(object sender, EventArgs e)
         {
             con.Open();
             SqlCommand cmd = new SqlCommand("delete Courier where CourierId= @CId", con);
             cmd.Parameters.AddWithValue("@CId", textcd.Text);
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

