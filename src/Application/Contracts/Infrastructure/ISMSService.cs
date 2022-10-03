namespace Application.Contracts.Infrastructure;

public interface ISMSService
{
    Task SendSmsByTwillioAsync(string number, string message);
}
