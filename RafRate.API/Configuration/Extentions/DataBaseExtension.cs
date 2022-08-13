﻿using RafRate.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace RafRate.API.Configuration.Extentions;

public static class DataBaseExtension
{
    static ConnectionStringContext stringContext = new();
    
    public static IServiceCollection AddDataBase(this IServiceCollection services)
    => services.AddDbContext<AppDbContext>(options => 
        options.UseSqlServer(stringContext.ConnectionString));
}