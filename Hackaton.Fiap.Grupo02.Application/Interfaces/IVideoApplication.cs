using Hackaton.Fiap.Grupo02.Domain.Entities;

namespace Hackaton.Fiap.Grupo02.Application.Interfaces;

public interface IVideoApplication
{
    Task GetStatusProcessAsync(string url);

    Task<List<VideoImage>> GetAll();
}