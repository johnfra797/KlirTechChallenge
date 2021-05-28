using System;
using System.Collections.Generic;
using System.Text;
using Klir.TechChallenge.Domain.DTOs.Response;
using MediatR;

namespace Klir.TechChallenge.Domain.DTOs.Request
{
    public class ShoppingCartRequest : IRequest<ShoppingCartResponse>
    {
        public int Id { get; set; }
    }
}
