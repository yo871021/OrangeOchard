using Model.Enums;
using Model.Common;
using Dao.Interface;
using Model.DataBase;
using SqlKata.Compilers;
using Tool.DataBase;
using Microsoft.Extensions.Options;

namespace Dao.Implement
{
    public class GenericRepository : DBRepositoryBase, IRepository
    {
        public CommonResult SELECT<T>(T condition, QueryOptions? options = null) where T : EntityBase, new()
        {
            var result = new CommonResult();
            try
            {
                do
                {
                    result = ExecuteSqlCommand(SQLBuilder.GenSelectCmd(condition, options));
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
            try
            {
                do
                {
                    result = ExecuteSqlCommand(EDBCmdType.INSERT ,SQLBuilder.GenInsertCmd(condition));
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

        public CommonResult UPDATE<T>(T updateData, T condition, bool isIgnoreDataAffect = false) where T : EntityBase, new()
        {
            var result = new CommonResult();
            try
            {
                do
                {
                    result = ExecuteSqlCommand(EDBCmdType.UPDATE, SQLBuilder.GenUpdateCmd(updateData, condition));
                    if (result.IsFail)
                    {
                        break;
                    }

                    if (!isIgnoreDataAffect && result.AffectCount != 1)
                    {
                        result.AssignMessage("資料已異動，請重新查詢!");
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

        public CommonResult DELETE<T>(T condition, bool isIgnoreDataAffect = false) where T : EntityBase, new()
        {
            var result = new CommonResult();
            try
            {
                do
                {
                    result = ExecuteSqlCommand(EDBCmdType.DELETE, SQLBuilder.GenDeleteCmd(condition));
                    if (result.IsFail)
                    {
                        break;
                    }

                    if (!isIgnoreDataAffect && result.AffectCount != 1)
                    {
                        result.AssignMessage("資料已異動，請重新查詢!");
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
    }
}