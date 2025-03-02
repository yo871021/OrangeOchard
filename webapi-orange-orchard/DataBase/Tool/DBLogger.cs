using Microsoft.Data.SqlClient;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Tool
{
    internal static class DBLogger
    {
        private static string _outputTemplate = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}";
        private static readonly Logger ActionLogger;
        private static readonly Logger ExceptionLogger;

        static DBLogger()
        {
            ActionLogger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Debug(outputTemplate: _outputTemplate)
                .WriteTo.Map(
                    keySelector: e => DateTime.Now.ToString("yyyy-MM-dd"),
                    configure: (date, wt) => wt.File(
                        path: $"LOG/{date}/DataBase/Database_Action_Log_.txt",
                        rollingInterval: RollingInterval.Hour,
                        outputTemplate: _outputTemplate
                    ))
                .CreateLogger();

            ExceptionLogger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Debug(outputTemplate: _outputTemplate)
                .WriteTo.Map(
                    keySelector: e => DateTime.Now.ToString("yyyy-MM-dd"),
                    configure: (date, wt) => wt.File(
                        path: $"LOG/{date}/DataBase/Database_Exception_Log_.txt",
                        rollingInterval: RollingInterval.Day,
                        outputTemplate: _outputTemplate
                    ))
                .CreateLogger();
        }

        public static string WriteLog(this string msg)
        {
            ActionLogger.Information(msg);

            return msg;
        }

        private static string GetConnectionIdString(this IDbConnection? connection)
        {
            return connection is SqlConnection sqlconnection ? $"  [id:{sqlconnection.ClientConnectionId}]" : string.Empty;
        }

        public static IDbConnection? WriteLog(this IDbConnection? connection, string msg)
        {
            WriteLog($"{msg}{connection?.GetConnectionIdString()}");
            return connection;
        }

        public static IDbTransaction? WriteLog(this IDbTransaction? transaction, string msg)
        {
            transaction?.Connection?.WriteLog(msg);
            return transaction;
        }

        public static IDbConnection WriteSqlLog(this IDbConnection connection, string sql, Dictionary<string, object>? parameters = null)
        {
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    sql = sql.Replace(parameter.Key, parameter.Value.ToString());
                }
            }

            WriteLog($"Executing SQL: {sql}{connection.GetConnectionIdString()}");

            return connection;
        }

        public static string WriteErroMsgLog(this string errMsg)
        {
            ActionLogger.Error(errMsg);

            return errMsg;
        }

        public static Exception WriteExceptionLog(this Exception ex)
        {
            ActionLogger.Fatal("Database exception occurred");
            ExceptionLogger.Fatal(ex, "Database exception occurred");

            return ex;
        }
    }
}
