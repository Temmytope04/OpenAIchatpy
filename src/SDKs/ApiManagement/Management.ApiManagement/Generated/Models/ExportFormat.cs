// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ExportFormat.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExportFormat
    {
        /// <summary>
        /// Export the Api Definition in OpenApi Specification 2.0 format to
        /// the Storage Blob.
        /// </summary>
        [EnumMember(Value = "application/vnd.swagger.link+json")]
        OpenApi2,
        /// <summary>
        /// Export the Api Definition in WSDL Schema to Storage Blob.
        /// </summary>
        [EnumMember(Value = "application/vnd.ms.wsdl.link+xml")]
        Wsdl,
        /// <summary>
        /// Export the Api Definition in WADL Schema to Storage Blob.
        /// </summary>
        [EnumMember(Value = "application/vnd.sun.wadl.link+json")]
        Wadl
    }
    internal static class ExportFormatEnumExtension
    {
        internal static string ToSerializedValue(this ExportFormat? value)  =>
            value == null ? null : ((ExportFormat)value).ToSerializedValue();

        internal static string ToSerializedValue(this ExportFormat value)
        {
            switch( value )
            {
                case ExportFormat.OpenApi2:
                    return "application/vnd.swagger.link+json";
                case ExportFormat.Wsdl:
                    return "application/vnd.ms.wsdl.link+xml";
                case ExportFormat.Wadl:
                    return "application/vnd.sun.wadl.link+json";
            }
            return null;
        }

        internal static ExportFormat? ParseExportFormat(this string value)
        {
            switch( value )
            {
                case "application/vnd.swagger.link+json":
                    return ExportFormat.OpenApi2;
                case "application/vnd.ms.wsdl.link+xml":
                    return ExportFormat.Wsdl;
                case "application/vnd.sun.wadl.link+json":
                    return ExportFormat.Wadl;
            }
            return null;
        }
    }
}
