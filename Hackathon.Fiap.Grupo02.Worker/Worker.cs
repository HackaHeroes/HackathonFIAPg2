using System.Text;
using Azure.Messaging.ServiceBus;
using Hackaton.Fiap.Grupo02.Application.Interfaces;
using Hackaton.Fiap.Grupo02.Domain.Data;

namespace Hackathon.Fiap.Grupo02.Worker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly ServiceBusClient _serviceBusClient;
    private readonly ServiceBusReceiver _receiver;
    private readonly IVideoApplication _videoApplication;
    private readonly IConfiguration _configuration;

    public Worker(ILogger<Worker> logger, IVideoApplication videoApplication, IConfiguration configuration)
    {
        _logger = logger;
        _videoApplication = videoApplication;
        _configuration = configuration;

        var queueName = configuration.GetSection("ServiceBusSettings")["Subscription"] ?? string.Empty;
        var connectionString = configuration.GetSection("ServiceBusSettings")["PubSubConnection"] ?? string.Empty;

        _serviceBusClient = new ServiceBusClient(connectionString);
        _receiver = _serviceBusClient.CreateReceiver(queueName);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var receivedMessage = await _receiver.ReceiveMessageAsync(cancellationToken: stoppingToken);

            if (receivedMessage != null)
            {
                var body = receivedMessage.Body;
                var receivedMessageData = Encoding.UTF8.GetString(body).Replace("\n", "");
                var messageData = Newtonsoft.Json.JsonConvert.DeserializeObject<ReceivedMessageData>(receivedMessageData);
                if (messageData != null)
                {
                    Console.WriteLine(messageData.ToString());
                }

                await _videoApplication.ProcessAsync(messageData.Message);
            }

            await _receiver.CompleteMessageAsync(receivedMessage);
        }
    }
}