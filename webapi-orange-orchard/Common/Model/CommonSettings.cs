using Common.Model.DataBase;
using DataBase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class CommonSettings
    {
        public Dictionary<string, DBOptions>? Database { get; set; }
    }
}
