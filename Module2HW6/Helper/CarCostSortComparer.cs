using System.Collections;
using Module2HW6.Model;

namespace Module2HW6.Helper
{
    public class CarCostSortComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var carX = x as Car;
            var carY = y as Car;

            return carX.FuelConsumption.CompareTo(carY.FuelConsumption);
        }
    }
}
