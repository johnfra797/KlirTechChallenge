using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Domain.DTOs.Request
{
    public class ShoppingCartCreateRequest
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public string PromotionApplied { get; set; }
    }
}
