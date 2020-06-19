using Emp.Core;
using Emp.Repositry;
using Emp.Repositry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.DomainService
{
	public class EmployeeService : IEmplpyeeService
	{

		private readonly EmployeeRepositry _repositry;
		public EmployeeService()
		{
			_repositry = new EmployeeRepositry( new EmployeeContext());
		}

		public Employee AddEmployee(Employee employee)
		{
			var result = _repositry.Insert<Employee>(employee);

			_repositry.SaveChanges();

			return result;
		}

		public IEnumerable<Employee> GetEmployeeByHiringDate(DateTime hiringdate)
		{

			return _repositry.FindBy<Employee>(obj => obj.HiringDate == hiringdate);

		}
	}
}
