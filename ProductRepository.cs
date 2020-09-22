using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BestBuyBestPractices
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;

        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM products;").ToList();
        }

        public void CreateProduct(string name, decimal price, int categoryID)
        {
            _connection.Execute("INSERT INTO products (Name, Price, CategoryID) " +
                "VALUES (@newName, @newPrice, @newCategoryID);"
                , new {newName = name, newPrice = price, newCategoryID = categoryID });
        }

        public void UpdateProduct(string name, decimal price, int categoryID, int productID)
        {
            _connection.Execute("UPDATE products SET Name = @newName, Price = @newPrice, CategoryID = @newCategoryID WHERE ProductID = @newproductID;",
                new { @newName = name, @newPrice = price, @newCategoryID = categoryID, @newproductID = productID });
        }

        public void DeleteProduct(int productID)
        {
            _connection.Execute("DELETE FROM products WHERE ProductID = @newproductID;",
                new { @newProductID = productID }); 
            
            _connection.Execute("DELETE FROM sales WHERE ProductID = @newproductID;",
                new { @newProductID = productID });
            
            _connection.Execute("DELETE FROM reviews WHERE ProductID = @newproductID;",
                new { @newProductID = productID });
        }
    }
}
