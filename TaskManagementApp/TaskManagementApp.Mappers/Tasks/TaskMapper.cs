using TaskManagementApp.Domain.Models;
using TaskManagementApp.Dtos.Tasks;

namespace TaskManagementApp.Mappers.Tasks
{
    public static class TaskMapper
    {
        public static TaskDto ToTaskDto(this TaskModel task)
        {
            return new TaskDto
            {
                Title = task.Title,
                Description = task.Description,
                DuteDate = task.DueDate,
                Priority = task.Priority,
                Status = task.Status,
                UserFullName = $"{task.User.FirstName} {task.User.LastName}"
            };
        } 
    }
}
