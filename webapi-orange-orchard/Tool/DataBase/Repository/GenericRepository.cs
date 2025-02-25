using Model.Enum;
using Model.Common;

namespace Tool.DataBase.Repository
{
    public class GenericRepository : IRepository
    {
        private DBInstance? _dbInstance;
        public void SetDB(DBInstance dbInstance)
        {
            _dbInstance = dbInstance;
        }

        //public CommonResult SELECT(params object[] conditions)
        //{
        //    if (conditions.Any(x=>x is EntityBase))
        //    {

        //    }

        //    return _dbInstance.ExecuteSqlCommand(EDBCmdType.SELECT, "");
        //}
        //public CommonResult INSERT(string sql)
        //{ 
        //}
        //public CommonResult UPDATE(string sql)
        //{
        //}
        //public CommonResult DELETE(string sql)
        //{
        //}
    }
}
