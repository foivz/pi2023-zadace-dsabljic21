using BusinessManagementSystem.Models;
using BusinessManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManagementSystem {
    public partial class FrmCreateUpdateEmployee : Form {

        private Employee employee;
        private Administrator administrator;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public FrmCreateUpdateEmployee() {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor koji prima selektiranog zaposlenika kao parametar.
        /// </summary>
        /// <param name="selectedEmployee">Odabrani zaposlenik na glavnoj formi</param>
        public FrmCreateUpdateEmployee(Employee selectedEmployee) {
            InitializeComponent();
            employee = selectedEmployee;
        }

        /// <summary>
        /// Metoda koja ispunjava formu podacima odabranog zaposlenika u slučaju ažuriranja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCreateUpdateEmployee_Load(object sender, EventArgs e) {
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

        /// <summary>
        /// Postavlja tekst/naslov forme ovisno o odabranoj opciji.
        /// </summary>
        private void SetFormText() {
            Text = (employee != null) ? employee.FirstName + " " + employee.LastName : "Unos zaposlenika";
        }


        /// <summary>
        /// Rukuje događajem odabira gumba Odustani i zatvara formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        /// <summary>
        /// Rukuje događajem promjene administratora za odabranog zaposlenika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboAdministrator_SelectedIndexChanged(object sender, EventArgs e) {
            administrator = cboAdministrator.SelectedItem as Administrator;
        }

        /// <summary>
        /// Rukuje događajem odabira opcije spremi kreirajući/ažurirajući 
        /// objekt zaposlenika i spremanjem u bazu podataka. Također provjerava 
        /// valjanost unosa informacija o zaposleniku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e) {
            if (txtFirstName.Text == "") {
                MessageBox.Show("Ime zaposlenika nije uneseno!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else if (txtLastName.Text == "") {
                MessageBox.Show("Prezime zaposlenima nije uneseno!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else if (txtYearsOfEmployeeExperience.Text == "") {
                MessageBox.Show("Radni staž zaposlenika nije unesen!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else if (txtPin.Text == "") {
                MessageBox.Show("OIB zaposlenika nije unesen!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else if (txtBankAccountNumber.Text == "") {
                MessageBox.Show("IBAN zaposlenika nije unesen!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else if (txtContact.Text == "") {
                MessageBox.Show("Kontakt broj zaposlenika nije unesen!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else if (txtAddress.Text == "") {
                MessageBox.Show("Adresa zaposlenika nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else if (txtUsername.Text == "") {
                MessageBox.Show("Korisničko ime zaposlenika nije uneseno!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else if (txtPassword.Text == "") {
                MessageBox.Show("Lozinka zaposlenika nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else {
                if (employee == null) {
                    employee = new Employee();
                }
                employee.FirstName = txtFirstName.Text;
                employee.LastName = txtLastName.Text;
                employee.YearsOfEmployeeExperience = txtYearsOfEmployeeExperience.Text == "" ? 0 : int.Parse(txtYearsOfEmployeeExperience.Text);
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

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
