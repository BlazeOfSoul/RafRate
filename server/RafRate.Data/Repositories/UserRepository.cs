using RafRate.Data.Contexts;
using RafRate.Data.Entities;
using RafRate.Data.Repositories.Base;

namespace RafRate.Data.Repositories;

using Entities.Users;

public class UserRepository : BaseRepository<UserEntity>
{
    public UserRepository(AppDbContext context)
        : base(context)
    {
    }
}
