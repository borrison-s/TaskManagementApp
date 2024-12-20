using TaskManagementApp.Domain.Enums;

namespace TaskManagementApp.Dtos.Tasks
{
    public class TaskDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DuteDate { get; set; } 
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public string UserFullName { get; set; }
    }
}
