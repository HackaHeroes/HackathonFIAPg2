using Hackaton.Fiap.Grupo02.Domain.Events;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;
using Hackaton.Fiap.Grupo02.Domain.Services;
using Hackaton.Fiap.Grupo02.Infra.Database;
using Hackaton.Fiap.Grupo02.Infra.Database.Repositories;
using MassTransit;
using MassTransit.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hackaton.Fiap.Grupo02.IOCWrapper
{
    public static class Startup
    {
        public static void Bootstrap(IServiceCollection services)
        {
            services.AddDbContext<SistemaDbContext>(options => options.UseSqlServer());
            services.AddScoped<IVideoImageRepository, VideoImageRepository>();
            services.AddScoped<IVideoImageService, VideoImageService>();


        }

        public static void AddDataBase(this IServiceCollection services)
        {
            services.AddDbContext<SistemaDbContext>(options => options.UseSqlServer());
        }

        public static void AddServiceBus(this IServiceCollection services, IConfiguration configuration)
        {
            var queueName = configuration.GetSection("ServiceBusSettings")["Subscription"] ?? string.Empty;
            var connectionString = configuration.GetSection("ServiceBusSettings")["PubSubConnection"] ?? string.Empty;


            services.AddMassTransit(x =>
            {
                x.UsingAzureServiceBus((context, cfg) =>
                {
                    cfg.Host(connectionString);

                    cfg.ReceiveEndpoint(queueName, e => { e.Consumer<ReceivedMessage>(); });
                });
            });
        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IVideoImageRepository, VideoImageRepository>();
            services.AddScoped<IVideoImageService, VideoImageService>();
        }

    }
}