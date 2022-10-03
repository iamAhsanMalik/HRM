using Application.Contracts.Infrastructure;

namespace Infrastructure.Services.Communication.SMS;

internal class SMSServices : ISMSService
{
    public Task SendSmsByTwillioAsync(string number, string message)
    {
        // Plug in your SMS service here to send a text message.
        return Task.FromResult(0);
    }
}
