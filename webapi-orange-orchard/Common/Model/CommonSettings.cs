using Common.Model.Enums;
using DataBase.Model;

namespace Common.Model
{
    public class CommonSettings
    {
        public Dictionary<string, DBOptions>? Database { get; set; }
        public Dictionary<EAPIServer, string>? ApiUrl { get; set; }
    }
}
