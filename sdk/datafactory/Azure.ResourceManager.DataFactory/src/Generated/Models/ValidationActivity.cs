// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> This activity verifies that an external resource exists. </summary>
    public partial class ValidationActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of ValidationActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="dataset"> Validation activity dataset reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="dataset"/> is null. </exception>
        public ValidationActivity(string name, DatasetReference dataset) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (dataset == null)
            {
                throw new ArgumentNullException(nameof(dataset));
            }

            Dataset = dataset;
            ActivityType = "Validation";
        }

        /// <summary> Initializes a new instance of ValidationActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="timeout"> Specifies the timeout for the activity to run. If there is no value specified, it takes the value of TimeSpan.FromDays(7) which is 1 week as default. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sleep"> A delay in seconds between validation attempts. If no value is specified, 10 seconds will be used as the default. Type: integer (or Expression with resultType integer). </param>
        /// <param name="minimumSize"> Can be used if dataset points to a file. The file must be greater than or equal in size to the value specified. Type: integer (or Expression with resultType integer). </param>
        /// <param name="childItems"> Can be used if dataset points to a folder. If set to true, the folder must have at least one file. If set to false, the folder must be empty. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="dataset"> Validation activity dataset reference. </param>
        internal ValidationActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, BinaryData timeout, BinaryData sleep, BinaryData minimumSize, BinaryData childItems, DatasetReference dataset) : base(name, activityType, description, dependsOn, userProperties, additionalProperties)
        {
            Timeout = timeout;
            Sleep = sleep;
            MinimumSize = minimumSize;
            ChildItems = childItems;
            Dataset = dataset;
            ActivityType = activityType ?? "Validation";
        }

        /// <summary> Specifies the timeout for the activity to run. If there is no value specified, it takes the value of TimeSpan.FromDays(7) which is 1 week as default. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public BinaryData Timeout { get; set; }
        /// <summary> A delay in seconds between validation attempts. If no value is specified, 10 seconds will be used as the default. Type: integer (or Expression with resultType integer). </summary>
        public BinaryData Sleep { get; set; }
        /// <summary> Can be used if dataset points to a file. The file must be greater than or equal in size to the value specified. Type: integer (or Expression with resultType integer). </summary>
        public BinaryData MinimumSize { get; set; }
        /// <summary> Can be used if dataset points to a folder. If set to true, the folder must have at least one file. If set to false, the folder must be empty. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData ChildItems { get; set; }
        /// <summary> Validation activity dataset reference. </summary>
        public DatasetReference Dataset { get; set; }
    }
}
