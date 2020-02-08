using DN.Domain.Entities;
using DN.SharedKernel.Validation;

namespace DN.Domain.Scopes
{
    public static class ProductScopes
    {
        public static bool CreateProductScopeIsValid(this Product product)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertLength(product.Title, 3, 60, "O Titulo deve conter entre 3 e 60 caracteres"),
                AssertionConcern.AssertLength(product.Description, 10, 100, "A descrição deve conter entre 10 e 100 caracteres"),
                AssertionConcern.AssertIsGreaterThan(product.Price, 0, "O valor deve ser maior que 0")
            );
        }

        public static bool UpdateProductScopeIsValid(this Product product, string title, string description, decimal price)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertLength(title, 3, 60, "O Titulo deve conter entre 3 e 60 caracteres"),
                AssertionConcern.AssertLength(description, 10, 100, "A descrição deve conter entre 10 e 100 caracteres"),
                AssertionConcern.AssertIsGreaterThan(price, 0, "O valor deve ser maior que 0")
            );
        }
    }
}
