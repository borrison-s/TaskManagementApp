using TaskManagementApp.Dtos.Tasks;

namespace TaskManagementApp.Services.Interfaces
{
    public interface ITaskService
    {
        List<TaskDto> GetAll();
        TaskDto GetById(int id);
        void AddTask(AddTaskDto addTaskDto);
        void UpdateTask(UpdateTaskDto UpdateTaskDto);
        void DeleteTask(int id);
    }
}
