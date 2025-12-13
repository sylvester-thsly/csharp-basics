using System;

namespace Cargonerds.Core
{
    public class EmissionCalculator
    {
        // A simple formula simulation: 
        // CO2 = Distance (km) * Weight (kg) * EmissionFactor
        private const double EmissionFactor = 0.002; // Arbitrary factor for demo

        public double CalculateCO2(double distanceKm, double weightKg)
        {
            if (distanceKm < 0 || weightKg < 0)
            {
                throw new ArgumentException("Distance and weight must be positive.");
            }

            return distanceKm * weightKg * EmissionFactor;
        }

        public string GetRating(double emissions)
        {
            if (emissions < 100) return "Eco-Friendly 🌿";
            if (emissions < 500) return "Standard 🚛";
            return "Heavy Impact 🏭";
        }
    }
}
