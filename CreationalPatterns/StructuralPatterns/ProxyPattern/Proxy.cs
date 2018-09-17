using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.StructuralPatterns.ProxyPattern
{
    public class Proxy : Subject
    {
        private Subject cs;

        public override void DoSomeWork()
        {
            Console.WriteLine("Proxy calling happining now...");

            if (cs == null)
            {
                cs = new ConcreteSubject();
            }

            cs.DoSomeWork();
        }
    }
}
