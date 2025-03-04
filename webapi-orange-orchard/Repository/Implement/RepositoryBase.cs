using Common.Model.DBEntity.Base;
using Database.Model.Enums;
using DataBase.Model;
using DataBase.Repository;
using DataBase.Tool;
using Repository.Interface;

namespace Repository.Implement
{
    public class RepositoryBase : DBRepositoryBase, IRepository
    {
        #region Interface
        CommonResult IRepository.SELECT<T>(T condition, QueryOptions? options)
        {
            return SELECT(condition, options);
        }

        CommonResult IRepository.INSERT<T>(T condition)
        {
            return INSERT(condition);
        }

        CommonResult IRepository.UPDATE<T>(T updateData, T condition, bool isIgnoreDataAffect)
        {
            return UPDATE(updateData, condition, isIgnoreDataAffect);
        }

        CommonResult IRepository.DELETE<T>(T condition, bool isIgnoreDataAffect)
        {
            return DELETE(condition, isIgnoreDataAffect);
        }
        #endregion

        private CommonResult SELECT<T>(T condition, QueryOptions? options = null) where T : EntityBase, new()
        {
            var result = new CommonResult();
            try
            {
                do
                {
                    result = db.ExecuteSqlCommand<T>(SqlBuilder.GenSelectCmd(condition.GetType().Name, condition.GetDirtyDictionory("="), options));
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

        private CommonResult INSERT<T>(T condition) where T : EntityBase, new()
        {
            var result = new CommonResult();
            try
            {
                do
                {
                    result = db.ExecuteSqlCommand(EDBCmdType.INSERT, SqlBuilder.GenInsertCmd(condition.GetType().Name, condition.GetDirtyDictionory()));
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

        private CommonResult UPDATE<T>(T updateData, T condition, bool isIgnoreDataAffect = false) where T : EntityBase, new()
        {
            var result = new CommonResult();
            try
            {
                do
                {
                    result = db.ExecuteSqlCommand(EDBCmdType.UPDATE, SqlBuilder.GenUpdateCmd(condition.GetType().Name, updateData.GetDirtyDictionory(), condition.GetDirtyDictionory("=")));
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

        private CommonResult DELETE<T>(T condition, bool isIgnoreDataAffect = false) where T : EntityBase, new()
        {
            var result = new CommonResult();
            try
            {
                do
                {
                    result = db.ExecuteSqlCommand(EDBCmdType.DELETE, SqlBuilder.GenDeleteCmd(condition.GetType().Name, condition.GetDirtyDictionory("=")));
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
