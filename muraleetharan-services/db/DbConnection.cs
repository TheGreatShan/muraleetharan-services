using Npgsql;

namespace muraleetharan_services.db;

internal static class DbConnection
{
    internal static NpgsqlConnection CreateDbConnection() => 
        new(Environment.GetEnvironmentVariable("connstring"));
}