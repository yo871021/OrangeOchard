using Microsoft.Data.SqlClient;
using Model.Common;
using Model.DataBase;
using Model.Enum;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlKata;
using Microsoft.Extensions.Options;
using SqlKata.Compilers;
using Tool.DataBase;
using Dapper;

namespace Dao.Implement
{
    public class DBRepositoryBase
    {
        private DBInstance? _dbInstance;
        public void SetDB(DBInstance dbInstance)
        {
            _dbInstance = dbInstance;
        }
        public CommonResult ExecuteSqlCommand(Query query) 
        {
            var sqlResult = new SqlServerCompiler().Compile(query);
            return ExecuteSqlCommand(sqlResult.Sql, sqlResult.NamedBindings);
        }

        public CommonResult ExecuteSqlCommand(string sql, Dictionary<string, object>? parameters = null)
        {
            return ExecuteSqlCommand(EDBCmdType.SELECT, sql, parameters);
        }

        public CommonResult ExecuteSqlCommand(EDBCmdType cmdType, string sql, Dictionary<string,object>? parameters = null)
        {
            var result = new CommonResult();
            try
            {
                switch (cmdType)
                {
                    case EDBCmdType.SELECT:
                        result.ListData = _dbInstance?.Conection?.Query(sql, parameters, _dbInstance.Transaction);
                        break;

                    case EDBCmdType.INSERT:
                    case EDBCmdType.UPDATE:
                    case EDBCmdType.DELETE:
                        result.AffectCount = _dbInstance?.Conection?.Execute(sql, parameters, _dbInstance.Transaction) ?? 0;
                        break;
                }
            }
            catch (Exception ex)
            {
                result.AssignException(ex);
            }

            return result;
        }
    }
}
