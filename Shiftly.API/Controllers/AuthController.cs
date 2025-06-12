//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Shiftly.API.DTOs.RegisterLogin;

//namespace Shiftly.Controllers
//{
//    [ApiController]
//    [Route("auth")]
//    public class AuthController : ControllerBase
//    {
//        [HttpPost("register")]
//        public IActionResult Register([FromBody] Register dto) => Ok();

//        [HttpPost("login")]
//        public IActionResult Login([FromBody] Login dto) => Ok();

//        [Authorize]
//        [HttpGet("profile")]
//        public IActionResult Profile() => Ok();
//    }
//}