using TaskManagementApp.Domain.Enums;

namespace TaskManagementApp.Dtos.Tasks
{
    public class AddTaskDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public int UserId { get; set; }
    }
}
