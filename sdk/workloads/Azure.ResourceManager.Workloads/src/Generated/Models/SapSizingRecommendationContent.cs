// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The SAP Sizing Recommendation request. </summary>
    public partial class SapSizingRecommendationContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SapSizingRecommendationContent"/>. </summary>
        /// <param name="appLocation"> The geo-location where the resource is to be created. </param>
        /// <param name="environment"> Defines the environment type - Production/Non Production. </param>
        /// <param name="sapProduct"> Defines the SAP Product type. </param>
        /// <param name="deploymentType"> The deployment type. Eg: SingleServer/ThreeTier. </param>
        /// <param name="saps"> The SAP Application Performance Standard measurement. </param>
        /// <param name="dbMemory"> The database memory configuration. </param>
        /// <param name="databaseType"> The database type. </param>
        public SapSizingRecommendationContent(AzureLocation appLocation, SapEnvironmentType environment, SapProductType sapProduct, SapDeploymentType deploymentType, long saps, long dbMemory, SapDatabaseType databaseType)
        {
            AppLocation = appLocation;
            Environment = environment;
            SapProduct = sapProduct;
            DeploymentType = deploymentType;
            Saps = saps;
            DBMemory = dbMemory;
            DatabaseType = databaseType;
        }

        /// <summary> Initializes a new instance of <see cref="SapSizingRecommendationContent"/>. </summary>
        /// <param name="appLocation"> The geo-location where the resource is to be created. </param>
        /// <param name="environment"> Defines the environment type - Production/Non Production. </param>
        /// <param name="sapProduct"> Defines the SAP Product type. </param>
        /// <param name="deploymentType"> The deployment type. Eg: SingleServer/ThreeTier. </param>
        /// <param name="saps"> The SAP Application Performance Standard measurement. </param>
        /// <param name="dbMemory"> The database memory configuration. </param>
        /// <param name="databaseType"> The database type. </param>
        /// <param name="dbScaleMethod"> The DB scale method. </param>
        /// <param name="highAvailabilityType"> The high availability type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SapSizingRecommendationContent(AzureLocation appLocation, SapEnvironmentType environment, SapProductType sapProduct, SapDeploymentType deploymentType, long saps, long dbMemory, SapDatabaseType databaseType, SapDatabaseScaleMethod? dbScaleMethod, SapHighAvailabilityType? highAvailabilityType, Dictionary<string, BinaryData> rawData)
        {
            AppLocation = appLocation;
            Environment = environment;
            SapProduct = sapProduct;
            DeploymentType = deploymentType;
            Saps = saps;
            DBMemory = dbMemory;
            DatabaseType = databaseType;
            DBScaleMethod = dbScaleMethod;
            HighAvailabilityType = highAvailabilityType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SapSizingRecommendationContent"/> for deserialization. </summary>
        internal SapSizingRecommendationContent()
        {
        }

        /// <summary> The geo-location where the resource is to be created. </summary>
        public AzureLocation AppLocation { get; }
        /// <summary> Defines the environment type - Production/Non Production. </summary>
        public SapEnvironmentType Environment { get; }
        /// <summary> Defines the SAP Product type. </summary>
        public SapProductType SapProduct { get; }
        /// <summary> The deployment type. Eg: SingleServer/ThreeTier. </summary>
        public SapDeploymentType DeploymentType { get; }
        /// <summary> The SAP Application Performance Standard measurement. </summary>
        public long Saps { get; }
        /// <summary> The database memory configuration. </summary>
        public long DBMemory { get; }
        /// <summary> The database type. </summary>
        public SapDatabaseType DatabaseType { get; }
        /// <summary> The DB scale method. </summary>
        public SapDatabaseScaleMethod? DBScaleMethod { get; set; }
        /// <summary> The high availability type. </summary>
        public SapHighAvailabilityType? HighAvailabilityType { get; set; }
    }
}
