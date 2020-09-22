using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace BestBuyBestPractices
{
    public class Connect
    {
        static IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

        static string connString = config.GetConnectionString("DefaultConnection");

        public static IDbConnection conn = new MySqlConnection(connString);
    }
}
