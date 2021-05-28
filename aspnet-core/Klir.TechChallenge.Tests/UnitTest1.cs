using System;
using System.Collections.Generic;
using System.Linq;
using Klir.TechChallenge.Data.Dao.Definitions.Commands;
using Klir.TechChallenge.Data.Dao.Definitions.Querys;
using Klir.TechChallenge.Data.Dao.Implementations.Querys;
using Klir.TechChallenge.Domain.DTOs.Request;
using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Services.Commands.Implementations;
using Klir.TechChallenge.Services.Querys.Implementations;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace KlirTechChallenge.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetProductsTest()
        {
            var ListProduct = new List<Product>() {
            new Product(){  Id=1, Name="Product 1" , Price=20, Promotion="Test"},
            new Product(){  Id=2, Name="Product 2" , Price=30, Promotion="Test 2"}
            };

            var moq = new Mock<IProductQueryDao>();
            moq.Setup(x => x.GetAll()).Returns(ListProduct.AsQueryable());
            ProductRequest productRequest = new ProductRequest();
            var getProductsQuery = new GetProductsQuery(moq.Object);
            var result = getProductsQuery.GetProducts(productRequest).Products.Any();
            Assert.True(result);
        }

        [Fact]
        public void GetProductsTestFailed()
        {
            var ListProduct = new List<Product>();

            var moq = new Mock<IProductQueryDao>();
            moq.Setup(x => x.GetAll()).Returns(ListProduct.AsQueryable());
            ProductRequest productRequest = new ProductRequest();
            var getProductsQuery = new GetProductsQuery(moq.Object);
            var result = getProductsQuery.GetProducts(productRequest).Products.Any();
            Assert.False(result);
        }

        [Fact]
        public void GetShoppingCartTest()
        {
            var ListShoppingCart = new List<ShoppingCart>() {
            new ShoppingCart(){  Id=1, Price=20, ProductName="Product 1", PromotionApplied="Promotion", Quantity=2, Total=40},
            new ShoppingCart(){  Id=2, Price=30, ProductName="Product 2", PromotionApplied="Promotion", Quantity=3, Total=90}
            };

            var moq = new Mock<IShoppingCartQueryDao>();
            moq.Setup(x => x.GetAll()).Returns(ListShoppingCart.AsQueryable());
            ShoppingCartRequest shoppingCartRequest = new ShoppingCartRequest();
            var getShoppingCartQuery = new GetShoppingCartQuery(moq.Object);
            var result = getShoppingCartQuery.GetShoppingCart(shoppingCartRequest).shoppingCart;
            Assert.True(result != null);
        }

        [Fact]
        public void GetShoppingCartTestFailed()
        {
            var ListShoppingCart = new List<ShoppingCart>() {
            new ShoppingCart(){  Id=1, Price=20, ProductName="Product 1", PromotionApplied="Promotion", Quantity=2, Total=40},
            new ShoppingCart(){  Id=2, Price=30, ProductName="Product 2", PromotionApplied="Promotion", Quantity=3, Total=90}
            };

            var moq = new Mock<IShoppingCartQueryDao>();
            moq.Setup(x => x.GetAll()).Returns(ListShoppingCart.AsQueryable());
            ShoppingCartRequest shoppingCartRequest = new ShoppingCartRequest();
            var getShoppingCartQuery = new GetShoppingCartQuery(moq.Object);
            var result = getShoppingCartQuery.GetShoppingCart(shoppingCartRequest).shoppingCart;
            Assert.False(result != null);
        }

        [Fact]
        public void CreateShoppingCartTest()
        {
            var moq = new Mock<IShoppingCartCommandDao>();
            ShoppingCartCreateRequest shoppingcartcreaterequest = new ShoppingCartCreateRequest();
            var createShoppingCartCommand = new CreateShoppingCartCommand(moq.Object);
            var result = createShoppingCartCommand.Create(shoppingcartcreaterequest);
            Assert.True(result != null);
        }
        [Fact]
        public void CreateShoppingCartTestFailed()
        {
            var moq = new Mock<IShoppingCartCommandDao>();
            ShoppingCartCreateRequest shoppingcartcreaterequest = new ShoppingCartCreateRequest();
            var createShoppingCartCommand = new CreateShoppingCartCommand(moq.Object);
            var result = createShoppingCartCommand.Create(shoppingcartcreaterequest);
            Assert.False(result != null);
        }
    }
}
