using Module2HW6.Model;
using Module2HW6.Service.Abstract;

namespace Module2HW6.Service
{
    public class CarCostCounterService : ICarCostCounterService
    {
        public double Calculation(Car[] array)
        {
            var sum = 0D;
            foreach (var item in array)
            {
                sum += item.UsdCost;
            }

            return sum;
        }
    }
}
