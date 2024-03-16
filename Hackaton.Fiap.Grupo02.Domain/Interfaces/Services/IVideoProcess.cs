namespace Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;

public interface IVideoProcess
{
    Task<TimeSpan> GetVideoDurationAsync(string path);
    bool VideoSnapshot(TimeSpan currentTime, string input, string output);
}