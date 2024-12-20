﻿using TaskManagementApp.Domain.Enums;

namespace TaskManagementApp.Domain.Models
{
    public class TaskModel : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}