using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapua_Programming._3._Inheritance
{
    internal class Person
    {
        private Name name;

        public Name Name
        {
            get { return name; }
        }

        protected int age;

        public Person(Name _name, int _age)
        {
            this.name = _name;
            this.age = _age;
        }

        public void DisplayAge()
        {
            Console.WriteLine($"Your age is {age}");
        }

    }
}
