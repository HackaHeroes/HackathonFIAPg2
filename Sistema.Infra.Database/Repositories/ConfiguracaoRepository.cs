using Hackaton.Fiap.Grupo02.Domain.Entities;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;

namespace Hackaton.Fiap.Grupo02.Infra.Database.Repositories
{
    public class ConfiguracaoRepository:Repository<Configuracao>,IConfiguracaoRepository
    {
        public ConfiguracaoRepository(SistemaDbContext context) : base(context)
        {
        }
    }
}
