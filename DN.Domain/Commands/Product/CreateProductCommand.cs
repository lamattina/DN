namespace DN.Domain.Commands.Product
{
    public class CreateProductCommand
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
