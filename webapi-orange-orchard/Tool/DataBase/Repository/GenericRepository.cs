using Dao.Interface;
using Model.Enum;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.DataBase.Repository
{
    public class GenericRepository : IRepository
    {
        private DBInstance? _dbInstance;
        public void SetDB(DBInstance dbInstance)
        {
            _dbInstance = dbInstance;
        }

        public CommonResult SELECT(string sql)
        {
            return _dbInstance.ExecuteSqlCommand(EDBCmdType.SELECT, sql);
        }
    }
}
