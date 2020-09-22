using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyBestPractices
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public void CreateProduct(string name, decimal price, int cetegoryID);
    }
}
