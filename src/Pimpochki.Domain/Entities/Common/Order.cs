namespace Pimpochki.Domain.Entities.Common;

public class Order : EntityBase
{
    public ICollection<Product> Products { get; set; } = new List<Product>();
    public DateTime OrderDate { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
}