using System.Collections.Generic;

namespace ProductsAPI.Services
{
    /// <summary>Implementation of <see cref="IProductsService" />.</summary>
    /// <seealso cref="ProductsAPI.Services.IProductsService" />
    public class ProductsService : IProductsService
    {
        private readonly List<Product> _productItems;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsService" /> class.
        /// </summary>
        public ProductsService()
        {
            _productItems = new List<Product>();
        }

        /// <inheritdoc/>
        public List<Product> GetProducts()
        {
            return _productItems;
        }

        /// <inheritdoc/>
        public Product AddProduct(Product productItem)
        {
            _productItems.Add(productItem);
            return productItem;
        }

        /// <inheritdoc/>
        public Product UpdateProduct(string id, Product productItem)
        {
            for (var index = _productItems.Count - 1; index >= 0; index--)
            {
                if (_productItems[index].ID == id)
                {
                    _productItems[index] = productItem;
                }
            }

            return productItem;
        }

        /// <inheritdoc/>
        public string DeleteProduct(string id)
        {
            for (var index = _productItems.Count - 1; index >= 0; index--)
            {
                if (_productItems[index].ID == id)
                {
                    _productItems.RemoveAt(index);
                }
            }

            return id;
        }
    }
}
