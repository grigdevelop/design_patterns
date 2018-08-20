using System;
using CreationalPatterns.Prototype;
using CreationalPatterns.Singleton;

namespace CreationalPatternsRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunSingleton();
            //RunPrototype();

            Console.Read();
        }

        private static void RunPrototype()
        {
            Console.WriteLine("***Prototype Pattern Demo***\n");

            //Base or Original Copy
            BasicCar nano_base = new Nano("Green Nano") { Price = 100000 };
            BasicCar ford_base = new Ford("Ford Yellow") { Price = 500000 };

            // Nano
            BasicCar bc1;
            bc1 = nano_base.Clone();
            bc1.Price = nano_base.Price + BasicCar.SetPrice();

            // Ford
            bc1 = ford_base.Clone();
            bc1.Price = ford_base.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1}",
                bc1.ModelName, bc1.Price);
            Console.ReadLine();

        }

        private static void RunSingleton()
        {
            Console.WriteLine("***Singleton Pattern Demo***\n");
            //Console.WriteLine(Singleton.MyInt);
            // Private Constructor.So,we cannot use 'new' keyword.
            Console.WriteLine("Trying to create instance s1.");
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Trying to create instance s2.");
            Singleton s2 = Singleton.Instance;
            if (s1 == s2)
            {
                Console.WriteLine("Only one instance exists.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
        }
    }
}
