using HRMS;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddWebUIServices(builder.Configuration);

var app = builder.Build();
{
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
