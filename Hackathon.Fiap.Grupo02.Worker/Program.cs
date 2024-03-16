using Hackathon.Fiap.Grupo02.Worker;
using Hackaton.Fiap.Grupo02.IOCWrapper;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        
        var configuration = hostContext.Configuration;
        services.AddHostedService<Worker>();
        services.AddServiceBus(configuration);
        services.AddDataBase();
        services.AddServices();
        
    })
    .Build();

host.Run();