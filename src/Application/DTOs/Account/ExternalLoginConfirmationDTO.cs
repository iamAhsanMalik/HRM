namespace Application.DTOs.Account;

public class ExternalLoginConfirmationDTO
{
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
}
