using Module2HW6.Model;

namespace Module2HW6.Service.Abstract
{
    public interface ICarFinderService
    {
        public Car[] Find(Car[] array, string name);

        public Car[] Find(Car[] array, double cost);

        public Car[] Find(Car[] array, string name, double cost);
        public Car[] FindOnRangeFuelConsumption(Car[] array, double min, double max);
    }
}
