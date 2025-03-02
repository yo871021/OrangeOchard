using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Model
{
    public class DBOptions
    {
        public string? DBType { get; set; }
        public string? DBServer { get; set; }
        public string? DBName { get; set; }
        public string? DBUser { get; set; }
        public string? DBPassword { get; set; }
        public int? ConnectTimeOut { get; set; }
        public int? CommandTimeOut { get; set; }

        /// <summary>
        /// Sqlite Only
        /// </summary>
        public int? DBFilePath { get; set; }
    }
}
