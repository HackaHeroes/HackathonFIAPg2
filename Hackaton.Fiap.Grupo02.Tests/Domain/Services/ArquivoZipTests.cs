using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;
using Moq;

namespace Hackaton.Fiap.Grupo02.Tests.Domain.Services;

public class ArquivoZipTests
{

    [Fact]
    public void DeveGravarArquivo()
    {
        string origem = string.Empty;
        string destino = string.Empty;

        Mock<IZipFile> arquivoZipMock = new Mock<IZipFile>();
        arquivoZipMock.Setup(x => x.SaveFile(It.IsAny<string>(), It.IsAny<string>()));


        arquivoZipMock.Verify();
    }
}