using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapua_Programming._4._Interface.Interfaces;

namespace Mapua_Programming._4._Interface.Classes
{
    internal class CustomerModel : ICustomerModel
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string PhoneNumber {get;set;}
        public string StreetAddress {get;set;}
        public string City {get;set;}
        public string EmailAddress {get;set;}
    }
}
