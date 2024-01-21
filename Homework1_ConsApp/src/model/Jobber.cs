using Homework1_ConsApp.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_ConsApp.src.model
{
	public class Jobber : User, IJobber
	{
		public string JobArea { get; set; }
		public string PlateID { get; set; }
		public Jobber() { }
		public Jobber(string userName, string password, bool isActive, string jobArea) : base(userName, password, isActive)
		{
			JobArea = jobArea;
		}
	}
}
