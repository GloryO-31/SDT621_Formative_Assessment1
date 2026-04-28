using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalIdentityProcessor_SectionB_Question_2
{
    internal class CitizenProfile
    {
        // Private field for Encapsulation 
        private string idNumber;

        // Constructor to set the ID
        public CitizenProfile(string id)
        {
            idNumber = id;
        }

        // Method for Gender
        public string GetGender()
        {
            // Getting the 7th character
            string genderPart = idNumber.Substring(6, 1);
            int digit = int.Parse(genderPart);

            if (digit >= 5)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }

        // Simple method for Birth Date
        public string GetDOB()
        {
            string yy = idNumber.Substring(0, 2);
            string mm = idNumber.Substring(2, 2);
            string dd = idNumber.Substring(4, 2);

            // Simple century check
            string year;
            if (int.Parse(yy) < 27)
            {
                year = "20" + yy;
            }
            else
            {
                year = "19" + yy;
            }

            return dd + "/" + mm + "/" + year;
        }
    }
}
