﻿using TaskManagementApp.Domain.Enums;

namespace TaskManagementApp.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public List<TaskModel> Tasks { get; set; }
    }
}
