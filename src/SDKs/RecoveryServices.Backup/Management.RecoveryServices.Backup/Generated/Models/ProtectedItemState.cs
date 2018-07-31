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
    /// Defines values for ProtectedItemState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(ProtectedItemStateConverter))]
    public struct ProtectedItemState : System.IEquatable<ProtectedItemState>
    {
        private ProtectedItemState(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly ProtectedItemState Invalid = "Invalid";

        public static readonly ProtectedItemState IRPending = "IRPending";

        public static readonly ProtectedItemState Protected = "Protected";

        public static readonly ProtectedItemState ProtectionError = "ProtectionError";

        public static readonly ProtectedItemState ProtectionStopped = "ProtectionStopped";

        public static readonly ProtectedItemState ProtectionPaused = "ProtectionPaused";


        /// <summary>
        /// Underlying value of enum ProtectedItemState
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for ProtectedItemState
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type ProtectedItemState
        /// </summary>
        public bool Equals(ProtectedItemState e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to ProtectedItemState
        /// </summary>
        public static implicit operator ProtectedItemState(string value)
        {
            return new ProtectedItemState(value);
        }

        /// <summary>
        /// Implicit operator to convert ProtectedItemState to string
        /// </summary>
        public static implicit operator string(ProtectedItemState e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum ProtectedItemState
        /// </summary>
        public static bool operator == (ProtectedItemState e1, ProtectedItemState e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum ProtectedItemState
        /// </summary>
        public static bool operator != (ProtectedItemState e1, ProtectedItemState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for ProtectedItemState
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is ProtectedItemState && Equals((ProtectedItemState)obj);
        }

        /// <summary>
        /// Returns for hashCode ProtectedItemState
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
