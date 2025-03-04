using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Common.Model.DBEntity.Base
{
    public class EntityBase
    {
        [JsonIgnore]
        public HashSet<string> PKColumnNames { get; set; } = new HashSet<string>();

        [JsonIgnore]
        public HashSet<string> Dirty { get; set; } = new HashSet<string>();

        [JsonIgnore]
        public int TotalCount { get; set; }

        public IEnumerable<PropertyInfo> GetAllProperties()
        {
            IEnumerable<PropertyInfo> propertyInfo = GetType().GetProperties().ToList();
            var eceptItem = new List<string>() { nameof(PKColumnNames), nameof(Dirty), nameof(TotalCount) };
            propertyInfo = propertyInfo.Where(x => !eceptItem.Contains(x.Name));
            return propertyInfo;
        }

        public IEnumerable<string> GetAllPropertiesName()
        {
            return GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance).Select(x => x.Name);
        }

        public object? GetValue(string propertyName)
        {
            object? result = null;
            PropertyInfo? propertyInfo = GetType().GetProperty(propertyName);
            if (propertyInfo != null)
            {
                result = propertyInfo.GetValue(this, null);
            }
            return result;
        }

        public void SetValue(string propertyName, object value)
        {
            var propertiesMapper = GetAllProperties().ToDictionary(x => x.Name, x => x);
            if (propertiesMapper.TryGetValue(propertyName, out PropertyInfo? propertyinfo))
            {
                var type = Nullable.GetUnderlyingType(propertyinfo.PropertyType) ?? propertyinfo.PropertyType;
                var safeValue = value == null ? null : Convert.ChangeType(value, type);
                propertyinfo.SetValue(this, safeValue);
            }
        }

        public EntityBase SetDirty(params string[] propertiesName)
        {
            var propertiesMapper = GetAllProperties().ToDictionary(x => x.Name, x => x);
            foreach (string propertyName in propertiesName)
            {
                if (propertiesMapper.ContainsKey(propertyName))
                {
                    Dirty.Add(propertyName);
                }
            }
            return this;
        }

        public void SetFullDirty()
        {
            foreach (var propertyName in GetAllProperties())
            {
                Dirty.Add(propertyName.Name);
            }
        }

        public object? GetConstValue(string propertyName)
        {
            object? result = null;
            FieldInfo? fieldInfo = GetType().GetField(propertyName);
            if (fieldInfo != null)
            {
                result = fieldInfo.GetRawConstantValue();
            }
            return result;
        }

        public EntityBase? Copy(EntityBase target, bool isCoverbyTarget = false, params string[] notCopyColumns)
        {
            if (target == null)
            {
                return isCoverbyTarget ? null : this;
            }

            foreach (var sKey in GetAllPropertiesName())
            {
                if (
                    (isCoverbyTarget || !Dirty.Contains(sKey)) &&
                    target.Dirty.Contains(sKey) &&
                    (notCopyColumns == null || notCopyColumns.All(col => col != sKey))
                   )
                {
                    SetValue(sKey, target.GetValue(sKey) ?? DBNull.Value);
                }
            }

            return this;
        }

        public EntityBase Clear()
        {
            IEnumerable<PropertyInfo> propertyInfos = GetAllProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                propertyInfo.SetValue(this, null);
            }
            Dirty.Clear();

            return this;
        }

        public void FillData(Dictionary<string, string> dicData)
        {
            var properties = GetAllProperties().ToDictionary(x => x.Name.ToLower(), x => x);

            foreach (var keypair in dicData)
            {
                var key = keypair.Key.ToLower();
                if (properties.TryGetValue(key, out PropertyInfo? property))
                {
                    if (!string.IsNullOrEmpty(keypair.Value))
                    {
                        Type t = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                        var value = keypair.Value == "=" ? string.Empty : keypair.Value;
                        if (t == typeof(DateTimeOffset))
                        {
                            object safeValue = DateTimeOffset.Parse(value);

                            property.SetValue(this, safeValue, null);
                        }
                        else
                        {
                            object? safeValue = value == null ? null : Convert.ChangeType(value, t);

                            property.SetValue(this, safeValue, null);
                        }
                    }
                }
            }
        }

        public Dictionary<string, object> GetDirtyDictionory(string? emptyValueFormat = null)
        {
            return GetAllProperties()
                .Where(prop => Dirty.Contains(prop.Name))
                .ToDictionary(
                prop => prop.Name, 
                prop =>
                {
                    var value = prop.GetValue(this, null);
                    return value is DateTime dt
                    ? (object)dt.ToString("yyyy-MM-dd HH:mm:ss")
                    : (object)(value?.ToString() ?? emptyValueFormat ?? string.Empty);
                });
        }
    }
}
