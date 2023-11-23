using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using lab_sqli.Dtos;
using lab_sqli.Interfaces;
using lab_sqli.Models;

namespace lab_sqli.Services
{
    public class UsersService : IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _map;

        public UsersService(
            IUserRepository userRepository,
            IMapper map
        )
        {
            _userRepository = userRepository;
            _map = map;
        }

        public async Task<UserDto> LoginUser(UserLoginDto user)
        {
            var userCreated = await _userRepository.LoginUser(user.Email, user.User_Password);

            return _map.Map<UserDto>(userCreated);
        }

        public async Task<UserDto> UpdateUser(UserUpdateDto user)
        {

            var userUpdate = new User(
                user.Id,
                user.User_Name,
                user.Email,
                user.User_Password
            );

            var userUpdated = await _userRepository.UpdateUser(userUpdate);

            return _map.Map<UserDto>(userUpdated);
        }
    }
}