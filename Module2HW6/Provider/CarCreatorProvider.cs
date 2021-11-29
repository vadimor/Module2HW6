using Module2HW6.Model;
using Module2HW6.Model.SpecialSegmentCars;
using Module2HW6.Model.StandardSegmentCars;
using Module2HW6.Provider.Abstract;

namespace Module2HW6.Provider
{
    public class CarCreatorProvider : ICarCreatorProvider
    {
        public Car[] GetCars()
        {
            var array = new Car[8];
            array[0] = new FiatDoblo { UsdCost = 40500 };
            array[1] = new FordGalaxy { UsdCost = 70000 };
            array[2] = new HavalJolion { UsdCost = 100000 };
            array[3] = new KiaRetona { UsdCost = 75000 };
            array[4] = new DaewooMatiz { UsdCost = 83000 };
            array[5] = new KiaPicanto { UsdCost = 59000 };
            array[6] = new NissanMicra { UsdCost = 84400 };
            array[7] = new VolkswagenPolo { UsdCost = 60000 };
            return array;
        }
    }
}
