using RestaurantManagementSystem.Entities;
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
    public partial class Menyu : Form
    {
        public Menyu()
        {
            InitializeComponent();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_customer_Click(object sender, EventArgs e)
        {
            MainPage mpg = new();
            mpg.Show();
            Close();
        }

        private void lbl_menu_Click(object sender, EventArgs e)
        {

        }

        private void lbl_order_Click(object sender, EventArgs e)
        {
        }

        private void lbl_employee_Click(object sender, EventArgs e)
        {

        }

        private void lbl_rezervation_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MainPage mpg = new();
            mpg.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Emp emp = new();
            emp.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ord ord = new();
            ord.Show();
            Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Rezerv rezerv = new();
            rezerv.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
