namespace Infrastructure.Persistence.Helpers;
public static class ClaimsHelper
{
    public static void GetPermissions(this List<RoleClaimDTO> allPermissions, Type policy, string roleId)
    {
        FieldInfo[] fields = policy.GetFields(BindingFlags.Static | BindingFlags.Public);

        foreach (FieldInfo field in fields)
        {
            allPermissions.Add(new RoleClaimDTO { Value = field.GetValue(null)?.ToString(), Type = "Permissions" });
        }
    }

    public static async Task AddPermissionClaim(this RoleManager<IdentityRole> roleManager, IdentityRole role, string permission)
    {
        var allClaims = await roleManager.GetClaimsAsync(role);
        if (!allClaims.Any(a => a.Type == "Permission" && a.Value == permission))
        {
            await roleManager.AddClaimAsync(role, new Claim("Permission", permission));
        }
    }
}

