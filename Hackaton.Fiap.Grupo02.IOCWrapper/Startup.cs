using Hackaton.Fiap.Grupo02.Domain.Event;
using Hackaton.Fiap.Grupo02.Infra.Database;
using MassTransit;
using MassTransit.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hackaton.Fiap.Grupo02.IOCWrapper;

public static class Startup
{
    public static void Bootstrap(IServiceCollection services)
    {
        services.AddDbContext<SistemaDbContext>();

        //services.AddDbContext<SistemaDbContext>(options =>
        //{
        //    options.UseMySql(builder.Configuration["ConnectionStrings:DefaultConnection"], new MySqlServerVersion(new Version(8, 0, 25)));
        //});

    }
        
    public static void ServiceBusSettings(IServiceCollection services, IConfiguration configuration)
    {
        var queueName = configuration.GetSection("ServiceBusSettings")["Subscription"] ?? string.Empty;
        var connectionString = configuration.GetSection("ServiceBusSettings")["PubSubConnection"] ?? string.Empty;
        
        services.AddMassTransit(x =>
        {
            x.UsingAzureServiceBus((context, cfg) =>
            {
                cfg.Host(connectionString);

                cfg.ReceiveEndpoint(queueName, e =>
                {
                    e.Consumer<ReceivedMessage>();
                });
            });
        });
    }
}