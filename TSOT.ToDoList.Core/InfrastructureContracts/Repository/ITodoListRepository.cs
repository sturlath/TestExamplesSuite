using System.Collections.Generic;
using System.Threading.Tasks;

namespace TSOT.ToDoList.Core.InfrastructureContracts.Repository
{
	public interface IToDoListRepository<T> : IGenericRepository<T> where T : EntityBase
	{
		/// <summary>
		/// Just an example of how you would do something totally different from 
		/// the generic repository. 
		/// This is an example of a method that should not be in the generic so we put it here
		/// </summary>
		/// <returns></returns>
		Task<List<T>> GetAllUnreadItemsAndMarkThemRead();
	}
}
