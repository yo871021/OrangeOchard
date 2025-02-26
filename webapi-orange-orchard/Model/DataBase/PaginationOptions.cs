using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataBase
{
    /// <summary>
    /// 分頁資料結構
    /// </summary>
    public class PaginationOptions
    {
        public int? PageSize { get; set; } = null;

        public int PageNum { get; set; } = 1;

        public List<SortingCondition> SortColumns = [];

        public class SortingCondition
        {
            public string? SortColumn { get; set; }

            public int SortOrder { get; set; }
        }
    }
}
