// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for JobOperationType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(JobOperationTypeConverter))]
    public struct JobOperationType : System.IEquatable<JobOperationType>
    {
        private JobOperationType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly JobOperationType Invalid = "Invalid";

        public static readonly JobOperationType Register = "Register";

        public static readonly JobOperationType UnRegister = "UnRegister";

        public static readonly JobOperationType ConfigureBackup = "ConfigureBackup";

        public static readonly JobOperationType Backup = "Backup";

        public static readonly JobOperationType Restore = "Restore";

        public static readonly JobOperationType DisableBackup = "DisableBackup";

        public static readonly JobOperationType DeleteBackupData = "DeleteBackupData";


        /// <summary>
        /// Underlying value of enum JobOperationType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for JobOperationType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type JobOperationType
        /// </summary>
        public bool Equals(JobOperationType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to JobOperationType
        /// </summary>
        public static implicit operator JobOperationType(string value)
        {
            return new JobOperationType(value);
        }

        /// <summary>
        /// Implicit operator to convert JobOperationType to string
        /// </summary>
        public static implicit operator string(JobOperationType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum JobOperationType
        /// </summary>
        public static bool operator == (JobOperationType e1, JobOperationType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum JobOperationType
        /// </summary>
        public static bool operator != (JobOperationType e1, JobOperationType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for JobOperationType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is JobOperationType && Equals((JobOperationType)obj);
        }

        /// <summary>
        /// Returns for hashCode JobOperationType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
