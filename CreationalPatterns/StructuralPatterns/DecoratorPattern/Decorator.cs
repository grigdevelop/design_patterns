using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.StructuralPatterns.DecoratorPattern
{
    public abstract class Component
    {
        public abstract void MakeHouse();
    }

    public class ConcreteComponent : Component
    {
        public override void MakeHouse()
        {
            Console.WriteLine("Original house is complete. It is closed for modifications.");
        }
    }

    public abstract class AbstractDecorator : Component
    {
        private Component com;
       
        public void SetTheComponent(Component c)
        {
            this.com = c;
        }

        protected AbstractDecorator()
        {
            if (com != null)
            {
                com.MakeHouse();
            }
        }

    }
}
