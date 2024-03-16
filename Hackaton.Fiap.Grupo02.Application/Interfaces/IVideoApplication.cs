using System.Buffers.Text;
using Hackaton.Fiap.Grupo02.Domain.Data;
using Hackaton.Fiap.Grupo02.Domain.Entities;

namespace Hackaton.Fiap.Grupo02.Application.Interfaces;

public interface IVideoApplication
{
    Task ProcessAsync(BinaryData message);
    
    Task GetStatusAsync(string url);


    IEnumerable<VideoImage> GetAll();
}