using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template_Method
{
    public abstract class Template
    {
        // The template method defines the skeleton of an algorithm.
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOperations1();
            this.BaseOperation2();
            this.Hook1();
            this.RequiredOperations2();
            this.BaseOperation3();
            this.Hook2();
        }

        // These operations already have implementations.
        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass BaseOperation1");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass BaseOperation2");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass BaseOperation3");
        }

        // These operations have to be implemented in subclasses.
        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperations2();

        // These are "hooks." Subclasses may override them, but it's not
        // mandatory since the hooks already have default (but empty)
        // implementation. Hooks provide additional extension points in some
        // crucial places of the algorithm.
        protected virtual void Hook1() 
        {
            Console.WriteLine("Hook 1 that may be overrided - This is a virtual method");
        }

        protected virtual void Hook2() 
        { 
            Console.WriteLine("Hook 2 that may be overrided - This is a virtual method"); 
        }

    }

    public class ConcreteTemplateClassA : Template
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine($"{nameof(ConcreteTemplateClassA)} - {nameof(RequiredOperations1)}");
        }
        protected override void RequiredOperations2()
        {
            Console.WriteLine($"{nameof(ConcreteTemplateClassA)} - {nameof(RequiredOperations2)}");
        }
    }

    public class ConcreteTemplateClassB : Template
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine($"{nameof(ConcreteTemplateClassB)} - {nameof(RequiredOperations1)}");
        }
        protected override void RequiredOperations2()
        {
            Console.WriteLine($"{nameof(ConcreteTemplateClassB)} - {nameof(RequiredOperations2)}");
        }

        protected override void Hook1()
        {
            Console.WriteLine($"{nameof(ConcreteTemplateClassB)} - I overrided {nameof(Hook1)}");
        }
        protected override void Hook2()
        {
            Console.WriteLine($"{nameof(ConcreteTemplateClassB)} - I overrided {nameof(Hook1)}");
        }
    }

    public class Client_TemplateMethod
    {
        public static void ExecuteTemplate(Template template)
        {
            template.TemplateMethod();
        }
    }

}
