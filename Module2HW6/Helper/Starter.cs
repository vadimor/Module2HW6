using Microsoft.Extensions.DependencyInjection;
using Module2HW6.Service.Abstract;
using Module2HW6.Service;
using Module2HW6.Provider.Abstract;
using Module2HW6.Provider;

namespace Module2HW6.Helper
{
    public class Starter
    {
        public void Start()
        {
            var starter = new ServiceCollection()
                .AddSingleton<ICarCostCounterService, CarCostCounterService>()
                .AddSingleton<ICarCreatorService, CarCreatorService>()
                .AddTransient<ICarCreatorProvider, CarCreatorProvider>()
                .AddTransient<ITaxiStationService, TaxiStationService>()
                .AddSingleton<ICarFinderService, CarFinderService>()
                .AddTransient<Application>().BuildServiceProvider();
            var app = starter.GetService<Application>();
            app.Run();
        }
    }
}
