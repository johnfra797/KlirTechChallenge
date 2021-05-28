using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klir.TechChallenge.Domain.Entities;

namespace Klir.TechChallenge.Domain.DTOs.Response
{
    public class ProductResponse
    {
        public List<Product> Products { get; set; }
    }
}
