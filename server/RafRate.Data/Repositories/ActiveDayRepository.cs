﻿using RafRate.Data.Contexts;
using RafRate.Data.Entities;
using RafRate.Data.Repositories.Base;

namespace RafRate.Data.Repositories;

using Entities.ActiveDays;

public class ActiveDayRepository : BaseRepository<ActiveDayEntity>
{
    public ActiveDayRepository(AppDbContext context)
        : base(context)
    {
    }
}
