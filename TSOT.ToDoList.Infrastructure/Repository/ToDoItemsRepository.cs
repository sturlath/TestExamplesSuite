using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TSOT.ToDoList.Core.InfrastructureContracts.Repository;
using TSOT.ToDoList.Core.Models;

namespace TSOT.ToDoList.Infrastructure.Repository
{
	public class ToDoItemsRepository : IToDoListRepository<Item>
	{
		public void Add(Item entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Item entity)
		{
			throw new NotImplementedException();
		}

		public void Edit(Item entity)
		{
			throw new NotImplementedException();
		}

		public Task<List<Core.Models.Item>> GetAllUnreadItemsAndMarkThemRead()
		{
			throw new NotImplementedException();
		}

		public Task<Item> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Item>> List()
		{
			//just some static test data to try out integration tests. 
			//TODO: Remove code when database has been implemented. This can be used in mocked tests.
			IEnumerable<Item> items = new Item[] { new Item() { Description = "First" }, new Item() { Description = "Second" } };
			items = items.Append(new Item() { Description = "Third" }); //another way to add/append to IEnumerable

			return await Task.Run(() => items);
		}

		public Task<IEnumerable<Item>> List(Expression<Func<Item, bool>> predicate)
		{
			throw new NotImplementedException();
		}
	}
}
