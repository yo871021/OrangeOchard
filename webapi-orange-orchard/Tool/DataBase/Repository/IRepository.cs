using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.DataBase.Repository
{
    public interface IRepository
    {
        void SetDB(DBInstance dbInstance);
        //CommonResult SELECT(params object[] conditions);
    }
}
