// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> List of Hosts. </summary>
    internal partial class VMwareHostListResult
    {
        /// <summary> Initializes a new instance of <see cref="VMwareHostListResult"/>. </summary>
        /// <param name="value"> Array of Hosts. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VMwareHostListResult(IEnumerable<VMwareHostData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VMwareHostListResult"/>. </summary>
        /// <param name="nextLink"> Url to follow for getting next page of Hosts. </param>
        /// <param name="value"> Array of Hosts. </param>
        internal VMwareHostListResult(string nextLink, IReadOnlyList<VMwareHostData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Url to follow for getting next page of Hosts. </summary>
        public string NextLink { get; }
        /// <summary> Array of Hosts. </summary>
        public IReadOnlyList<VMwareHostData> Value { get; }
    }
}
