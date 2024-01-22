using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Courier_Management_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textusername.Text = "";
            textpassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textusername.Text == "" || textpassword.Text == "")
            {
                MessageBox.Show("Enter the username and password");
            }
            else if (textusername.Text == "admin" && textpassword.Text == "1122")
            { 
                
                Staff obj = new Staff();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
