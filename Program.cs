using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DTpureback.Models;
using DTpureback.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DragonsTailContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DragonsTailContext") ?? throw new InvalidOperationException("Connection string 'DragonsTailContext' not found.")));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<DragonsTailContext>();
    DbInitializer.Initialize(context);
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
