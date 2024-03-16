using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackaton.Fiap.Grupo02.Domain.Entities;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;

namespace Hackaton.Fiap.Grupo02.Infra.Database.Repositories
{
    public class VideoImageRepository:Repository<VideoImage>, IVideoImageRepository 
    {
        public VideoImageRepository(SistemaDbContext context) : base(context)
        {
        }
    }
}
