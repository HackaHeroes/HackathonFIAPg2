using Hackaton.Fiap.Grupo02.Domain.Data;
using Hackaton.Fiap.Grupo02.Domain.Entities;

namespace Hackaton.Fiap.Grupo02.Application.Interfaces;

public interface IVideoApplication
{
    Task ProcessAsync(MessageData message);

    IEnumerable<VideoImage> GetAll();
}