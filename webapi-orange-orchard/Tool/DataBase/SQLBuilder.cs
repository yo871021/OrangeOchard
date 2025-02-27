using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Model.DataBase;
using Model.Enums;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tool.DataBase
{
    public static class SQLBuilder
    {
        public static Query GenSelectCmd(EntityBase condition, QueryOptions? options) 
        {
            options ??= new QueryOptions();

            var query = new Query()
                .BuildLockCategory(condition.GetType().Name, options?.DBLock_Type ?? EDBLock_Type.EMPTY)
                .BuildWhereString(condition.GetDirtyDictionory(), options)
                .BuildPaginationSql(options?.Pagination);

            return query;
        }

        public static Query GenInsertCmd(EntityBase condition) 
        {
            return new Query(condition.GetType().Name)
                .AsInsert(condition);
        }

        public static Query GenUpdateCmd(EntityBase updatedata, EntityBase condition) 
        {
            return new Query(condition.GetType().Name)
                .BuildWhereString(condition.GetDirtyDictionory())
                .AsUpdate(updatedata.GetDirtyDictionory());
        }

        public static Query GenDeleteCmd(EntityBase condition)
        {
            return new Query(condition.GetType().Name)
                .BuildWhereString(condition.GetDirtyDictionory())
                .AsDelete();
        }

        public static Query BuildLockCategory(this Query query, string tableName, EDBLock_Type lockCategory)
        {
            switch (lockCategory)
            {
                case EDBLock_Type.EMPTY:
                    break;
                case EDBLock_Type.NOLOCK:
                    tableName += " With (NOLOCK)";
                    break;
                case EDBLock_Type.UPDLOCK:
                    tableName += " With (UPDLOCK)";
                    break;
            }            

            return query.FromRaw($"{tableName}");
        }

        public static Query BuildPaginationSql(this Query query, PaginationOptions? options)
        {
            if (options != null)
            {
                foreach (var column in options.SortColumns)
                {
                    if (column.SortOrder == -1)
                    {
                        query.OrderByDesc(column.SortColumn);
                    }
                    else
                    {
                        query.OrderBy(column.SortColumn);
                    }
                }
                if (int.TryParse(options.PageSize?.ToString(), out var pageSize))
                {
                    query.Offset(options.PageNum).Limit(pageSize);
                } 
            }

            return query;
        }

        public static Query BuildWhereString(this Query query, IEnumerable<KeyValuePair<string, string>> condition, ConditionOptions? options = null) 
        {
            options ??= new ConditionOptions();
            var operatorList = new[] { ">=", "<=", ">", "<", "!=", "<>", "=" };

            foreach (var (key, value) in condition.Select(c => (c.Key.Trim(), c.Value.Trim())))
            {
                if (string.IsNullOrEmpty(value))
                {
                    continue;
                }

                var column = string.IsNullOrEmpty(options?.Alias) ? key : $"{options.Alias}.{key}";

                if (value.Contains('|') || value.Contains('&'))
                {
                    var separator = value.Contains('|') ? '|' : '&';
                    var subConditions = value
                        .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                        .Select(v => new KeyValuePair<string, string>(key, v));
                    var condOptions = new ConditionOptions() { IsOR = separator == '|', IsLike = options.IsLike, Alias = options.Alias };

                    var subquery = (Query q) => q.BuildWhereString(subConditions, condOptions);

                    query = options.IsOR ? query.Where(subquery) : query.OrWhere(subquery);
                }
                else if (value == "=")
                {
                    var subquery = (Query q) => q.Where(column, value, string.Empty).OrWhereNull(column);

                    query = options.IsOR ? query.Where(subquery) : query.OrWhere(subquery);
                }
                else if (value == "!=")
                {
                    var subquery = (Query q) => q.Where(column, value, string.Empty).WhereNotNull(column);

                    query = options.IsOR ? query.Where(subquery) : query.OrWhere(subquery);
                }
                else if (operatorList.Any(x => value.StartsWith(x)))
                {
                    var op = value[..(operatorList.Any(x => x.Length >= 2 && value.StartsWith(x)) ? 2 : 1)];

                    query = options.IsOR ? query.Where(column, op, value[op.Length..]) : query.OrWhere(column, op, value[op.Length..]);
                }
                else if (value.Contains(".."))
                {
                    var parts = value.Split("..", StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 2)
                    {
                        query = query.WhereBetween(column, parts[0], parts[1]);
                    }
                }
                else if (value.Contains('*'))
                {
                    query = value.StartsWith('!') ? query.WhereNotLike(column, value.Trim('!').Replace("*", "%")) : query.WhereLike(column, value.Trim('!').Replace("*", "%"));
                }
                else
                {
                    query = options.IsLike ? query.WhereLike(column, value) : query.Where(column, value);
                }

            }
            return query;
        }
    }
}
