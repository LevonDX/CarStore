namespace CarStore.Data.Entities
{
    public class Car : EntityBase
    {
        public virtual Model Model { get; set; } = new Model();
        public int? Year { get; set; }
        public string? Color { get; set; } = "";
        public decimal? Price { get; set; }

        public override string ToString()
        {
            return $"{Model.Make.Name} {Model.Name} {Year} {Color} {Price}";
        }
        

    }
}
