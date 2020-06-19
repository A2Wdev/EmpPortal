using Emp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.DomainService
{
	public interface IEmplpyeeService
	{
		IEnumerable<Employee> GetEmployeeByHiringDate(DateTime hiringdate);

		Employee AddEmployee(Employee employee);  

	}
}
