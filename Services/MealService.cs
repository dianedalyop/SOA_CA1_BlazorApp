using System.Net.Http.Json;
using SOA_CA1_BlazorApp.Models;

namespace SOA_CA1_BlazorApp.Services
{
    //  interact with TheMealDB API
    public class MealService
    {
        private readonly HttpClient _http;

        public MealService(HttpClient http)
        {
            _http = http;
        }


        // Searching for meals by name
        public async Task<List<Meal>> SearchMealsAsync(string query)
        {

            try // in case of network issues or invalid responses
            {
                var response = await _http.GetFromJsonAsync<MealResponse>(
                    $"https://www.themealdb.com/api/json/v1/1/search.php?s={query}"
                );
                return response?.meals ?? new List<Meal>();
            }
            catch
            {
                return new List<Meal>();
            }
        }
    }
}
