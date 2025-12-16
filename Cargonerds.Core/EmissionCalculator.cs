// ============================================================================
// EMISSION CALCULATOR - Business Logic
// ============================================================================
// This class contains the core calculation logic for CO2 emissions.
// It's separated from the API controller to follow the "Separation of Concerns"
// principle - business logic should be independent of web framework code.
// ============================================================================

using System;

namespace Cargonerds.Core
{
    public class EmissionCalculator
    {
        // ====================================================================
        // CONSTANTS
        // ====================================================================
        // Emission factor: How much CO2 is produced per km per kg
        // This is a simplified formula for demonstration purposes
        // Real-world calculations would use different factors for air/sea/road
        private const double EmissionFactor = 0.002; // kg CO2 per km per kg

        // ====================================================================
        // METHOD: CalculateCO2
        // ====================================================================
        // Purpose: Calculate total CO2 emissions for a shipment
        // Formula: Distance (km) × Weight (kg) × Emission Factor
        // Example: 1000 km × 500 kg × 0.002 = 1000 kg CO2
        public double CalculateCO2(double distanceKm, double weightKg)
        {
            // Validate inputs - distance and weight must be positive numbers
            if (distanceKm < 0 || weightKg < 0)
            {
                throw new ArgumentException("Distance and weight must be positive.");
            }

            // Perform the calculation
            return distanceKm * weightKg * EmissionFactor;
        }

        // ====================================================================
        // METHOD: GetRating
        // ====================================================================
        // Purpose: Categorize the environmental impact of a shipment
        // Returns: A human-readable rating with an emoji
        public string GetRating(double emissions)
        {
            // Less than 100 kg CO2 = Eco-friendly
            if (emissions < 100) return "Eco-Friendly 🌿";
            
            // Between 100-500 kg CO2 = Standard
            if (emissions < 500) return "Standard 🚛";
            
            // More than 500 kg CO2 = Heavy impact
            return "Heavy Impact 🏭";
        }
    }
}
