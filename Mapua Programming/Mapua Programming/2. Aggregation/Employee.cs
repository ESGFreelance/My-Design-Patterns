using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapua_Programming.Aggregation
{
    internal class Employee
    {
        private string name;
        private Address address;
        public Address Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }

        public Employee(string _name, Address _address)
        {
            this.name = _name;
            this.address = _address;
        }

        public void DisplayName()
        {
            Console.WriteLine($"Hello {name} you're from {address.no} - {address.City}, {address.Country}");
        }

    }
}
