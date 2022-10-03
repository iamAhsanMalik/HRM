namespace Application.DTOs.Permission;
public class PermissionDTO
{
    public string? RoleId { get; set; }
    public IList<RoleClaimDTO>? RoleClaims { get; set; }
}
