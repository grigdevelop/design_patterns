using System;

namespace CreationalPatterns.StructuralPatterns.ProxyPattern
{
    public class ConcreteSubject : Subject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("ConcreteSubject.DoSomeWork()");
        }
    }
}
