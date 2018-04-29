using System;
using System.Collections.Generic;
using System.Text;
using TSOT.ToDoList.Core.InfrastructureContracts.Repository;

namespace TSOT.ToDoList.Core.Models
{
    public class Item: EntityBase
	{
		public string Description { get; set; }
	}
}
