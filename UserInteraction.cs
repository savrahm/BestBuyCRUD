using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace BestBuyBestPractices
{
    public class UserInteraction : Connect
    {
        public static void UserDeleteProduct()
        {
            var prodRepo = new ProductRepository(conn);

            Console.WriteLine("Please enter the Product ID of the product you want to delete.");
            var productID = int.Parse(Console.ReadLine());

            prodRepo.DeleteProduct(productID);
        }

        public static void UserUpdateProduct()
        {
            var prodRepo = new ProductRepository(conn);

            Console.WriteLine("Please enter the Product ID of the product you want to update.");
            var productID = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the product's new name. If you don't want to update the name, please enter the product's current name.");
            var name = Console.ReadLine();

            Console.WriteLine("Please enter the product's new price. If you don't want to update the price, please enter the product's current price.");
            var price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the product's new Category ID. If you don't want to update the Category ID, please enter the product's current Category ID.");
            var categoryID = int.Parse(Console.ReadLine());

            prodRepo.UpdateProduct(name, price, categoryID, productID);
        }
    }
}
