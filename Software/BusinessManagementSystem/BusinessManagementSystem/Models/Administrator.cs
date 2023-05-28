using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Models {

    public class Administrator : Person {

        public string JobTitle { get; set; }

        /// <summary>
        /// Metoda koja nadjačava ToString metodu.
        /// </summary>
        /// <returns>Vraća imee, prezime i ulogu administratora</returns>
        public override string ToString() {
            return FirstName + " " + LastName + ", " + JobTitle;
        }

        /// <summary>
        /// Metoda za provjeru lozinke administratora.
        /// </summary>
        /// <param name="password">Unesena lozinka</param>
        /// <returns>Logička vrijednost valjanosti unesene lozinke</returns>
        public bool CheckPassword(string password) {
            return Password == password;
        }
    }
}
