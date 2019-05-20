// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CostManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// States and configurations of Cost Analysis.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class View : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the View class.
        /// </summary>
        public View()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the View class.
        /// </summary>
        /// <param name="timeframe">The time frame for pulling data for the
        /// report. If custom, then a specific time period must be provided.
        /// Possible values include: 'WeekToDate', 'MonthToDate', 'YearToDate',
        /// 'Custom'</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="eTag">eTag of the resource. To handle concurrent
        /// update scenario, this field will be used to determine whether the
        /// user is updating the latest version or not.</param>
        /// <param name="version">View API version used to create the
        /// view.</param>
        /// <param name="queryVersion">Query API version to use.</param>
        /// <param name="displayName">User input name of the view.
        /// Required.</param>
        /// <param name="scope">Cost Management scope to save the view on. This
        /// includes 'subscriptions/{subscriptionId}' for subscription scope,
        /// 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}'
        /// for resourceGroup scope,
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}'
        /// for Billing Account scope,
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
        /// for Department scope,
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
        /// for EnrollmentAccount scope,
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
        /// for BillingProfile scope,
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}'
        /// for InvoiceSection scope,
        /// 'providers/Microsoft.Management/managementGroups/{managementGroupId}'
        /// for Management Group scope,
        /// '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}'
        /// for ExternalBillingAccount scope, and
        /// '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}'
        /// for ExternalSubscription scope.</param>
        /// <param name="createdOn">Date the user created this view.</param>
        /// <param name="modifiedOn">Date when the user last modified this
        /// view.</param>
        /// <param name="timePeriod">Has time period for pulling data for the
        /// report.</param>
        /// <param name="dataset">Has definition for data in this report
        /// config.</param>
        /// <param name="chart">Chart type of the main view in Cost Analysis.
        /// Required. Possible values include: 'Area', 'Line', 'StackedColumn',
        /// 'GroupedColumn', 'Table'</param>
        /// <param name="accumulated">Show costs accumulated over time.
        /// Possible values include: 'true', 'false'</param>
        /// <param name="metric">Metric to use when displaying costs. Possible
        /// values include: 'ActualCost', 'AmortizedCost', 'AHUB'</param>
        /// <param name="kpis">List of KPIs to show in Cost Analysis
        /// UI.</param>
        /// <param name="pivots">Configuration of 3 sub-views in the Cost
        /// Analysis UI.</param>
        public View(string timeframe, string id = default(string), string name = default(string), string type = default(string), string eTag = default(string), string version = default(string), string queryVersion = default(string), string displayName = default(string), string scope = default(string), System.DateTime? createdOn = default(System.DateTime?), System.DateTime? modifiedOn = default(System.DateTime?), ReportConfigTimePeriod timePeriod = default(ReportConfigTimePeriod), ReportConfigDataset dataset = default(ReportConfigDataset), string chart = default(string), string accumulated = default(string), string metric = default(string), IList<KpiProperties> kpis = default(IList<KpiProperties>), IList<PivotProperties> pivots = default(IList<PivotProperties>))
            : base(id, name, type, eTag)
        {
            Version = version;
            QueryVersion = queryVersion;
            DisplayName = displayName;
            Scope = scope;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            Timeframe = timeframe;
            TimePeriod = timePeriod;
            Dataset = dataset;
            Chart = chart;
            Accumulated = accumulated;
            Metric = metric;
            Kpis = kpis;
            Pivots = pivots;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for View class.
        /// </summary>
        static View()
        {
            ViewType = "Usage";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets view API version used to create the view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets query API version to use.
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryVersion")]
        public string QueryVersion { get; set; }

        /// <summary>
        /// Gets or sets user input name of the view. Required.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets cost Management scope to save the view on. This
        /// includes 'subscriptions/{subscriptionId}' for subscription scope,
        /// 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}'
        /// for resourceGroup scope,
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}'
        /// for Billing Account scope,
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
        /// for Department scope,
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
        /// for EnrollmentAccount scope,
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
        /// for BillingProfile scope,
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}'
        /// for InvoiceSection scope,
        /// 'providers/Microsoft.Management/managementGroups/{managementGroupId}'
        /// for Management Group scope,
        /// '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}'
        /// for ExternalBillingAccount scope, and
        /// '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}'
        /// for ExternalSubscription scope.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets date the user created this view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdOn")]
        public System.DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Gets date when the user last modified this view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.modifiedOn")]
        public System.DateTime? ModifiedOn { get; private set; }

        /// <summary>
        /// Gets or sets the time frame for pulling data for the report. If
        /// custom, then a specific time period must be provided. Possible
        /// values include: 'WeekToDate', 'MonthToDate', 'YearToDate', 'Custom'
        /// </summary>
        [JsonProperty(PropertyName = "properties.query.timeframe")]
        public string Timeframe { get; set; }

        /// <summary>
        /// Gets or sets has time period for pulling data for the report.
        /// </summary>
        [JsonProperty(PropertyName = "properties.query.timePeriod")]
        public ReportConfigTimePeriod TimePeriod { get; set; }

        /// <summary>
        /// Gets or sets has definition for data in this report config.
        /// </summary>
        [JsonProperty(PropertyName = "properties.query.dataset")]
        public ReportConfigDataset Dataset { get; set; }

        /// <summary>
        /// Gets or sets chart type of the main view in Cost Analysis.
        /// Required. Possible values include: 'Area', 'Line', 'StackedColumn',
        /// 'GroupedColumn', 'Table'
        /// </summary>
        [JsonProperty(PropertyName = "properties.chart")]
        public string Chart { get; set; }

        /// <summary>
        /// Gets or sets show costs accumulated over time. Possible values
        /// include: 'true', 'false'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accumulated")]
        public string Accumulated { get; set; }

        /// <summary>
        /// Gets or sets metric to use when displaying costs. Possible values
        /// include: 'ActualCost', 'AmortizedCost', 'AHUB'
        /// </summary>
        [JsonProperty(PropertyName = "properties.metric")]
        public string Metric { get; set; }

        /// <summary>
        /// Gets or sets list of KPIs to show in Cost Analysis UI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.kpis")]
        public IList<KpiProperties> Kpis { get; set; }

        /// <summary>
        /// Gets or sets configuration of 3 sub-views in the Cost Analysis UI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pivots")]
        public IList<PivotProperties> Pivots { get; set; }

        /// <summary>
        /// The type of the report. Usage represents actual usage, forecast
        /// represents forecasted data and UsageAndForecast represents both
        /// usage and forecasted data. Actual usage and forecasted data can be
        /// differentiated based on dates.
        /// </summary>
        [JsonProperty(PropertyName = "properties.query.type")]
        public static string ViewType { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Timeframe == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Timeframe");
            }
            if (TimePeriod != null)
            {
                TimePeriod.Validate();
            }
            if (Dataset != null)
            {
                Dataset.Validate();
            }
        }
    }
}
