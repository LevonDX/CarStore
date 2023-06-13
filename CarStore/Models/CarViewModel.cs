namespace CarStore.Models
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string? Color { get; set; } = "";
        public int? Year { get; set; }
        public decimal? Price { get; set; }

        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
    }
}
