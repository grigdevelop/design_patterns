using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private int numberOfInstances = 0;

        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("We already have an instance now.Use it.");
                return instance;
            }
        }

        private Singleton()
        {
            Console.WriteLine("Instantiating inside the private constructor.");
            numberOfInstances++;
            Console.WriteLine("Number of instances = {0}", numberOfInstances);
        }
    }

    [Runner(Ignore = true)]
    public class SignletonRunner : IRunner
    {
        public void Run()
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
