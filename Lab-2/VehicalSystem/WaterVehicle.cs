using System;

namespace VehicleSystem
{
    public class WaterVehicle : Vehicle
    {
        // Additional property specific to WaterVehicle
        public bool IsCargoShip { get; set; }

        // Constructor
        public WaterVehicle(string vehicleName, int passengerCapacity, int luggageCapacity, string fuelType,
            int manufactureYear, int mileage, int totalDistanceTravelled, bool isCargoShip)
            : base("Water Vehicle", vehicleName, passengerCapacity, luggageCapacity, fuelType, manufactureYear, mileage, totalDistanceTravelled)
        {
            IsCargoShip = isCargoShip;
        }

        // Overriding Suitability
        public override void Suitability()
        {
            Console.WriteLine($"The water vehicle '{VehicleName}' is suitable for marine travel.");
        }

        // Hiding the base class DisplayDetails method
        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Cargo Ship: {(IsCargoShip ? "Yes" : "No")}");
        }
    }
}
