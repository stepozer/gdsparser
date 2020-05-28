using System;
using System.Text.Json;
using InfrastuctureLayer.Gds.Sirena;

namespace GdsParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var trips = new Driver().Trips();

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