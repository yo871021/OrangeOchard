using Microsoft.Extensions.Options;
using Model.ViewModel.CommonSettings;

namespace Tool.DataBase.Service
{
    public class GenericService : DBServiceBase, IService
    {
        public GenericService(IOptions<CommonSettings> commonSettings) : base(commonSettings)
        {
        }
    }
}
