using System;

namespace Shiftly.API.Models
{
    public class Notification
    {
        public string Id { get; set; } // Unique identifier
        public string UserId { get; set; } // Recipient (Employee or Manager)
        public string Title { get; set; } // Short notification title
        public string Message { get; set; } // Detailed message body
        public DateTime CreatedAt { get; set; } // When the notification was generated
        public bool IsRead { get; set; } // Has the user viewed this notification?
        public string Type { get; set; } // E.g., "ShiftChange", "LeaveApproved", "Reminder"
        public string RelatedEntityId { get; set; } // Optional: related shift/leave/request id
    }
}