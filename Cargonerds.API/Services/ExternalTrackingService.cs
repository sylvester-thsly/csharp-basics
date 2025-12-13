using System.Net.Http.Json;

namespace Cargonerds.API.Services
{
    // This service simulates fetching data from OUTSIDE (e.g., Maersk or Lufthansa)
    public class ExternalTrackingService
    {
        private readonly HttpClient _httpClient;

        public ExternalTrackingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetContainerLocationFromMaersk(string containerId)
        {
            // In real life, this URL would be: "https://api.maersk.com/tracking/v1/..."
            // We explain this is an External API Call
            
            // Simulating a network call...
            await Task.Delay(500); // 0.5s network delay

            // logic: If we actually had a key, we would do:
            // var response = await _httpClient.GetAsync($"https://api.maersk.com/track/{containerId}");
            
            return $"North Atlantic Ocean (Coordinates: 45.2N, 30.1W) - Fetched from Maersk API";
        }
    }
}
