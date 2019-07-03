// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity DelimitedText sink.
    /// </summary>
    public partial class DelimitedTextSink : CopySink
    {
        /// <summary>
        /// Initializes a new instance of the DelimitedTextSink class.
        /// </summary>
        public DelimitedTextSink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DelimitedTextSink class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="writeBatchSize">Write batch size. Type: integer (or
        /// Expression with resultType integer), minimum: 0.</param>
        /// <param name="writeBatchTimeout">Write batch timeout. Type: string
        /// (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="sinkRetryCount">Sink retry count. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="sinkRetryWait">Sink retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the sink data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="storeSettings">DelimitedText store settings.</param>
        /// <param name="formatSettings">DelimitedText format settings.</param>
        public DelimitedTextSink(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object writeBatchSize = default(object), object writeBatchTimeout = default(object), object sinkRetryCount = default(object), object sinkRetryWait = default(object), object maxConcurrentConnections = default(object), StoreWriteSettings storeSettings = default(StoreWriteSettings), DelimitedTextWriteSettings formatSettings = default(DelimitedTextWriteSettings))
            : base(additionalProperties, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections)
        {
            StoreSettings = storeSettings;
            FormatSettings = formatSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets delimitedText store settings.
        /// </summary>
        [JsonProperty(PropertyName = "storeSettings")]
        public StoreWriteSettings StoreSettings { get; set; }

        /// <summary>
        /// Gets or sets delimitedText format settings.
        /// </summary>
        [JsonProperty(PropertyName = "formatSettings")]
        public DelimitedTextWriteSettings FormatSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StoreSettings != null)
            {
                StoreSettings.Validate();
            }
            if (FormatSettings != null)
            {
                FormatSettings.Validate();
            }
        }
    }
}
