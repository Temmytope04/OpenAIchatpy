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
    /// Defines values for StreamingLocatorContentKeyType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(StreamingLocatorContentKeyTypeConverter))]
    public struct StreamingLocatorContentKeyType : System.IEquatable<StreamingLocatorContentKeyType>
    {
        private StreamingLocatorContentKeyType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Common Encryption using CENC
        /// </summary>
        public static readonly StreamingLocatorContentKeyType CommonEncryptionCenc = "CommonEncryptionCenc";

        /// <summary>
        /// Common Encryption using CBCS
        /// </summary>
        public static readonly StreamingLocatorContentKeyType CommonEncryptionCbcs = "CommonEncryptionCbcs";

        /// <summary>
        /// Envelope Encryption
        /// </summary>
        public static readonly StreamingLocatorContentKeyType EnvelopeEncryption = "EnvelopeEncryption";


        /// <summary>
        /// Underlying value of enum StreamingLocatorContentKeyType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for StreamingLocatorContentKeyType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type StreamingLocatorContentKeyType
        /// </summary>
        public bool Equals(StreamingLocatorContentKeyType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to
        /// StreamingLocatorContentKeyType
        /// </summary>
        public static implicit operator StreamingLocatorContentKeyType(string value)
        {
            return new StreamingLocatorContentKeyType(value);
        }

        /// <summary>
        /// Implicit operator to convert StreamingLocatorContentKeyType to
        /// string
        /// </summary>
        public static implicit operator string(StreamingLocatorContentKeyType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum StreamingLocatorContentKeyType
        /// </summary>
        public static bool operator == (StreamingLocatorContentKeyType e1, StreamingLocatorContentKeyType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum StreamingLocatorContentKeyType
        /// </summary>
        public static bool operator != (StreamingLocatorContentKeyType e1, StreamingLocatorContentKeyType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for StreamingLocatorContentKeyType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is StreamingLocatorContentKeyType && Equals((StreamingLocatorContentKeyType)obj);
        }

        /// <summary>
        /// Returns for hashCode StreamingLocatorContentKeyType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
