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
               
        private static string GetConnectionIdTag(this string? connectionId)
        {
            return string.IsNullOrEmpty(connectionId) ? string.Empty : $"  [id:{connectionId}]";
        }

        public static string WriteLog(string msg)
        {
            ActionLogger.Information(msg);

            return msg;
        }

        public static IDbConnection? WriteLog(this IDbConnection? connection, string msg)
        {
            WriteLog($"{msg}{connection.GetConnectionId().GetConnectionIdTag()}");
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

            WriteLog($"Executing SQL: {sql}{connection.GetConnectionId().GetConnectionIdTag()}");

            return connection;
        }

        public static string WriteErroMsgLog(this string errMsg, string? connectionId = null)
        {
            ActionLogger.Error(errMsg + connectionId.GetConnectionIdTag());

            return errMsg;
        }

        public static Exception WriteExceptionLog(this Exception ex, string? connectionId = null)
        {
            ActionLogger.Fatal("Database exception occurred" + connectionId.GetConnectionIdTag());
            ExceptionLogger.Fatal(ex, "Database exception occurred" + connectionId.GetConnectionIdTag());

            return ex;
        }
    }
}
