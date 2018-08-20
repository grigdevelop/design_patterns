namespace CreationalPatterns.Prototype
{
    public class Ford : BasicCar
    {
        public Ford(string m)
        {
            this.ModelName = m;
        }

        public override BasicCar Clone()
        {
            return (Ford) this.MemberwiseClone();
        }
    }
}
