namespace Shiftly.API.Models
{
    public interface IUser
    {
        string UserId { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Role { get; }
        string GetPermissions();
    }

    public class Employee : IUser
    {
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } = "Employee";
        public string GetPermissions() => "View Shifts";
    }

    public class Manager : IUser
    {
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } = "Manager";
        public string GetPermissions() => "Manage Shifts, View Reports";
    }
}
