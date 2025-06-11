using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Shiftly.Controllers
{
    [ApiController]
    [Route("leave-requests")]
    public class LeaveRequestsController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetAllLeaveRequests() => Ok();

        [Authorize]
        [HttpPost]
        public IActionResult CreateLeaveRequest([FromBody] LeaveRequestDto dto) => Ok();

        [Authorize(Roles = "Manager")]
        [HttpPut("{id}/approve")]
        public IActionResult ApproveRequest(Guid id) => Ok();

        [Authorize(Roles = "Manager")]
        [HttpPut("{id}/reject")]
        public IActionResult RejectRequest(Guid id) => Ok();
    }
}