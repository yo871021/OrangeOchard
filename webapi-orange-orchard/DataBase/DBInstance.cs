using System.Data;
using System.Data.Common;
using Database.Model.Enums;
using DataBase.Model;
using DataBase.Tool;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Data.SqlClient;
using SqlKata.Compilers;

namespace DataBase
{
    public class DBInstance : IDisposable
    {
        private readonly DBOptions? _dbOptions;
        private readonly IDbConnection? _connection;
        private IDbTransaction? _transaction;
        private bool _disposed = false;
        public string? ConnectionId { get { return _connection.GetConnectionId(); } }
        internal IDbConnection? Connection { get { return _connection; } }
        internal IDbTransaction? Transaction { get { return _transaction; } }
        public Compiler? Compiler { get { return _dbOptions?.GetDBCompiler(); } }
        public DBInstance(DBOptions? dbOptions)
        {
            _dbOptions = dbOptions;
            _connection = _dbOptions?.GetDBConnection();
            _connection?.Open();
            _connection.WriteLog($"Initial DBConnection: {_connection?.ConnectionString}");
        }

        public void Begin()
        {
            _transaction = _connection?.WriteLog("BEGIN()")?.BeginTransaction();
        }

        public void Commit()
        {
            _transaction?.WriteLog("COMMIT()")?.Commit();
        }

        public void Rollback()
        {
            _transaction?.WriteLog("ROLLBACK()")?.Rollback();
        }

        public void Close()
        {
            _connection?.WriteLog("CLOSE()")?.Close();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _transaction?.Rollback();
                    _transaction?.Dispose();
                    _connection?.Close();
                    _connection?.Dispose();
                }

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DBInstance()
        {
            Dispose(false);
        }
    }
}
