using BusinessManagementSystem.Models;
using BusinessManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BusinessManagementSystem {
    public partial class FrmLogin : Form {

        // string username = "admin";
        // string password = "test";

        public static Administrator LoggedAdministrator { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public FrmLogin() {
            InitializeComponent();
        }

        /// <summary>
        /// Kod prijave provjerava valjanost unosa te podudaraju li se uneseni korisnički 
        /// podaci s onima u bazi podataka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e) {
            if (txtUsername.Text == "") {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtPassword.Text == "") {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else {
                LoggedAdministrator = AdministratorRepository.GetAdministrator(txtUsername.Text);
                if (LoggedAdministrator != null && LoggedAdministrator.CheckPassword(txtPassword.Text)) {
                    FrmEmployees frmStudents = new FrmEmployees();
                    Hide();
                    frmStudents.ShowDialog();
                    Close();
                } else {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }

        }
    }
}
