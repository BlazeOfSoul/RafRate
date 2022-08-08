using RafRate.Data.Contexts;
using RafRate.Data.Entities;
using RafRate.Data.Repositories.Base;

namespace RafRate.Data.Repositories
{
    public class ActiveDayRepository : BaseRepository<ActiveDayEntity>
    {
        public ActiveDayRepository(AppDbContext context)
            : base(context)
        {}
    }
}
