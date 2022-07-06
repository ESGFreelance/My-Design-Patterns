using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapua_Programming._3._Inheritance
{
    internal class Driver : Person
    {
        private double rate;
        private double bonus;

        public Driver(Name _name, int _age, double _rate, double _bonus) : base(_name, _age)
        {
            this.rate = _rate;
            this.bonus = _bonus;
        }

        public double GetGrossPay()
        {
            return (rate * bonus);
        }
    }
}
