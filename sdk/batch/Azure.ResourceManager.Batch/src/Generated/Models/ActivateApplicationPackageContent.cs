// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Parameters for an activating an application package. </summary>
    public partial class ActivateApplicationPackageContent
    {
        /// <summary> Initializes a new instance of ActivateApplicationPackageContent. </summary>
        /// <param name="format"> The format of the application package binary file. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="format"/> is null. </exception>
        public ActivateApplicationPackageContent(string format)
        {
            if (format == null)
            {
                throw new ArgumentNullException(nameof(format));
            }

            Format = format;
        }

        /// <summary> The format of the application package binary file. </summary>
        public string Format { get; }
    }
}
