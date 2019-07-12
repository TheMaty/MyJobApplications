using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJobApplication
{
    public class CompanyContact
    {
        public string FullName {
            get
            {
                return FirstName + (MiddleName != string.Empty ? " " + MiddleName : "") + " " + LastName;
            }
        }

        public int ID;
        public string FirstName;
        public string LastName;
        public string MiddleName;

        public CompanyContact()
        {

        }

    }
}
