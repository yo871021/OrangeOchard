using DataBase.Tool;
using System.Data;

namespace DataBase.Model
{
    public class CommonResult
    {
        private string? _message;
        private string? _code;
        public string? Message { get => _message; }
        public string? Code { get => _code;  }
        public bool IsSuccess { get => string.IsNullOrEmpty(_message); }
        public bool IsFail { get => !IsSuccess; }
        public int AffectCount { get; set; } = -1;
        public IEnumerable<object>? ListData { get; set; }
        public DataTable? DataTableData { get; set; }
        public Dictionary<string, object> ExternalData { get; set; } = [];

        private void ClearData()
        {
            AffectCount = -1;
            ListData = null;
            DataTableData = null;
            ExternalData = [];
        }

        public CommonResult AssignMessage(string msg, string? code = null)
        {
            _message = msg.WriteErroMsgLog();
            _code = code;

            ClearData();

            return this;
        }

        public CommonResult AssignException(Exception ex)
        {
            AssignMessage(ex.WriteExceptionLog().Message);

            return this;
        }
    }
}
