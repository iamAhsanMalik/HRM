namespace Application.Configurations.SMTP;

public class SMTPConfig
{
    public string? SMTPHost { get; set; }
    public int SMTPPort { get; set; }
    public string? EmailFrom { get; set; }
    public string? AccountEmail { get; set; }
    public string? AccountPassword { get; set; }
    //public bool SecureSocketOptions { get; set; }
}

