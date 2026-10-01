using Microsoft.AspNetCore.Identity;
using RafRate.Data.Interfaces;

namespace RafRate.Data.Entities.Users;

public class UserEntity : IdentityUser<Guid>, IEntity
{
    public string? RefreshToken { get; set; }
    
    public DateTime RefreshTokenExpiryTime { get; set; }
}