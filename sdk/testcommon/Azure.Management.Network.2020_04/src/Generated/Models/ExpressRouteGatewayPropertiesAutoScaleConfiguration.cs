// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> Configuration for auto scaling. </summary>
    public partial class ExpressRouteGatewayPropertiesAutoScaleConfiguration
    {
        /// <summary> Initializes a new instance of ExpressRouteGatewayPropertiesAutoScaleConfiguration. </summary>
        public ExpressRouteGatewayPropertiesAutoScaleConfiguration()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteGatewayPropertiesAutoScaleConfiguration. </summary>
        /// <param name="bounds"> Minimum and maximum number of scale units to deploy. </param>
        internal ExpressRouteGatewayPropertiesAutoScaleConfiguration(ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds bounds)
        {
            Bounds = bounds;
        }

        /// <summary> Minimum and maximum number of scale units to deploy. </summary>
        public ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds Bounds { get; set; }
    }
}
