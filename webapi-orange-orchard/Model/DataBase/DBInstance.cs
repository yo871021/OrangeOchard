using Microsoft.Data.SqlClient;
using Model.Common;
using Model.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataBase
{
    public class DBInstance
    {
        private readonly IDbConnection? _connection;
        private IDbTransaction? _transaction;
        public IDbConnection? Conection { get { return _connection; } }
        public IDbTransaction? Transaction { get { return _transaction; } }
        public DBInstance(DBOptions? dbOptions)
        {
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
    }
}
