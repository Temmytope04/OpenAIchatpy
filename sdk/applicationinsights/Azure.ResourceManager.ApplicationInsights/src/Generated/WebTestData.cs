// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    /// <summary>
    /// A class representing the WebTest data model.
    /// An Application Insights WebTest definition.
    /// </summary>
    public partial class WebTestData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WebTestData"/>. </summary>
        /// <param name="location"> The location. </param>
        public WebTestData(AzureLocation location) : base(location)
        {
            Locations = new ChangeTrackingList<WebTestGeolocation>();
        }

        /// <summary> Initializes a new instance of <see cref="WebTestData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> The kind of WebTest that this web test watches. Choices are ping, multistep and standard. </param>
        /// <param name="syntheticMonitorId"> Unique ID of this WebTest. This is typically the same value as the Name field. </param>
        /// <param name="webTestName"> User defined name if this WebTest. </param>
        /// <param name="description"> User defined description for this WebTest. </param>
        /// <param name="isEnabled"> Is the test actively being monitored. </param>
        /// <param name="frequencyInSeconds"> Interval in seconds between test runs for this WebTest. Default value is 300. </param>
        /// <param name="timeoutInSeconds"> Seconds until this WebTest will timeout and fail. Default value is 30. </param>
        /// <param name="webTestKind"> The kind of web test this is, valid choices are ping, multistep and standard. </param>
        /// <param name="isRetryEnabled"> Allow for retries should this WebTest fail. </param>
        /// <param name="locations"> A list of where to physically run the tests from to give global coverage for accessibility of your application. </param>
        /// <param name="configuration"> An XML configuration specification for a WebTest. </param>
        /// <param name="provisioningState"> Current state of this component, whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed. </param>
        /// <param name="request"> The collection of request properties. </param>
        /// <param name="validationRules"> The collection of validation rule properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebTestData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, WebTestKind? kind, string syntheticMonitorId, string webTestName, string description, bool? isEnabled, int? frequencyInSeconds, int? timeoutInSeconds, WebTestKind? webTestKind, bool? isRetryEnabled, IList<WebTestGeolocation> locations, WebTestPropertiesConfiguration configuration, string provisioningState, WebTestPropertiesRequest request, WebTestPropertiesValidationRules validationRules, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Kind = kind;
            SyntheticMonitorId = syntheticMonitorId;
            WebTestName = webTestName;
            Description = description;
            IsEnabled = isEnabled;
            FrequencyInSeconds = frequencyInSeconds;
            TimeoutInSeconds = timeoutInSeconds;
            WebTestKind = webTestKind;
            IsRetryEnabled = isRetryEnabled;
            Locations = locations;
            Configuration = configuration;
            ProvisioningState = provisioningState;
            Request = request;
            ValidationRules = validationRules;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="WebTestData"/> for deserialization. </summary>
        internal WebTestData()
        {
        }

        /// <summary> The kind of WebTest that this web test watches. Choices are ping, multistep and standard. </summary>
        public WebTestKind? Kind { get; set; }
        /// <summary> Unique ID of this WebTest. This is typically the same value as the Name field. </summary>
        public string SyntheticMonitorId { get; set; }
        /// <summary> User defined name if this WebTest. </summary>
        public string WebTestName { get; set; }
        /// <summary> User defined description for this WebTest. </summary>
        public string Description { get; set; }
        /// <summary> Is the test actively being monitored. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Interval in seconds between test runs for this WebTest. Default value is 300. </summary>
        public int? FrequencyInSeconds { get; set; }
        /// <summary> Seconds until this WebTest will timeout and fail. Default value is 30. </summary>
        public int? TimeoutInSeconds { get; set; }
        /// <summary> The kind of web test this is, valid choices are ping, multistep and standard. </summary>
        public WebTestKind? WebTestKind { get; set; }
        /// <summary> Allow for retries should this WebTest fail. </summary>
        public bool? IsRetryEnabled { get; set; }
        /// <summary> A list of where to physically run the tests from to give global coverage for accessibility of your application. </summary>
        public IList<WebTestGeolocation> Locations { get; }
        /// <summary> An XML configuration specification for a WebTest. </summary>
        internal WebTestPropertiesConfiguration Configuration { get; set; }
        /// <summary> The XML specification of a WebTest to run against an application. </summary>
        public string WebTest
        {
            get => Configuration is null ? default : Configuration.WebTest;
            set
            {
                if (Configuration is null)
                    Configuration = new WebTestPropertiesConfiguration();
                Configuration.WebTest = value;
            }
        }

        /// <summary> Current state of this component, whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed. </summary>
        public string ProvisioningState { get; }
        /// <summary> The collection of request properties. </summary>
        public WebTestPropertiesRequest Request { get; set; }
        /// <summary> The collection of validation rule properties. </summary>
        public WebTestPropertiesValidationRules ValidationRules { get; set; }
    }
}
