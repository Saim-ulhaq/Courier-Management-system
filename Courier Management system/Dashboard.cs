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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountStaff();
            CountCustomer();
            CountDeliveryman();
            CountCourier();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DIFSIEP\SQLEXPRESS;Initial Catalog=Project2;Integrated Security=True");
        private void CountStaff()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Staff", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textstaff.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void CountCustomer()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Customer", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textcustomer.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void CountDeliveryman()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Delivery", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textdelivery.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void CountCourier()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Courier", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textcourier.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Delieveryman obj = new Delieveryman();
            obj.Show();
            this.Hide();
        }
    }
}
