using Database.Model.Enums;
using DataBase.Model;
using Microsoft.Data.SqlClient;
using SqlKata.Compilers;
using System.Data;

namespace DataBase.Tool
{
    public static class ConnectionProvider
    {
        public static string? GetConnectionId(this IDbConnection? connection)
        {
            return connection is SqlConnection sqlconnection ? sqlconnection.ClientConnectionId.ToString() : null;
        }

        private static string? GetConnectionString(DBOptions? dbOptions)
        {
            var dbType = Enum.TryParse<EDBType>(dbOptions?.DBType, out var dbtype) ? dbtype : EDBType.SqlServer;
            return dbType switch
            {
                EDBType.SqlServer =>
                    $"Server={dbOptions?.DBServer};Database={dbOptions?.DBName};User Id={dbOptions?.DBUser};Password={dbOptions?.DBPassword};" +
                    $"Connection Timeout={dbOptions?.ConnectTimeOut};TrustServerCertificate=True;",

                EDBType.MySql =>
                    $"Server={dbOptions?.DBServer};Database={dbOptions?.DBName};Uid={dbOptions?.DBUser};Pwd={dbOptions?.DBPassword};" +
                    $"Connection Timeout={dbOptions?.ConnectTimeOut};",

                EDBType.PostgreSql =>
                    $"Host={dbOptions?.DBServer};Database={dbOptions?.DBName};Username={dbOptions?.DBUser};Password={dbOptions?.DBPassword};" +
                    $"Timeout={dbOptions?.ConnectTimeOut};",

                EDBType.Sqlite =>
                    $"Data Source={dbOptions?.DBFilePath};",

                EDBType.Oracle =>
                    $"Data Source={dbOptions?.DBServer}:1521/{dbOptions?.DBName};User Id={dbOptions?.DBUser};Password={dbOptions?.DBPassword};" +
                    $"Connection Timeout={dbOptions?.ConnectTimeOut};",

                _ => null
            };
        }

        public static IDbConnection? GetDBConnection(this DBOptions dbOptions)
        {
            _ = Enum.TryParse<EDBType>(dbOptions?.DBType, out var dbtype) ? dbtype : EDBType.SqlServer;
            var connectionstring = GetConnectionString(dbOptions);
            return dbtype switch
            {
                EDBType.SqlServer => new SqlConnection(connectionstring),
                //EDBType.MySql => new MySqlConnection(connectionstring),
                //EDBType.PostgreSql => new NpgsqlConnection(connectionstring),
                //EDBType.Sqlite => new SQLiteConnection(connectionstring),
                //EDBType.Oracle => new OracleConnection(connectionstring),
                _ => new SqlConnection(),
            };
        }

        public static Compiler? GetDBCompiler(this DBOptions dbOptions)
        {
            _ = Enum.TryParse<EDBType>(dbOptions?.DBType, out var dbtype) ? dbtype : EDBType.SqlServer;
            return dbtype switch
            {
                EDBType.SqlServer => new SqlServerCompiler(),
                EDBType.MySql => new MySqlCompiler(),
                EDBType.PostgreSql => new PostgresCompiler(),
                EDBType.Sqlite => new SqliteCompiler(),
                EDBType.Oracle => new OracleCompiler(),
                _ => null,
            };
        }
    }
}
