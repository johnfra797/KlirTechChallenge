using System;
using System.Collections.Generic;
using System.Text;
using Klir.TechChallenge.Domain.DTOs.Request;
using Klir.TechChallenge.Domain.DTOs.Response;

namespace Klir.TechChallenge.Services.Querys.Definitions
{
    public interface IGetProductsQuery
    {
        ProductResponse GetProducts(ProductRequest productRequest);
    }
}
