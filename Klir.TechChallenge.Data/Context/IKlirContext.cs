using System;
using System.Collections.Generic;
using System.Text;
using Klir.TechChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Klir.TechChallenge.Data.Context
{
    public interface IKlirContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
    }
}
