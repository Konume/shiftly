using ShiftlyAPI.Models;
using System;

namespace ShiftlyAPI.Factories
{
	public static class UserFactory
	{
		public static IUserRole CreateUser(string role)
		{
			return role switch
			{
				"Employee" => new Employee(),
				"Manager" => new Manager(),
				_ => throw new ArgumentException("Unknown role")
			};
		}
	}
}
