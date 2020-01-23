using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string GetFullName()
        {
            string fullname = FirstName + " " + LastName;
            return fullname;
        }

        public bool IsAdult()
        {
            if (Age >= 18)
            {
                return true;
            }
            return false;
        }

        public Person() { }

    }
}
