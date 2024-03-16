using Hackaton.Fiap.Grupo02.Domain.Entities;

namespace Hackaton.Fiap.Grupo02.Application.Interfaces;

public interface IVideoApplication
{
    Task Processa(string url);

    Task<List<VideoImage>> GetAll();
}