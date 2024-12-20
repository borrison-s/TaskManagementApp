using Microsoft.EntityFrameworkCore;
using TaskManagementApp.DataAccess.Interfaces;
using TaskManagementApp.Domain.Models;

namespace TaskManagementApp.DataAccess.Implementations
{
    public class TaskRepository : IRepository<TaskModel>
    {
        private readonly TaskManagementDbContext _context;

        public TaskRepository(TaskManagementDbContext context)
        {
            _context = context;
        }


        public List<TaskModel> GetAll()
        {
            return _context
                .Tasks
                .Include(x => x.User) //join with table Users
                .ToList();

        }

        public TaskModel GetById(int id)
        {
            return _context.Tasks
                .Include(x => x.User)
                .FirstOrDefault(x => x.Id == id);

        }

        public void Add(TaskModel entity)
        {
            _context.Tasks.Add(entity);
            _context.SaveChanges();
        }

        public void Update(TaskModel entity)
        {
            _context.Tasks.Update(entity);
            _context.SaveChanges();

        }

        public void Delete(TaskModel entity)
        {
            _context.Tasks.Remove(entity);
            _context.SaveChanges();
        }
    }
}
