using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shopping.Core.Interfaces;
using Shopping.Infrastructure.Data;
using Shopping.Infrastructure.Repositories;

namespace Shopping.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext> (options =>
        {
            options.UseSqlServer(@"Server=SACHIN\MSSQLSERVER01; DataBase=Shopping; Trusted_Connection=True; MultipleActiveResultSets=true; TrustServerCertificate=True");
        });

        services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        return services;
    }
}