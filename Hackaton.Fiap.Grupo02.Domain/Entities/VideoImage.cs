namespace Hackaton.Fiap.Grupo02.Domain.Entities
{
    public class VideoImage: BaseEntity
    {
        public string VideoName { get; set; }
        public string VideoLink { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ZipFile { get; set; }
        public string ZipName { get; set; }
        public DateTime ZipCreatedAt { get; set; }
        public bool IsProcessed { get; set; }

    }
}