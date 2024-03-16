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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //var versao = new MariaDbServerVersion("11.2.2-MariaDB");
        //var connectionstring = "Server=127.0.0.1;Port=3306;DataBase=Sistema;Uid=root;Pwd=luciana;Allow User Variables=True;Default Command Timeout=120;";




        var connectionstring = _configuration["ConnectionStrings:DefaultConnection"];
        var versao = _configuration["ConnectionStrings:VersionDatabase"];

        optionsBuilder.UseMySql(connectionstring, new MySqlServerVersion(new Version(8, 0, 25)));

    }

}