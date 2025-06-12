using Shiftly.API.Models;
using System;

namespace Shiftly.API.Factories
{
    public static class UserFactory
    {
        public static IUser CreateUser(string role, string name, string email)
        {
            if (string.IsNullOrWhiteSpace(role))
                throw new ArgumentException("Role cannot be null or empty.", nameof(role));

            return role.ToLowerInvariant() switch
            {
                "employee" => new Employee
                {
                    Name = name,
                    Email = email,
                    Role = "Employee"
                },
                "manager" => new Manager
                {
                    Name = name,
                    Email = email,
                    Role = "Manager"
                },
                _ => throw new NotSupportedException($"Unsupported user role: {role}")
            };
        }
    }
}
