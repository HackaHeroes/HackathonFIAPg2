using Hackaton.Fiap.Grupo02.Domain.Entities;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;

namespace Hackaton.Fiap.Grupo02.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        public readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<IEnumerable<Usuario>> Listar()
        {

            return _usuarioRepository.Get(x => x.UsuarioTelefones).Where(m => m.FlgStatus == "A");
        }

        public async Task<Usuario?> VerificaSenha(string login, string senha)
        {


            return _usuarioRepository.Get(m =>
                m.UsuarioTelefones).FirstOrDefault(m => (m.Login == login || m.Email == login) && m.Senha == senha && m.FlgStatus == "A");
        }

        public async Task<Usuario?> Carregar(Guid id)
        {
            var retorno = _usuarioRepository
                .Get(m => m.UsuarioTelefones).FirstOrDefault(m => m.Id == id);
            return retorno;
        }

        public void Excluir(Guid id)
        {
            var obj = _usuarioRepository.CarregarPorId(id);
            obj.FlgStatus = "E";
            _usuarioRepository.Alterar(obj);

        }
    }
}
