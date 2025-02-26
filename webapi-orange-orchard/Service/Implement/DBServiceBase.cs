using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Model.Common;
using Model.DataBase;
using Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implement
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
            return new DBInstance(_dbOptionsDict?[db.ToString()]);
        }
    }
}
