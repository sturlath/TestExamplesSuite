using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TSOT.ToDoList.Core.InfrastructureContracts.Repository
{
	/// <summary>
	/// Having a generic repository is something I would recomend. This way all repository methods basically look the same.
	/// This code comes from http://deviq.com/repository-pattern/
	/// Other good ones are:
	/// https://techbrij.com/generic-repository-unit-of-work-entity-framework-unit-testing-asp-net-mvc
	/// https://cpratt.co/truly-generic-repository/
	/// 
	/// P.s
	/// You might want to skip the "Generic" part in the name and call it just IRepository, but the choice is yours.
	/// </summary>
	public interface IGenericRepository<T> where T : EntityBase
	{
		/* GetX methods could be broken out into a IGenericReadOnlyRepository
		   where IGenericRepository would inherit that one, and define Add/Delete/Edit 
		   Take a look at https://cpratt.co/truly-generic-repository/ for more resoning on that.
		*/

		Task<T> GetById(int id);
		Task<IEnumerable<T>> List();
		Task<IEnumerable<T>> List(Expression<Func<T, bool>> predicate);

		void Add(T entity);
		void Delete(T entity);
		void Edit(T entity);
	}

	public abstract class EntityBase
	{
		public int Id { get; protected set; }
	}
}
