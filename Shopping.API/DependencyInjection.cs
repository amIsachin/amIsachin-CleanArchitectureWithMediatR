namespace Shopping.API;
using Application;
using Infrastructure;
using Shopping.Core;


public static class DependencyInjection
{
    public static IServiceCollection AddAppDI(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddApplicationDI().AddInfrastructureDI().AddCoreDI(configuration);

        return services;
    }
}