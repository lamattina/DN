using DN.Domain.Commands.Product;
using DN.Domain.Entities;

namespace DN.Domain.Services
{
    public interface IProductApplicationService
    {
        Product Create(CreateProductCommand cmd);
        Product Update(UpdateProductCommand cmd);
    }
}
