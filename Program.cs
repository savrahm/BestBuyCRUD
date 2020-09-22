using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;


namespace BestBuyBestPractices
{
    class Program : Connect
    {
        static void Main(string[] args)
        {
            //UserInteraction.UserUpdateProduct();

            //var prodRepo = new ProductRepository(conn);
            //prodRepo.UpdateProduct("Test II: The Retesting", 14, 7, 941);

            UserInteraction.UserDeleteProduct();
        }
    }
}
