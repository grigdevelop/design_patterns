using System;

namespace CreationalPatterns.Prototype
{
    public abstract class BasicCar
    {
        public string ModelName { get; set; }

        public int Price { get; set; }

        public static int SetPrice()
        {
            int price = 0;
            Random rd = new Random();
            int p = rd.Next(200000, 500000);
            price = p;
            return price;
        }

        public abstract BasicCar Clone();
    }
}
