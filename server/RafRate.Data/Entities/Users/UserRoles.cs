using Microsoft.AspNetCore.Identity;

namespace RafRate.Data.Entities.Users;

public class UserRoles : IdentityRole<Guid>
{
    public const string Admin = "Admin";
    public const string Moderator = "Moderator";
    public const string User = "User";
}