using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using Shiftly.API.Models; // Assuming SwapRequest model is defined in this namespace

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
        public IActionResult CreateSwapRequest([FromBody] SwapRequest dto) => Ok();

        [Authorize(Roles = "Manager")]
        [HttpPut("{id}/approve")]
        public IActionResult ApproveSwapRequest(Guid id) => Ok();

        [Authorize(Roles = "Manager")]
        [HttpPut("{id}/reject")]
        public IActionResult RejectSwapRequest(Guid id) => Ok();
    }
}
