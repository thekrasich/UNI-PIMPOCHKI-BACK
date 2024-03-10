namespace Pimpochki.Domain.Entities.Common;

public class User : EntityBase
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
