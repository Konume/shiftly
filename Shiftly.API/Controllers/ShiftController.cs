using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using Shiftly.API.Models;

namespace Shiftly.Controllers
{
    [ApiController]
    [Route("shifts")]
    public class ShiftController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetUserShifts() => Ok();

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetShiftById(Guid id) => Ok();

        [Authorize(Roles = "Manager")]
        [HttpPost]
        public IActionResult CreateShift([FromBody] Shift dto) => Ok();

        [Authorize]
        [HttpPut("{id}")]
        public IActionResult UpdateShift(Guid id, [FromBody] Shift dto) => Ok();

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeleteShift(Guid id) => Ok();
    }
}
