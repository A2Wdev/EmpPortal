using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Core
{
	public class EmployeeContext : DbContext
	{
		public EmployeeContext() : base("Cnnstr")
		{
			base.Configuration.ProxyCreationEnabled = false;
			base.Configuration.ValidateOnSaveEnabled = false;

			Database.SetInitializer<EmployeeContext>(new CreateDatabaseIfNotExists<EmployeeContext>());
			//Database.SetInitializer<EmployeeContext>(new NullDatabaseInitializer<EmployeeContext>());
		}


		DbSet<Employee> Employees { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			BaseEntityMap(modelBuilder);

			base.OnModelCreating(modelBuilder);
		}

		private void BaseEntityMap(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Employee>().HasKey(x => x.EmployeeId);
		}

	}
}
