using Dapper;
using Database.Model.Enums;
using DataBase.Model;
using DataBase.Tool;
using SqlKata;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DBFactory
    {
        private readonly DBInstance? _dbInstance;
        public DBFactory(DBInstance dbInstance)
        {
            _dbInstance = dbInstance;
        }

        public CommonResult ExecuteSqlCommand(Query query)
        {
            return ExecuteSqlCommand(EDBCmdType.SELECT, query);
        }

        public CommonResult ExecuteSqlCommand(EDBCmdType cmdType, Query query)
        {
            var sqlResult = _dbInstance?.Compiler?.Compile(query);
            return ExecuteSqlCommand(cmdType, sqlResult?.Sql ?? string.Empty, sqlResult?.NamedBindings);
        }

        public CommonResult ExecuteSqlCommand(string sql, Dictionary<string, object>? parameters = null)
        {
            return ExecuteSqlCommand(EDBCmdType.SELECT, sql, parameters);
        }

        public CommonResult ExecuteSqlCommand(EDBCmdType cmdType, string sql, Dictionary<string, object>? parameters = null)
        {
            var result = new CommonResult() { ConnectionId = _dbInstance?.ConnectionId };
            try
            {
                var connection = _dbInstance?.Connection?.WriteSqlLog(sql, parameters);

                switch (cmdType)
                {
                    case EDBCmdType.SELECT:
                        result.ListData = connection?.Query(sql, parameters, _dbInstance?.Transaction).Cast<object>();
                        break;

                    case EDBCmdType.INSERT:
                    case EDBCmdType.UPDATE:
                    case EDBCmdType.DELETE:
                        result.AffectCount = connection?.Execute(sql, parameters, _dbInstance?.Transaction) ?? 0;
                        break;
                }
            }
            catch (Exception ex)
            {
                result.AssignException(ex);
            }

            return result;
        }

        public CommonResult ExecuteSqlCommand<T>(Query query) 
        {
            var sqlResult = _dbInstance?.Compiler?.Compile(query);
            return ExecuteSqlCommand<T>(sqlResult?.Sql ?? string.Empty, sqlResult?.NamedBindings);
        }

        public CommonResult ExecuteSqlCommand<T>(string sql, Dictionary<string, object>? parameters = null) 
        {
            var result = new CommonResult() { ConnectionId = _dbInstance?.ConnectionId };
            try
            {
                result.ListData = _dbInstance?.Connection?.WriteSqlLog(sql, parameters).Query<T>(sql, parameters, _dbInstance.Transaction).Cast<object>();
            }
            catch (Exception ex)
            {
                result.AssignException(ex);
            }

            return result;
        }
    }
}
