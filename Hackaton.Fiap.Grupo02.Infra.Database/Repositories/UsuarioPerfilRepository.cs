using Hackaton.Fiap.Grupo02.Domain.Entities;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;

namespace Hackaton.Fiap.Grupo02.Infra.Database.Repositories
{
    public class UsuarioPerfilRepository:Repository<UsuarioPerfil>,IUsuarioPerfilRepository
    {
        public UsuarioPerfilRepository(SistemaDbContext context) : base(context)
        {
        }
    }
}
