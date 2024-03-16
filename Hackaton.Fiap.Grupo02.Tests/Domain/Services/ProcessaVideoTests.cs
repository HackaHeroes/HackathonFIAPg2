using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;
using Moq;

namespace Hackaton.Fiap.Grupo02.Tests.Domain.Services;

public class ProcessaVideoTests
{
    Mock<IProcessaVideo> processaVideoMock = new Mock<IProcessaVideo>();
    public ProcessaVideoTests()
    {
        processaVideoMock.Setup(x => 
                x.GetVideoDurationAsync(It.IsAny<string>()))
            .ReturnsAsync(new TimeSpan(0, 0, 20));
        processaVideoMock.Setup(x => x.Snapshot(It.IsAny<TimeSpan>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(true);
    }

    [Fact]
    public void DeveObterDuracaoVideo()
    {
        var result = processaVideoMock.Object.GetVideoDurationAsync(string.Empty).Result;

        Assert.NotNull(result);
        Assert.Equal(new TimeSpan(0, 0, 20), result);
    }

    [Fact]
    public void DeveProcessarSnapshot()
    {
        var result = processaVideoMock.Object.Snapshot(
            new TimeSpan(0, 0, 20),
            string.Empty,
            string.Empty);

        Assert.NotNull(result);
        Assert.True(result);
    }
}