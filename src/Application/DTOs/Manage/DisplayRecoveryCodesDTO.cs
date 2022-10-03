namespace Application.DTOs.Manage;

public class DisplayRecoveryCodesDTO
{
    [Required]
    public IEnumerable<string>? Codes { get; set; }

}
