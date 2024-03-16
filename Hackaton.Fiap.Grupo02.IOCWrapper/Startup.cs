using Hackaton.Fiap.Grupo02.Application.Applications;
using Hackaton.Fiap.Grupo02.Application.Interfaces;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;
using Hackaton.Fiap.Grupo02.Domain.Services;
using Hackaton.Fiap.Grupo02.Infra.Database;
using Hackaton.Fiap.Grupo02.Infra.Database.Repositories;
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


            #region Usuarios
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IUsuarioApp, UsuarioApp>();
            services.AddScoped<IUsuarioPerfilApp, UsuarioPerfilApp>();
            services.AddScoped<IUsuarioPerfilService, UsuarioPerfilService>();
            services.AddScoped<IUsuarioPerfilRepository, UsuarioPerfilRepository>();
            #endregion
            #region Configuracoes
            services.AddScoped<IConfiguracaoRepository, ConfiguracaoRepository>();
            services.AddScoped<IConfiguracaoService, ConfiguracaoService>();
            services.AddScoped<IConfiguracaoApp, ConfiguracaoApp>();


            #endregion
        }
    }
}
