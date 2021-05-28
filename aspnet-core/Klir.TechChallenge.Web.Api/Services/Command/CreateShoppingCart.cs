using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Klir.TechChallenge.Domain.DTOs.Request;
using Klir.TechChallenge.Domain.DTOs.Response;
using Klir.TechChallenge.Services.Commands.Definitions;
using MediatR;

namespace Klir.TechChallenge.Web.Api.Services.Command
{
     public static class CreateShoppingCart
    {
        public record Request(ShoppingCartCreateRequest shoppingCartCreateRequest) : IRequest<ShoppingCartCreateResponse>;

        public class Handler : IRequestHandler<Request, ShoppingCartCreateResponse>
        {
            private readonly ICreateShoppingCartCommand _shoppingCartCommandService;

            public Handler(ICreateShoppingCartCommand shoppingCartCommandService)
            {
                this._shoppingCartCommandService = shoppingCartCommandService;
            }

            public Task<ShoppingCartCreateResponse> Handle(Request request, CancellationToken cancellationToken)
            {
                return Task.Run(() => _shoppingCartCommandService.Create(request.shoppingCartCreateRequest));
            }
        }
    }
}
