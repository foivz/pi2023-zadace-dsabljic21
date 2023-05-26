using System;
using System.Collections.Generic;
using System.Data.Common;
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

        public static void SaveEmployee(Employee employee) {
            string sql = "";
            DB.OpenConnection();
            if (employee.Id == 0)
            {
                sql = $"INSERT INTO Employees (FirstName, LastName, YearsOfEmployeeExperience, PIN, BankAccountNumber, Contact, Address, Password, Username, ID_administrator) VALUES ('{employee.FirstName}', '{employee.LastName}', {employee.YearsOfEmployeeExperience}, '{employee.Pin}', '{employee.BankAccountNumber}', '{employee.Contact}', '{employee.Address}', '{employee.Password}', '{employee.Username}', {employee.Administrator.Id})";
            } else
              {
                sql = $"UPDATE Employees SET FirstName = '{employee.FirstName}', LastName = '{employee.LastName}', YearsOfEmployeeExperience = {employee.YearsOfEmployeeExperience}, PIN = '{employee.Pin}', BankAccountNumber = '{employee.BankAccountNumber}', Contact = '{employee.Contact}', Address = '{employee.Address}', Password = '{employee.Password}', Username = '{employee.Username}', ID_administrator = '{employee.Administrator.Id}' WHERE ID_employee = {employee.Id}";
            }
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteEmployee(Employee employee) {
            string sql = "DELETE FROM Employees WHERE Id_employee = " + employee.Id;
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static List<Employee> FilterByUsername(string username) {
            List<Employee> employees = new List<Employee>();
            string sql = $"SELECT * FROM Employees WHERE Username = '{username}'";
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
            string address = reader["Address"].ToString();
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
                Address = address,
                Contact = contact,
                Username = username,
                Password = password,
                Administrator = administrator
            };
            return employee;
        }
    }
}
