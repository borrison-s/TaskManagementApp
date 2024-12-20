using TaskManagementApp.DataAccess.Interfaces;
using TaskManagementApp.Domain.Models;
using TaskManagementApp.Dtos.Tasks;
using TaskManagementApp.Mappers.Tasks;
using TaskManagementApp.Services.Interfaces;

namespace TaskManagementApp.Services.Implementations
{
    public class TaskService : ITaskService
    {
        private readonly IRepository<TaskModel> _taskRepository;

        public TaskService(IRepository<TaskModel> taskRepository)
        {
            _taskRepository = taskRepository;
        }


        public List<TaskDto> GetAll()
        {
            // 1. Get all tasks from db
            List<TaskModel> tasksDb = _taskRepository.GetAll();

            return tasksDb.Select(x => x.ToTaskDto()).ToList();
        }

        public TaskDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddTask(AddTaskDto addTaskDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(UpdateTaskDto UpdateTaskDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(int id)
        {
            throw new NotImplementedException();
        }
    }
}
