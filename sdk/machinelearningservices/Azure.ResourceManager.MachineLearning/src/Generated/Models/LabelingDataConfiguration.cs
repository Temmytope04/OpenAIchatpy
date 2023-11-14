// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Labeling data configuration definition. </summary>
    public partial class LabelingDataConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LabelingDataConfiguration"/>. </summary>
        public LabelingDataConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LabelingDataConfiguration"/>. </summary>
        /// <param name="dataId"> Resource Id of the data asset to perform labeling. </param>
        /// <param name="incrementalDataRefresh"> Indicates whether to enable incremental data refresh. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LabelingDataConfiguration(string dataId, IncrementalDataRefresh? incrementalDataRefresh, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DataId = dataId;
            IncrementalDataRefresh = incrementalDataRefresh;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource Id of the data asset to perform labeling. </summary>
        public string DataId { get; set; }
        /// <summary> Indicates whether to enable incremental data refresh. </summary>
        public IncrementalDataRefresh? IncrementalDataRefresh { get; set; }
    }
}
