using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

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
        public IActionResult CreateShift([FromBody] ShiftDto dto) => Ok();

        [Authorize]
        [HttpPut("{id}")]
        public IActionResult UpdateShift(Guid id, [FromBody] ShiftDto dto) => Ok();

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeleteShift(Guid id) => Ok();
    }
}
