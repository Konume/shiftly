using System;

namespace Shiftly.API.Models
{ 
public class LeaveRequest
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string UserId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Reason { get; set; }
    public string Status { get; set; } = "Pending"; // "Pending", "Approved", "Rejected"
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
}
