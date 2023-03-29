namespace ORMExplained.Shared.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Image { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;


        // Establishing One mny relationship
        public List<Product>? Product { get; set; }


    }
}
