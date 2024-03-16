﻿using Hackaton.Fiap.Grupo02.Application.Interfaces;

namespace Hackaton.Fiap.Grupo02.Application.Applications;

public class VideoApplication : IVideoApplication
{
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

    private void GravarArquivo(string output)
    {

    }
}