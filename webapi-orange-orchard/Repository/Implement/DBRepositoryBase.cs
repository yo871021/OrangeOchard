using DataBase;
using Common.Model;
using Database.Model.Enums;
using Common.Model.DataBase;
using Common.Tool;
using DataBase.Model;
using Repository.Interface;

namespace Repository.Implement
{
    public class DBRepositoryBase : IRepository
    {
        protected DBFactory? db;

        #region Interface
        void IRepository.SetDB(DBInstance dbInstance)
        {
            SetDB(dbInstance);
        }

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

        private void SetDB(DBInstance dbInstance)
        {
            db = new DBFactory(dbInstance);
        }

        private CommonResult SELECT<T>(T condition, QueryOptions? options = null) where T : EntityBase, new()
        {
            var result = new CommonResult();
            try
            {
                do
                {
                    result = db.ExecuteSqlCommand(SQLBuilder.GenSelectCmd(condition, options)).ToCommon();
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
                    result = db.ExecuteSqlCommand(EDBCmdType.INSERT, SQLBuilder.GenInsertCmd(condition)).ToCommon();
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
                    result = db.ExecuteSqlCommand(EDBCmdType.UPDATE, SQLBuilder.GenUpdateCmd(updateData, condition)).ToCommon();
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
                    result = db.ExecuteSqlCommand(EDBCmdType.DELETE, SQLBuilder.GenDeleteCmd(condition)).ToCommon();
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
