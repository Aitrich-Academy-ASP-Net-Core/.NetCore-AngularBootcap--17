
using TaskManagementSystemss;

public class User
{
	public int UserId { get; set; }
	public string Name { get; set; }
	public List<ProjectTask> AssignedTasks { get; set; }

	public User(int userId, string name)
	{
		UserId = userId;
		Name = name;
		AssignedTasks = new List<ProjectTask>();
	}

	public void AddTask(ProjectTask task)
	{
		AssignedTasks.Add(task);
	}

	public void RemoveTask(ProjectTask task)
	{
		AssignedTasks.Remove(task);
	}

	public void ViewTasks()
	{
		foreach (var task in AssignedTasks)
		{
			Console.WriteLine($"{task.TaskId}: {task.Title} (Priority: {task.Priority})");
		}
	}
}
