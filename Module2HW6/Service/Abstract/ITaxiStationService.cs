using System.Collections;
using Module2HW6.Model;

namespace Module2HW6.Service.Abstract
{
    public interface ITaxiStationService
    {
        public Car[] Array { get; set; }
        public void Add(Car car);
        public void Sort(IComparer comparer);
    }
}
