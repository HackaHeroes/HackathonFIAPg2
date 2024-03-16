using Hackaton.Fiap.Grupo02.Domain.Entities;

namespace Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;

public interface IVideoImageService
{
    IEnumerable<VideoImage> GetAll();
    VideoImage GetById(int id);
    void Insert(VideoImage entity);
    void Update(VideoImage entity);
    void Delete(int id);

}