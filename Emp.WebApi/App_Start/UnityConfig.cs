using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using Unity;
using Emp.Core;
using Unity.Lifetime;
using Unity.Injection;

namespace Emp.WebApi.App_Start
{
	public class UnityConfig
	{
		public static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
	   {
		   var container = new UnityContainer();
		   RegisterTypes(container);
		   return container;
	   });

		public static IUnityContainer GetConfiguredContainer()
		{
			return container.Value;
		}

		public static void RegisterTypes(IUnityContainer container)
		{
			container.RegisterType<DbContext, EmployeeContext>(new PerResolveLifetimeManager(),  new InjectionConstructor()); 

			//container.RegisterType(AllClases)

		}
	}
}