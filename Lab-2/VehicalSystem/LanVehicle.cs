using System;

namespace VehicleSystem
{
    public class LandVehicle : Vehicle
    {
        // Additional property specific to LandVehicle
        public int WheelCount { get; set; }

        // Constructor
        public LandVehicle(string vehicleName, int passengerCapacity, int luggageCapacity, string fuelType,
            int manufactureYear, int mileage, int totalDistanceTravelled, int wheelCount)
            : base("Land Vehicle", vehicleName, passengerCapacity, luggageCapacity, fuelType, manufactureYear, mileage, totalDistanceTravelled)
        {
            WheelCount = wheelCount;
        }

        // Overriding Suitability
        public override void Suitability()
        {
            Console.WriteLine($"The land vehicle '{VehicleName}' is suitable for road travel.");
        }

        // Hiding the base class DisplayDetails method
        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Wheel Count: {WheelCount}");
        }
    }
}
