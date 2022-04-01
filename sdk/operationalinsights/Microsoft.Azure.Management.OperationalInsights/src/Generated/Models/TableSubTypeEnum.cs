// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{

    /// <summary>
    /// Defines values for TableSubTypeEnum.
    /// </summary>
    public static class TableSubTypeEnum
    {
        /// <summary>
        /// The default subtype with which built-in tables are created.
        /// </summary>
        public const string Any = "Any";
        /// <summary>
        /// Indicates a table created through the Data Collector API or with
        /// the custom logs feature of the MMA agent, or any table against
        /// which Custom Fields were created.
        /// </summary>
        public const string Classic = "Classic";
        /// <summary>
        /// A table eligible to have data sent into it via any of the means
        /// supported by Data Collection Rules: the Data Collection Endpoint
        /// API, ingestion-time transformations, or any other mechanism
        /// provided by Data Collection Rules
        /// </summary>
        public const string DataCollectionRuleBased = "DataCollectionRuleBased";
    }
}
