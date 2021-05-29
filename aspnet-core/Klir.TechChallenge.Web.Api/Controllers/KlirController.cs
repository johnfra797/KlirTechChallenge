using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Klir.TechChallenge.Domain.DTOs.Request;
using Klir.TechChallenge.Web.Api.Services;
using Klir.TechChallenge.Web.Api.Services.Command;
using Klir.TechChallenge.Web.Api.Services.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Klir.TechChallenge.Web.Api.Controllers
{
    public class KlirController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<KlirController> _logger;
        private readonly IConfiguration _configuration;
        public KlirController(IMediator mediator, ILogger<KlirController> logger, IConfiguration configuration)
        {
            _mediator = mediator;
            _logger = logger;
            _configuration = configuration;
        }

        [HttpPost("products")]
        public async Task<IActionResult> GetProducts(ProductRequest productRequest)
        {
            var response = await _mediator.Send(new GetProducts.Request(productRequest));
            return Ok(response);
        }
        [HttpPost("get/shoppingCart")]
        public async Task<IActionResult> GetShoppingCart(ShoppingCartRequest shoppingCartRequest)
        {
            var response = await _mediator.Send(new GetShoppingCart.Request(shoppingCartRequest));
            return Ok(response);
        }
        [HttpPost("shoppingCart")]
        public async Task<IActionResult> GetShoppingCart(ShoppingCartCreateRequest  shoppingCartCreateRequest)
        {
            var response = await _mediator.Send(new CreateShoppingCart.Request(shoppingCartCreateRequest));
            return Ok(response);
        }
    }
}
