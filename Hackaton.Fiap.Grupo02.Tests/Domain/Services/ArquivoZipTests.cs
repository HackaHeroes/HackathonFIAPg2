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

        Mock<IArquivoZip> arquivoZipMock = new Mock<IArquivoZip>();
        arquivoZipMock.Setup(x => x.GravarArquivo(It.IsAny<string>(), It.IsAny<string>()));


        arquivoZipMock.Verify();
    }
}