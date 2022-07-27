namespace FoodGuide.Models
{
    public class FoodPreference
    {
        public int FoodPreferenceID { get; set; }
        public string FoodSize { get; set; }
        public string Taste { get; set; }
        public string Spicyness { get; set; }
        public Food Food { get; set; }
    }
}
