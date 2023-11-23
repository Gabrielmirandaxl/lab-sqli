using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_sqli.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string User_Name { get; set; }
        public string User_Password { get; set; }
    }
}