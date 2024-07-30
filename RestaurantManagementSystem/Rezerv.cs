using Microsoft.IdentityModel.Tokens;
using RestaurantManagementSystem.Entities;
using RestaurantManagementSystem.Managers;
using RestaurantManagementSystem.Mocdels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RestaurantManagementSystem
{
    public partial class Rezerv : Form
    {
        private readonly RezervationManager _rezervManager;
        public Rezerv()
        {
            InitializeComponent();
            _rezervManager = new RezervationManager();
        }

        private void lbl_rezervation_Click(object sender, EventArgs e)
        {
            Rezerv rezerv = new();
            rezerv.Show();
            Close();
        }

        private async void Rezerv_Load(object sender, EventArgs e)
        {
            await FillDataGridAsync();
        }

        private async void btn_add_c_Click(object sender, EventArgs e)
        {
            if (txt_tablenumber.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Form is not valid");
                return;
            }
            Rezervation rezervation = new()
            {
                TableNumber = Convert.ToInt32(txt_tablenumber.Text),
                RezervTime = Convert.ToDateTime(txt_time.Text),

            };
            try
            {
                await _rezervManager.AddAcync(rezervation);
                await _rezervManager.SaveChangesAsync();
                MessageBox.Show("Rezervation added succesfully!");
                await FillDataGridAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task FillDataGridAsync()
        {
            var datas = await _rezervManager.GetRezervdetail();
            List<RezervViewModel> data = new List<RezervViewModel>();
            foreach (var dataItem in datas)
            {
                data.Add(new RezervViewModel
                {
                    Id = dataItem.Id,
                    RezervTime = dataItem.RezervTime,
                    TableNumber = dataItem.TableNumber,

                });
            }
            dataGridView_rezerv.DataSource = data;
        }

        private async void btn_remove_c_Click(object sender, EventArgs e)
        {
            if (dataGridView_rezerv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;

            }
            RezervViewModel selectedRezerv = (RezervViewModel)dataGridView_rezerv.SelectedRows[0].DataBoundItem;
            var rezervation = (RezervViewModel)dataGridView_rezerv.SelectedRows[0].DataBoundItem;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this reserve?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var deletedReserv = await _rezervManager.GetById(rezervation.Id);
                    _rezervManager.Remove(deletedReserv);
                    await _rezervManager.SaveChangesAsync();
                    MessageBox.Show("Reservation deleted succesfully!");
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
            if (dataGridView_rezerv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            RezervViewModel selectedRezerv = (RezervViewModel)dataGridView_rezerv.SelectedRows[0].DataBoundItem;

            try
            {
                var updatedRezerv = await _rezervManager.GetById(selectedRezerv.Id);
                if (updatedRezerv != null)
                {
                    updatedRezerv.TableNumber = selectedRezerv.TableNumber;
                    updatedRezerv.RezervTime = selectedRezerv.RezervTime;

                    _rezervManager.Update(updatedRezerv);
                    await _rezervManager.SaveChangesAsync();
                    MessageBox.Show("Reservation updated successfully");
                    await FillDataGridAsync();

                }
                else
                {
                    MessageBox.Show("Reservation not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lbl_menu_Click(object sender, EventArgs e)
        {

        }

        private void lbl_order_Click(object sender, EventArgs e)
        {
        }

        private void lbl_customer_Click(object sender, EventArgs e)
        {

        }

        private void lbl_employee_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView_rezerv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
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
            MainPage mainPage = new();
            mainPage.Show();
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

            Ord od = new();
            od.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
