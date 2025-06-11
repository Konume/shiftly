using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Shiftly.Controllers
{
    [ApiController]
    [Route("swap-requests")]
    public class SwapRequestsController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetAllSwapRequests() => Ok();

        [Authorize]
        [HttpPost]
        public IActionResult CreateSwapRequest([FromBody] SwapRequestDto dto) => Ok();

        [Authorize(Roles = "Manager")]
        [HttpPut("{id}/approve")]
        public IActionResult ApproveSwapRequest(Guid id) => Ok();

        [Authorize(Roles = "Manager")]
        [HttpPut("{id}/reject")]
        public IActionResult RejectSwapRequest(Guid id) => Ok();
    }
}
