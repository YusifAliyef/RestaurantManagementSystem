using Microsoft.IdentityModel.Tokens;
using RestaurantManagementSystem.Entities;
using RestaurantManagementSystem.Interfaces;
using RestaurantManagementSystem.Managers;
using RestaurantManagementSystem.Mocdels;
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
    public partial class MainPage : Form
    {
        private readonly ICustomerManager _customerManager;
        private readonly IRezervationManager _rezervationManager;

        public MainPage()
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
            _rezervationManager = new RezervationManager();
        }

        private void lbl_rezervation_Click(object sender, EventArgs e)
        {
        }

        private async void MainPage_Load(object sender, EventArgs e)
        {
            await FillDataGridAsync();
            await FillCombo();
        }

        private async Task FillCombo()
        {
            var reservs = await _rezervationManager.GetAll();
            comboBox1.DataSource = reservs;
            comboBox1.DisplayMember = "RezervTime";
            comboBox1.ValueMember = "Id";
        }

        private async void btn_add_c_Click(object sender, EventArgs e)
        {
            if (txt_firstName_cust.Text.IsNullOrEmpty() || txt_latname_cust.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Form is not valid!");
                return;

            }
            Customer customer = new()
            {
                FirstName = txt_firstName_cust.Text,
                LastName = txt_latname_cust.Text,
                RezervationId = (int)comboBox1.SelectedValue

            };

            try
            {
                await _customerManager.AddAsync(customer);
                await _customerManager.SaveChangesAsync();
                MessageBox.Show("Customer added succesfully!");
                await FillDataGridAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
        }


        private async Task FillDataGridAsync()
        {

            var data = await _customerManager.GetCustomerDetail();
            List<CustomerViewModel> customerViewModels = new List<CustomerViewModel>();
            foreach (var cust in data)
            {
                customerViewModels.Add(new CustomerViewModel
                {
                    Id = cust.Id,
                    FirstName = cust.FirstName,
                    LastName = cust.LastName,
                });

            }
            dataGridView_main.DataSource = customerViewModels;
        }

        private void lbl_order_Click(object sender, EventArgs e)
        {

        }

        private void lbl_menu_Click(object sender, EventArgs e)
        {

        }

        private void lbl_customer_Click(object sender, EventArgs e)
        {
        }

        private void lbl_employee_Click(object sender, EventArgs e)
        {

        }

        private async void btn_remove_c_Click(object sender, EventArgs e)
        {
            if (dataGridView_main.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;

            }
            CustomerViewModel selectedcust = (CustomerViewModel)dataGridView_main.SelectedRows[0].DataBoundItem;
            var customer = (CustomerViewModel)dataGridView_main.SelectedRows[0].DataBoundItem;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var deletedcust = await _customerManager.GetById(customer.Id);
                    _customerManager.Remove(deletedcust);
                    await _customerManager.SaveChangesAsync();
                    MessageBox.Show("Customer deleted succesfully!");
                    await FillDataGridAsync();



                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured:" + ex.Message);
                }

            }
        }

        private async void btn_update_c_Click(object sender, EventArgs e)
        {
            if (dataGridView_main.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            CustomerViewModel selectedorder = (CustomerViewModel)dataGridView_main.SelectedRows[0].DataBoundItem;

            try
            {
                var upcust = await _customerManager.GetById(selectedorder.Id);
                if (upcust != null)
                {
                    upcust.FirstName = selectedorder.FirstName;
                    upcust.LastName = selectedorder.LastName;
                   

                    _customerManager.Update(upcust);
                    await _customerManager.SaveChangesAsync();
                    MessageBox.Show("Customer updated successfully");
                    await FillDataGridAsync();
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void dataGridView_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menyu men = new();
            men.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Emp em = new();
            em.Show();
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
