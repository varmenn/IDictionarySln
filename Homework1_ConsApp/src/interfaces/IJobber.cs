using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_ConsApp.src.interfaces
{
	internal interface IJobber : IUser
	{
		string JobArea { get; set; }

		string PlateID { get; set; }
	}
}
