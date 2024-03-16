using FFMpegCore;
using System.Drawing;

namespace Hackaton.Fiap.Grupo02.Infra.FFMpegSupport
{
    public class MpegSupport
    {
        private async Task<IMediaAnalysis> AnalisarVideo(string path)
        {
            return await FFProbe.AnalyseAsync(path);
        }

        public bool Snapshot(TimeSpan currentTime, string input, string output)
        {
            return FFMpeg.Snapshot(input, output, new Size(1920, 1080), currentTime);
        }

        public async Task<TimeSpan> ObterDuracaoVideo(string path)
        {
            var media = await AnalisarVideo(path);
            return media.Duration;
        }

    }
}
