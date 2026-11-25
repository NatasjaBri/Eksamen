using System;
using System.Collections.Generic;
using System.Text;
using MSF.Models;

namespace MSF.Repositories
{
    // This class implements the IProductRepository interface and provides methods to manage product data.
    public class ProductRepository : IProductRepository
    {
        // This method retrieves all products from the repository.
        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        // This method retrieves a product by its ID from the repository.
        public Product? GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
