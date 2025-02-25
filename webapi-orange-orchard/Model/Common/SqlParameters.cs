using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public class SqlParameters
    {
        public Dictionary<string, string> Value => _parameters;
        private readonly Dictionary<string, string> _parameters = new Dictionary<string, string>();

        public void Add(string value)
        {
            _parameters.Add(string.Format("@WD_{0:0000}", _parameters.Count), value);
        }
    }
}
