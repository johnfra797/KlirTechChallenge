using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klir.TechChallenge.Domain.DTOs.Response;
using MediatR;

namespace Klir.TechChallenge.Domain.DTOs.Request
{
    public class ProductRequest :  IRequest<ProductResponse>
    {
    }
}
