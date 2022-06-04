using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapua_Programming._4._Interface.Interfaces
{
    internal interface ICustomerModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string StreetAddress { get; set; }
        string City { get; set; }
        string EmailAddress { get; set; }
    }
}
