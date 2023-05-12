using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DTpureback.Models;
using DTpureback.Data;
using Microsoft.Data.SqlClient;
using Npgsql;
using Microsoft.OpenApi.Models;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

var conStrBuilder = new NpgsqlConnectionStringBuilder(
        builder.Configuration["HOSTED_DB:ConnectionString"]);
conStrBuilder.Password = builder.Configuration["HOSTED_DB:DbPassword"];
var connection = conStrBuilder.ConnectionString;

//var connection = Environment.GetEnvironmentVariable("HOSTED_DB_URL");
Console.WriteLine(connection);


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        { //WithOrigins("http://localhost:4200/game")
                                policy.AllowAnyHeader()
                                .AllowAnyOrigin()
                                .AllowAnyMethod(); 
        });
});

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddDbContext<DragonsTailContext>(opt =>
    opt.UseNpgsql(connection));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<DragonsTailContext>();
    
    DbInitializer.Initialize(context);
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
