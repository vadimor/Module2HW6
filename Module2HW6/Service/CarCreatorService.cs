using Module2HW6.Model;
using Module2HW6.Provider.Abstract;
using Module2HW6.Service.Abstract;

namespace Module2HW6.Service
{
    public class CarCreatorService : ICarCreatorService
    {
        private ICarCreatorProvider _carCreatorProvider;
        public CarCreatorService(ICarCreatorProvider carCreatorProvider)
        {
            _carCreatorProvider = carCreatorProvider;
        }

        public Car[] GetCars()
        {
            return _carCreatorProvider.GetCars();
        }
    }
}
