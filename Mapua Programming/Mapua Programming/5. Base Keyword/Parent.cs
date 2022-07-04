using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapua_Programming._5._Base_Keyword
{
    public class Parent
    {
        public string value = "Parent";
        public Parent()
        {
            Console.WriteLine("This is a parent");
        }
        public Parent(int inputNumber)
        {
            Console.WriteLine($"The number that you inserted is {inputNumber}");
        }
    }

    public class Child : Parent
    {
        public string value = "Child";
        public Child(int childInputNumber) : base (childInputNumber)
        {
            Console.WriteLine("This is a child constructor!");
            Console.WriteLine(base.value);
            Console.WriteLine(this.value);
        }


    }
}
