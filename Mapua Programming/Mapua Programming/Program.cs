using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapua_Programming
{
    using Mapua_Programming._1._Basic;
    using Mapua_Programming.Aggregation;
    using Mapua_Programming._3._Inheritance;
    using Mapua_Programming._4._Interface.Classes;
    using Mapua_Programming._4._Interface.Interfaces;
    using DesignPatterns.Creational.Singleton;
    using DesignPatterns.Creational.Factory_Method;
    using Mapua_Programming._5._Base_Keyword;
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region 1. Basic
            //Student firstStudent = new Student();
            //firstStudent.name = "Edward Garcia";

            //char[] c = firstStudent.name.ToCharArray();
            //Array.Reverse(c);
            //Console.WriteLine(new String(c));

            //Console.WriteLine("MANUAL\n");
            ////Console.WriteLine(firstStudent.name.Length);
            //for (int currentPosition = 0; currentPosition <= firstStudent.name.Length-1; currentPosition++)
            //{
            //    Console.Write(firstStudent.name[currentPosition]);
            //}

            //var g = firstStudent.name.ToList().OrderByDescending(x=>x.ToString());

            //Console.WriteLine(g.Min());

            //string words = "hello";
            //byte[] m = Encoding.ASCII.GetBytes(words);
            //Console.WriteLine(m.ToList().Min());
            ////Console.WriteLine(((char)m.ToList().Min()).ToString());
            //Console.WriteLine(m.Min());
            //Console.WriteLine(((char)m.Min()));


            //firstStudent.course = "IT-101";
            //firstStudent.DisplayDetails();
            //#endregion

            //#region 2. Aggregation
            //Employee employee = new Employee("Edward Garcia", new Address("Makati","Philippines"));
            //employee.Address.no = 55;
            //employee.DisplayName();
            //#endregion

            //#region 3. Inheritance
            //Driver driver = new Driver(new Name("Edward","Garcia"),23,1.33, 3.14);
            //Console.WriteLine($"Hello {driver.Name.GetName()}\nYour Gross Pay is {driver.GetGrossPay()}");
            //driver.DisplayAge();
            //#endregion

            //#region 4. Interface
            //List<IProductModel> cartProducts = AddSampleData();
            //CustomerModel customer = AddSampleCustomer();
            //DigitalProductModel dpm = new DigitalProductModel();
            //foreach (IProductModel item in cartProducts)
            //{
            //    item.ShipItem(customer);

            //    if (item is IDigitalProductModel digital)
            //    {
            //        dpm.TotalDownloadsLeft -= 1;
            //        Console.WriteLine($"For the { digital.Title } you have { dpm.TotalDownloadsLeft } downloads left.");
            //    }

            //}
            //#endregion

            //#region Design Patterns

            //#region Creational Patterns

            //    #region Singleton
            //        Singleton obj1 = Singleton.GetInstance();
            //        Singleton obj2 = Singleton.GetInstance();
            //        Console.WriteLine($"{obj1.GetHashCode()}\n{obj2.GetHashCode()}");
            //    #endregion

            //    #region Factory Method
            //        Console.WriteLine("App: Launched with the ConcreteCreator1.");
            //        ClientCode(new ConcreteCreatorA());

            //        Console.WriteLine("App: Launched with the ConcreteCreator2.");
            //        ClientCode(new ConcreteCreatorB());

            //var objA = new ConcreteCreatorA();
            //Console.WriteLine(objA.SomeMethod());

            //    #endregion

            //#endregion

            //#region Behavioral Patterns
            //#endregion

            //#region Structural Patterns
            //#endregion

            //#endregion

            #region 5. Base Keyword
            Child c = new Child(5);
            #endregion

            #region --Terminator--
            Console.Read();
            #endregion
        }

        private static CustomerModel AddSampleCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Edward",
                LastName = "Garcia",
                EmailAddress = "IAm@EdwardGarcia.tech",
                PhoneNumber = "+639311091104",
                City = "Makati City, National Capital Region",
                StreetAddress = "G-7 Progreso 1 Street Barangay Guadalupe Viejo"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> sampleData = new List<IProductModel>();
            sampleData.Add(new PhysicalProductModel { Title = "Computer Keyboard"});
            sampleData.Add(new PhysicalProductModel { Title = "Mousepad and Mouse" });
            sampleData.Add(new DigitalProductModel { Title = "MS Office 365 " });
            sampleData.Add(new DigitalProductModel { Title = "MS Visio 123 Professional" });
            sampleData.Add(new DigitalProductModel { Title = "MS Visio 123 Professional" });
            sampleData.Add(new CourseProductModel { Title = "IT101 - Introduction to Computers" });
            sampleData.Add(new CourseProductModel { Title = "IT132 - Introduction to Networking" });
            return sampleData;
        }


        static void ClientCode(Creator creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeMethod());
            // ...
        }

    }

}
