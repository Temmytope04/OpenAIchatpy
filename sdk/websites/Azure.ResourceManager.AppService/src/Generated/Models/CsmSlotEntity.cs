// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Deployment slot parameters. </summary>
    public partial class CsmSlotEntity
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CsmSlotEntity"/>. </summary>
        /// <param name="targetSlot"> Destination deployment slot during swap operation. </param>
        /// <param name="preserveVnet"> &lt;code&gt;true&lt;/code&gt; to preserve Virtual Network to the slot during swap; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetSlot"/> is null. </exception>
        public CsmSlotEntity(string targetSlot, bool preserveVnet)
        {
            Argument.AssertNotNull(targetSlot, nameof(targetSlot));

            TargetSlot = targetSlot;
            PreserveVnet = preserveVnet;
        }

        /// <summary> Initializes a new instance of <see cref="CsmSlotEntity"/>. </summary>
        /// <param name="targetSlot"> Destination deployment slot during swap operation. </param>
        /// <param name="preserveVnet"> &lt;code&gt;true&lt;/code&gt; to preserve Virtual Network to the slot during swap; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CsmSlotEntity(string targetSlot, bool preserveVnet, Dictionary<string, BinaryData> rawData)
        {
            TargetSlot = targetSlot;
            PreserveVnet = preserveVnet;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CsmSlotEntity"/> for deserialization. </summary>
        internal CsmSlotEntity()
        {
        }

        /// <summary> Destination deployment slot during swap operation. </summary>
        public string TargetSlot { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to preserve Virtual Network to the slot during swap; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool PreserveVnet { get; }
    }
}
