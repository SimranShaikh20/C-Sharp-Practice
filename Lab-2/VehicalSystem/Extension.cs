using System;

namespace VehicleSystem
{
    public static class VehicleExtensions
    {
        // Extension method to calculate fuel required for a given distance
        public static double CalculateFuelRequired(this Vehicle vehicle, int distance)
        {
            if (vehicle.Mileage <= 0)
                throw new InvalidOperationException("Mileage must be greater than 0 to calculate fuel required.");

            return (double)distance / vehicle.Mileage;
        }
    }
}
