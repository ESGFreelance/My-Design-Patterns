using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapua_Programming._4._Interface.Interfaces;

namespace Mapua_Programming._4._Interface.Classes
{
    internal class CourseProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customerModel)
        {
            Console.WriteLine($"{Title} course link sent to {customerModel.EmailAddress}");
        }
    }
}
