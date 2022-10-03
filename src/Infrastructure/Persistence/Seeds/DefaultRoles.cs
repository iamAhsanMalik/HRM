namespace Infrastructure.Persistence.Seeds;

public static class DefaultRoles
{
    public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        await roleManager.CreateAsync(new IdentityRole(AppRoles.SuperAdmin.ToString()));
        await roleManager.CreateAsync(new IdentityRole(AppRoles.Admin.ToString()));
        await roleManager.CreateAsync(new IdentityRole(AppRoles.Basic.ToString()));
    }
}