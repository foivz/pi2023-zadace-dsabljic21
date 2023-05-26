using BusinessManagementSystem.Models;
using BusinessManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManagementSystem {
    public partial class FrmEmployees : Form {
        public FrmEmployees() {
            InitializeComponent();
        }

        private void FrmEmployees_Load(object sender, EventArgs e) {
            ShowEmployees();
        }

        private void ShowEmployees() {
            List<Employee> employees = EmployeeRepository.GetEmployees();
            dgvEmployees.DataSource = employees;

            dgvEmployees.Columns["Id"].DisplayIndex = 0;
            dgvEmployees.Columns["FirstName"].DisplayIndex = 1;
            dgvEmployees.Columns["LastName"].DisplayIndex = 2;
            dgvEmployees.Columns["Password"].Visible = false;
        }
        private void btnCreateEmployee_Click(object sender, EventArgs e) {
            FrmCreateUpdateEmployee frmCreate = new FrmCreateUpdateEmployee();
            frmCreate.ShowDialog();
            ShowEmployees();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e) {
            Employee selectedEmployee = dgvEmployees.CurrentRow.DataBoundItem as Employee;
            if (selectedEmployee != null) {
                FrmCreateUpdateEmployee frmUpdate = new FrmCreateUpdateEmployee(selectedEmployee);
                frmUpdate.ShowDialog();
                ShowEmployees();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e) {
            Employee selectedEmployee = dgvEmployees.CurrentRow.DataBoundItem as Employee;
            if (selectedEmployee != null) {
                EmployeeRepository.DeleteEmployee(selectedEmployee);
                ShowEmployees();
            }
        }

        private void lblFilterUsername_Click(object sender, EventArgs e) {

        }

        private void btnFilterUsername_Click(object sender, EventArgs e) {
            string username = txtFilterUsername.Text;
            List<Employee> employees = EmployeeRepository.FilterByUsername(username);
            dgvEmployees.DataSource = employees;

            dgvEmployees.Columns["Id"].DisplayIndex = 0;
            dgvEmployees.Columns["FirstName"].DisplayIndex = 1;
            dgvEmployees.Columns["LastName"].DisplayIndex = 2;
            dgvEmployees.Columns["Password"].Visible = false;
        }

        private void btnRemoveFilter_Click(object sender, EventArgs e) {
            ShowEmployees();
        }
    }
}
