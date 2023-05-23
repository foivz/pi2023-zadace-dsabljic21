using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Models {
    public class Employee : Person {

        [DisplayName("Godine staža")]
        public int YearsOfEmployeeExperience{ get; set; }
        [DisplayName("OIB")]
        public string Pin { get; set; }
        [DisplayName("IBAN")]
        public string BankAccountNumber{ get; set; }
        [DisplayName("Kontakt")]
        public string Contact { get; set; }
        [DisplayName("Nadređena osoba")]
        public Administrator Administrator { get; set; }
    }
}
