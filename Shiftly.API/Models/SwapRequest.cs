using System;
namespace Shiftly.API.Models
{
    public class SwapRequest
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public string ShiftId { get; set; }
        public string Status { get; set; } = "Pending"; // "Pending", "Approved", "Rejected"
        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;
    }
}