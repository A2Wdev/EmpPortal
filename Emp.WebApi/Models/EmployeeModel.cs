using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Emp.WebApi
{
	public class EmployeeModel
	{
		public Guid EmployeeId { get;  set; }

		[Required]
		public string Name { get;  set; }

		[Required]
		public int Age { get;  set; }

		[Required]
		public DateTime HiringDate { get;  set; }

	}
}