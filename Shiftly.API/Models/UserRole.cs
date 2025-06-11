namespace ShiftlyAPI.Models
{
    public interface IUser
    {
        string Name { get; set; }
        string Email { get; set; }
        public string UserId { get; set; }
        string GetPermissions();
    }

    public class Employee : IUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string EmployeeId { get; set; }
        public string GetPermissions() => "View Shifts";
    }

    public class Manager : IUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ManagerId { get; set; }
        public string GetPermissions() => "Manage Shifts, View Reports";
    }
}