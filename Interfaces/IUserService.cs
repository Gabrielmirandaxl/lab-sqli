using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_sqli.Dtos;
using lab_sqli.Models;

namespace lab_sqli.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> LoginUser(UserLoginDto user);
        Task<UserDto> UpdateUser(UserUpdateDto user);
    }
}