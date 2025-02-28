using Common.Model;
using Common.Model.DataBase;
using DataBase.Model;

namespace Service.Interface
{
    public interface IService
    {
        CommonResult SELECT<T>(T condition, QueryOptions? options = null) where T : EntityBase, new();
        CommonResult INSERT<T>(T condition) where T : EntityBase, new();
        CommonResult UPDATE<T>(T updateData, T condition, bool isIgnoreDataAffect = false) where T : EntityBase, new();
        CommonResult DELETE<T>(T condition, bool isIgnoreDataAffect = false) where T : EntityBase, new();
        CommonResult DELETE<T>(IEnumerable<T> conditionList, bool isIgnoreDataAffect = false) where T : EntityBase, new();
    }
}
