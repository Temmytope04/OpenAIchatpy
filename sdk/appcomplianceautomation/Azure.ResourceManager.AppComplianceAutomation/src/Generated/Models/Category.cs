// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> A class represent the compliance category. </summary>
    public partial class Category
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="Category"/>. </summary>
        internal Category()
        {
            ControlFamilies = new ChangeTrackingList<ControlFamily>();
        }

        /// <summary> Initializes a new instance of <see cref="Category"/>. </summary>
        /// <param name="categoryName"> The name of the compliance category. e.g. "Operational Security". </param>
        /// <param name="categoryType"> The category type. </param>
        /// <param name="categoryStatus"> Category status. </param>
        /// <param name="controlFamilies"> List of control families. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal Category(string categoryName, CategoryType? categoryType, CategoryStatus? categoryStatus, IReadOnlyList<ControlFamily> controlFamilies, Dictionary<string, BinaryData> rawData)
        {
            CategoryName = categoryName;
            CategoryType = categoryType;
            CategoryStatus = categoryStatus;
            ControlFamilies = controlFamilies;
            _rawData = rawData;
        }

        /// <summary> The name of the compliance category. e.g. "Operational Security". </summary>
        public string CategoryName { get; }
        /// <summary> The category type. </summary>
        public CategoryType? CategoryType { get; }
        /// <summary> Category status. </summary>
        public CategoryStatus? CategoryStatus { get; }
        /// <summary> List of control families. </summary>
        public IReadOnlyList<ControlFamily> ControlFamilies { get; }
    }
}
