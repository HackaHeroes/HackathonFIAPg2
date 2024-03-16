namespace Hackaton.Fiap.Grupo02.Domain.Entities
{
    public class UsuarioPerfil : BaseEntity
    {
        public string Nome { get; private set; }
        public IList<UsuarioPerfilAcesso> UsuarioPerfilAcessos { get; private set; }


    }
}
