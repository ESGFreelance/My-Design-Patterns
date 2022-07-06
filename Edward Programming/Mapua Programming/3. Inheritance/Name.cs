using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapua_Programming._3._Inheritance
{
    internal class Name
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public Name(string _firstName, string _lastName)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
        }

        public string GetName()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
