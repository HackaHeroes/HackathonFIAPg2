using Hackaton.Fiap.Grupo02.Application.Interfaces;
using Hackaton.Fiap.Grupo02.Application.ViewModels;

namespace Hackaton.Fiap.Grupo02.Application.Applications;

public class VideoApplication : IVideoApplication
{

    public VideoApplication()
    {

    }



    public async Task ProcessaAsync(string base64)
    {
        var stream = await ToMemoryStream(base64);
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

    private void SaveFile(string output)
    {

    }


    public Task Processa(InboundFileViewModel file)
    {
        var content = file.Res.Split(";");
        var fileName = file.Name;
        var type = content[0];
        var base64 = content[1];

        Console.WriteLine(type);
        Console.WriteLine(content);
        Console.WriteLine(fileName);

        return Task.CompletedTask;
    }

}