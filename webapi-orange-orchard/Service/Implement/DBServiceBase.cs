using Common.Model;
using Database.Model.Enums;
using DataBase;
using DataBase.Model;
using Microsoft.Extensions.Options;
using System.Collections.ObjectModel;

namespace Service.Implement
{
    public class DBServiceBase 
    {
        private static ReadOnlyDictionary<string, DBOptions>? _dbOptionsDict;

        public static void ConfigureDBOptions(Dictionary<string, DBOptions> options)
        {
            _dbOptionsDict = new ReadOnlyDictionary<string, DBOptions>(options);
        }

        public DBInstance GetDBInstance(EDB db = EDB.Main)
        {
            return new DBInstance(_dbOptionsDict?.TryGetValue(db.ToString(), out var dbOption) ?? false ? dbOption : new DBOptions());
        }
    }
}
