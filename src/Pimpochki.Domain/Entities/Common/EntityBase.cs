using System.ComponentModel.DataAnnotations;

namespace Pimpochki.Domain.Entities.Common;

public abstract class EntityBase
{
    [Key]
    public int Id { get; set; }
}