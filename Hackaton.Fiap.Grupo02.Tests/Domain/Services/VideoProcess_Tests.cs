using Hackaton.Fiap.Grupo02.Domain.Interfaces.Services;
using Moq;

namespace Hackaton.Fiap.Grupo02.Tests.Domain.Services;

public class VideoProcess_Tests
{
    Mock<IVideoProcess> videoProcessMock = new Mock<IVideoProcess>();
    public VideoProcess_Tests()
    {
        videoProcessMock.Setup(x => x.GetVideoDurationAsync(It.IsAny<string>())).ReturnsAsync(new TimeSpan(0, 0, 20));
        videoProcessMock.Setup(x => x.VideoSnapshot(It.IsAny<TimeSpan>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(true);
    }

    [Fact]
    [Trait("Obtem a duração do video", "")]
    public void Test_GetVideoDurationAsync()
    {
        var result = videoProcessMock.Object.GetVideoDurationAsync(string.Empty).Result;

        Assert.NotNull(result);
        Assert.Equal(new TimeSpan(0, 0, 20), result);
    }

    [Fact]
    public void Test_VideoSnapshot()
    {
        var result = videoProcessMock.Object.VideoSnapshot(
            new TimeSpan(0, 0, 20),
            string.Empty,
            string.Empty);

        Assert.NotNull(result);
        Assert.True(result);
    }
}