using Hackaton.Fiap.Grupo02.Application.Interfaces;
using Hackaton.Fiap.Grupo02.Application.ViewModels;
using Hackaton.Fiap.Grupo02.Domain.Entities;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;

namespace Hackaton.Fiap.Grupo02.Application.Applications
{
    public class ConfiguracaoApp : IConfiguracaoApp
    {
        private readonly IConfiguracaoService _configuracaoService;
        public ConfiguracaoApp(IConfiguracaoService configuracaoService)
        {
            _configuracaoService = configuracaoService;
        }

        public async Task<IEnumerable<ConfiguracaoViewModel>> Listar()
        {
            var lista = _configuracaoService.Listar();
            var retorno = new List<ConfiguracaoViewModel>();
            foreach (var item in lista)
            {
                var viewModel = await FromDomain(item);
                retorno.Add(viewModel);
            }

            return retorno;
        }

        public async Task<ConfiguracaoViewModel> Carregar(Guid id)
        {
            var viewModel = new ConfiguracaoViewModel();
            var obj = _configuracaoService.Carregar(id);
            if (obj != null)
            {
                viewModel = await FromDomain(obj);
                return viewModel;
            }


            viewModel.AddNotification("Configuracao", "Configuracao não encontrado.");
            return viewModel;
        }

        public async Task<IEnumerable<ConfiguracaoViewModel>> Listar(string grupo)
        {
            var lista = _configuracaoService.Listar(grupo);
            var retorno = new List<ConfiguracaoViewModel>();
            foreach (var item in lista)
            {
                var viewModel = await FromDomain(item);
                retorno.Add(viewModel);
            }

            return retorno;

        }

        public Task Alterar(Guid id, string valor)
        {

            _configuracaoService.Alterar(id, valor);
            return Task.CompletedTask;
        }

        public Task<ConfiguracaoViewModel> FromDomain(Configuracao obj)
        {
            var objView = new ConfiguracaoViewModel
            {
                Variavel = obj.Variavel,
                Descricao = obj.Descricao,
                Valor = obj.Valor,
                Id = obj.Id
            };
            return Task.FromResult(objView);
        }


    }
}
