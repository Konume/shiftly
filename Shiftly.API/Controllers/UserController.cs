using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Shiftly.API.Models; // Assuming User model is defined in this namespace
using Shiftly.API.Factories; // Assuming UserFactory is defined in this namespace
using Shiftly.API.Services; // Assuming INotifier is defined in this namespace

namespace Shiftly.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly INotifier _notifier;

        public UserController(INotifier notifier)
        {
            _notifier = notifier;
        }

        [Authorize(Roles = "Manager")]
        [HttpGet]
        public IActionResult GetAllUsers() => Ok();

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetUserById(Guid id) => Ok();

        [Authorize]
        [HttpPost]
        [HttpPost("create")]
        public async Task<IActionResult> CreateUser(string role, string name, string email)
        {
            var user = UserFactory.CreateUser(role, name, email);
            await _notifier.SendNotificationAsync(new { IUser = user, Message = "User created!" });
            return Ok(user);
        }

        [Authorize]
        [HttpPut("{id}")]
        public IActionResult UpdateUser(Guid id, [FromBody] IUser dto) => Ok();

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id) => Ok();
    }
}
