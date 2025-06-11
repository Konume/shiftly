using System;

namespace Shiftly.API.Models
{
    public class Shift
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public string? Notes { get; set; }
    }
}