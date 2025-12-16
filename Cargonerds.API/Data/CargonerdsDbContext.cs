using Microsoft.EntityFrameworkCore;

namespace Cargonerds.API.Data
{
    // 🌉 This is the Bridge between C# code and the SQL Database.
    // In Entity Framework, this "DbContext" represents the whole Database.
    public class CargonerdsDbContext : DbContext
    {
        public CargonerdsDbContext(DbContextOptions<CargonerdsDbContext> options) 
            : base(options)
        {
        }

        // This line tells C#: "Please create a Table called 'Shipments' based on the ShipmentRecord class."
        public DbSet<ShipmentRecord> Shipments { get; set; }
    }
}
