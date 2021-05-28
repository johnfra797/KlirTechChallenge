using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Klir.TechChallenge.Data.Dao.Definitions.Commands;
using Klir.TechChallenge.Domain.DTOs.Request;
using Klir.TechChallenge.Domain.DTOs.Response;
using Klir.TechChallenge.Services.Commands.Definitions;
using Klir.TechChallenge.Services.Querys.Definitions;
using MediatR;

namespace Klir.TechChallenge.Web.Api.Services.Query
{
      public static class GetShoppingCart
    {
        public record Request(ShoppingCartRequest shoppingCartRequest) : IRequest<ShoppingCartResponse>;

        public class Handler : IRequestHandler<Request, ShoppingCartResponse>
        {
            private readonly IGetShoppingCartQuery _getShoppingCartQuery;

            public Handler(IGetShoppingCartQuery getShoppingCartQuery)
            {
                this._getShoppingCartQuery = getShoppingCartQuery;
            }

            public Task<ShoppingCartResponse> Handle(Request request, CancellationToken cancellationToken)
            {
                return Task.Run(() => _getShoppingCartQuery.GetShoppingCart(request.shoppingCartRequest));
            }
        }
    }
}
