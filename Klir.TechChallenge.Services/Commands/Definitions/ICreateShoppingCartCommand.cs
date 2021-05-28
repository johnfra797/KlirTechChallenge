using System;
using System.Collections.Generic;
using System.Text;
using Klir.TechChallenge.Domain.DTOs.Request;
using Klir.TechChallenge.Domain.DTOs.Response;

namespace Klir.TechChallenge.Services.Commands.Definitions
{
    public interface ICreateShoppingCartCommand
    {
        ShoppingCartCreateResponse Create(ShoppingCartCreateRequest shoppingCartCreateRequest);
    }
}
