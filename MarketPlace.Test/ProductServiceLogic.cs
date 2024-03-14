﻿using MarketPlace.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Test
{
    public partial class ProductServiceLogic : ProductServiceTests
    {

        [Fact]
        public async Task ShouldAddNewProductAsync()
        {

            var inputProduct = new Product()
            {
                Id = 1,
                Name = "Test",
                Description = "zo'r narsa"
            };
            var expectedProduct = new Product()
            {
                Id = inputProduct.Id,
                Name = inputProduct.Name,
                Description = inputProduct.Description
            };

            _productRepoMock.Setup(p => p.InsertAsync(It.IsAny<Product>()))
                .ReturnsAsync(expectedProduct);

            var actualProduct = await _productService.Add(inputProduct);

            Assert.Equal(expectedProduct.Name, actualProduct.Name);
            Assert.Equal(expectedProduct.Description, actualProduct.Description);
        }

        [Fact]
        public async Task ShouldDeleteNewProductAsync()
        {

            var inputProduct = new Product()
            {
                Id = 1,
                Name = "Test",
                Description = "zo'r narsa"
            };
            var expectedProduct = new Product()
            {
                Id = inputProduct.Id,
                Name = inputProduct.Name,
                Description = inputProduct.Description
            };

            _productRepoMock.Setup(p => p.DeleteAsync(It.IsAny<Product>()))
                .ReturnsAsync(expectedProduct);

            var actualProduct = await _productService.Delete(inputProduct.Id);

            Assert.Equal(expectedProduct.Name, actualProduct.Name);
            Assert.Equal(expectedProduct.Description, actualProduct.Description);
        }

        public async Task ShouldUpdateNewProductAsync()
        {

            var inputProduct = new Product()
            {
                Id = 1,
                Name = "Test",
                Description = "zo'r narsa"
            };
            var expectedProduct = new Product()
            {
                Id = inputProduct.Id,
                Name = inputProduct.Name,
                Description = inputProduct.Description
            };

            _productRepoMock.Setup(p => p.UpdateAsync(It.IsAny<Product>()))
                .ReturnsAsync(expectedProduct);

            var actualProduct = await _productService.Update(inputProduct.Id, inputProduct);

            Assert.Equal(expectedProduct.Name, actualProduct.Name);
            Assert.Equal(expectedProduct.Description, actualProduct.Description);
        }
    }
}
