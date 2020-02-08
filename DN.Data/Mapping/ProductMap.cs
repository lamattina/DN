using DN.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DN.Data.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Produto");
            HasKey(x => x.Id);

            Property(x => x.Title).HasMaxLength(60).IsRequired();
            Property(x => x.Description).HasMaxLength(100).IsRequired();
            Property(x => x.Price).HasPrecision(18, 2).IsRequired();
            Property(x => x.IsActive).IsRequired();
        }
    }
}
