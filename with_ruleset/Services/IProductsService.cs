using System.Collections.Generic;

namespace ProductsAPI.Services
{
    /// <summary>The product service.</summary>
    public interface IProductsService
    {
        /// <summary>Gets the products.</summary>
        /// <returns>All <see cref="Product"/>s.</returns>
        public List<Product> GetProducts();

        /// <summary>Adds the product.</summary>
        /// <param name="productItem">The product item.</param>
        /// <returns>The new <see cref="Product"/>.</returns>
        public Product AddProduct(Product productItem);

        /// <summary>Updates the product.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="productItem">The product item.</param>
        /// <returns>Updated <see cref="Product"/>.</returns>
        public Product UpdateProduct(string id, Product productItem);

        /// <summary>Deletes the product.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The id.</returns>
        public string DeleteProduct(string id);
    }
}
