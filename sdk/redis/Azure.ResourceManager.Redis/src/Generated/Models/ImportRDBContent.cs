// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Parameters for Redis import operation. </summary>
    public partial class ImportRDBContent
    {
        /// <summary> Initializes a new instance of ImportRDBContent. </summary>
        /// <param name="files"> files to import. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="files"/> is null. </exception>
        public ImportRDBContent(IEnumerable<string> files)
        {
            if (files == null)
            {
                throw new ArgumentNullException(nameof(files));
            }

            Files = files.ToList();
        }

        /// <summary> File format. </summary>
        public string Format { get; set; }
        /// <summary> files to import. </summary>
        public IList<string> Files { get; }
    }
}
