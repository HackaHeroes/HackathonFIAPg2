using Hackaton.Fiap.Grupo02.Application.ViewModels;

namespace Hackaton.Fiap.Grupo02.Application.Interfaces
{
    public interface IUsuarioPerfilApp
    {
        Task<IEnumerable<UsuarioPerfilViewModel>> Listar();
    }
}
