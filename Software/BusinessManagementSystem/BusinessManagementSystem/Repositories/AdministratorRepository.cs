using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessManagementSystem.Models;
using DBLayer;

namespace BusinessManagementSystem.Repositories {
    public class AdministratorRepository {

        public static Administrator GetAdministrator(int id) {
            Administrator administrator= null;
            string sql = $"SELECT * FROM Administrators WHERE ID_administrator = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
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
