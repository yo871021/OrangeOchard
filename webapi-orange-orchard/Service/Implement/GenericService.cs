using Common.Model;
using Repository.Interface;
using DataBase.Model;
using Microsoft.Extensions.Options;
using Service.Interface;
using Common.Model.DBEntity.Base;

namespace Service.Implement
{
    public class GenericService : DBServiceBase, IService
    {
        IRepository _IRepository;
        public GenericService(IRepository iRepository) 
        {
            _IRepository = iRepository;
        }

        public CommonResult SELECT<T>(T condition, QueryOptions? options = null) where T : EntityBase, new()
        {
            var result = new CommonResult();

            try
            {
                do
                {
                    using (var db = GetDBInstance())
                    {
                        _IRepository.SetDB(db);

                        result = _IRepository.SELECT(condition, options);
                        if (result.IsFail)
                        {
                            break;
                        }
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
                    using (var db = GetDBInstance())
                    {
                        _IRepository.SetDB(db);

                        result = _IRepository.INSERT(condition);
                        if (result.IsFail)
                        {
                            break;
                        }
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
                    using (var db = GetDBInstance())
                    {
                        _IRepository.SetDB(db);

                        result = _IRepository.UPDATE(updateData, condition, isIgnoreDataAffect);
                        if (result.IsFail)
                        {
                            break;
                        }
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
                    using (var db = GetDBInstance())
                    {
                        _IRepository.SetDB(db);

                        result = _IRepository.DELETE(condition, isIgnoreDataAffect);
                        if (result.IsFail)
                        {
                            break;
                        }
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

        public CommonResult DELETE<T>(IEnumerable<T> conditionList, bool isIgnoreDataAffect = false) where T : EntityBase, new()
        {
            var result = new CommonResult();

            try
            {
                do
                {
                    using (var db = GetDBInstance())
                    {
                        _IRepository.SetDB(db);
                        db.Begin();

                        foreach (var condition in conditionList)
                        {
                            result = _IRepository.DELETE(condition, isIgnoreDataAffect);
                            if (result.IsFail)
                            {
                                break;
                            }
                        }
                        if (result.IsFail)
                        {
                            break;
                        }

                        db.Commit();
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
