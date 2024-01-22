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
    public partial class Delieveryman : Form
    {
        public Delieveryman()
        {
            InitializeComponent();
            ShowDelieveryman();
        }
        private void ShowDelieveryman()
        {
            con.Open();
            string Query = "select * from Delivery";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView5.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Clear()
        {
            textid1.Text = "";
            DName.Text = "";
            Dphoneno.Text = "";
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DIFSIEP\SQLEXPRESS;Initial Catalog=Project2;Integrated Security=True");
        private void button13_Click(object sender, EventArgs e)
        {
            if (textid1.Text == "" || DName.Text == "" || Dphoneno.Text == "")
            {
                MessageBox.Show("Information is missing");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Delivery(DId,DName,DPhoneno)values(@DD,@DN,@DP)", con);
                    cmd.Parameters.AddWithValue("@DD", int.Parse(textid1.Text));
                    cmd.Parameters.AddWithValue("@DN", DName.Text);
                    cmd.Parameters.AddWithValue("@DP", Dphoneno.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deliveryman information is Added");





                    con.Close();
                    ShowDelieveryman();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (textid1.Text == "" || DName.Text == "" || Dphoneno.Text == "")
            {
                MessageBox.Show("Information is missing");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Delivery set DName=@DN,DPhoneno=@DP where DId=@DD", con);
                    cmd.Parameters.AddWithValue("@DN", DName.Text);
                    cmd.Parameters.AddWithValue("@DP", Dphoneno.Text);
                    cmd.Parameters.AddWithValue("@DD", int.Parse(textid1.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deliveryman information is updated");





                    con.Close();
                    ShowDelieveryman();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textid1.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            DName.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();
            Dphoneno.Text = dataGridView5.CurrentRow.Cells[3].Value.ToString();

            if (DName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView5.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Delivery where DId=@DD", con);
            cmd.Parameters.AddWithValue("@DD", int.Parse(textid1.Text));


            cmd.ExecuteNonQuery();
            MessageBox.Show(" information is Deleted");





            con.Close();
            ShowDelieveryman();
            Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dphoneno_TextChanged(object sender, EventArgs e)
        {

        }

        private void DName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void label97_Click(object sender, EventArgs e)
        {

        }

        private void textid1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Courier obj = new Courier();
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
