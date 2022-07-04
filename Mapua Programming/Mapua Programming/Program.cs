using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapua_Programming
{
    #region References
    using Mapua_Programming._1._Basic;
    using Mapua_Programming.Aggregation;
    using Mapua_Programming._3._Inheritance;
    using Mapua_Programming._4._Interface.Classes;
    using Mapua_Programming._4._Interface.Interfaces;
    using DesignPatterns.Creational.Singleton;
    using DesignPatterns.Creational.Factory_Method;
    using Mapua_Programming._5._Base_Keyword;
    using DesignPatterns.Structural.Decorator;
    using DesignPatterns.Behavioral.Template_Method;
    #endregion

    class TEMPLATE_Main
    {
        static void Main(string[] args)
        {
            Console.Read();
        }
    }

    class MAIN_TUTORIAL_Basic
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student();
            firstStudent.name = "Edward Garcia";

            char[] c = firstStudent.name.ToCharArray();
            Array.Reverse(c);
            Console.WriteLine(new String(c));

            Console.WriteLine("MANUAL\n");
            //Console.WriteLine(firstStudent.name.Length);
            for (int currentPosition = 0; currentPosition <= firstStudent.name.Length - 1; currentPosition++)
            {
                Console.Write(firstStudent.name[currentPosition]);
            }

            var g = firstStudent.name.ToList().OrderByDescending(x => x.ToString());

            Console.WriteLine(g.Min());

            string words = "hello";
            byte[] m = Encoding.ASCII.GetBytes(words);
            Console.WriteLine(m.ToList().Min());
            //Console.WriteLine(((char)m.ToList().Min()).ToString());
            Console.WriteLine(m.Min());
            Console.WriteLine(((char)m.Min()));


            firstStudent.course = "IT-101";
            firstStudent.DisplayDetails();
            Console.ReadLine();
        }
    }

    class MAIN_TUTORIAL_Aggregation
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Edward Garcia", new Address("Makati", "Philippines"));
            employee.Address.no = 55;
            employee.DisplayName();
            Console.Read();
        }
    }

    class MAIN_TUTORIAL_Inheritance
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver(new Name("Edward", "Garcia"), 23, 1.33, 3.14);
            Console.WriteLine($"Hello {driver.Name.GetName()}\nYour Gross Pay is {driver.GetGrossPay()}");
            driver.DisplayAge();
            Console.Read();
        }
    }

    class MAIN_TUTORIAL_Interface
    {
        static void Main(string[] args)
        {

            List<IProductModel> cartProducts = AddSampleData();
            CustomerModel customer = AddSampleCustomer();
            DigitalProductModel dpm = new DigitalProductModel();
            foreach (IProductModel item in cartProducts)
            {
                item.ShipItem(customer);

                if (item is IDigitalProductModel digital)
                {
                    dpm.TotalDownloadsLeft -= 1;
                    Console.WriteLine($"For the { digital.Title } you have { dpm.TotalDownloadsLeft } downloads left.");
                }

            }
            Console.Read();

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
            sampleData.Add(new PhysicalProductModel { Title = "Computer Keyboard" });
            sampleData.Add(new PhysicalProductModel { Title = "Mousepad and Mouse" });
            sampleData.Add(new DigitalProductModel { Title = "MS Office 365 " });
            sampleData.Add(new DigitalProductModel { Title = "MS Visio 123 Professional" });
            sampleData.Add(new DigitalProductModel { Title = "MS Visio 123 Professional" });
            sampleData.Add(new CourseProductModel { Title = "IT101 - Introduction to Computers" });
            sampleData.Add(new CourseProductModel { Title = "IT132 - Introduction to Networking" });
            return sampleData;
        }


    }

    class MAIN_TUTORIAL_BaseKeyword
    {
        static void Main(string[] args)
        {
            Child baseChild = new Child(5);
            Console.Read();
        }
    }

    class MAIN_DesignPatterns
    {
        class Behavioral 
        {
            class PATTERN_TemplateMethod 
            {
                static void Main(string[] args)
                {
                    ClientTemplate.ClientProcess(new ConcreteClassB());

                    Console.WriteLine();

                    ClientTemplate.ClientProcess(new ConcreteClassA());

                    Console.Read();
                }
            }
        }

        class Structural
        {
            class PATTERN_Decorator
            {
                static void Main(string[] args)
                {
                    IPizza pizza = new Pizza();
                    IPizza tomatorDecorator = new TomatoDecorator(pizza);
                    IPizza meatDecorator = new MeatDecorator(tomatorDecorator);
                    IPizza baconDecorator = new BaconDecorator(meatDecorator);
                    PizzaDecorator pizzaDecorator = new PizzaDecorator(pizza);
                    Console.WriteLine(baconDecorator.GetPizza());
                    Console.WriteLine(pizzaDecorator.GetPizza());
                    Console.Read();
                }
            }
        }

        class Creational
        {
            class PATTERN_Singleton
            {
                static void Main(string[] args)
                {
                    Singleton obj1 = Singleton.GetInstance();
                    Singleton obj2 = Singleton.GetInstance();
                    Console.WriteLine($"{obj1.GetHashCode()}\n{obj2.GetHashCode()}");
                    Console.Read();
                }
            }

            class PATTERN_FactoryMethod
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("App: Launched with the ConcreteCreator1.");
                    ClientCode(new ConcreteCreatorA());

                    Console.WriteLine("App: Launched with the ConcreteCreator2.");
                    ClientCode(new ConcreteCreatorB());

                    var objA = new ConcreteCreatorA();
                    Console.WriteLine(objA.SomeMethod());
                    Console.Read();
                }
                static void ClientCode(Creator creator)
                {
                    Console.WriteLine("Client: I'm not aware of the creator's class," +
                        "but it still works.\n" + creator.SomeMethod());
                }
            }
        }
    }

}
