using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapua_Programming._4._Interface.Classes;

namespace Mapua_Programming._4._Interface.Interfaces
{
    internal interface IProductModel
    {
        string Title { get; set; }
        bool HasOderBeenCompleted { get; }

        void ShipItem(CustomerModel customerModel);
    }
}
