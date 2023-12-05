// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> OData page of available SKUs. </summary>
    internal partial class ServiceSkuList
    {
        /// <summary> Initializes a new instance of <see cref="ServiceSkuList"/>. </summary>
        internal ServiceSkuList()
        {
            Value = new ChangeTrackingList<AvailableServiceSku>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceSkuList"/>. </summary>
        /// <param name="value"> List of service SKUs. </param>
        /// <param name="nextLink"> URL to load the next page of service SKUs. </param>
        internal ServiceSkuList(IReadOnlyList<AvailableServiceSku> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of service SKUs. </summary>
        public IReadOnlyList<AvailableServiceSku> Value { get; }
        /// <summary> URL to load the next page of service SKUs. </summary>
        public string NextLink { get; }
    }
}
