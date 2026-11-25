using System;
using System.Collections.Generic;
using System.Text;
using MSF.Models;

namespace MSF.Repositories
{
    // This interface defines the contract for a product repository, which is responsible for managing product data.
    public interface IProductRepository
    {
        // The GetAllProducts method retrieves all products from the repository.
        IEnumerable<Product> GetAllProducts();

        // This method retrieves a product by its ID from the repository.
        Product? GetProductById(int productId);
    }
}
