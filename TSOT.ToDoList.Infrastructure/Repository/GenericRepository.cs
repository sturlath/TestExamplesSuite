using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TSOT.ToDoList.Core.InfrastructureContracts.Repository;

namespace TSOT.ToDoList.Infrastructure.Repository
{
	/// <summary>
	/// This is the generic implementation of the generic interface. 
	/// 
	/// With it you could get away with implementing special repository classess 
	/// if you don´t have any special funtionality.
	/// 
	/// Implementation of it using Entity Framewor can be found here: http://deviq.com/repository-pattern/
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class GenericRepository<T> : IGenericRepository<T> where T : EntityBase
	{
		public void Add(T entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(T entity)
		{
			throw new NotImplementedException();
		}

		public void Edit(T entity)
		{
			throw new NotImplementedException();
		}

		public Task<T> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<T>> List()
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<T>> List(Expression<Func<T, bool>> predicate)
		{
			throw new NotImplementedException();
		}
	}
}
