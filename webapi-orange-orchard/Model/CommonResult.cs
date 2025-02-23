using Model.Const;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CommonResult
    {
        public string? Message { get; set; } = ConstDefine.OK;
        public string? Code { get; set; }
        public bool IsSuccess { get => Message == ConstDefine.OK; }
        public bool IsFail { get => !IsSuccess; }
        public int AffectCount { get; set; } = -1;
        public IEnumerable<object>? ListData { get; set; }
        public DataTable? DataTableData { get; set; }
        public Dictionary<string, object> ExtenalData { get; set; } = new Dictionary<string, object>();

        private void ClearData()
        {
            ListData = null;
            DataTableData = null;
            ExtenalData = new Dictionary<string, object>();
        }

        public CommonResult AssignMessage(string msg, string? code = null)
        {
            Message = msg;
            Code = code;

            ClearData();

            return this;
        }

        public CommonResult AssignException(Exception exception)
        {
            AssignMessage(exception.Message);

            return this;
        }
    }
}
