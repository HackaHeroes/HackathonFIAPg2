using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hackaton.Fiap.Grupo02.Domain.Entities;

namespace Hackaton.Fiap.Grupo02.Infra.Database.Mappings
{
    public class UsuarioPerfilMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioPerfil>(entity =>
            {
                entity.ToTable("UsuarioPerfis");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Nome).HasMaxLength(80).IsRequired();
            });
        }
    }
}
