using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Application.Models.IdentityModels;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
    public string? State { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? Zip { get; set; }
    public bool Status { get; set; }
    public string? TimeZoneID { get; set; }
    public int UserType { get; set; }
}