using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_ConsApp.src.interfaces
{
	public  interface IUser
	{
		string UserName { get; set; }
		string Password { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		bool IsActive { get; set; }
		string UserIDnumber { get; set; }

	}
}
