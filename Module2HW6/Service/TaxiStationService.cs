using System.Collections;
using Module2HW6.Model;
using Module2HW6.Service.Abstract;

namespace Module2HW6.Service
{
    public class TaxiStationService : ITaxiStationService
    {
        private const int _arrayIncrementStep = 10;
        private Car[] _array;
        private int _count;
        public Car[] Array
        {
            get
            {
                var retArray = new Car[_count];
                for (var i = 0; i < _count; i++)
                {
                    retArray[i] = _array[i];
                }

                return retArray;
            }
            set
            {
                _array = value;
                _count = _array.Length;
            }
        }

        public void Add(Car item)
        {
            if (_count == _array.Length)
            {
                IncrimentArray();
            }

            _array[_count++] = item;
        }

        public void Sort(IComparer comparer)
        {
            var sortArray = Array;
            System.Array.Sort(sortArray, comparer);
            sortArray.CopyTo(_array, 0);
        }

        private void IncrimentArray()
        {
            var newArray = new Car[_array.Length + _arrayIncrementStep];
            _array.CopyTo(newArray, 0);
            _array = newArray;
        }
    }
}
