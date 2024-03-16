using System.Text.Json;
using Hackaton.Fiap.Grupo02.Application.Interfaces;
using Hackaton.Fiap.Grupo02.Domain.Data;
using Hackaton.Fiap.Grupo02.Domain.Entities;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;
using MassTransit;

namespace Hackaton.Fiap.Grupo02.Application.Applications;

public class VideoApplication : IVideoApplication
{
    public readonly IVideoImageService _VideoImageService;

    public VideoApplication(IVideoImageService videoImageService)
    {
        _VideoImageService = videoImageService;
    }


    public async Task ProcessAsync(MessageData message)
    {
        var registry = new VideoImage()
        {
            VideoName = message.VideoName,
            VideoLink = message.VideoLink,
            CreatedAt = DateTime.Now
        };
        SaveFile(registry);
        var stream = await ToMemoryStream(JsonSerializer.Serialize(message));
    }

    private static async Task<MemoryStream> ToMemoryStream(string base64)
    {
        byte[] bArray = Convert.FromBase64String(base64);

        MemoryStream ms = new MemoryStream(bArray);

        await ms.WriteAsync(bArray, 0, bArray.Length);
        await ms.FlushAsync();
        ms.Position = 0;
        return ms;
    }

    private void SaveFile(VideoImage output)
    {
        
        _VideoImageService.Insert(output);
    }

    public Task Processa(string url)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<VideoImage> GetAll()
    {
        return _VideoImageService.GetAll();
    }
}