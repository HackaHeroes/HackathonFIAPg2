using Hackaton.Fiap.Grupo02.Domain.Entities;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;

namespace Hackaton.Fiap.Grupo02.Infra.Database.Repositories
{
    public class UsuarioRepository:Repository<Usuario>,IUsuarioRepository
    {
        public UsuarioRepository(SistemaDbContext context) : base(context)
        {
        }
    }
}
