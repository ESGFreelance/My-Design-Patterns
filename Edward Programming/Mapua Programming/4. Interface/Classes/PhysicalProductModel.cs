using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapua_Programming._4._Interface.Interfaces;

namespace Mapua_Programming._4._Interface.Classes
{
    internal class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customerModel)
        {
            if (HasOderBeenCompleted == false)
            {
                Console.WriteLine($"Shipped to {customerModel.FirstName} {customerModel.LastName} at {customerModel.StreetAddress} - {customerModel.City}");
            }
        }
    }
}
