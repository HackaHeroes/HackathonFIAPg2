using System.ComponentModel.DataAnnotations.Schema;

namespace Hackaton.Fiap.Grupo02.Domain.Entities;

public class BaseEntity
{
    public BaseEntity()
    {
        Id = Guid.NewGuid();
        CriadoEm = DateTime.Now;
        ModificadoEm = DateTime.Now;
        FlgStatus = "A";
    }
    [Column(TypeName = "uuid")]
    public Guid Id { get; private set; }
    public DateTime CriadoEm { get; private set; }
    public DateTime ModificadoEm { get; private set; }
    public string FlgStatus { get; set; }
}