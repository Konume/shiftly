using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Shiftly.Controllers
{
    [ApiController]
    [Route("shifts/export")]
    public class ExportController : ControllerBase
    {
        [Authorize]
        [HttpGet("pdf")]
        public IActionResult ExportShiftsToPdf() => Ok();
    }
}
