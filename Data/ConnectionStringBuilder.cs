using Npgsql;

namespace DTpureback.Data
{
    public class ConnectionStringBuilder
    {

        public static string BuildConnection(WebApplicationBuilder builder)
        {

        var conStrBuilder = new NpgsqlConnectionStringBuilder(
        builder.Configuration.GetConnectionString("LocalDragonsTailContext"));
        conStrBuilder.Password = builder.Configuration["LocalDragonsTailContext:DbPassword"];
        var connection = conStrBuilder.ConnectionString;
            return connection;
        }
    }
}
