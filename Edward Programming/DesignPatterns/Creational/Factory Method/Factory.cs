using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory_Method
{
    public interface IProduct 
    {
        string Operation();
    }

    public class ConcreteProductA : IProduct
    { 
        public string Operation()
        {
            return "This is Product A";
        }
    }

    public class ConcreteProductB : IProduct
    {
        public string Operation()
        {
            return "This is Product B";
        }
    }

    public abstract class Creator
    {
        public abstract IProduct Product();

        public string SomeMethod()
        {
            return "MEOW "+Product().Operation();
        }
    }

    public class ConcreteCreatorA : Creator
    {
        public override IProduct Product()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override IProduct Product()
        {
            return new ConcreteProductB();
        }
    }
}
