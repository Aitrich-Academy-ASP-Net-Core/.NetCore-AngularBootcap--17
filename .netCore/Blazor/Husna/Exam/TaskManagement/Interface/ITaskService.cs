using TaskManagement.Model;

namespace TaskManagement.Interface
{
    public interface ITaskService
    {
        Task<List<TaskItemDto>> GetAllTasksAsync();
        Task<TaskItemDto> GetTaskByIdAsync(int id);
        Task AddTaskAsync(TaskItemDto taskDto);
      
        Task DeleteTaskAsync(int id);
        Task MarkAsCompletedAsync(int id);
    }
}
