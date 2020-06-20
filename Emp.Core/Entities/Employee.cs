using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Core
{
	public class Employee
	{
		
		public Guid EmployeeId { get; private set; }

		[StringLength(100)]
		public string Name { get; private set; }

		public int Age { get; private set; }

		public DateTime HiringDate { get; private set; }


		public Employee()
		{

		}
		public Employee(string name, int age, DateTime hiringDate)
		{
			Name = name;
			Age = age;
			HiringDate = hiringDate;
		}
	}
}
