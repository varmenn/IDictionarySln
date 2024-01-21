using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_ConsApp.src.interfaces
{
	public interface IStudent : IUser
	{
		int AbsenceCount { get; set; }
		byte Marks { get; set; }
		string StudentID { get; set; }
	}
}
