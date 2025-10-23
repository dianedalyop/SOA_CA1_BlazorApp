namespace SOA_CA1_BlazorApp.Models
{
    public class Meal
    {
        public string strMeal { get; set; }
        public string strCategory { get; set; }
        public string strArea { get; set; }
        public string strInstructions { get; set; }
        public string strMealThumb { get; set; }
    }

    public class MealResponse
    {
        public List<Meal> meals { get; set; }
    }
}
