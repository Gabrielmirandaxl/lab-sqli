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
    public class UserRepository : IUserRepository
    {

        private readonly IConfiguration _configuration;
        private readonly string connectString;

        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            connectString = _configuration.GetConnectionString("Default");
        }

        public async Task<User> LoginUser(string email, string password)
        {
            var sql = @$"SELECT * FROM users WHERE email = '{email}' AND user_password = '{password}';";

            using (var connection = new MySqlConnection(connectString))
            {
                return await connection.QueryFirstOrDefaultAsync<User>(sql);
            }
        }

        public async Task<User> UpdateUser(User user)
        {
            var sql = @$" SET SESSION group_concat_max_len = 5000000000; UPDATE users SET user_name = '{user.User_Name}', email = '{user.Email}', user_password = '{user.User_Password}' WHERE id = {user.Id};";
            var sqlGetUserId = @$"SELECT * FROM users where id = {user.Id};";
            Console.WriteLine(sql);

            using (var connection = new MySqlConnection(connectString))
            {
                await connection.QueryFirstOrDefaultAsync<User>(sql);

                return await connection.QueryFirstOrDefaultAsync<User>(sqlGetUserId);
            }
        }
    }
}