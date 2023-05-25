﻿using BusinessManagementSystem.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BusinessManagementSystem {
    public partial class FrmUpdateEmployee : Form {

        private Employee employee;
        private Administrator administrator;
        public FrmUpdateEmployee(Models.Employee selectedEmployee) {
            InitializeComponent();
            employee = selectedEmployee;
        }

        private void FrmUpdateEmployee_Load(object sender, EventArgs e) {
            SetFormText();
            var administrators = AdministratorRepository.GetAdministrators();
            cboAdministrator.DataSource = administrators;

            if (employee != null) {
                txtId.Text = employee.Id.ToString();
                txtFirstName.Text = employee.FirstName.ToString();
                txtLastName.Text = employee.LastName.ToString();
                txtYearsOfEmployeeExperience.Text = employee.YearsOfEmployeeExperience.ToString();
                txtPin.Text = employee.Pin.ToString();
                txtBankAccountNumber.Text = employee.BankAccountNumber.ToString();
                txtContact.Text = employee.Contact.ToString();
                txtAddress.Text = employee.Address.ToString();
                txtUsername.Text = employee.Username.ToString();
                txtPassword.Text = employee.Password.ToString();
                cboAdministrator.Text = employee.Administrator.ToString();
            }
        }

        private void SetFormText() {
            Text = employee.FirstName + " " + employee.LastName;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void cboAdministrator_SelectedIndexChanged(object sender, EventArgs e) {
            administrator = cboAdministrator.SelectedItem as Administrator;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (employee == null) {
                employee = new Employee();
            }
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.YearsOfEmployeeExperience = int.Parse(txtYearsOfEmployeeExperience.Text);
            employee.Pin = txtPin.Text;
            employee.BankAccountNumber = txtBankAccountNumber.Text;
            employee.Contact = txtContact.Text;
            employee.Address = txtAddress.Text;
            employee.Username = txtUsername.Text;
            employee.Password = txtPassword.Text;
            employee.Administrator = administrator;
            EmployeeRepository.SaveEmployee(employee);
            Close();
        }
    }
}
