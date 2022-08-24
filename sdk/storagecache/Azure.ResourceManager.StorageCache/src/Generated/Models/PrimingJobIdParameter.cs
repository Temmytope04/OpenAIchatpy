// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Object containing the priming job ID. </summary>
    public partial class PrimingJobIdParameter
    {
        /// <summary> Initializes a new instance of PrimingJobIdParameter. </summary>
        /// <param name="primingJobId"> The unique identifier of the priming job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="primingJobId"/> is null. </exception>
        public PrimingJobIdParameter(string primingJobId)
        {
            if (primingJobId == null)
            {
                throw new ArgumentNullException(nameof(primingJobId));
            }

            PrimingJobId = primingJobId;
        }

        /// <summary> The unique identifier of the priming job. </summary>
        public string PrimingJobId { get; }
    }
}
