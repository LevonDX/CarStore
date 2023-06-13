namespace CarStore.Data.Entities
{
    public class Model : EntityBase
    {
        public string Name { get; set; } = "";
        public virtual Make Make { get; set; } = new Make();
    }
}
