using Microsoft.AspNetCore.Mvc.Authorization;

namespace HRMS;

public static class DependencyInjection
{
    public static IServiceCollection AddWebUIServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Add Dependency Layers to the project
        services.AddApplicationServices().AddInfrastructureServices(configuration);

        //var authPolicy = options => options.Filters.Add(new AuthorizeFilter(new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build()))
        // Add services to the container.
        services.AddControllersWithViews(options => options.Filters.Add(new AuthorizeFilter(new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build()))).AddJsonOptions(options =>
                options.JsonSerializerOptions.PropertyNamingPolicy = null);
        services.AddDistributedMemoryCache();

        services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromSeconds(10);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });

        return services;
    }
}