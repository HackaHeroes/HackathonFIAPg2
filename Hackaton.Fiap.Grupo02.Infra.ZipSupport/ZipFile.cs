using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;
using System.IO.Compression;

namespace Hackaton.Fiap.Grupo02.Infra.ZipSupport;

public class ZipFile : IZipFile
{
    public void SaveFile(string origem, string destino)
    {
        System.IO.Compression.ZipFile.CreateFromDirectory(origem, destino);
    }
}