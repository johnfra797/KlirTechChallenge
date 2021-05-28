using System;
using System.Collections.Generic;
using System.Text;
using Klir.TechChallenge.Data.Dao.Definitions.Commands;
using Klir.TechChallenge.Domain.DTOs.Request;
using Klir.TechChallenge.Domain.DTOs.Response;
using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Services.Commands.Definitions;

namespace Klir.TechChallenge.Services.Commands.Implementations
{
    public class CreateShoppingCartCommand : ICreateShoppingCartCommand
    {
        private IShoppingCartCommandDao _shoppingCartCommandDao;
        public CreateShoppingCartCommand(IShoppingCartCommandDao shoppingCartCommandDao)
        {
            _shoppingCartCommandDao = shoppingCartCommandDao;
        }

        public ShoppingCartCreateResponse Create(ShoppingCartCreateRequest shoppingCartCreateRequest)
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.Id = shoppingCartCreateRequest.Id;
            shoppingCart.ProductName = shoppingCartCreateRequest.ProductName;
            shoppingCart.Quantity = shoppingCartCreateRequest.Quantity;
            shoppingCart.Price = shoppingCartCreateRequest.Price;
            shoppingCart.Total = shoppingCartCreateRequest.Total;
            shoppingCart.PromotionApplied = shoppingCartCreateRequest.PromotionApplied;

            if(shoppingCart.Id>0)
                _shoppingCartCommandDao.Update(shoppingCart);
            else
                _shoppingCartCommandDao.Create(shoppingCart);

            return new ShoppingCartCreateResponse();
        }
    }
}
