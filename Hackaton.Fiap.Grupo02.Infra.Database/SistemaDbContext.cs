using Hackaton.Fiap.Grupo02.Domain.Entities;
using Hackaton.Fiap.Grupo02.Infra.Database.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



namespace Hackaton.Fiap.Grupo02.Infra.Database;

public class SistemaDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public SistemaDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }
}