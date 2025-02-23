using Microsoft.Data.SqlClient;
using Model.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DBInstance
    {
        private readonly SqlConnection? _conection;
        private SqlTransaction? _transaction;
        public SqlConnection? Conection { get { return _conection; } }
        public SqlTransaction? Transaction { get { return _transaction; } }
        public DBInstance(SqlConnection connection) 
        {
            _conection = connection;
            _conection.Open();
        }

        public void Begin()
        {
            _transaction = _conection?.BeginTransaction();
        }

        public void Commit()
        {
            _transaction?.Commit();
        }

        public void Rollback()
        {
            _transaction?.Rollback();
        }

        public void Close()
        {
            _conection?.Close();
        }

        public CommonResult ExecuteSqlCommand(EDBCmdType cmdType, string sql, SqlParameters? parameters = null)
        {
            var result = new CommonResult();
            try
            {
                using (var cmd = new SqlCommand(sql, _conection, _transaction))
                {
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters.Value)
                        {
                            cmd.Parameters.Add(parameter);
                        }
                    }

                    switch (cmdType)
                    {
                        case EDBCmdType.SELECT:
                            using (var reader = cmd.ExecuteReader())
                            {
                                result.DataTableData = new DataTable();
                                result.DataTableData.Load(reader);
                            }
                            break;

                        case EDBCmdType.INSERT:
                        case EDBCmdType.UPDATE:
                        case EDBCmdType.DELETE:
                            result.AffectCount = cmd.ExecuteNonQuery();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                result.AssignException(ex);
            }

            return result;
        }
    }
}
