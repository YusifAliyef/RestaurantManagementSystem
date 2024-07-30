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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Emp : Form
    {
        private readonly EmployeeManager _employeeManager;
        public Emp()
        {
            InitializeComponent();
            _employeeManager = new EmployeeManager();
        }

        private void lbl_menu_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_order_Click(object sender, EventArgs e)
        {

        }

        private void lbl_customer_Click(object sender, EventArgs e)
        {

        }

        private void lbl_rezervation_Click(object sender, EventArgs e)
        {
        }

        private async void btn_add_c_Click(object sender, EventArgs e)
        {
            if (txt_firstname.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Form is not valid!");
                return;


            }
            Employee employee = new()
            {
                FirstName = txt_firstname.Text,
                LastName = txt_lastname.Text,
                Age = Convert.ToInt32(txt_age.Text),
                Salary = Convert.ToInt32(txt_salary.Text),
                Experience = Convert.ToInt32(txt_experience.Text),


            };
            try
            {
                await _employeeManager.AddAcync(employee);
                await _employeeManager.SaveChangesAsync();
                MessageBox.Show("Employee added succesfully!");
                await FillDateGridAsync();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        private async Task FillDateGridAsync()
        {

            var datas = await _employeeManager.GetEmpDetail();
            List<EmpViewModel> data = new List<EmpViewModel>();
            foreach (var d in datas)
            {
                data.Add(new EmpViewModel
                {
                    Id = d.Id,
                    FirstName = d.FirstName,
                    LastName = d.LastName,
                    Age = Convert.ToInt32(d.Age),
                    Salary = Convert.ToInt32(d.Salary),
                    Experience = Convert.ToInt32(d.Experience),
                });

            }
            dataGridView_emp.DataSource = data;

        }

        private async void dataGridView_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dataGridView_emp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btn_remove_c_Click(object sender, EventArgs e)
        {
            if (dataGridView_emp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;

            }
            EmpViewModel selectedRezerv = (EmpViewModel)dataGridView_emp.SelectedRows[0].DataBoundItem;
            var employee = (EmpViewModel)dataGridView_emp.SelectedRows[0].DataBoundItem;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var deletedemp = await _employeeManager.GetById(employee.Id);
                    _employeeManager.Remove(deletedemp);
                    await _employeeManager.SaveChangesAsync();
                    MessageBox.Show("Employee deleted succesfully!");
                    await FillDateGridAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured:" + ex.Message);
                }
            }


        }

        private async void Emp_Load(object sender, EventArgs e)
        {
            await FillDateGridAsync();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btn_update_c_Click(object sender, EventArgs e)
        {
            if (dataGridView_emp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            EmpViewModel selectedorder = (EmpViewModel)dataGridView_emp.SelectedRows[0].DataBoundItem;

            try
            {
                var upemp = await _employeeManager.GetById(selectedorder.Id);
                if (upemp != null)
                {
                    upemp.FirstName = selectedorder.FirstName;
                    upemp.LastName = selectedorder.LastName;
                    upemp.Age = selectedorder.Age;
                    upemp.Salary = selectedorder.Salary;
                    upemp.Experience = selectedorder.Experience;

                    _employeeManager.Update(upemp);
                    await _employeeManager.SaveChangesAsync();
                    MessageBox.Show("Employee updated successfully");
                    await FillDateGridAsync();
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Menyu men = new();
            men.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage mpg = new();
            mpg.Show();
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

            Rezerv rez = new();
            rez.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
