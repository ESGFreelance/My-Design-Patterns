using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    //Base Interface
    public interface IPizza
    {
        string GetPizza();
    }

    //Concrete Implementation
    public class Pizza : IPizza
    {
        public string GetPizza()
        {
            return "This is a normal Pizza";
        }
    }

    //Base Decorator
    public class PizzaDecorator : IPizza
    {
        private IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string GetPizza()
        {
            return _pizza.GetPizza();
        }
    }

    //Derived Decorator - cheese, tomato, meat, bacon, etc...
    public class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza ingredient) : base (ingredient)
        {
            
        }

        public override string GetPizza()
        {
            return base.GetPizza()+" with cheese";
        }

    }


}
