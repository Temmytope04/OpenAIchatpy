// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes the de-interlacing settings. </summary>
    public partial class DeinterlaceSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeinterlaceSettings"/>. </summary>
        public DeinterlaceSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeinterlaceSettings"/>. </summary>
        /// <param name="parity"> The field parity for de-interlacing, defaults to Auto. </param>
        /// <param name="mode"> The deinterlacing mode. Defaults to AutoPixelAdaptive. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeinterlaceSettings(DeinterlaceParity? parity, DeinterlaceMode? mode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Parity = parity;
            Mode = mode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The field parity for de-interlacing, defaults to Auto. </summary>
        public DeinterlaceParity? Parity { get; set; }
        /// <summary> The deinterlacing mode. Defaults to AutoPixelAdaptive. </summary>
        public DeinterlaceMode? Mode { get; set; }
    }
}
