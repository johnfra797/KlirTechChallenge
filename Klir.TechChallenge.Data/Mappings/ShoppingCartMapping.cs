using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klir.TechChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Klir.TechChallenge.Data.Mappings
{
      public class ShoppingCartMapping : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.HasKey(e => e.Id);
            builder.ToTable("ShoppingCart");
            builder.Property(e => e.Id).HasColumnName("Id");
            builder.Property(e => e.ProductName).HasColumnName("ProductName");
            builder.Property(e => e.Quantity).HasColumnName("Quantity");
            builder.Property(e => e.Price).HasColumnName("Price");
            builder.Property(e => e.Total).HasColumnName("Total");
            builder.Property(e => e.PromotionApplied).HasColumnName("PromotionApplied");
        }
    }
}