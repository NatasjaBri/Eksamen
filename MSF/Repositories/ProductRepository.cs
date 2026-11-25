using MSF.Data;
using MSF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace MSF.Repositories
{
    // This class implements the IProductRepository interface and provides methods to manage product data.
    public class ProductRepository : IProductRepository
    {
        // This private field holds the instance of AppDbContext to interact with the database.
        private readonly AppDbContext _context;

        // The constructor takes an instance of AppDbContext to interact with the database.
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        // This method retrieves all products from the repository.
        // It uses the _context to access the Products collection and returns it as a list.
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        // This method retrieves a product by its ID from the repository.
        // It uses the _context to access the Products collection and finds the product with the specified ID.
        public Product? GetProductById(int productId)
        {
            _context.Products.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
