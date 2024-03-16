using MassTransit;

namespace Hackaton.Fiap.Grupo02.Domain.Events;

public class ReceivedMessage : IConsumer<MessageData<>>
{
    public Task Consume(ConsumeContext<MessageData> context)
    {
        Console.WriteLine(context.Message);
        return Task.CompletedTask;
    }
}
