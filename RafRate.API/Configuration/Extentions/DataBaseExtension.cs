using RafRate.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace RafRate.API.Configuration.Extentions;

public static class DataBaseExtension
{
    public static IServiceCollection AddDataBase(this IServiceCollection services)
    => services.AddDbContext<AppDbContext>(options => 
        options.UseSqlServer(System.Environment.GetEnvironmentVariable("ConnectionString",
            EnvironmentVariableTarget.Machine)));
}