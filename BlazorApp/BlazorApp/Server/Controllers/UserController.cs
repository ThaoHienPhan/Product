﻿using BlazorApp.Server.Interfaces;
using BlazorApp.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IProduct _IProduct;

        public UserController(IProduct iProduct)
        {
            _IProduct = iProduct;
        }

        [HttpGet]
        public async Task<List<Product>> Get()
        {
            return await Task.FromResult(_IProduct.GetProductDetails());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Product product = _IProduct.GetProductData(id);
            if (product != null)
            {
                return Ok(product);
            }
            return NotFound();
        }

        [HttpPost]
        public void Post(Product product)
        {
            _IProduct.AddProduct(product);
        }

        [HttpPut]
        public void Put(Product product)
        {
            _IProduct.UpdateProductDetails(product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _IProduct.DeleteProduct(id);
            return Ok();
        }
    }
}
