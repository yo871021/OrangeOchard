using Common.Model;
using Database.Model.Enums;
using DataBase;
using DataBase.Model;
using Microsoft.Extensions.Options;

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
