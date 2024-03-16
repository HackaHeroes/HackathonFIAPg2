using Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;
using Hackaton.Fiap.Grupo02.Domain.Services;
using Hackaton.Fiap.Grupo02.Domain.Event;
using Hackaton.Fiap.Grupo02.Infra.Database;
using Hackaton.Fiap.Grupo02.Infra.Database.Repositories;
using Microsoft.EntityFrameworkCore;
using MassTransit;
using MassTransit.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hackaton.Fiap.Grupo02.IOCWrapper;

public static class Startup
{
    public static void Bootstrap(this IServiceCollection services)
    {
        services.AddDbContext<SistemaDbContext>();

        //services.AddDbContext<SistemaDbContext>(options =>
        //{
        //    options.UseMySql(builder.Configuration["ConnectionStrings:DefaultConnection"], new MySqlServerVersion(new Version(8, 0, 25)));
        //});

    }
        
    public static void ServiceBusSettings(this IServiceCollection services, IConfiguration configuration)
    {
        var queueName = configuration.GetSection("ServiceBusSettings")["Subscription"] ?? string.Empty;
        var connectionString = configuration.GetSection("ServiceBusSettings")["PubSubConnection"] ?? string.Empty;
        
        services.AddMassTransit(x =>
        {
            services.AddDbContext<SistemaDbContext>(options => options.UseSqlServer());
            services.AddScoped<IVideoImageRepository, VideoImageRepository>();
            services.AddScoped<IVideoImageService, VideoImageService>();
        }
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
    
    public static void AddServices(this IServiceCollection services)
    {
        //services.AddScoped<>();
    }
}