using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TSOT.ToDoList.Core.InfrastructureContracts.Repository;
using TSOT.ToDoList.Core.Models;

namespace ToDoListApi.Controllers
{
	[Produces("application/json")]
    [Route("api/[controller]")]
    public class ToDoListController : Controller
    {
		private IToDoListRepository<Item> _repository { get; }

		public ToDoListController(IToDoListRepository<Item> repository)
		{
			_repository = repository;
		}

		// GET: api/ToDoList
		[HttpGet]
		public async Task<IEnumerable<Item>> Get()
		{
			return await _repository.List();
		}

		// GET: api/ToDoList/5
		[HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ToDoList
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ToDoList/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
