using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Services;

namespace ProductsAPI.Controllers
{
    /// <summary>The controller.</summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _service;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsController"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public ProductsController(IProductsService service)
        {
            _service = service;
        }

        /// <summary>Gets the products.</summary>
        [HttpGet("/api/products")]
        public ActionResult<List<Product>> GetProducts()
        {
            return _service.GetProducts();
        }

        /// <summary>Adds the product.</summary>
        /// <param name="product">The product.</param>
        [HttpPost("/api/products")]
        public ActionResult<Product> AddProduct(Product product)
        {
            _service.AddProduct(product);
            return product;
        }

        /// <summary>Updates the product.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="product">The product.</param>
        [HttpPut("/api/products/{id}")]
        public ActionResult<Product> UpdateProduct(string id, Product product)
        {
            _service.UpdateProduct(id, product);
            return product;
        }

        /// <summary>Deletes the product.</summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete("/api/products/{id}")]
        public ActionResult<string> DeleteProduct(string id)
        {
            _service.DeleteProduct(id);
            return id;
        }
    }
}
