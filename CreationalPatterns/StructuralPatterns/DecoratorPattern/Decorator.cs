using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.StructuralPatterns.DecoratorPattern
{
    abstract class Component
    {
        public abstract void MakeHouse();
    }

    class ConcreteComponent : Component
    {
        public override void MakeHouse()
        {
            Console.WriteLine("Original house is complete. It is closed for modifications.");
        }
    }

    abstract class AbstractDecorator : Component
    {
        private Component com;

        public void SetTheComponent(Component c)
        {
            this.com = c;
        }

        public override void MakeHouse()
        {
            if (com != null)
            {
                com.MakeHouse();
            }
        }

    }

    class ConcreteDecoratorEx1 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            base.MakeHouse();
            Console.WriteLine("***Using a decorator***");
            AddFloor();
        }

        private void AddFloor()
        {
            Console.WriteLine("I'm adding additional floor at this house.");
        }
    }

    class ConcreteDecoratorEx2 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            Console.WriteLine("");
            base.MakeHouse();
            Console.WriteLine("***Using another decorator***");
            //Decorating now.
            PaintTheHouse();
            //You can add additional stuffs as per your need
        }
        private void PaintTheHouse()
        {
            Console.WriteLine("Now I am painting the house.");
        }
    }
}
