using Hackaton.Fiap.Grupo02.Infra.Database;
using Microsoft.Extensions.DependencyInjection;

namespace Hackaton.Fiap.Grupo02.IOCWrapper
{
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
    }
}
