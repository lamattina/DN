using DN.Data.DataContext;
using DN.Domain.Entities;
using DN.Domain.Repositories;
using System.Data.Entity;
using System.Linq;

namespace DN.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DNContext _context;

        public ProductRepository(DNContext context)
            => _context = context;

        public void Create(Product product)
            => _context.Products.Add(product);

        public Product Get(int id)
            => _context.Products.FirstOrDefault(x => x.Id == id);

        public void Update(Product product)
            => _context.Entry(product).State = EntityState.Modified;
    }
}
