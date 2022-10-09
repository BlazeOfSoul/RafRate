using Microsoft.AspNetCore.Identity;
using RafRate.Data.Interfaces;

namespace RafRate.Data.Entities.Users;

public class UserEntity : IdentityUser<Guid>, IEntity
{

}