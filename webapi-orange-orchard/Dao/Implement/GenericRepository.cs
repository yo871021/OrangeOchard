using Model.Enum;
using Model.Common;
using Dao.Interface;
using Model.DataBase;
using SqlKata.Compilers;
using Tool.DataBase;

namespace Dao.Implement
{
    public class GenericRepository : DBRepositoryBase, IRepository
    {
        public CommonResult SELECT<T>(T condition, QueryOptions? options = null) where T : EntityBase, new()
        {
            var result = new CommonResult();
            options ??= new QueryOptions();
            try
            {
                do
                {
                    result = ExecuteSqlCommand(SQLBuilder.GenSelectCmd<T>(condition, options));
                    if (result.IsFail)
                    {
                        break;
                    }
                }
                while (false);
            }
            catch (Exception ex) 
            {
                result.AssignException(ex);
            }

            return result;
        }

        public CommonResult INSERT<T>(T condition) where T : EntityBase, new()
        {
            var result = new CommonResult();
            return result;
        }

        public CommonResult UPDATE<T>(T updateData, T condition, bool isIgnoreDataAffect = false) where T : EntityBase, new()
        {
            var result = new CommonResult(); 
            return result;
        }

        public CommonResult DELETE<T>(T condition, bool isIgnoreDataAffect = false) where T : EntityBase, new()
        {
            var result = new CommonResult();
            return result;
        }
    }
}