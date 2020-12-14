// <auto-generated>
//
// </auto-generated>

namespace Microsoft.Azure.Management.Scheduler.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobScheduleDay.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobScheduleDay
    {
        [EnumMember(Value = "Monday")]
        Monday,
        [EnumMember(Value = "Tuesday")]
        Tuesday,
        [EnumMember(Value = "Wednesday")]
        Wednesday,
        [EnumMember(Value = "Thursday")]
        Thursday,
        [EnumMember(Value = "Friday")]
        Friday,
        [EnumMember(Value = "Saturday")]
        Saturday,
        [EnumMember(Value = "Sunday")]
        Sunday
    }
    internal static class JobScheduleDayEnumExtension
    {
        internal static string ToSerializedValue(this JobScheduleDay? value)
        {
            return value == null ? null : ((JobScheduleDay)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this JobScheduleDay value)
        {
            switch( value )
            {
                case JobScheduleDay.Monday:
                    return "Monday";
                case JobScheduleDay.Tuesday:
                    return "Tuesday";
                case JobScheduleDay.Wednesday:
                    return "Wednesday";
                case JobScheduleDay.Thursday:
                    return "Thursday";
                case JobScheduleDay.Friday:
                    return "Friday";
                case JobScheduleDay.Saturday:
                    return "Saturday";
                case JobScheduleDay.Sunday:
                    return "Sunday";
            }
            return null;
        }

        internal static JobScheduleDay? ParseJobScheduleDay(this string value)
        {
            switch( value )
            {
                case "Monday":
                    return JobScheduleDay.Monday;
                case "Tuesday":
                    return JobScheduleDay.Tuesday;
                case "Wednesday":
                    return JobScheduleDay.Wednesday;
                case "Thursday":
                    return JobScheduleDay.Thursday;
                case "Friday":
                    return JobScheduleDay.Friday;
                case "Saturday":
                    return JobScheduleDay.Saturday;
                case "Sunday":
                    return JobScheduleDay.Sunday;
            }
            return null;
        }
    }
}
