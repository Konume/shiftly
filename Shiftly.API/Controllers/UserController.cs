using Microsoft.AspNetCore.Mvc;
using Shiftly.Core.Factories;
using Shiftly.Infrastructure.Notifications;
using Shiftly.Core.Models;
using System.Threading.Tasks;

namespace Shiftly.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ServiceBusNotifier _notifier;

        public UserController(ServiceBusNotifier notifier)
        {
            _notifier = notifier;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateUser(string type, string name, string email)
        {
            User user = UserFactory.CreateUser(type, name, email);

            // Example notification
            await _notifier.NotifyUserAsync(user.Email, "Welcome to Shiftly!");

            return Ok(user);
        }
    }
}