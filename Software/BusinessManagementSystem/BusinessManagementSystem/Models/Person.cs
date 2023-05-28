using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Models {

    public abstract class Person {
        public int Id { get; set; }

        [DisplayName("Ime")]
        public string FirstName { get; set; }

        [DisplayName("Prezime")]
        public string LastName { get; set; }

        [DisplayName("Korisničko ime")]
        public string Username { get; set; } 
        public string Password { get; set; }

        /// <summary>
        /// Metoda koja nadjačava ToString metodu.
        /// </summary>
        /// <returns>Vraća ime i prezime osobe</returns>
        public override string ToString() {
            return FirstName + " " + LastName;
        }
    }
}
