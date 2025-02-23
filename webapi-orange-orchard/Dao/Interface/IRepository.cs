using Model;
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
        CommonResult SELECT(string sql);
    }
}
