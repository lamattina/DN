using DN.Domain.Scopes;

namespace DN.Domain.Entities
{
    public class Product
    {
        private Product() { }

        public Product(string title, string description, decimal price)
        {
            Title = title;
            Description = description;
            Price = price;
            IsActive = true;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public bool IsActive { get; private set; }

        public void Create()
        {
            if (!this.CreateProductScopeIsValid())
                return;
        }

        public void Update(string title, string description, decimal price)
        {
            if (!this.UpdateProductScopeIsValid(title, description, price))
                return;

            Title = title;
            Description = description;
            Price = price;
        }
    }
}
