using Microsoft.Extensions.DependencyInjection;

namespace Shopping.Application;

public static class DepedencyInjection
{
    public static IServiceCollection AddApplicationDI(this IServiceCollection services)
    {
        services.AddMediatR(x => x.RegisterServicesFromAssemblies(typeof(DepedencyInjection).Assembly));

        return services;
    }
}