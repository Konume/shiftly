using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shiftly.API.Models; // Assuming Notification model is defined in this namespace
namespace Shiftly.Controllers
{
    [ApiController]
    [Route("notifications")]
    public class NotificationsController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetAllNotifications() => Ok();

        [Authorize]
        [HttpPost]
        public IActionResult AddNotification([FromBody] Notification dto) => Ok();
    }
}
