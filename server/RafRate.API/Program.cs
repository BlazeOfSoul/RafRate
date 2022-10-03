using RafRate.API.Configuration.Extensions;
using RafRate.API.Configuration.Handlers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureServices();
builder.Services.AddDataBase();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddPolicy("RafRateOrigins",
    policy =>
    {
        policy.WithOrigins(builder.Configuration["FrontUrl"])
            .AllowAnyMethod().AllowAnyHeader();
    }));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("RafRateOrigins");
app.UseHttpsRedirection();
app.UseExceptionHandling();
app.UseAuthorization();
app.MapControllers();
app.Run();
