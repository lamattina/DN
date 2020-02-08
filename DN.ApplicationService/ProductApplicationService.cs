using DN.Data;
using DN.Domain.Commands.Product;
using DN.Domain.Entities;
using DN.Domain.Repositories;
using DN.Domain.Services;

namespace DN.ApplicationService
{
    public class ProductApplicationService : ApplicationService, IProductApplicationService
    {
        private readonly IProductRepository _repository;

        public ProductApplicationService(IProductRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
            => _repository = repository;

        public Product Create(CreateProductCommand cmd)
        {
            var product = new Product(cmd.Title, cmd.Description, cmd.Price);
            product.Create();
            _repository.Create(product);

            if (Commit())
                return product;

            return null;
        }

        public Product Update(UpdateProductCommand cmd)
        {
            var product = _repository.Get(cmd.Id);
            product.Update(cmd.Title, cmd.Description, cmd.Price);
            _repository.Update(product);

            if (Commit())
                return product;

            return null;
        }
    }
}
