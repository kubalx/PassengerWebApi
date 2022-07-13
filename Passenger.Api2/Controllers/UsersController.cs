using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Passenger.Infrastucture.Commands.Users;
using Passenger.Infrastucture.DTO;
using Passenger.Infrastucture.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passenger.Api2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}")]
        public async Task<UserDto> Get(string email)
            => await _userService.GetAsync(email);

        [HttpPost("")]
        public async Task Post([FromBody]CreateUser request)
            => await _userService.RegisterAsync(request.Email, request.Username, request.Password);
    }
}
