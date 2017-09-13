// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Vision.Face.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Vision;
    using Microsoft.CognitiveServices.Vision.Face;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AzureRegion.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AzureRegion
    {
        [EnumMember(Value = "westus")]
        Westus,
        [EnumMember(Value = "westeurope")]
        Westeurope,
        [EnumMember(Value = "southeastasia")]
        Southeastasia,
        [EnumMember(Value = "eastus2")]
        Eastus2,
        [EnumMember(Value = "westcentralus")]
        Westcentralus
    }
    internal static class AzureRegionEnumExtension
    {
        internal static string ToSerializedValue(this AzureRegion? value)  =>
            value == null ? null : ((AzureRegion)value).ToSerializedValue();

        internal static string ToSerializedValue(this AzureRegion value)
        {
            switch( value )
            {
                case AzureRegion.Westus:
                    return "westus";
                case AzureRegion.Westeurope:
                    return "westeurope";
                case AzureRegion.Southeastasia:
                    return "southeastasia";
                case AzureRegion.Eastus2:
                    return "eastus2";
                case AzureRegion.Westcentralus:
                    return "westcentralus";
            }
            return null;
        }

        internal static AzureRegion? ParseAzureRegion(this string value)
        {
            switch( value )
            {
                case "westus":
                    return AzureRegion.Westus;
                case "westeurope":
                    return AzureRegion.Westeurope;
                case "southeastasia":
                    return AzureRegion.Southeastasia;
                case "eastus2":
                    return AzureRegion.Eastus2;
                case "westcentralus":
                    return AzureRegion.Westcentralus;
            }
            return null;
        }
    }
}
