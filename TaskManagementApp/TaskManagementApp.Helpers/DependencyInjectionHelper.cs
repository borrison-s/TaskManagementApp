using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskManagementApp.DataAccess;
using TaskManagementApp.DataAccess.Implementations;
using TaskManagementApp.DataAccess.Interfaces;
using TaskManagementApp.Domain.Models;
using TaskManagementApp.Services.Implementations;
using TaskManagementApp.Services.Interfaces;

namespace TaskManagementApp.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<TaskManagementDbContext>(x => x.UseSqlServer(connectionString));
        }

        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<ITaskService, TaskService>();
        }

        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<TaskModel>, TaskRepository>();
        }
    }
}
