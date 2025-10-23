namespace SOA_CA1_BlazorApp.Models
{
    public class Meal
    {
        public string sMeal { get; set; }
        public string sCategory { get; set; }
        public string sArea { get; set; }
        public string sInstructions { get; set; }
        public string sMealThumb { get; set; }
    }

    public class MealResponse
    {
        public List<Meal> meals { get; set; }
    }
}
