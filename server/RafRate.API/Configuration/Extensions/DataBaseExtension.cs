using RafRate.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace RafRate.API.Configuration.Extensions;

public static class DataBaseExtension
{
    public static IServiceCollection AddDataBase(this IServiceCollection services)
        => services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionString",
                EnvironmentVariableTarget.Machine)));
}
