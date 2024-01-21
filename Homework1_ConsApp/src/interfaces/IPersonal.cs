using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_ConsApp.src.interfaces
{
	public interface IPersonal : IUser
	{
		string SSN { get; set; }
		decimal Salary { get; set; }
		void CalculateSalary(short workingHours);
	}
}
