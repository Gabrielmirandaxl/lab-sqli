using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using lab_sqli.Interfaces;
using lab_sqli.Models;
using MySql.Data.MySqlClient;

namespace lab_sqli.Data.Repository
{
    public class ProductRepository : IProductRepository
    {

        private readonly IConfiguration _configuration;
        private readonly string connectString;

        public ProductRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            connectString = _configuration.GetConnectionString("Default");
        }

        public async Task<IEnumerable<Product>> GetAllProductSearch(string search)
        {

            var sql = @$"SELECT  *  from  products  WHERE  product_name like '%{search}%' limit 1 ";
            
            using (var connection = new MySqlConnection(connectString))
            {
                return await connection.QueryAsync<Product>(sql);
            }
        }

    }
}