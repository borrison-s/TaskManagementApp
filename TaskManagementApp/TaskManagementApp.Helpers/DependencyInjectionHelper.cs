using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskManagementApp.DataAccess;

namespace TaskManagementApp.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<TaskManagementDbContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
