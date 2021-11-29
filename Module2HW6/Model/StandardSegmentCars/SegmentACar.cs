namespace Module2HW6.Model.StandardSegmentCars
{
    public abstract class SegmentACar : StandardSegmentCar
    {
        public override double MaxLength => 3.6;
        public override double MinLength => 0;
        public override double MaxWidth => 1.6;
        public override double MinWidth => 0;
    }
}
