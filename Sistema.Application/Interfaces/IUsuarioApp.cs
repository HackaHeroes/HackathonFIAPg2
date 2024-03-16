using Hackaton.Fiap.Grupo02.Application.ViewModels;

namespace Hackaton.Fiap.Grupo02.Application.Interfaces
{
    public interface IUsuarioApp
    {
        Task<IEnumerable<UsuarioViewModel>> Listar();
        Task<UsuarioViewModel>? VerificaSenha(string login, string senha);
        Task<UsuarioViewModel> Carregar(Guid id);
        Task Excluir(Guid id);
    }
}
