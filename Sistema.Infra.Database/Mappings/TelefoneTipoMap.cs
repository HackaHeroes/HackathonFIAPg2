using Hackaton.Fiap.Grupo02.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.Fiap.Grupo02.Infra.Database.Mappings
{
    public class TelefoneTipoMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TelefoneTipo>(entity =>
            {
                entity.ToTable("TelefoneTipos");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Nome).HasMaxLength(80).IsRequired();
            });
        }
    }
}
