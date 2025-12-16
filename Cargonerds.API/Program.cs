using Cargonerds.Core;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddOpenApi();

// Register the Engine (Business Logic)
builder.Services.AddSingleton<EmissionCalculator>();

// Register the "Phone" to talk to other companies (HttpClient)
// Register the "Phone" to talk to other companies (HttpClient)
builder.Services.AddHttpClient<Cargonerds.API.Services.ExternalTrackingService>();

// 💽 Register the Database (SQLite for now, acts like Azure SQL)
// We tell it to save the file "cargonerds.db" in this folder.
builder.Services.AddDbContext<Cargonerds.API.Data.CargonerdsDbContext>(options =>
    options.UseSqlite("Data Source=cargonerds.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// ✅ Enable Serving "The Customer Portal" (Frontend)
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("index.html");
app.Run();
