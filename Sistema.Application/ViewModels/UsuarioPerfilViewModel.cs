using Hackaton.Fiap.Grupo02.Domain.Entities;

namespace Hackaton.Fiap.Grupo02.Application.ViewModels
{
    public class UsuarioPerfilViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public static explicit operator UsuarioPerfilViewModel(UsuarioPerfil obj)
        {
            var model = new UsuarioPerfilViewModel
            {
                Id = obj.Id,
                Nome = obj.Nome
            };
            return model;
        }
    }
}
