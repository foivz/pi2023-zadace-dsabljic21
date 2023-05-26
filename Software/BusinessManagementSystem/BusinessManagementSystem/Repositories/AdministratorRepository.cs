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
        public static Administrator GetAdministrator(string username) {
            string sql = $"SELECT * FROM Administrators WHERE Username = '{username}'";
            return FetchAdministrator(sql);
        }

        public static Administrator GetAdministrator(int id) {
            string sql = $"SELECT * FROM Administrators WHERE ID_administrator = {id}";
            return FetchAdministrator(sql);
        }

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
