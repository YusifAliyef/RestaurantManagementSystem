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
    public partial class Ord : Form
    {
        private readonly OrdersManager _manager;
        private readonly ICustomerManager _customerManager;
        public Ord()
        {
            InitializeComponent();
            _manager = new OrdersManager();
            _customerManager = new CustomerManager();

        }

        private async void Ord_Load(object sender, EventArgs e)
        {
            await FillDataGridAsync();
            await FillCombo();
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

        private void lbl_rezervation_Click(object sender, EventArgs e)
        {
        }

        private async void btn_add_c_Click(object sender, EventArgs e)
        {
            if (txt_ordername.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Form is not valid");
                return;
            }
            Orders orders = new()
            {
                TotalOrder = txt_ordername.Text,

                OrderNumbers = Convert.ToInt32(txt_ordernumber.Text),
                TotalPrice = Convert.ToInt32(txt_orderprice.Text),
                CustomerId = (int)cmb_cust.SelectedValue,
            };
            try
            {
                await _manager.AddAcync(orders);
                await _manager.SaveChangesAsync();
                await FillDataGridAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private async Task FillDataGridAsync()
        {
            var das = await _manager.GetOrdersDetail();
            List<OrderViewModel> bus = new List<OrderViewModel>();
            foreach (var d in das)
            {
                bus.Add(new OrderViewModel
                {
                    Id = d.Id,
                    OrderName = d.TotalOrder,
                    OrderNumber = d.OrderNumbers,
                    OrderPrice = d.TotalPrice,

                });



            }
            dataGridView_ord.DataSource = bus;



        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async Task FillCombo()
        {
            var emps = await _customerManager.GetAllAsync();
            cmb_cust.DataSource = emps;
            cmb_cust.DisplayMember = "Customer";
            cmb_cust.ValueMember = "Id";


        }

        private async void btn_remove_c_Click(object sender, EventArgs e)
        {

            if (dataGridView_ord.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;

            }
            OrderViewModel selectedord = (OrderViewModel)dataGridView_ord.SelectedRows[0].DataBoundItem;
            var order = (OrderViewModel)dataGridView_ord.SelectedRows[0].DataBoundItem;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var selectedordd = await _manager.GetById(order.Id);
                    _manager.Remove(selectedordd);
                    await _manager.SaveChangesAsync();
                    MessageBox.Show("Order deleted succesfully!");
                    await FillDataGridAsync();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Order deleted succesfully!");

                }





            }
        }

        private void txt_ordername_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_cust_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menyu menyu = new();
            menyu.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage mao = new();
            mao.Show();
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Emp mn = new();
            mn.Show();
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

        private async void btn_update_c_Click(object sender, EventArgs e)
        {
            if (dataGridView_ord.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            OrderViewModel selectedorder = (OrderViewModel)dataGridView_ord.SelectedRows[0].DataBoundItem;

            try
            {
                var updatedord = await _manager.GetById(selectedorder.Id);
                if (updatedord != null)
                {
                    updatedord.TotalOrder = selectedorder.OrderName;
                    updatedord.OrderNumbers = selectedorder.OrderNumber;
                    updatedord.TotalPrice = selectedorder.OrderPrice;

                    _manager.Update(updatedord);
                    await _manager.SaveChangesAsync();
                    MessageBox.Show("Order updated successfully");
                    await FillDataGridAsync();
                }
                else
                {
                    MessageBox.Show("Order not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }








        }
    }
    }


