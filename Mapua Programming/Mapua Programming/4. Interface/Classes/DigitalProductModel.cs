using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapua_Programming._4._Interface.Interfaces;

namespace Mapua_Programming._4._Interface.Classes
{
    internal class DigitalProductModel : IDigitalProductModel
    {
        public string Title { get; set; }

        public bool HasOderBeenCompleted { get; private set; } = false;

        public int TotalDownloadsLeft { get;  set; } = 5;

      
        public void ShipItem(CustomerModel customerModel)
        {
            if (!HasOderBeenCompleted)
            {
                Console.WriteLine($"{Title} sent to {customerModel.FirstName}'s email address at {customerModel.EmailAddress}");
                HasOderBeenCompleted = true;
            }
        }
    }
}
