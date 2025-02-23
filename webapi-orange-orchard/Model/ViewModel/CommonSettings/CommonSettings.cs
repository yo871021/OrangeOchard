using Model.ViewModel.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel.CommonSettings
{
    public class CommonSettings
    {
        public Dictionary<string, DBOptions>? Database { get; set; }
    }
}
