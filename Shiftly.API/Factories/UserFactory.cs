using ShiftlyAPI.Models;
using System;

namespace ShiftlyAPI.Factories
{
	public static class UserFactory
	{
		public static IUser CreateUser(string type, string name, string email)
		{
			return type switch
			{
				"Employee" => new Employee { Name = name, Email = email },
				"Manager" => new Manager { Name = name, Email = email },
				_ => throw new ArgumentException("Unknown role")
			};
		}
	}
}
