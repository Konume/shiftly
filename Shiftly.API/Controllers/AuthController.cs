using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Shiftly.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterDto dto) => Ok();

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto dto) => Ok();

        [Authorize]
        [HttpGet("profile")]
        public IActionResult Profile() => Ok();
    }
}