using Module2HW6.Model;
using Module2HW6.Helper;
using Module2HW6.Service.Abstract;

namespace Module2HW6.Service
{
    public class CarFinderService : ICarFinderService
    {
        public Car[] Find(Car[] array, string name)
        {
            return array.Find(name);
        }

        public Car[] Find(Car[] array, double cost)
        {
            return array.Find(cost);
        }

        public Car[] Find(Car[] array, string name, double cost)
        {
            return array.Find(name, cost);
        }

        public Car[] FindOnRangeFuelConsumption(Car[] array, double min = 0, double max = 1000)
        {
            return array.Find(min, max);
        }
    }
}
