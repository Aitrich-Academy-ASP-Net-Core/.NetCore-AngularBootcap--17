using AutoMapper;
using TaskManagement.Interface;
using TaskManagement.Model;

namespace TaskManagement.Service
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public TaskService(ITaskRepository taskRepository,IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task<List<TaskItemDto>> GetAllTasksAsync()
        {
            var taskDetails = await _taskRepository.GetAllTasksAsync();
            return _mapper.Map<List<TaskItemDto>>(taskDetails);
        }

        public async Task<TaskItemDto> GetTaskByIdAsync(int id)
        {
            var taskDetail=await _taskRepository.GetTaskByIdAsync(id);
            return _mapper.Map<TaskItemDto>(taskDetail);

        }

        public async Task AddTaskAsync(TaskItemDto taskDto)
        {
            var taskDetail = _mapper.Map<TaskItem>(taskDto);
            await _taskRepository.AddTaskAsync(taskDetail);
        }

   

        public async Task DeleteTaskAsync(int id)
        {
            await _taskRepository.DeleteTaskAsync(id);
        }

        public async Task MarkAsCompletedAsync(int id)
        {
            await _taskRepository.MarkAsCompletedAsync(id);
        }


    }
}
