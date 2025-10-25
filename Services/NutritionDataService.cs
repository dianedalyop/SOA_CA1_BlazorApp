using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace SOA_CA1_BlazorApp.Services
{
    public class NutritionDataService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "wF0Z3LUwpRkv2pqvAiFT1Q==u23V6YopIXHiQOPq"; 

        public NutritionDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<NutritionData?> GetNutritionAsync(string query)
        {
            try
            {
                var request = new HttpRequestMessage(
                    HttpMethod.Get,
                    $"https://api.calorieninjas.com/v1/nutrition?query={query}"
                );
                request.Headers.Add("X-Api-Key", _apiKey);

                var response = await _httpClient.SendAsync(request);
          
                
                if (!response.IsSuccessStatusCode)
                    return null;

                var json = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Nutrition API raw result: {json}");
                var result = JsonSerializer.Deserialize<NutritionApiResponse>(
                    json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                );

                return result?.Items?.FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
    }

    public class NutritionApiResponse
    {
        public List<NutritionData>? Items { get; set; }
    }

    public class NutritionData
    {
        public string Name { get; set; }
        public double Calories { get; set; }
        public double FatTotalG { get; set; }
        public double ProteinG { get; set; }
        public double CarbohydratesTotalG { get; set; }
    }
}
