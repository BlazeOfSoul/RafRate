using RafRate.Data.Contexts;
using RafRate.Data.Entities;
using RafRate.Data.Repositories.Base;

namespace RafRate.Data.Repositories;

using Entities.Teachers;

public class TeacherRepository : BaseRepository<TeacherEntity>
{
    public TeacherRepository(AppDbContext context)
        : base(context)
    {
    }
}
