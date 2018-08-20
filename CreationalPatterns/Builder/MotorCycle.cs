﻿namespace CreationalPatterns.Builder
{
    public class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;

        public MotorCycle(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void StartUpOperations()
        {
            //Nothing in this case
        }

        public void BuildBody()
        {
            product.Add("This is a body of a Motorcycle");
        }

        public void InsertWheels()
        {
            product.Add("2 whells are added");
        }

        public void AddHeadlights()
        {
            product.Add("1 Headlights are added");
        }

        public void EndOperations()
        {
            //Finishing up with brandname
            product.Add(string.Format("Motorcycle Model name: {0}", this.brandName));
        }

        public Product GetVehicle()
        {
            return product;
        }
    }
}
