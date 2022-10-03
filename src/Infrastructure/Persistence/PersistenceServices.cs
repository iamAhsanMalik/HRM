namespace Infrastructure.Persistence;
internal static class PersistenceServices
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        // DB Context Setting
        services.AddDbContext<HRMSContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString(ConnectionString.DefaultConnection)));

        // Authentication Configurations Options
        services.Configure<IdentityOptions>(options =>
        {
            // Password settings.
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 6;
            options.Password.RequiredUniqueChars = 0;

            // Lockout settings.
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.AllowedForNewUsers = true;

            // User settings.
            //options.User.AllowedUserNameCharacters = AppConstants.AllowedUserNameCharacters;
            options.User.RequireUniqueEmail = false;
        });

        // Identity Services
        services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<HRMSContext>().AddDefaultTokenProviders();

        services.AddAuthentication()
           .AddFacebook(facebookOptions =>
           {
               IConfigurationSection facebookAuthNSection = configuration.GetSection("ExternalAuthenticators:Faceboook");
               facebookOptions.ClientId = facebookAuthNSection["AppId"];
               facebookOptions.ClientSecret = facebookAuthNSection["AppSecret"];
               facebookOptions.AccessDeniedPath = "/AccessDeniedPathInfo";
           })
           .AddGoogle(googleOptions =>
           {
               IConfigurationSection googleAuthNSection = configuration.GetSection("ExternalAuthenticators:Google");
               googleOptions.ClientId = googleAuthNSection["AppId"];
               googleOptions.ClientSecret = googleAuthNSection["AppSecret"];
           })
           .AddMicrosoftAccount(microsoftOptions =>
           {
               IConfigurationSection microsoftAuthNSection = configuration.GetSection("ExternalAuthenticators:Microsoft");
               microsoftOptions.ClientId = microsoftAuthNSection["AppSecret"];
               microsoftOptions.ClientSecret = microsoftAuthNSection["AppSecret"];
           });
        services.AddScoped<IDbHelpers, DbHelpers>();
        return services;
    }
}
