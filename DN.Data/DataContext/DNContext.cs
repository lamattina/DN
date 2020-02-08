using DN.Data.Mapping;
using DN.Domain.Entities;
using System.Data.Entity;

namespace DN.Data.DataContext
{
    public class DNContext : DbContext
    {
        public DNContext() : base("DNConnectionString") { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
