using Common.Model;
using Repository.Interface;
using Microsoft.Extensions.Options;
using Service.Interface;
using DataBase.Model;
using Common.Model.DBEntity;

namespace Service.Implement
{
    public class TESTService : DBServiceBase, ITESTService
    {
        private readonly ITESTRepository _ITESTRepository;
        public TESTService(ITESTRepository ITESTRepository) 
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

                    result = _ITESTRepository.SELECT(new Products());
                    if (result.IsFail)
                    {
                        break;
                    }

                    result = _ITESTRepository.INSERT(new Products()
                    {
                        Item_Name = "椪柑",
                        Item_SubName = "(中)",
                        Item_SubTitle = "23 ~ 25 cm",
                        Item_Sts = "S",
                        Unit_Price = 30,
                        Unit = "每斤",
                        Item_Desc = "經典",
                        Sort_No = 0,
                        Created_Date = DateTime.Now,
                        Updated_Date = DateTime.Now
                    });
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
