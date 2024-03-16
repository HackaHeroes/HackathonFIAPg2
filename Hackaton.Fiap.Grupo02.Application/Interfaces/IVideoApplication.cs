namespace Hackaton.Fiap.Grupo02.Application.Interfaces;

public interface IVideoApplication
{
    Task GetStatusProcessAsync(string url);
}