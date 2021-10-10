using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ_8
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LasteName { get; set; }

        public string MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }


        public Person(string firstName, string lastename, string middlename, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LasteName = lastename;
            this.MiddleName = middlename;
            this.DateOfBirth = dateOfBirth;
        }


        public Person()
        {

        }

    }
}
