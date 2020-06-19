using Emp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Emp.WebApi.Map
{
	public static class EmployeeMapConfig
	{
		public  static  Employee  ToEntity (this EmployeeModel  model   )
		{
			return new Employee(model.Name, model.Age, model.HiringDate);  
		}


		public static EmployeeModel ToModel(this Employee entity)
		{
			return new EmployeeModel
			{
				EmployeeId = entity.EmployeeId  ,  
				Name  =  entity.Name  ,  
				Age=  entity.Age  ,  
				HiringDate  =  entity.HiringDate  
			};
		}



	}
}