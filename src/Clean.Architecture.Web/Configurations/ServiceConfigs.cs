using Clean.Architecture.Core.Interfaces;
using Clean.Architecture.Infrastructure;
using Clean.Architecture.Infrastructure.Email;
using StackExchange.Redis;

namespace Clean.Architecture.Web.Configurations;

public static class ServiceConfigs
{
  public static IServiceCollection AddServiceConfigs(this IServiceCollection services, Microsoft.Extensions.Logging.ILogger logger, WebApplicationBuilder builder)
  {
    services.AddInfrastructureServices(builder.Configuration, logger)
            .AddMediatrConfigs();

    // DI
    // gRpc Service Register
    builder.Services.AddGrpc();

    services.AddSingleton<ICacheService, RedisCacheService>(); // adjust names accordingly

    // Redis Service Register
    builder.Services.AddSingleton<IConnectionMultiplexer>(sp =>
    {
      var configuration = builder.Configuration.GetConnectionString("Redis");
      if (string.IsNullOrEmpty(configuration))
      {
        throw new InvalidOperationException("Redis connection string is missing in configuration.");
      }
      return ConnectionMultiplexer.Connect(configuration);
    });

    if (builder.Environment.IsDevelopment())
    {
      // Use a local test email server
      // See: https://ardalis.com/configuring-a-local-test-email-server/
      services.AddScoped<IEmailSender, MimeKitEmailSender>();

      // Otherwise use this:
      //builder.Services.AddScoped<IEmailSender, FakeEmailSender>();

    }
    else
    {
      services.AddScoped<IEmailSender, MimeKitEmailSender>();
    }

    logger.LogInformation("{Project} services registered", "Mediatr and Email Sender");

    return services;
  }


}
