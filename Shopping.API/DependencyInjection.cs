﻿namespace Shopping.API;
using Application;
using Infrastructure;


public static class DependencyInjection
{
    public static IServiceCollection AddAppDI(this IServiceCollection services)
    {
        services.AddApplicationDI().AddInfrastructureDI();

        return services;
    }
}