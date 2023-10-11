// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Each KPI must contain a 'type' and 'enabled' key. </summary>
    public partial class ViewKpiProperties
    {
        /// <summary> Initializes a new instance of ViewKpiProperties. </summary>
        public ViewKpiProperties()
        {
        }

        /// <summary> Initializes a new instance of ViewKpiProperties. </summary>
        /// <param name="kpiType"> KPI type (Forecast, Budget). </param>
        /// <param name="id"> ID of resource related to metric (budget). </param>
        /// <param name="isEnabled"> show the KPI in the UI?. </param>
        internal ViewKpiProperties(ViewKpiType? kpiType, ResourceIdentifier id, bool? isEnabled)
        {
            KpiType = kpiType;
            Id = id;
            IsEnabled = isEnabled;
        }

        /// <summary> KPI type (Forecast, Budget). </summary>
        public ViewKpiType? KpiType { get; set; }
        /// <summary> ID of resource related to metric (budget). </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> show the KPI in the UI?. </summary>
        public bool? IsEnabled { get; set; }
    }
}
