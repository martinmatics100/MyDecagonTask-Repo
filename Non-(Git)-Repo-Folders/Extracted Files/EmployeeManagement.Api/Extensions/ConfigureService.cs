using EmployeeManagement.Api.Context;
using EmployeeManagement.Api.Implementations;
using EmployeeManagement.Api.Services;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Extensions
{
    public static class ConfigureService
    {
        public static void AddDepencies(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<ApplicationContext>(opts => opts.
            UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            service.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
