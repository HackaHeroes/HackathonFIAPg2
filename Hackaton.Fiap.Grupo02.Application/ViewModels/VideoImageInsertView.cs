using Hackaton.Fiap.Grupo02.Domain.Entities;

namespace Hackaton.Fiap.Grupo02.Application.ViewModels;

public class VideoImageInsertView
{
    public string VideoName { get; set; }
    public string VideoLink { get; set; }
    public string ZipFile { get; set; }
    public string ZipName { get; set; }

    public static explicit operator VideoImageInsertView(VideoImage obj)
    {
            var model = new VideoImageInsertView
            {
                VideoName = obj.VideoName,
                VideoLink = obj.VideoLink,
                ZipFile = obj.ZipFile,
                ZipName = obj.ZipName
            };
            return model;
        }
}