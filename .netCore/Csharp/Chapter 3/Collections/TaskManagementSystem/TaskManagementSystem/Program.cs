using TaskManagementSystemss;

public class Program
{
	public static void Main()
	{
		TaskManagementSystem system = new TaskManagementSystem();

		// Adding tasks
		ProjectTask task1 = new ProjectTask(1, "Design Database", "Design the initial database schema", 1);
		ProjectTask task2 = new ProjectTask(2, "Implement Authentication", "Implement user authentication module", 2);
		ProjectTask task3 = new ProjectTask(3, "Set up CI/CD", "Set up continuous integration and deployment", 1);

		system.AddTask(task1);
		system.AddTask(task2);
		system.AddTask(task3);

		// Adding users
		User user1 = new User(1, "Alice");
		User user2 = new User(2, "Bob");

		system.AddUser(user1);
		system.AddUser(user2);

		// Assign tasks to users
		system.AssignTaskToUser(1, 1);
		system.AssignTaskToUser(2, 2);

		// View user's tasks
		Console.WriteLine("Alice's tasks:");
		user1.ViewTasks();
		Console.WriteLine("Bob's tasks:");
		user2.ViewTasks();

		// Complete a task
		system.CompleteTask(1, 1);

		// Push task to backlog
		system.PushToBacklog(task3);

		// Pop task from backlog and assign it to a user
		ProjectTask backlogTask = system.PopFromBacklog();
		if (backlogTask != null)
		{
			system.AssignTaskToUser(backlogTask.TaskId, 2);
		}

		// View top high-priority tasks
		Console.WriteLine("Top high-priority tasks:");
		system.ViewTopHighPriorityTasks(2);
	}
}
