namespace Module2HW6.Model.StandardSegmentCars
{
    public abstract class SegmentBCar : StandardSegmentCar
    {
        public override double MaxLength => 3.9;
        public override double MinLength => 3.6;
        public override double MaxWidth => 1.7;
        public override double MinWidth => 1.5;
    }
}
