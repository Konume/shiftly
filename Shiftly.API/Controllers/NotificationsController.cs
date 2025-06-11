using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult AddNotification([FromBody] NotificationDto dto) => Ok();
    }
}
