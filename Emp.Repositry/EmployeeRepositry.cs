using Emp.Repositry.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Emp.Repositry
{
	public class EmployeeRepositry : IRepositry
	{
		private readonly DbContext _context;
		public DbContext DbContext { get { return _context; } }

		public EmployeeRepositry(DbContext dbContext)
		{
			_context = dbContext;
		}

		public IEnumerable<TEntity> FindBy<TEntity>(Expression<Func<TEntity, bool>> pridicate) where TEntity : class
		{
			var result = _context.Set<TEntity>().AsQueryable();

			return result.AsNoTracking().Where(pridicate).ToList();
		}

		public TEntity Insert<TEntity>(TEntity entity) where TEntity : class
		{
			var result = _context.Set<TEntity>().Add(entity);
			return result;
		}

		public void SaveChanges()
		{
			_context.SaveChanges();
		}
	}
}
