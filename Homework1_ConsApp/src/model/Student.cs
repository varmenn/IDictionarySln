using Homework1_ConsApp.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_ConsApp.src.model
{
	public  class Student : User, IStudent
	{
		public int AbsenceCount { get; set; }
		public byte Marks { get; set; }
		public string StudentID { get; set; }
		public Student() { }
		public Student(string userName, string password, bool isActive, int absenceCount, byte marks) : base(userName, password, isActive) // base- User conc isActive check
		{
			AbsenceCount = absenceCount;
			Marks = marks;
		}
	}

}
