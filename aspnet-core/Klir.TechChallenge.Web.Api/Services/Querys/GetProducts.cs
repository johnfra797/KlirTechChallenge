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
      public static class GetProducts
    {
        public record Request(ProductRequest productRequest) : IRequest<ProductResponse>;

        public class Handler : IRequestHandler<Request, ProductResponse>
        {
            private readonly IGetProductsQuery _getProductsQuery;

            public Handler(IGetProductsQuery getProductsQuery)
            {
                this._getProductsQuery = getProductsQuery;
            }

            public Task<ProductResponse> Handle(Request request, CancellationToken cancellationToken)
            {
                return Task.Run(() => _getProductsQuery.GetProducts(request.productRequest));
            }
        }
    }
}
