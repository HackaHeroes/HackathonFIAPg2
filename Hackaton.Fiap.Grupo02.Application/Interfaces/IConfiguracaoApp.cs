using Hackaton.Fiap.Grupo02.Application.ViewModels;

namespace Hackaton.Fiap.Grupo02.Application.Interfaces
{
    public interface IConfiguracaoApp
    {
        Task<IEnumerable<ConfiguracaoViewModel>> Listar();
        Task<ConfiguracaoViewModel> Carregar(Guid id);
        Task<IEnumerable<ConfiguracaoViewModel>> Listar(string grupo);
        Task Alterar(Guid id, string valor);
    }
}
