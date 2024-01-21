using Homework1_ConsApp.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_ConsApp.src.model
{
	public abstract class User : IUser
	{
		public string UserName { get ; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsActive { get; set; }
		public string UserIDnumber { get; set; }
		public User() { }
		public User(string userName, string password, bool isActive)
		{
			UserName = userName;
			Password = password;
			IsActive = isActive;
		}
	}
}
