using System;
using System.Collections.Generic;
using System.Text;
using Klir.TechChallenge.Data.Dao.Definitions.Querys;
using Klir.TechChallenge.Domain.DTOs.Request;
using Klir.TechChallenge.Domain.DTOs.Response;
using Klir.TechChallenge.Services.Querys.Definitions;
using System.Linq;
namespace Klir.TechChallenge.Services.Querys.Implementations
{
    public class GetProductsQuery : IGetProductsQuery
    {
        private IProductQueryDao _productQueryDao;
        public GetProductsQuery(IProductQueryDao productQueryDao)
        {
            _productQueryDao = productQueryDao;
        }

        public ProductResponse GetProducts(ProductRequest productRequest)
        {
            ProductResponse productResponse = new ProductResponse();
            productResponse.Products = _productQueryDao.GetAll().ToList();
            return productResponse;
        }

    }
}
