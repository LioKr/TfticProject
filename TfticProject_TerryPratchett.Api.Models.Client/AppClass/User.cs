using System;

namespace TfticProject_TerryPratchett.Api.Models.Client
{
    public class User
    {
		public int UserId { get; private set; }
		public string Firstname { get; private set; }
		public string Lastname { get; private set; }
		public string Email { get; private set; }
		public string Username { get; private set; }
		public string Password { get; private set; }
		public string Role { get; private set; }

		public User(string firstname, string lastname, string email, string username,string password, string role)
		{
			Firstname = firstname;
			Lastname = lastname;
			Email = email;
			Username = username;
			Password = password;
			Role = role;
		}

		internal User(int id,string firstname, string lastname, string email, string username,string password, string role)
		:this(firstname, lastname, email, username, password, role)
		{
			UserId = id;
		}
	}
}
