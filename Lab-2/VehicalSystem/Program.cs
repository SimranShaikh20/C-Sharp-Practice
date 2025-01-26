using System;

namespace VehicleSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vehicle Management System!");

            // Object Initializer Example
            var airVehicle = new AirVehicle("Boeing 747", 416, 1000, "Aviation Fuel", 2005, 8, 1500000, 35000);
            var waterVehicle = new WaterVehicle("Titanic", 3000, 5000, "Diesel", 1912, 2, 30000, true);
            var landVehicle = new LandVehicle("Tesla Model S", 5, 500, "Electric", 2022, 400, 15000, 4);

            // Display details
            airVehicle.DisplayDetails();
            airVehicle.Suitability();

            Console.WriteLine();

            waterVehicle.DisplayDetails();
            waterVehicle.Suitability();

            Console.WriteLine();

            landVehicle.DisplayDetails();
            landVehicle.Suitability();

            // Using the extension method
            int distance = 500; // Example distance
            Console.WriteLine($"\nFuel required for {distance} km in {landVehicle.VehicleName}: " +
                $"{landVehicle.CalculateFuelRequired(distance)} liters");
        }
    }
}
