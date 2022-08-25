// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The UnknownStreamAnalyticsDataSerialization. </summary>
    internal partial class UnknownStreamAnalyticsDataSerialization : StreamAnalyticsDataSerialization
    {
        /// <summary> Initializes a new instance of UnknownStreamAnalyticsDataSerialization. </summary>
        /// <param name="eventSerializationType"> Indicates the type of serialization that the input or output uses. Required on PUT (CreateOrReplace) requests. </param>
        internal UnknownStreamAnalyticsDataSerialization(EventSerializationType eventSerializationType) : base(eventSerializationType)
        {
            EventSerializationType = eventSerializationType;
        }
    }
}
