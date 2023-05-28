using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessManagementSystem.Models;
using DBLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BusinessManagementSystem.Repositories {

    public class AdministratorRepository {

        /// <summary>
        /// Dohvaća administratora s danim korisničkim imenom.
        /// </summary>
        /// <param name="username">Korisničko ime administratora</param>
        /// <returns>Objekt administratora s danim korisničkim imenom</returns>
        public static Administrator GetAdministrator(string username) {
            string sql = $"SELECT * FROM Administrators WHERE Username = '{username}'";
            return FetchAdministrator(sql);
        }

        /// <summary>
        /// Dohvaća administratora s danim ID-em.
        /// </summary>
        /// <param name="id">ID administratora</param>
        /// <returns>Objekt administratora s danim ID-em</returns>
        public static Administrator GetAdministrator(int id) {
            string sql = $"SELECT * FROM Administrators WHERE ID_administrator = {id}";
            return FetchAdministrator(sql);
        }

        /// <summary>
        /// Dohvaća administratora izvršavanjem danog sql upita.
        /// </summary>
        /// <param name="sql">sql upit nad tablicom Administrators</param>
        /// <returns>Objekt klase Administrator</returns>
        private static Administrator FetchAdministrator(string sql) {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Administrator administrator = null;
            if (reader.HasRows) {
                reader.Read();
                administrator = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return administrator;
        }

        /// <summary>
        /// Dohvaća sve administratore iz baze i vraća ih u obliku generičke liste.
        /// </summary>
        /// <returns>Lista administratora</returns>
        public static List<Administrator> GetAdministrators() {
            List<Administrator> administrtors = new List<Administrator>();
            string sql = "SELECT * FROM Administrators";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Administrator administrator = CreateObject(reader);
                administrtors.Add(administrator);
            }
            reader.Close();
            DB.CloseConnection();
            return administrtors;
        }

        /// <summary>
        /// Kreira novu instancu klase Administrator.
        /// </summary>
        /// <param name="reader">Reader objekt sa podacima zaposlenika</param>
        /// <returns>Vraća kreirani objekt administratora</returns>
        private static Administrator CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["ID_administrator"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            string jobTitle = reader["JobTitle"].ToString();
            var administrator = new Administrator {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password,
                JobTitle = jobTitle
            };
            return administrator;
        }
    }
}
