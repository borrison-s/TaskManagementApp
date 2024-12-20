using Microsoft.EntityFrameworkCore;
using TaskManagementApp.Domain.Enums;
using TaskManagementApp.Domain.Models;

namespace TaskManagementApp.DataAccess
{
    public class TaskManagementDbContext : DbContext
    {
        public TaskManagementDbContext(DbContextOptions options) : base(options) { }

        public DbSet<TaskModel> Tasks { get; set; } 
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Tasks

            modelBuilder.Entity<TaskModel>()
                .Property(x => x.Title)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<TaskModel>()
                .Property(x => x.Description)
                .HasMaxLength(200);

            modelBuilder.Entity<TaskModel>()
                .Property(x => x.DueDate)
                .IsRequired();

            modelBuilder.Entity<TaskModel>()
                .Property(x => x.Priority)
                .IsRequired();

            modelBuilder.Entity<TaskModel>()
                .Property(x => x.Status)
                .IsRequired();

            //Relation

            modelBuilder.Entity<TaskModel>()
                .HasOne(x => x.User)
                .WithMany(x => x.Tasks)
                .HasForeignKey(x => x.UserId);


            // User

            modelBuilder.Entity<User>()
                .Property(x => x.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(x => x.LastName)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(x => x.Username)
                .HasMaxLength(20)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(x => x.Password)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(x => x.Role)
                .IsRequired();


            // Seed Admin user
            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        Id = 1, FirstName = "John", LastName = "Doe", Username = "root", Password = "root123", Role = Role.Admin
                    });


        }
    }
}
