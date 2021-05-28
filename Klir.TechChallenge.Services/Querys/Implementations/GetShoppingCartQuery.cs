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
   public class GetShoppingCartQuery : IGetShoppingCartQuery
    {
        private IShoppingCartQueryDao _shoppingCartQueryDao;
        public GetShoppingCartQuery(IShoppingCartQueryDao shoppingCartQueryDao)
        {
            _shoppingCartQueryDao = shoppingCartQueryDao;
        }
        public ShoppingCartResponse GetShoppingCart(ShoppingCartRequest shoppingCartRequest)
        {
            ShoppingCartResponse shoppingCartResponse = new ShoppingCartResponse();
            shoppingCartResponse.shoppingCart=_shoppingCartQueryDao.GetBy(x => x.Id == shoppingCartRequest.Id).FirstOrDefault();
            return shoppingCartResponse;
        }
    }
}
