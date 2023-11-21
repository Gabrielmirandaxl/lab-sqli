using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_sqli.Models
{
    public class User
    {
        public int Id { get; set; }
        public string User_Name { get; set; }
        public string Email { get; set; }
        public string User_Password { get; set; }

        public User(
            int id, 
            string userName, 
            string email
        )
        {
            Id = id;
            User_Name = userName;
            Email = email;
        }
    }
}