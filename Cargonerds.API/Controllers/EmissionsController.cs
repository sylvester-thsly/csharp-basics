// ============================================================================
// EMISSIONS CONTROLLER - The "Brain" of the API
// ============================================================================
// This file handles all HTTP requests related to CO2 emission calculations.
// It receives data from the frontend, processes it, saves it to the database,
// and sends back results.
// ============================================================================

using Microsoft.AspNetCore.Mvc;      // Provides API controller functionality
using Cargonerds.Core;                // Our business logic (EmissionCalculator)
using Cargonerds.API.Data;            // Database models and context

namespace Cargonerds.API.Controllers
{
    // [ApiController] - Tells ASP.NET this is an API controller (not a web page)
    [ApiController]
    
    // [Route] - Defines the base URL: /api/emissions
    // [controller] is replaced with "Emissions" (from class name)
    [Route("api/[controller]")]
    
    public class EmissionsController : ControllerBase
    {
        // ====================================================================
        // DEPENDENCIES (Things this controller needs to work)
        // ====================================================================
        
        // The calculator that does the CO2 math
        private readonly EmissionCalculator _calculator;
        
        // The database connection (to save and retrieve shipments)
        private readonly CargonerdsDbContext _context;

        // ====================================================================
        // CONSTRUCTOR (Runs when the controller is created)
        // ====================================================================
        // ASP.NET automatically provides (injects) the calculator and database
        // This is called "Dependency Injection"
        public EmissionsController(EmissionCalculator calculator, CargonerdsDbContext context)
        {
            _calculator = calculator;  // Store calculator for later use
            _context = context;        // Store database connection for later use
        }

        // ====================================================================
        // ENDPOINT 1: GET /api/emissions
        // ====================================================================
        // Purpose: Show a welcome message when someone visits the API
        // Example: http://localhost:5100/api/emissions
        [HttpGet]  // Responds to GET requests
        public IActionResult GetInfo()
        {
            // Return a 200 OK response with a friendly message
            return Ok("✅ The Global Logistics Engine is RUNNING! \n\n" +
                      "To use the calculator, you must send a POST request to /api/emissions/calculate with JSON data.\n" +
                      "Example: { \"distanceKm\": 500, \"weightKg\": 1000 }");
        }

        // ====================================================================
        // ENDPOINT 2: POST /api/emissions/calculate
        // ====================================================================
        // Purpose: Calculate CO2 emissions and save to database
        // Example: POST http://localhost:5100/api/emissions/calculate
        //          Body: { "distanceKm": 1000, "weightKg": 500, "isPriority": true }
        [HttpPost("calculate")]  // Responds to POST requests at /api/emissions/calculate
        public async Task<IActionResult> Calculate([FromBody] ShipmentData request)
        {
            // ----------------------------------------------------------------
            // STEP 1: Validate Input
            // ----------------------------------------------------------------
            // Make sure the user sent valid numbers (no negatives or zeros)
            if (request.WeightKg <= 0 || request.DistanceKm <= 0)
                return BadRequest("Invalid shipment data.");  // Return 400 error

            // ----------------------------------------------------------------
            // STEP 2: Calculate CO2 Emissions
            // ----------------------------------------------------------------
            // Use the EmissionCalculator to do the math
            var co2 = _calculator.CalculateCO2(request.DistanceKm, request.WeightKg);
            
            // Get a rating based on the CO2 amount
            var rating = _calculator.GetRating(co2);

            // ----------------------------------------------------------------
            // STEP 3: Create Database Record
            // ----------------------------------------------------------------
            // Build a new ShipmentRecord object with all the data
            var record = new ShipmentRecord
            {
                 DistanceKm = request.DistanceKm,      // Copy distance from request
                 WeightKg = request.WeightKg,          // Copy weight from request
                 Co2Emission = co2,                    // Store calculated CO2
                 CreatedAt = DateTime.UtcNow,          // Timestamp (UTC time)
                 IsPriority = request.IsPriority       // Is this priority shipping?
            };

            // ----------------------------------------------------------------
            // STEP 4: Save to Database
            // ----------------------------------------------------------------
            // Add the record to the "pending changes" list
            _context.Shipments.Add(record);

            // Actually save to the database (runs SQL INSERT command)
            // 'await' means "wait for this to finish before continuing"
            await _context.SaveChangesAsync();

            // ----------------------------------------------------------------
            // STEP 5: Send Response
            // ----------------------------------------------------------------
            // Return a 200 OK with the results as JSON
            return Ok(new 
            { 
                Id = record.Id,        // Database ID (auto-generated)
                Emission = co2,        // Calculated CO2 value
                Unit = "kg CO2",       // Unit of measurement
                Rating = rating,       // Eco-friendly, Standard, or Heavy
                Message = $"Calculation saved to Database! ID: {record.Id}"
            });
        }

        // ====================================================================
        // ENDPOINT 3: GET /api/emissions/history
        // ====================================================================
        // Purpose: Get the last 10 shipments from the database
        // Example: GET http://localhost:5100/api/emissions/history
        [HttpGet("history")]  // Responds to GET requests at /api/emissions/history
        public ActionResult<IEnumerable<ShipmentRecord>> GetHistory()
        {
            // ----------------------------------------------------------------
            // Query the database for shipments
            // ----------------------------------------------------------------
            var history = _context.Shipments           // Start with all shipments
                .OrderByDescending(s => s.CreatedAt)   // Sort by date (newest first)
                .Take(10)                              // Only get the first 10
                .ToList();                             // Execute query and convert to list

            // Return the list as JSON
            return Ok(history);
        }
    }

    // ========================================================================
    // DATA MODEL: ShipmentData
    // ========================================================================
    // This class defines what data the frontend must send when calling
    // the /calculate endpoint. It's like a "form" that must be filled out.
    public class ShipmentData
    {
        public double DistanceKm { get; set; }   // How far the shipment travels
        public double WeightKg { get; set; }     // How heavy the shipment is
        public bool IsPriority { get; set; }     // Is this priority shipping?
    }
}
