using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapua_Programming.Aggregation
{
    internal class Address
    {
        public int no;
        private string city;
        public string City
        {
            get { return city; }
        }

        private string country;

        public string Country
        {
            get { return country; }
        }

        public Address(string _city, string country)
        {
            this.city = _city;
            this.country = country;
        }
    }
}
