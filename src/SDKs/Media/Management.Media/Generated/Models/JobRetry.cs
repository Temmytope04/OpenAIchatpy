// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for JobRetry.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(JobRetryConverter))]
    public struct JobRetry : System.IEquatable<JobRetry>
    {
        private JobRetry(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Issue needs to be investigated and then the job resubmitted with
        /// corrections or retried once the underlying issue has been
        /// corrected.
        /// </summary>
        public static readonly JobRetry DoNotRetry = "DoNotRetry";

        /// <summary>
        /// Issue may be resolved after waiting for a period of time and
        /// resubmitting the same Job.
        /// </summary>
        public static readonly JobRetry MayRetry = "MayRetry";


        /// <summary>
        /// Underlying value of enum JobRetry
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for JobRetry
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type JobRetry
        /// </summary>
        public bool Equals(JobRetry e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to JobRetry
        /// </summary>
        public static implicit operator JobRetry(string value)
        {
            return new JobRetry(value);
        }

        /// <summary>
        /// Implicit operator to convert JobRetry to string
        /// </summary>
        public static implicit operator string(JobRetry e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum JobRetry
        /// </summary>
        public static bool operator == (JobRetry e1, JobRetry e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum JobRetry
        /// </summary>
        public static bool operator != (JobRetry e1, JobRetry e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for JobRetry
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is JobRetry && Equals((JobRetry)obj);
        }

        /// <summary>
        /// Returns for hashCode JobRetry
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
