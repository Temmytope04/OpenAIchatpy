// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description of the App Service plan scale options. </summary>
    public partial class AppServiceSkuCapacity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceSkuCapacity"/>. </summary>
        public AppServiceSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceSkuCapacity"/>. </summary>
        /// <param name="minimum"> Minimum number of workers for this App Service plan SKU. </param>
        /// <param name="maximum"> Maximum number of workers for this App Service plan SKU. </param>
        /// <param name="elasticMaximum"> Maximum number of Elastic workers for this App Service plan SKU. </param>
        /// <param name="default"> Default number of workers for this App Service plan SKU. </param>
        /// <param name="scaleType"> Available scale configurations for an App Service plan. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceSkuCapacity(int? minimum, int? maximum, int? elasticMaximum, int? @default, string scaleType, Dictionary<string, BinaryData> rawData)
        {
            Minimum = minimum;
            Maximum = maximum;
            ElasticMaximum = elasticMaximum;
            Default = @default;
            ScaleType = scaleType;
            _rawData = rawData;
        }

        /// <summary> Minimum number of workers for this App Service plan SKU. </summary>
        public int? Minimum { get; set; }
        /// <summary> Maximum number of workers for this App Service plan SKU. </summary>
        public int? Maximum { get; set; }
        /// <summary> Maximum number of Elastic workers for this App Service plan SKU. </summary>
        public int? ElasticMaximum { get; set; }
        /// <summary> Default number of workers for this App Service plan SKU. </summary>
        public int? Default { get; set; }
        /// <summary> Available scale configurations for an App Service plan. </summary>
        public string ScaleType { get; set; }
    }
}
