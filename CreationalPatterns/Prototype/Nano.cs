namespace CreationalPatterns.Prototype
{
    public class Nano : BasicCar
    {
        public Nano(string m)
        {
            this.ModelName = m;
        }

        public override BasicCar Clone()
        {
            return (Nano) this.MemberwiseClone();
        }
    }
}
