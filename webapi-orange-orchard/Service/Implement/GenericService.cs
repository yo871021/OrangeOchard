using Microsoft.Extensions.Options;
using Model.ViewModel.CommonSettings;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.DataBase;

namespace Service.Implement
{
    public class GenericService : DBServiceBase, IService
    {
        public GenericService(IOptions<CommonSettings> commonSettings) : base(commonSettings)
        {
        }
    }
}
