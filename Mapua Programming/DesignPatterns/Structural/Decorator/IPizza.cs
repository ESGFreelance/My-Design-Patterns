using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    //Component
    public interface IPizza
    {
        string GetPizza();
    }

    //ConcreteComponent
    public class Pizza : IPizza
    {
        public string GetPizza()
        {
            return "Normal Pizza";
        }
    }

    //Creator
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

    //ConcreteCreator - Tomato - Meat - Bacon
    public class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string GetPizza()
        {
            return base.GetPizza() + " w/ Tomato";
        }
    }

    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string GetPizza()
        {
            return base.GetPizza() + " w/ Bacon";
        }
    }

    public class MeatDecorator : PizzaDecorator
    {
        public MeatDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string GetPizza()
        {
            return base.GetPizza() + " w/ Meat";
        }
    }


}
