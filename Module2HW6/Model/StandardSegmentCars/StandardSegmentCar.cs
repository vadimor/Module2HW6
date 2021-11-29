namespace Module2HW6.Model.StandardSegmentCars
{
    public abstract class StandardSegmentCar : Car
    {
        public abstract double MaxLength { get; }
        public abstract double MinLength { get; }
        public abstract double MaxWidth { get; }
        public abstract double MinWidth { get; }
    }
}
