using System;

namespace VehicleSystem
{
    public class AirVehicle : Vehicle
    {
        // Additional property specific to AirVehicle
        public int MaxAltitude { get; set; }

        // Constructor
        public AirVehicle(string vehicleName, int passengerCapacity, int luggageCapacity, string fuelType,
            int manufactureYear, int mileage, int totalDistanceTravelled, int maxAltitude)
            : base("Air Vehicle", vehicleName, passengerCapacity, luggageCapacity, fuelType, manufactureYear, mileage, totalDistanceTravelled)
        {
            MaxAltitude = maxAltitude;
        }

        // Overriding Suitability
        public override void Suitability()
        {
            Console.WriteLine($"The air vehicle '{VehicleName}' is suitable for long-distance air travel.");
        }

        // Hiding the base class DisplayDetails method
        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Max Altitude: {MaxAltitude} feet");
        }
    }
}
