using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Login : Form
    {

        string originalUserName;
        string originalPassword;
        public Login()
        {
            InitializeComponent();
            originalUserName = "admin";
            originalPassword = "2004";

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName=txt_userName.Text;
            string password=txt_password.Text;

            if (userName == originalUserName && password == originalPassword)
            {
                var mainpage = new MainPage();
                this.Hide();
                mainpage.Show();

            }
            else 
            {
                MessageBox.Show("Username or Password is incorrect!");

            }
        }
    }
}
