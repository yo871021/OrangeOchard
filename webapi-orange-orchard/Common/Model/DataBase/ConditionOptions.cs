using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model.DataBase
{
    public class ConditionOptions
    {
        public bool IsOR { get; set; } = false;
        public bool IsLike { get; set; } = false;
        public string? Alias { get; set; } = null;
    }
}
