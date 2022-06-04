using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapua_Programming._4._Interface.Interfaces
{
    internal interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get;  set; }
    }
}
