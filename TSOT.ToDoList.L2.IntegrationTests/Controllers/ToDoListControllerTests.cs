using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Shouldly;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TSOT.ToDoList.Api;
using TSOT.ToDoList.Core.Models;

namespace IntegrationTests.Controllers
{
	/// <summary>
	/// See "Integration tests in ASP.NET Core" here: https://docs.microsoft.com/en-us/aspnet/core/testing/integration-testing?view=aspnetcore-2.1
	/// </summary>
	[TestClass]
	public class ToDoListControllerTests
	{
		private readonly TestServer _server;
		private readonly HttpClient _client;

		public ToDoListControllerTests()
		{
			// Arrange
			_server = new TestServer(new WebHostBuilder()
				.UseStartup<Startup>());
			_client = _server.CreateClient();
			_client.BaseAddress = new System.Uri("https://localhost/");
		}

		//TODO: Test method naming conventions https://dzone.com/articles/7-popular-unit-test-naming
		[TestMethod]
		public async Task GetAllToDoLists()
		{
			var response  = await _client.GetAsync("api/ToDoList");

			response.EnsureSuccessStatusCode();

			var responseStrong = await response.Content.ReadAsStringAsync();

			var listOfItems = JsonConvert.DeserializeObject<List<Item>>(responseStrong);

			listOfItems.Count.ShouldBe(3);
			listOfItems.ShouldContain(p => p.Description == "First");
			listOfItems.ShouldContain(p => p.Description == "Second");
			listOfItems.ShouldContain(p => p.Description == "Third");
		}
	}
}
