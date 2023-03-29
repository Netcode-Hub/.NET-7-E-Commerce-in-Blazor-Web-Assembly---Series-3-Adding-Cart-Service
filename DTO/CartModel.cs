namespace ORMExplained.Shared.DTO
{
    public class CartModel
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double SubTotal { get; set; }
    }
}
