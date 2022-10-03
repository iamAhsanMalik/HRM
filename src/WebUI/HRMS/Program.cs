var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddWebUIServices(builder.Configuration);

var app = builder.Build();
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
        await DefaultRoles.SeedAsync(userManager, roleManager);
        await DefaultUsers.SeedBasicUserAsync(userManager, roleManager);
        await DefaultUsers.SeedSuperAdminAsync(userManager, roleManager);
    }

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }
    //else
    //{
    //    app.UseMigrationsEndPoint();
    //}

    app.AddRequestPipeline();

    app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
    app.Run();
}
