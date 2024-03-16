using Microsoft.EntityFrameworkCore;

namespace Hackaton.Fiap.Grupo02.Infra.Database.Mappings
{
    public class UsuarioTelefoneMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UsuarioTelefone>(entity =>
            //{
            //    entity.ToTable("UsuarioTelefones");
            //    entity.HasKey(x => x.Id);
            //    entity.Property(x => x.Numero).HasMaxLength(80).IsRequired();
            //});
        }
    }
}
