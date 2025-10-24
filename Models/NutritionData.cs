namespace SOA_CA1_BlazorApp.Models
{
    public class NutritionData
    {
        public string Name { get; set; }
        public double Calories { get; set; }
        public double CholesterolMg { get; set; }
        public double CarbohydratesTotalG { get; set; }
        public double FiberG { get; set; }
        public double SugarG { get; set; }

        public double FatTotalG { get; set; }
        public double FatSaturatedG { get; set; }
        public double ProteinG { get; set; }
        public double SodiumMg { get; set; }
        public double PotassiumMg { get; set; }
        
    }

    public class NutritionApiResponse
    {
        public List<NutritionData> Items { get; set; }
    }
}
