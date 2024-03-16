using Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;
using Hackaton.Fiap.Grupo02.Domain.Services;
using Hackaton.Fiap.Grupo02.Infra.Database;
using Hackaton.Fiap.Grupo02.Infra.Database.Repositories;
using Microsoft.EntityFrameworkCore;
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
    }
}
