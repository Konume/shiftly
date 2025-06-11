using System;

namespace Shiftly.API.Events
{
    public class LeaveRequestApprovedEvent
    {
        public string EmployeeId { get; set; }
        public string ManagerId { get; set; }
        public string LeaveRequestId { get; set; }
        public DateTime ApprovedAt { get; set; }
    }
}