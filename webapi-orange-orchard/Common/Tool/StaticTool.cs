using Common.Model;
using DataBase.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Tool
{
    public static class StaticTool
    {
        public static T? SetTo<T>(this object obj)
        {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(obj));
        }

        public static CommonResult ToCommon(this DBResult result)
        {
            return new CommonResult()
            {
                Message = result?.Message,
                Code = result?.Code,
                AffectCount = result?.AffectCount ?? -1,
                ListData = result?.ListData
            };
        }
    }
}
