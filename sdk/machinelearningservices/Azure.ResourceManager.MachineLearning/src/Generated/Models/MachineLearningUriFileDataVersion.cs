// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> uri-file data version entity. </summary>
    public partial class MachineLearningUriFileDataVersion : MachineLearningDataVersionProperties
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningUriFileDataVersion"/>. </summary>
        /// <param name="dataUri"> [Required] Uri of the data. Example: https://go.microsoft.com/fwlink/?linkid=2202330. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataUri"/> is null. </exception>
        public MachineLearningUriFileDataVersion(Uri dataUri) : base(dataUri)
        {
            Argument.AssertNotNull(dataUri, nameof(dataUri));

            DataType = MachineLearningDataType.UriFile;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningUriFileDataVersion"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="autoDeleteSetting"> Specifies the lifecycle setting of managed data asset. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). For types where Stage is defined, when Stage is provided it will be used to populate IsAnonymous. </param>
        /// <param name="isArchived"> Is the asset archived? For types where Stage is defined, when Stage is provided it will be used to populate IsArchived. </param>
        /// <param name="dataType"> [Required] Specifies the type of data. </param>
        /// <param name="dataUri"> [Required] Uri of the data. Example: https://go.microsoft.com/fwlink/?linkid=2202330. </param>
        /// <param name="intellectualProperty"> Intellectual Property details. Used if data is an Intellectual Property. </param>
        /// <param name="stage"> Stage in the data lifecycle assigned to this data asset. </param>
        internal MachineLearningUriFileDataVersion(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, AutoDeleteSetting autoDeleteSetting, bool? isAnonymous, bool? isArchived, MachineLearningDataType dataType, Uri dataUri, IntellectualProperty intellectualProperty, string stage) : base(description, properties, tags, autoDeleteSetting, isAnonymous, isArchived, dataType, dataUri, intellectualProperty, stage)
        {
            DataType = dataType;
        }
    }
}
