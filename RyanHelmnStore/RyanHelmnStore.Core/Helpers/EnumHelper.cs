using System;
using System.ComponentModel.DataAnnotations;
using Umbraco.Core;

namespace RyanHelmnStore.Core.Helpers
{
    public static class EnumHelper<T>
    {
        public static T GetValueFromName(string name)
        {
            var type = typeof(T);
            if (!type.IsEnum)
            {
                return default;
            }

            foreach (var field in type.GetFields())
            {
                if (Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) is DisplayAttribute attribute)
                {
                    if (attribute.Name.InvariantEquals(name))
                    {
                        return (T) field.GetValue(null);
                    }
                }
                else
                {
                    if (field.Name.InvariantEquals(name))
                    {
                        return (T) field.GetValue(null);
                    }
                }
            }

            return default;
        }
    }
}