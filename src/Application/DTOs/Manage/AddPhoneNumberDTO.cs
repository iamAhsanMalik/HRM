namespace Application.DTOs.Manage;

public class AddPhoneNumberDTO
{
    [Required]
    [Phone]
    [Display(Name = "Phone number")]
    public string? PhoneNumber { get; set; }
}
