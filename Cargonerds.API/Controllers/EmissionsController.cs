using Microsoft.AspNetCore.Mvc;
using Cargonerds.Core;
using Cargonerds.API.Data; // Import the Data definitions

namespace Cargonerds.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmissionsController : ControllerBase
    {
        private readonly EmissionCalculator _calculator;
        private readonly CargonerdsDbContext _context; // 💽 Reference to the Database

        // We ask for both the Calculator AND the Database Connection
        public EmissionsController(EmissionCalculator calculator, CargonerdsDbContext context)
        {
            _calculator = calculator;
            _context = context;
        }

        // Add this so you can see something in the browser!
        [HttpGet] 
        public IActionResult GetInfo()
        {
            return Ok("✅ The Global Logistics Engine is RUNNING! \n\n" +
                      "To use the calculator, you must send a POST request to /api/emissions/calculate with JSON data.\n" +
                      "Example: { \"distanceKm\": 500, \"weightKg\": 1000 }");
        }

        [HttpPost("calculate")]
        public async Task<IActionResult> Calculate([FromBody] ShipmentData request)
        {
            if (request.WeightKg <= 0 || request.DistanceKm <= 0)
                return BadRequest("Invalid shipment data.");

            // 1. Calculate the result (Using the Core Engine)
            var co2 = _calculator.CalculateCO2(request.DistanceKm, request.WeightKg);
            var rating = _calculator.GetRating(co2);

            // 2. 💾 Create a record for the Database
            var record = new ShipmentRecord
            {
                 DistanceKm = request.DistanceKm,
                 WeightKg = request.WeightKg,
                 Co2Emission = co2,
                 CreatedAt = DateTime.UtcNow,
                 IsPriority = request.IsPriority
            };

            // 3. Add to the "To Do" list of things to save
            _context.Shipments.Add(record);

            // 4. Commit transaction (Send SQL INSERT command)
            await _context.SaveChangesAsync();

            return Ok(new 
            { 
                Id = record.Id, // Return the Database ID so we can find it later!
                Emission = co2, 
                Unit = "kg CO2", 
                Rating = rating,
                Message = $"Calculation saved to Database! ID: {record.Id}"
            });
        }

        // 🆕 New Endpoint: Get the history of calculations!
        [HttpGet("history")]
        public ActionResult<IEnumerable<ShipmentRecord>> GetHistory()
        {
            // Fetch the last 10 shipments from the database, newest first
            var history = _context.Shipments
                .OrderByDescending(s => s.CreatedAt)
                .Take(10)
                .ToList();

            return Ok(history);
        }
    }

    public class ShipmentData
    {
        public double DistanceKm { get; set; }
        public double WeightKg { get; set; }
        public bool IsPriority { get; set; }
    }
}
