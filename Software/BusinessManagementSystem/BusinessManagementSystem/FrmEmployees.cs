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
            List<Employee> students = EmployeeRepository.GetEmployees();
            dgvEmployees.DataSource = students;

            dgvEmployees.Columns["Id"].DisplayIndex = 0;
            dgvEmployees.Columns["FirstName"].DisplayIndex = 1;
            dgvEmployees.Columns["LastName"].DisplayIndex = 2;
            dgvEmployees.Columns["Password"].Visible = false;
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e) {
            Employee selectedEmployee = dgvEmployees.CurrentRow.DataBoundItem as Employee;
            if (selectedEmployee != null) {
                FrmUpdateEmployee frmEvaluation = new FrmUpdateEmployee(selectedEmployee);
                frmEvaluation.ShowDialog();
            }

        }
    }
}
