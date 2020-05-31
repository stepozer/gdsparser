using System;
using System.Text.Json;
using InfrastuctureLayer;
using InfrastuctureLayer.Gds.Sirena;
using Microsoft.Extensions.DependencyInjection;

namespace GdsParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            CompositionRootLayer.CompositionRootBuilder.Build(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var driver = (Driver) serviceProvider.GetService(typeof(Driver));
            var trips = driver.Trips();

            foreach (var trip in trips)
            {
                Console.WriteLine($"{trip}");    
            }
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            Console.WriteLine(JsonSerializer.Serialize(trips, options));
        }
    }
}