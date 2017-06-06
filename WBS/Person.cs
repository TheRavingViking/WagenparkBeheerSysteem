using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBS
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string DriversLicense { get; set; }
        public string DateOfExpiry { get; set; }
        public string Firstname { get; internal set; }
        public string Lastname { get; internal set; }

        public Person(
            string firstName = null,
            string lastName = null,
            string gender = null,
            string birthday = null,
            string driversLicense = null,
            string dateOfExpiry = null
            )
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Birthday = birthday;
            DriversLicense = driversLicense;
            DateOfExpiry = dateOfExpiry;
        }

        public string CheckLicense()
        {
            string date = DateOfExpiry;
            DateTime dt = Convert.ToDateTime(date);
            DateTime year = DateTime.Now;

            if (dt >= year)
            {
                return "Valid";
            }
            else
            {
                return "Expired";
            }
            
        }

    }
}


