using Dao.Interface;
using Microsoft.Extensions.Options;
using Model.ViewModel.CommonSettings;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.DataBase;

namespace Service.Implement
{
    public class TESTService : DBServiceBase, ITESTService
    {
        private readonly IRepository bbb;
        public TESTService(IOptions<CommonSettings> commonSettings, IRepository bbbb) : base(commonSettings)
        {
            bbb = bbbb;
        }

        public void TEST()
        {
            var db = GetDBInstance();
            //db.Begin();
            bbb.SetDB(db);
            var a = bbb.SELECT("SELECT * FROM Letter_Info");

            db.Close();
        }
    }
}
