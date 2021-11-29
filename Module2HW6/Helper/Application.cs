using Module2HW6.Service.Abstract;

namespace Module2HW6.Helper
{
    public class Application
    {
        private ICarCostCounterService _carCostCounterService;
        private ICarCreatorService _carCreatorService;
        private ITaxiStationService _taxiStationService;
        private ICarFinderService _carFinderService;
        public Application(
            ICarCostCounterService carCostCounterService,
            ICarCreatorService carCreatorService,
            ITaxiStationService taxiStationService,
            ICarFinderService carFinderService)
        {
            _carCostCounterService = carCostCounterService;
            _carCreatorService = carCreatorService;
            _taxiStationService = taxiStationService;
            _carFinderService = carFinderService;
        }

        public void Run()
        {
            _taxiStationService.Array = _carCreatorService.GetCars();
            var comparer = new CarCostSortComparer();
            _taxiStationService.Sort(comparer);

            System.Console.WriteLine("Count Fiat Doblo: " +
                _carFinderService.Find(_taxiStationService.Array, "Fiat Doblo").Length);

            System.Console.WriteLine("Count car with fuel consumption in the range from 5.9 to 7: " +
                _carFinderService.FindOnRangeFuelConsumption(_taxiStationService.Array, 5.9, 7).Length);

            System.Console.WriteLine("Cost taxi station: " +
                _carCostCounterService.Calculation(_taxiStationService.Array));
        }
    }
}