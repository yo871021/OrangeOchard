using Common.Model;
using Common.Model.DataBase.DBEntity;
using Repository.Interface;
using Microsoft.Extensions.Options;
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
            var result = new CommonResult();
            var db = GetDBInstance();

            try
            {
                do
                {
                    db.Begin();
                    _ITESTRepository.SetDB(db);

                    result = _ITESTRepository.SELECT(new Letter_Info() { Letter_ID = "1231231231" });
                    if (result.IsFail)
                    {
                        break;
                    }

                    result = _ITESTRepository.INSERT(new Letter_Info() { Letter_ID = "1231231231" });
                    if (result.IsFail)
                    {
                        break;
                    }

                    db.Commit();
                }
                while (false);
            }
            catch (Exception ex)
            {
                result.AssignException(ex);
            }
            finally
            {
                if (result.IsFail)
                {
                    db.Rollback();
                }
                db.Close();
            }

            return result;
        }
    }
}
