using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Models {
    public class Employee : Person {
        public int YearsOfEmployeeExperience{ get; set; }
        public string PIN { get; set; }
        public string BankAccountNumber{ get; set; }
        public string Contact { get; set; }
        public Administrator Administrator { get; set; }
    }
}
