// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.ResourceManager.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ChangeType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChangeType
    {
        /// <summary>
        /// The resource does not exist in the current state but is present in
        /// the desired state. The resource will be created when the deployment
        /// is executed.
        /// </summary>
        [EnumMember(Value = "Create")]
        Create,
        /// <summary>
        /// The resource exists in the current state and is missing from the
        /// desired state. The resource will be deleted when the deployment is
        /// executed.
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete,
        /// <summary>
        /// The resource exists in the current state and is missing from the
        /// desired state. The resource will not be deployed or modified when
        /// the deployment is executed.
        /// </summary>
        [EnumMember(Value = "Ignore")]
        Ignore,
        /// <summary>
        /// The resource exists in the current state and the desired state and
        /// will be redeployed when the deployment is executed. The properties
        /// of the resource may or may not change.
        /// </summary>
        [EnumMember(Value = "Deploy")]
        Deploy,
        /// <summary>
        /// The resource exists in the current state and the desired state and
        /// will be redeployed when the deployment is executed. The properties
        /// of the resource will not change.
        /// </summary>
        [EnumMember(Value = "NoChange")]
        NoChange,
        /// <summary>
        /// The resource exists in the current state and the desired state and
        /// will be redeployed when the deployment is executed. The properties
        /// of the resource will change.
        /// </summary>
        [EnumMember(Value = "Modify")]
        Modify
    }
    internal static class ChangeTypeEnumExtension
    {
        internal static string ToSerializedValue(this ChangeType? value)
        {
            return value == null ? null : ((ChangeType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ChangeType value)
        {
            switch( value )
            {
                case ChangeType.Create:
                    return "Create";
                case ChangeType.Delete:
                    return "Delete";
                case ChangeType.Ignore:
                    return "Ignore";
                case ChangeType.Deploy:
                    return "Deploy";
                case ChangeType.NoChange:
                    return "NoChange";
                case ChangeType.Modify:
                    return "Modify";
            }
            return null;
        }

        internal static ChangeType? ParseChangeType(this string value)
        {
            switch( value )
            {
                case "Create":
                    return ChangeType.Create;
                case "Delete":
                    return ChangeType.Delete;
                case "Ignore":
                    return ChangeType.Ignore;
                case "Deploy":
                    return ChangeType.Deploy;
                case "NoChange":
                    return ChangeType.NoChange;
                case "Modify":
                    return ChangeType.Modify;
            }
            return null;
        }
    }
}
