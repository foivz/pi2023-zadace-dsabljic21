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

        /// <summary>
        /// Konstruktor
        /// </summary>
        public FrmEmployees() {
            InitializeComponent();
        }

        /// <summary>
        /// Poziva metodu za prikaz zaposlenika kod učitavanja forme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEmployees_Load(object sender, EventArgs e) {
            ShowEmployees();
        }

        /// <summary>
        /// Dohvaća sve zaposlenike iz baze te ih pohranjuje u listu koju postavlja kao 
        /// izvor podataka za DataGridView zaposlenika.
        /// </summary>
        private void ShowEmployees() {
            List<Employee> employees = EmployeeRepository.GetEmployees();
            dgvEmployees.DataSource = employees;

            dgvEmployees.Columns["Id"].DisplayIndex = 0;
            dgvEmployees.Columns["FirstName"].DisplayIndex = 1;
            dgvEmployees.Columns["LastName"].DisplayIndex = 2;
            dgvEmployees.Columns["Password"].Visible = false;
        }

        /// <summary>
        /// Rukuje događajem odabira opcije kreiranja novog zaposlenika. Kreira novu 
        /// instancu FrmCreatUpdateEmployee klase te prikazuje formu za unos/ažuriranje zaposlenika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEmployee_Click(object sender, EventArgs e) {
            FrmCreateUpdateEmployee frmCreate = new FrmCreateUpdateEmployee();
            frmCreate.ShowDialog();
            ShowEmployees();
        }

        /// <summary>
        /// Rukuje događajem odabira opcije ažuriranja postojećeg zaposlenika. Kreira novu 
        /// instancu FrmCreatUpdateEmployee klase te prikazuje formu za unos/ažuriranje zaposlenika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateEmployee_Click(object sender, EventArgs e) {
            Employee selectedEmployee = dgvEmployees.CurrentRow.DataBoundItem as Employee;
            if (selectedEmployee != null) {
                FrmCreateUpdateEmployee frmUpdate = new FrmCreateUpdateEmployee(selectedEmployee);
                frmUpdate.ShowDialog();
                ShowEmployees();
            }
        }
        /// <summary>
        /// Rukuje događajem brisanja odabranog zaposlenika. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteEmployee_Click(object sender, EventArgs e) {
            Employee selectedEmployee = dgvEmployees.CurrentRow.DataBoundItem as Employee;
            if (selectedEmployee != null) {
                EmployeeRepository.DeleteEmployee(selectedEmployee);
                ShowEmployees();
            }
        }

        private void lblFilterUsername_Click(object sender, EventArgs e) {

        }

        /// <summary>
        /// Rukuje događajem pretraživanja zaposlenika po korsiničkom imenu 
        /// koje šalje odgovarajućoj metodi. Metoda izvršava upit i vraća listu 
        /// zaposlenika koji zadovoljavaju pretraženo korisničko ime koja se 
        /// postavlja kao izvor podataka za DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilterUsername_Click(object sender, EventArgs e) {
            string username = txtFilterUsername.Text;
            List<Employee> employees = EmployeeRepository.FilterByUsername(username);
            if (employees.Count == 0) {
                MessageBox.Show("Zaposlenik s unesenim korisničkim imenom ne postoji!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else {
                dgvEmployees.DataSource = employees;

                dgvEmployees.Columns["Id"].DisplayIndex = 0;
                dgvEmployees.Columns["FirstName"].DisplayIndex = 1;
                dgvEmployees.Columns["LastName"].DisplayIndex = 2;
                dgvEmployees.Columns["Password"].Visible = false;
            }
        }

        /// <summary>
        /// Rukuje događajem uklanjanja filter tako što osvježava formu prikaza zaposlenika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveFilter_Click(object sender, EventArgs e) {
            ShowEmployees();
        }
    }
}
