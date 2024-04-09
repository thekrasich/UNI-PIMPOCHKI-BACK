namespace Pimpochki.Application.Services.Auth.Abstractions;

public interface IHashService
{
    public string HashPassword(string password);
    
    public bool VerifyPassword(string hashPassword, string rawPassword);
}