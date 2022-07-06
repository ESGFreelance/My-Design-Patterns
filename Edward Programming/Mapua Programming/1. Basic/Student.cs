using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapua_Programming._1._Basic
{
    internal class Student
    {
        public string name;
        public string course;

        public void DisplayDetails()
        {
            Console.WriteLine($"Hello {name}, your course is {course}");
        }
    }
}
