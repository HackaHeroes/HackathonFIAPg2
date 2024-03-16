using Hackaton.Fiap.Grupo02.Domain.Entities;

namespace Hackaton.Fiap.Grupo02.Domain.Interfaces.Services
{
    public interface IUsuarioPerfilService
    {
        Task<IEnumerable<UsuarioPerfil>> Listar();
    }
}
