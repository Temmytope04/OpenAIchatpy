// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Monitor.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CategoryType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoryType
    {
        [EnumMember(Value = "Metrics")]
        Metrics,
        [EnumMember(Value = "Logs")]
        Logs
    }
    internal static class CategoryTypeEnumExtension
    {
        internal static string ToSerializedValue(this CategoryType? value)
        {
            return value == null ? null : ((CategoryType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this CategoryType value)
        {
            switch( value )
            {
                case CategoryType.Metrics:
                    return "Metrics";
                case CategoryType.Logs:
                    return "Logs";
            }
            return null;
        }

        internal static CategoryType? ParseCategoryType(this string value)
        {
            switch( value )
            {
                case "Metrics":
                    return CategoryType.Metrics;
                case "Logs":
                    return CategoryType.Logs;
            }
            return null;
        }
    }
}
