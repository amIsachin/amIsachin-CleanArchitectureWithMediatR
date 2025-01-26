using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Shopping.Core.Interfaces;
using Shopping.Core.Options;
using Shopping.Infrastructure.Data;
using Shopping.Infrastructure.Repositories;

namespace Shopping.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext> ((provider, options) =>
        {
            options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.DefaultConnection);
        });

        services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        return services;
    }
}