using Homework1_ConsApp.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_ConsApp.src.model
{
	public class Personal : User, IPersonal
	{
		public string SSN { get; set; }
		public decimal Salary { get; set; }

		public Personal() { }
		public Personal(string userName, string password, bool isActive, string ssn, decimal salary) : base(userName, password, isActive)
		{
			SSN = ssn;
			Salary = salary;
		}
		public void CalculateSalary(short workingHours)
		{
			Console.WriteLine(@$"Calculated salary: {Salary * workingHours} ₺");
		}
	}
}
