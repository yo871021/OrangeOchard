using Microsoft.Extensions.Options;
using Model.Common;
using Service.Interface;

namespace Service.Implement
{
    public class GenericService : DBServiceBase, IService
    {
        public GenericService(IOptions<CommonSettings> commonSettings) : base(commonSettings)
        {
        }
    }
}
