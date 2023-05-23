using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessManagementSystem.Models;
using DBLayer;

namespace BusinessManagementSystem.Repositories {
    public class EmployeeRepository {
        public static Employee GetEmployee(int id) {
            Employee employee = null;
            string sql = $"SELECT * FROM Employees WHERE ID_employee = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                employee = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return employee;
        }

        public static List<Employee> GetEmployees() {
            List<Employee> employees = new List<Employee>();
            string sql = "SELECT * FROM Employees";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Employee student = CreateObject(reader);
                employees.Add(student);
            }
            reader.Close();
            DB.CloseConnection();
            return employees;
        }

        private static Employee CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["ID_employee"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            // int yearsOfEmployeeExperience = int.Parse(reader["YearsOfEmployeeExperience"].ToString);
            int.TryParse(reader["YearsOfEmployeeExperience"].ToString(), out int yearsOfEmployeeExperience);
            string pin = reader["PIN"].ToString();
            string bankAccountNumber = reader["BankAccountNumber"].ToString();
            string contact = reader["Contact"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            int adminId = int.Parse(reader["ID_administrator"].ToString());
            Administrator administrator = AdministratorRepository.GetAdministrator(adminId);
            var employee = new Employee {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                YearsOfEmployeeExperience = yearsOfEmployeeExperience,
                Pin = pin,
                BankAccountNumber = bankAccountNumber,
                Contact = contact,
                Username = username,
                Password = password,
                Administrator = administrator
            };
            return employee;
        }
    }
}
