using System;

namespace VehicleSystem
{
    public class Vehicle
    {
        // Properties
        public string VehicleType { get; set; }
        public string VehicleName { get; set; }
        public int PassengerCapacity { get; set; }
        public int LuggageCapacity { get; set; }
        public string FuelType { get; set; }
        public int ManufactureYear { get; set; }
        public int Mileage { get; set; }
        public int Age => DateTime.Now.Year - ManufactureYear; // Calculated property
        public int TotalDistanceTravelled { get; set; }

        // Constructor
        public Vehicle(string vehicleType, string vehicleName, int passengerCapacity, int luggageCapacity,
            string fuelType, int manufactureYear, int mileage, int totalDistanceTravelled)
        {
            VehicleType = vehicleType;
            VehicleName = vehicleName;
            PassengerCapacity = passengerCapacity;
            LuggageCapacity = luggageCapacity;
            FuelType = fuelType;
            ManufactureYear = manufactureYear;
            Mileage = mileage;
            TotalDistanceTravelled = totalDistanceTravelled;
        }

        // Virtual Method for Suitability
        public virtual void Suitability()
        {
            Console.WriteLine("The vehicle is suitable for general purposes.");
        }

        // Virtual Method for displaying details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"\n--- {VehicleName} Details ---");
            Console.WriteLine($"Type: {VehicleType}");
            Console.WriteLine($"Passenger Capacity: {PassengerCapacity}");
            Console.WriteLine($"Luggage Capacity: {LuggageCapacity}");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Manufacture Year: {ManufactureYear}");
            Console.WriteLine($"Mileage: {Mileage} km/l");
            Console.WriteLine($"Age: {Age} years");
            Console.WriteLine($"Total Distance Travelled: {TotalDistanceTravelled} km");
        }
    }
}
