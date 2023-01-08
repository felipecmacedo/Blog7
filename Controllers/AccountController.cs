using Blog7.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics;

namespace Blog7.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("v1/login")]
        public IActionResult Login([FromServices] TokenService tokenService)
        {
            var token = tokenService.GenerateToken(null);

            return Ok(token);
        }
    }
}
