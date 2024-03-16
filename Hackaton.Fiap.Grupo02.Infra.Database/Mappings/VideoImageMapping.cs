using Hackaton.Fiap.Grupo02.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.Fiap.Grupo02.Infra.Database.Mappings
{
    public class VideoImageMapping
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoImage>(entity =>
            {
                entity.ToTable("UsuarioTelefones");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.VideoName).HasMaxLength(500).IsRequired();
                entity.Property(x => x.VideoLink).IsRequired();
                entity.Property(x => x.CreatedAt);
                entity.Property(x => x.ZipFile);
                entity.Property(x => x.ZipName);
                entity.Property(x => x.ZipCreatedAt);
            });
        }
    }
}
