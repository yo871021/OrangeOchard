using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Model;
using Model.Enum;
using Model.ViewModel.CommonSettings;
using Model.ViewModel.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.DataBase.Service
{
    public class DBServiceBase
    {
        private readonly Dictionary<string, DBOptions>? _dbOptionsDict;

        public DBServiceBase(IOptions<CommonSettings> commonSettings)
        {
            _dbOptionsDict = commonSettings.Value.Database;
        }

        public DBInstance GetDBInstance(EDB db = EDB.Main)
        {
            var dbOptions = _dbOptionsDict?[db.ToString()];
            var connection = new SqlConnection($"Server={dbOptions?.DBServer};" +
                $"Database={dbOptions?.DBName};" +
                $"User Id={dbOptions?.DBUser};" +
                $"Password={dbOptions?.DBPassword};" +
                $"Connection Timeout={dbOptions?.ConnectTimeOut};" +
                $"TrustServerCertificate=True;");

            return new DBInstance(connection);
        }
    }
}
