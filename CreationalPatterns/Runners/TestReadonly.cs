using System;

namespace CreationalPatterns.Runners
{
    [Runner(Ignore = true)]
    public class TestReadonly : IRunner
    {
        private readonly Person Pers = new Person { FirstName = "Anun", LastName = "Azganun" };        

        public void Run()
        {
            Pers.WriteLine();

            var p = Pers;
            p.FirstName = "Another anun";
            p.LastName = "Another azganun";
            p.WriteLine();

            Pers.WriteLine();

        }

        class Person
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public void WriteLine()
            {
                Console.WriteLine("Person. FirstName: {0}, LastName: {1}", FirstName, LastName);
            }
        }
    }
}
