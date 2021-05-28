using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Domain.Entities
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public string PromotionApplied { get; set; }
    }
}
