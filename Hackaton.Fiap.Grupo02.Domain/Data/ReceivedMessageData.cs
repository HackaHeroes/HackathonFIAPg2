namespace Hackaton.Fiap.Grupo02.Domain.Data;

public class ReceivedMessageData
{
    public MessageData Message { get; set; }
}

public class MessageData
{
    public string VideoName { get; set; }
    public string VideoLink { get; set; }
    public DateTime CreatedAt { get; set; }
}