using Hackaton.Fiap.Grupo02.Domain.Data;
using MassTransit;

namespace Hackaton.Fiap.Grupo02.Domain.Event;

    public class ReceivedMessage : IConsumer<MessageData>
    {
        public Task Consume(ConsumeContext<MessageData> context)
        {
            Console.WriteLine(context.Message);
            return Task.CompletedTask;
        }
    }
