using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataBase
{
    public class QueryOptions : ConditionOptions
    {
        public List<string> SelectedColumn { get; set; } = [];
        public PaginationOptions Pagination { get; set; } = new();
        public EDBLock_Type DBLock_Type { get; set; } = EDBLock_Type.EMPTY;
    }
}
