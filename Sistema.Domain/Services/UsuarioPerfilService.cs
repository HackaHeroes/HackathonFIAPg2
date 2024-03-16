using Hackaton.Fiap.Grupo02.Domain.Entities;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;

namespace Hackaton.Fiap.Grupo02.Domain.Services
{
    public class UsuarioPerfilService : IUsuarioPerfilService
    {
        private readonly IUsuarioPerfilRepository _perfilrepository;

        public UsuarioPerfilService(IUsuarioPerfilRepository perfilRepository)
        {
            _perfilrepository = perfilRepository;
        }

        public async Task<IEnumerable<UsuarioPerfil>> Listar()
        {
            var lista = _perfilrepository.ListarTodos().OrderBy(m => m.Nome);
            return lista;
        }
    }
}
