using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_sqli.Models;

namespace lab_sqli.Interfaces
{
    public interface IUserRepository
    {
           Task<User> LoginUser(string email, string password);
           Task<User> UpdateUser(User user);
    }
}