using Hackaton.Fiap.Grupo02.Domain.Entities;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;

namespace Hackaton.Fiap.Grupo02.Domain.Services;

public class VideoImageService : IVideoImageService
{
    public readonly IVideoImageRepository _videoImageRepository;

    public VideoImageService(IVideoImageRepository videoImageRepository)
    {
        _videoImageRepository = videoImageRepository;
    }

    /// <summary>
    /// Obtem todos os videos 
    /// </summary>
    /// <returns></returns>
    public IEnumerable<VideoImage> GetAll()
    {
        return _videoImageRepository.GetAllSavedVideos();
    }

    /// <summary>
    /// Obtem o video por Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public VideoImage? GetById(int id)
    {
        var obj = _videoImageRepository.GetVideoById(id);
        return obj;
    }

    /// <summary>
    /// Insere o video no banco de dados
    /// </summary>
    /// <param name="entity"></param>
    public void Insert(VideoImage entity)
    {
        _videoImageRepository.InsertVideo(entity);
    }

    /// <summary>
    /// Atualiza o registro do video
    /// </summary>
    /// <param name="entity"></param>
    public void Update(VideoImage entity)
    {
        _videoImageRepository.UpdateVideoRegistry(entity);
    }

    /// <summary>
    /// Apaga o registro do video do banco de dados por Id
    /// </summary>
    /// <param name="id"></param>
    public void Delete(int id)
    {
        _videoImageRepository.DEleteVideoRegistryById(id);
    }
}