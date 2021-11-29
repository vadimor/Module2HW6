namespace Module2HW6.Model
{
    public abstract class Car
    {
        public abstract string Name { get; }

        public abstract double FuelConsumption { get; }
        public double UsdCost { get; set; }
    }
}
