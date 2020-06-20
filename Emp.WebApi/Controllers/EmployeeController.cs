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
		[ExcetionFilter]
		public IHttpActionResult AddEmp([FromBody]EmployeeModel employeeModel)
		{
			//Validate Model 
			var employee = employeeModel.ToEntity();  
			var result = _emplpyeeService.AddEmployee(employee);

			return Ok(result);
		}

		[HttpGet]
		[ExcetionFilter]
		public IHttpActionResult Get(DateTime hiringDate)
		{

			var emp = _emplpyeeService.GetEmployeeByHiringDate(hiringDate);

			return Ok(emp);  
		
		}


	}
}
