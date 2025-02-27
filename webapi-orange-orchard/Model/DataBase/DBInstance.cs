using Microsoft.Data.SqlClient;
using Model.Common;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlKata.Compilers;

namespace Model.DataBase
{
    public class DBInstance : IDisposable
    {
        private readonly EDBType _dbtype;
        private readonly IDbConnection? _connection;
        private IDbTransaction? _transaction;
        private bool _disposed = false;
        public IDbConnection? Conection { get { return _connection; } }
        public IDbTransaction? Transaction { get { return _transaction; } }
        public Compiler Compiler
        {
            get
            {
                switch (_dbtype)
                {
                    case EDBType.SqlServer:
                        return new SqlServerCompiler();
                    case EDBType.MySql:
                        return new MySqlCompiler();
                    case EDBType.PostgreSql:
                        return new PostgresCompiler();
                    case EDBType.Sqlite:
                        return new SqliteCompiler();
                    case EDBType.Oracle:
                        return new OracleCompiler();
                    default:
                        throw new NotSupportedException("不支援的資料庫類型");
                }
            }
        }
        public DBInstance(DBOptions? dbOptions)
        {
            _dbtype = Enum.TryParse<EDBType>(dbOptions?.DBType, out var dbtype) ? dbtype : EDBType.SqlServer;
            _connection = new SqlConnection(
                $"Server={dbOptions?.DBServer};" +
                $"Database={dbOptions?.DBName};" +
                $"User Id={dbOptions?.DBUser};" +
                $"Password={dbOptions?.DBPassword};" +
                $"Connection Timeout={dbOptions?.ConnectTimeOut};" +
                $"TrustServerCertificate=True;"
                );
            _connection.Open();
        }

        public void Begin()
        {
            _transaction = _connection?.BeginTransaction();
        }

        public void Commit()
        {
            _transaction?.Commit();
        }

        public void Rollback()
        {
            _transaction?.Rollback();
        }

        public void Close()
        {
            _connection?.Close();
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
