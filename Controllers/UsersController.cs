
using lab_sqli.Dtos;
using lab_sqli.Exceptions;
using lab_sqli.Interfaces;
using lab_sqli.Models;
using lab_sqli.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lab_sqli.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {

        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> LoginUser([FromBody] UserLoginDto user)
        {

            var loginUser = await _userService.LoginUser(user);


            if (loginUser == null)
            {
                throw new BadRequestException("Email ou Senha incorretos");
            }

          var token = TokenService.TokenGenerate(loginUser);

            return Ok(new {token, loginUser});
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser ([FromBody] UserUpdateDto user)
        {
            var userUpdate = await _userService.UpdateUser(user);

            return Ok(userUpdate);
        }

    }
}