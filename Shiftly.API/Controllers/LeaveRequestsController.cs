using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using Shiftly.API.Models; 

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
        public IActionResult CreateLeaveRequest([FromBody] LeaveRequest dto) => Ok();

        [Authorize(Roles = "Manager")]
        [HttpPut("{id}/approve")]
        public IActionResult ApproveRequest(Guid id) => Ok();

        [Authorize(Roles = "Manager")]
        [HttpPut("{id}/reject")]
        public IActionResult RejectRequest(Guid id) => Ok();
    }
}