namespace Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;

public interface IProcessaVideo
{
    Task<TimeSpan> GetVideoDurationAsync(string path);
    bool Snapshot(TimeSpan currentTime, string input, string output);
}