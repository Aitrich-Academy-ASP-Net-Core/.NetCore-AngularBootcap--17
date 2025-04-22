using TaskManagementSystemss;

public class TaskManagementSystem
{
	private Dictionary<int, ProjectTask> tasks = new Dictionary<int, ProjectTask>();
	private Dictionary<int, User> users = new Dictionary<int, User>();
	private SortedList<int, ProjectTask> tasksByPriority = new SortedList<int, ProjectTask>(new DuplicateKeyComparer<int>());
	private Queue<ProjectTask> taskBacklog = new Queue<ProjectTask>();
	private Stack<ProjectTask> completedTasks = new Stack<ProjectTask>();

	public void AddTask(ProjectTask task)
	{
		tasks[task.TaskId] = task;
		tasksByPriority.Add(task.Priority, task);
	}

	public void AddUser(User user)
	{
		users[user.UserId] = user;
	}

	public void AssignTaskToUser(int taskId, int userId)
	{
		if (tasks.ContainsKey(taskId) && users.ContainsKey(userId))
		{
			User user = users[userId];
			ProjectTask task = tasks[taskId];
			user.AddTask(task);
		}
		else
		{
			Console.WriteLine("Task or User not found.");
		}
	}

	public void CompleteTask(int taskId, int userId)
	{
		if (users.ContainsKey(userId))
		{
			User user = users[userId];
			ProjectTask task = tasks[taskId];
			user.RemoveTask(task);
			completedTasks.Push(task);
		}
		else
		{
			Console.WriteLine("User not found.");
		}
	}

	public void PushToBacklog(ProjectTask task)
	{
		taskBacklog.Enqueue(task);
	}

	public ProjectTask PopFromBacklog()
	{
		if (taskBacklog.Count > 0)
		{
			return taskBacklog.Dequeue();
		}
		return null;
	}

	public void ViewTopHighPriorityTasks(int topN)
	{
		int count = 0;
		foreach (var task in tasksByPriority.Values)
		{
			if (count >= topN) break;
			Console.WriteLine($"{task.TaskId}: {task.Title} (Priority: {task.Priority})");
			count++;
		}
	}

	public ProjectTask GetTaskById(int taskId)
	{
		tasks.TryGetValue(taskId, out var task);
		return task;
	}

	public User GetUserById(int userId)
	{
		users.TryGetValue(userId, out var user);
		return user;
	}
}

public class DuplicateKeyComparer<TKey> : IComparer<TKey> where TKey : IComparable
{
	public int Compare(TKey x, TKey y)
	{
		int result = x.CompareTo(y);
		if (result == 0)
			return 1; // Handle equality as being greater
		else
			return result;
	}
}