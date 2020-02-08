using DN.Domain.Entities;

namespace DN.Domain.Repositories
{
    public interface IProductRepository
    {
        Product Get(int id);
        void Create(Product product);
        void Update(Product product);
    }
}
