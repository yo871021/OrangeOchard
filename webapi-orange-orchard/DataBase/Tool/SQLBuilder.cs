using Database.Model.Enums;
using DataBase.Model;
using SqlKata;
using SqlKata.Compilers;

namespace DataBase.Tool
{
    public static class SqlBuilder
    {        
        public static Query GenSelectCmd(string tableName, Dictionary<string, object> condition, QueryOptions? options)
        {
            options ??= new QueryOptions();

            var query = new Query()
                .BuildLockCategory(tableName, options?.DBLock_Type ?? EDBLock_Type.EMPTY)
                .BuildWhereString(condition, options)
                .BuildPaginationSql(options?.Pagination);

            return query;
        }

        public static Query GenInsertCmd(string tableName, Dictionary<string, object> condition)
        {
            return new Query(tableName)
                .AsInsert(condition);
        }

        public static Query GenUpdateCmd(string tableName, Dictionary<string, object> updatedata, Dictionary<string, object> condition)
        {
            return new Query(tableName)
                .BuildWhereString(condition)
                .AsUpdate(updatedata);
        }

        public static Query GenDeleteCmd(string tableName, Dictionary<string, object> condition)
        {
            return new Query(tableName)
                .BuildWhereString(condition)
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

        public static Query BuildWhereString(this Query query, IEnumerable<KeyValuePair<string, object>> condition, ConditionOptions? options = null)
        {
            var operatorList = new[] { ">=", "<=", ">", "<", "!=", "<>", "=" };
            var isAND = !options?.IsOR ?? true;

            foreach (var (key, value) in condition.Select(c => (c.Key.Trim(), c.Value?.ToString()?.Trim())))
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
                        .Select(v => new KeyValuePair<string, object>(key, v));
                    var condOptions = new ConditionOptions() { IsOR = separator == '|', IsLike = options?.IsLike ?? false, Alias = options?.Alias };

                    Query subquery(Query q) => q.BuildWhereString(subConditions, condOptions);

                    query = isAND ? query.Where(subquery) : query.OrWhere(subquery);
                }
                else if (value == "=")
                {
                    Query subquery(Query q) => q.Where(column, value, string.Empty).OrWhereNull(column);

                    query = isAND ? query.Where(subquery) : query.OrWhere(subquery);
                }
                else if (value == "!=")
                {
                    Query subquery(Query q) => q.Where(column, value, string.Empty).WhereNotNull(column);

                    query = isAND ? query.Where(subquery) : query.OrWhere(subquery);
                }
                else if (operatorList.Any(x => value.StartsWith(x)))
                {
                    var op = value[..(operatorList.Any(x => x.Length >= 2 && value.StartsWith(x)) ? 2 : 1)];

                    query = isAND ? query.Where(column, op, value[op.Length..]) : query.OrWhere(column, op, value[op.Length..]);
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
                    if (options?.IsLike ?? false)
                    {
                        query = isAND ? query.WhereLike(column, value) : query.OrWhereLike(column, value);
                    }
                    else
                    {
                        query = isAND ? query.Where(column, value) : query.OrWhere(column, value);
                    }
                }

            }
            return query;
        }
    }
}
