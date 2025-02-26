using Model.Common;
using Model.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Interface
{
    public interface IRepository
    {
        void SetDB(DBInstance dbInstance);
        CommonResult SELECT<T>(T condition, QueryOptions? options = null) where T : EntityBase, new();
        CommonResult INSERT<T>(T condition) where T : EntityBase, new ();
        CommonResult UPDATE<T>(T updateData, T condition, bool isIgnoreDataAffect = false) where T : EntityBase, new();
        CommonResult DELETE<T>(T condition, bool isIgnoreDataAffect = false) where T : EntityBase, new ();
    }
}
