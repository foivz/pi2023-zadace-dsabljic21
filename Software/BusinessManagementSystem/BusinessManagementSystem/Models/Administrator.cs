using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Models {
    public class Administrator : Person {

        public string JobTitle { get; set; }

        public override string ToString() {
            return FirstName + " " + LastName + ", " + JobTitle;
        }
    }
}
