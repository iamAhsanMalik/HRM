using Application.Configurations.MailJet;
using Application.Configurations.SMTP;
using Application.Contracts.Infrastructure;
using Infrastructure.Files;
using Infrastructure.Identity;
using Infrastructure.Persistence;
using Infrastructure.Services.Communication.Email;
using Infrastructure.Services.Communication.SMS;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        #region Persistence & Identity Services
        services.AddPersistenceServices(configuration).AddIdentityServices();
        #endregion

        #region Communication Services Configurations
        services.Configure<MailJetConfig>(configuration.GetSection("MailJet"));
        services.Configure<SMTPConfig>(configuration.GetSection("SMTPServer"));
        #endregion

        #region Communication Services
        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<ISMSService, SMSServices>();
        #endregion

        #region Files Reading & Writing Helpers
        services.AddScoped<IFileHelpers, FileHelpers>();
        #endregion
        return services;
    }
}