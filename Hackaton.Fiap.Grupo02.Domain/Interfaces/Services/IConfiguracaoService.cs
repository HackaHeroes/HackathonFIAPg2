using Hackaton.Fiap.Grupo02.Domain.Entities;

namespace Hackaton.Fiap.Grupo02.Domain.Interfaces.Services
{
    public interface IConfiguracaoService
    {
        IEnumerable<Configuracao> Listar();
        Configuracao? Carregar(Guid id);
        IEnumerable<Configuracao> Listar(string grupoVariaveis);
        void Alterar(Guid id, string valor);
    }
}
