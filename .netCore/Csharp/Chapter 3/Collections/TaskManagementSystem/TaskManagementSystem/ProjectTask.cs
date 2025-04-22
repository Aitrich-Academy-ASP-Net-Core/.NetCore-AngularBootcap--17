using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystemss
{


	public class ProjectTask
	{
		public int TaskId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Priority { get; set; }

		public ProjectTask(int taskId, string title, string description, int priority)
		{
			TaskId = taskId;
			Title = title;
			Description = description;
			Priority = priority;
		}
	}

	}
	

	


