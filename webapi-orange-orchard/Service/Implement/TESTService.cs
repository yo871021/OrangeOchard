using Dao.Interface;
using Microsoft.Extensions.Options;
using Model.Common;
using Model.DataBase;
using Service.Interface;

namespace Service.Implement
{
    public class TESTService : DBServiceBase, ITESTService
    {
        private readonly ITESTRepository _ITESTRepository;
        public TESTService(IOptions<CommonSettings> commonSettings, ITESTRepository ITESTRepository) : base(commonSettings)
        {
            _ITESTRepository = ITESTRepository;
        }

        public CommonResult TEST()
        {
            var db = GetDBInstance();
            //db.Begin();
            _ITESTRepository.SetDB(db);
            var result = _ITESTRepository.SELECT(new Letter_Info() { Letter_ID = "1231231231" });

            db.Close();

            return result;
        }
    }
}
