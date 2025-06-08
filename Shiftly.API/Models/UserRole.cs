namespace ShiftlyAPI.Models
{
    public interface IUserRole
    {
        string GetPermissions();
    }

    public class Employee : IUserRole
    {
        public string GetPermissions() => "View Shifts";
    }

    public class Manager : IUserRole
    {
        public string GetPermissions() => "Manage Shifts, View Reports";
    }
}