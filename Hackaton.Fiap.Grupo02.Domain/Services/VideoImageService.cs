using Hackaton.Fiap.Grupo02.Domain.Entities;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;

namespace Hackaton.Fiap.Grupo02.Domain.Services;

public class VideoImageService:IVideoImageService
{
    public readonly IVideoImageRepository _videoImageRepository;

    public VideoImageService(IVideoImageRepository videoImageRepository)
    {
        _videoImageRepository = videoImageRepository;
    }
    
    public IEnumerable<VideoImage> GetAll()
    {
        return _videoImageRepository.GetAllUploads();
    }

    public VideoImage? GetById(int id)
    {
        var obj = _videoImageRepository.GetVideoById(id);
        return obj;
    }

    public void Insert(VideoImage entity)
    {
        _videoImageRepository.InsertVideo(entity);
    }

    public void Update(VideoImage entity)
    {
        _videoImageRepository.UpdateVideoRegistry(entity);
        
    }

    public void Delete(int id)
    {
        _videoImageRepository.DeleteVideoById(id);
    }
}