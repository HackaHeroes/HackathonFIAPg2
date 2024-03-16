using Hackaton.Fiap.Grupo02.Domain.Entities;

namespace Hackaton.Fiap.Grupo02.Application.ViewModels
{
    public class UsuarioTelefoneViewModel
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }

        public static explicit operator UsuarioTelefoneViewModel(UsuarioTelefone obj)
        {
            var model = new UsuarioTelefoneViewModel
            {
                Id = obj.Id,
                Numero = obj.Numero
            };
            return model;
        }
    }
}
