using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Shiftly.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        [Authorize(Roles = "Manager")]
        [HttpGet]
        public IActionResult GetAllUsers() => Ok();

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetUserById(Guid id) => Ok();

        [Authorize]
        [HttpPost]
        [HttpPost("create")]
        public async Task<IActionResult> CreateUser(string type, string name, string email)
        {
            var user = UserFactory.CreateUser(type, name, email);
            await _notifier.SendNotificationAsync(new { User = user, Message = "User created!" });
            return Ok(user);

            [Authorize]
        [HttpPut("{id}")]
        public IActionResult UpdateUser(Guid id, [FromBody] UserDto dto) => Ok();

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id) => Ok();
    }
}
