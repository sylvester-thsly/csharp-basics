using System;

namespace Cargonerds.API.Data
{
    // 🗄️ This class represents a "Row" in our Database Table.
    // Every time someone calculates an emission, we will save it here.
    // This is how Cargonerds keeps a history of all shipments.
    public class ShipmentRecord
    {
        // Unique ID for the database (Primary Key)
        public int Id { get; set; }

        public double DistanceKm { get; set; }
        public double WeightKg { get; set; }
         
         //new field
         
        
        // We save the result too, so we don't have to recalculate it later.
        public double Co2Emission { get; set; }
        public bool IsPriority { get; set; }
        // When did this calculation happen?
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
