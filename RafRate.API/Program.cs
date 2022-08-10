using RafRate.API.Configuration.Extentions;
using RafRate.API.Handlers;
using RafRate.Data.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureServices();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseExceptionHandling();
app.UseAuthorization();
app.MapControllers();
app.Run();