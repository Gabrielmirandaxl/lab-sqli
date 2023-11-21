using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_sqli.Dtos
{
    public class UserLoginDto
    {
        public string Email { get; set; }
        public string User_Password { get; set; }
    }
}