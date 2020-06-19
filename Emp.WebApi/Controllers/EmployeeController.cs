using Emp.Core;
using Emp.DomainService;
using Emp.WebApi.Map;
using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Emp.WebApi.Controllers
{
	public class EmployeeController : ApiController
	{

		private readonly EmployeeService _emplpyeeService = new EmployeeService();

	

       [HttpPost]
		public IHttpActionResult AddEmp([FromBody] EmployeeModel employeeModel)
		{
			var employee = employeeModel.ToEntity();  
			var result = _emplpyeeService.AddEmployee(employee);

			return Ok();
		}

		[HttpGet]
		public IHttpActionResult Get()
		{
			var emp = _emplpyeeService.GetEmployeeByHiringDate(Convert.ToDateTime("2020-06-20 01:48:20.847"));

			return Ok(emp);  
		
		}


	}
}
