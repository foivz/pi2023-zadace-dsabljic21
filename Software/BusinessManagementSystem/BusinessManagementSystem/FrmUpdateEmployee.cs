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
    public partial class FrmUpdateEmployee : Form {
        private Employee employee;
        public FrmUpdateEmployee(Models.Employee selectedEmployee) {
            InitializeComponent();
            employee = selectedEmployee;
        }

        private void FrmUpdateEmployee_Load(object sender, EventArgs e) {
            SetFormText();
            var administrators = AdministratorRepository.GetAdministrators();
            cboAdministrator.DataSource = administrators;
        }

        private void SetFormText() {
            Text = employee.FirstName + " " + employee.LastName;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
