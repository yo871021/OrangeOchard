using Common.Model.Const;
using DataBase.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common.Model
{
    public class CommonResult : DBResult
    {
        public DataTable? DataTableData { get; set; }
        public Dictionary<string, object> ExternalData { get; set; } = [];

        private void ClearAllData()
        {
            DataTableData = null;
            ExternalData = [];
        }        

        public new CommonResult AssignMessage(string msg, string? code = null)
        {
            base.AssignMessage(msg, code);
            ClearAllData();

            return this;
        }

        public new CommonResult AssignException(Exception ex)
        {
            AssignMessage(ex.Message);

            return this;
        }
    }
}
