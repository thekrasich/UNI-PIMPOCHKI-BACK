namespace Pimpochki.Domain.Entities.Common;

public class Product : EntityBase
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
}