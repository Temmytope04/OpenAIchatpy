// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> DirectLine Speech channel definition. </summary>
    public partial class DirectLineSpeechChannel : BotChannelProperties
    {
        /// <summary> Initializes a new instance of DirectLineSpeechChannel. </summary>
        public DirectLineSpeechChannel()
        {
            ChannelName = "DirectLineSpeechChannel";
        }

        /// <summary> Initializes a new instance of DirectLineSpeechChannel. </summary>
        /// <param name="channelName"> The channel name. </param>
        /// <param name="etag"> Entity Tag of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="location"> Specifies the location of the resource. </param>
        /// <param name="properties"> The set of properties specific to DirectLine Speech channel resource. </param>
        internal DirectLineSpeechChannel(string channelName, ETag? etag, string provisioningState, AzureLocation? location, DirectLineSpeechChannelProperties properties) : base(channelName, etag, provisioningState, location)
        {
            Properties = properties;
            ChannelName = channelName ?? "DirectLineSpeechChannel";
        }

        /// <summary> The set of properties specific to DirectLine Speech channel resource. </summary>
        public DirectLineSpeechChannelProperties Properties { get; set; }
    }
}
