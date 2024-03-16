using Hackaton.Fiap.Grupo02.Domain.Entities;
using Hackaton.Fiap.Grupo02.Infra.Database.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Hackaton.Fiap.Grupo02.Infra.Database;

public class SistemaDbContext : DbContext
{
    public DbSet<VideoImage> VideoImages { get; set; }
    
    private readonly IConfiguration _configuration;

    public SistemaDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        VideoImageMapping.Map(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionstring = _configuration["ConnectionStrings:DefaultConnection"];
        
        optionsBuilder.UseSqlServer(connectionstring);
    }
}