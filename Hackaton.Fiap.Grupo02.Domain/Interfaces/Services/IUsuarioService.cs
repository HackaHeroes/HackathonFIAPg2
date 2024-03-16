using Hackaton.Fiap.Grupo02.Domain.Entities;

namespace Hackaton.Fiap.Grupo02.Domain.Interfaces.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> Listar();
        Task<Usuario?> VerificaSenha(string login, string senha);
        Task<Usuario> Carregar(Guid id);
        void Excluir(Guid id);
    }
}
