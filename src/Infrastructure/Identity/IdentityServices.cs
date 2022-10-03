namespace Infrastructure.Identity;
internal static class IdentityServices
{
    public static IServiceCollection AddIdentityServices(this IServiceCollection services)
    {
        services.AddScoped<IUserInfo, UserInfo>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddHttpContextAccessor();
        return services;
    }
}
