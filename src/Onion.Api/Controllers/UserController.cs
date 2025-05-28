using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.DTOs;
using Onion.Application.Service_Interfaces;

namespace Onion.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpPost("/api/user")]
        public async Task<IActionResult> CreateUser(CreateUserDTO createUser)
        {
            var res = await userService.CreateUser(createUser);
            return Ok(res);
        }
    }
}