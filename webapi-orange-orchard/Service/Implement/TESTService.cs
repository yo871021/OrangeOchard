using Dao.Interface;
using Microsoft.Extensions.Options;
using Model.Common;
using Model.ViewModel.CommonSettings;
using Service.Interface;
using Tool.DataBase.Service;

namespace Service.Implement
{
    public class TESTService : DBServiceBase, ITESTService
    {
        private readonly ITESTRepository bbb;
        public TESTService(IOptions<CommonSettings> commonSettings, ITESTRepository bbbb) : base(commonSettings)
        {
            bbb = bbbb;
        }

        public void TEST()
        {
            var db = GetDBInstance();
            //db.Begin();
            bbb.SetDB(db);
            //var a = bbb.SELECT("SELECT * FROM Letter_Info");
            //var a = bbb.SELECT(new Letter_Info());

            db.Close();
        }
    }
}
