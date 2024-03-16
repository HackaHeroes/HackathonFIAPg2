using Hackaton.Fiap.Grupo02.Application.Interfaces;
using Hackaton.Fiap.Grupo02.Application.ViewModels;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;

namespace Hackaton.Fiap.Grupo02.Application.Applications
{
    public class UsuarioPerfilApp : IUsuarioPerfilApp
    {
        private readonly IUsuarioPerfilService _usuarioPerfilService;
        public UsuarioPerfilApp(IUsuarioPerfilService usuarioPerfilService)
        {
            _usuarioPerfilService = usuarioPerfilService;
        }
        public async Task<IEnumerable<UsuarioPerfilViewModel>> Listar()
        {
            var lista = await _usuarioPerfilService.Listar();
            var retorno = new List<UsuarioPerfilViewModel>();

            foreach (var item in lista)
            {
                var viewModel = (UsuarioPerfilViewModel)item;
                retorno.Add(viewModel);
            }
            return retorno;
        }
    }
}
