using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_ClassLibrary
{
    abstract class Person
    {
        public string FirstName;
        public string LastName;

        public Person(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public virtual string toString()
        {
            return "\nFirst Name: " + this.FirstName + " \tLast Name: " + this.LastName;
        }

    }
}
