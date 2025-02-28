using Common.Model.Enums;

namespace Common.Model.DataBase
{
    public class QueryOptions : ConditionOptions
    {
        public List<string> SelectedColumn { get; set; } = [];
        public PaginationOptions Pagination { get; set; } = new();
        public EDBLock_Type DBLock_Type { get; set; } = EDBLock_Type.EMPTY;
    }
}
