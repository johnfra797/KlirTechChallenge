
using Klir.TechChallenge.Data.Mappings;
using Klir.TechChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Klir.TechChallenge.Data.Context
{
    internal class KlirContext : DbContext, IKlirContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new ShoppingCartMapping());
        }

        public KlirContext(DbContextOptions<KlirContext> options) : base(options)
        {
        }
    }

    
}