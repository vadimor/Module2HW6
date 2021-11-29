using System;
using Module2HW6.Model;

namespace Module2HW6.Helper
{
    public static class CarArrayExtended
    {
        private static TypeComparison _typeComparison;
        private static string _name;
        private static double _cost;
        private static double _min;
        private static double _max;
        public static Car[] Find(this Car[] array, string name)
        {
            _typeComparison = TypeComparison.Name;
            _name = name;
            return FindCalculation(array);
        }

        public static Car[] Find(this Car[] array, double min, double max)
        {
            _typeComparison = TypeComparison.RangelFuelConsumption;
            _min = min;
            _max = max;
            return FindCalculation(array);
        }

        public static Car[] Find(this Car[] array, double cost)
        {
            _typeComparison = TypeComparison.Cost;
            _cost = cost;
            return FindCalculation(array);
        }

        public static Car[] Find(this Car[] array, string name, double cost)
        {
            _typeComparison = TypeComparison.CostAndName;
            _name = name;
            _cost = cost;
            return FindCalculation(array);
        }

        private static Car[] FindCalculation(Car[] array)
        {
            var newArray = new Car[array.Length];
            var count = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (Comparison(array[i]))
                {
                    newArray[count++] = array[i];
                }
            }

            Array.Resize(ref newArray, count);
            return newArray;
        }

        private static bool Comparison(Car item)
        {
            switch (_typeComparison)
            {
                case TypeComparison.Name:
                    return item.Name.Equals(_name);
                case TypeComparison.Cost:
                    return item.UsdCost == _cost;
                case TypeComparison.CostAndName:
                    return item.Name.Equals(_name) && item.UsdCost == _cost;
                case TypeComparison.RangelFuelConsumption:
                    return item.FuelConsumption > _min && item.FuelConsumption < _max;
            }

            return false;
        }
    }
}