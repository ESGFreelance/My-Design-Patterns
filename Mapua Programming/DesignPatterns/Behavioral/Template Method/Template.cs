using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template_Method
{
    public abstract class Template
    {
        public void SkeletonMethod()
        {
            this.Operation1();
            this.Operation2();
            this.Process1();
            this.DoSomething();
            this.FinalizeData();
        }

        protected void Operation1()
        {
            Console.WriteLine(nameof(Operation1));
        }

        protected void Operation2()
        {
            Console.WriteLine(nameof(Operation2));
        }

        protected abstract void DoSomething();

        protected abstract void FinalizeData();

        protected virtual void Process1()
        {
            
        }

    }

    public class ConcreteClassA : Template
    {
        protected override void DoSomething()
        {
            Console.WriteLine("Concrete Class A DoSomething()");
        }

        protected override void FinalizeData()
        {
            Console.WriteLine("Concrete Class A FinalizeData()");
        }
    }

    public class ConcreteClassB : Template
    {
        protected override void DoSomething()
        {
            Console.WriteLine("Concrete Class B DoSomething()");
        }

        protected override void FinalizeData()
        {
            Console.WriteLine("Concrete Class B FinalizeData()");
        }

        protected override void Process1()
        {
            Console.WriteLine("This is a process 1 for CCB");
        }
    }

    public class ClientTemplate
    {
        public static void ClientProcess(Template templateMethod)
        {
            templateMethod.SkeletonMethod();
        }
    }


}
