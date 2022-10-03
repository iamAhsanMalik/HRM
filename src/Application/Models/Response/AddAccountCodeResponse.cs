namespace Application.Models.Response;

public class AddAccountCodeResponse
{
    public bool IsAdded = false;
    public string? AccountCode { get; set; }
    public string? AccountName { get; set; }
}
