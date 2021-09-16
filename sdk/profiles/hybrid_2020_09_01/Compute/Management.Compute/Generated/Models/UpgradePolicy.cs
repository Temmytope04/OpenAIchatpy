// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes an upgrade policy - automatic, manual, or rolling.
    /// </summary>
    public partial class UpgradePolicy
    {
        /// <summary>
        /// Initializes a new instance of the UpgradePolicy class.
        /// </summary>
        public UpgradePolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpgradePolicy class.
        /// </summary>
        /// <param name="mode">Specifies the mode of an upgrade to virtual
        /// machines in the scale set.&lt;br /&gt;&lt;br /&gt; Possible values
        /// are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the
        /// application of updates to virtual machines in the scale set. You do
        /// this by using the manualUpgrade action.&lt;br /&gt;&lt;br /&gt;
        /// **Automatic** - All virtual machines in the scale set are
        /// automatically updated at the same time. Possible values include:
        /// 'Automatic', 'Manual', 'Rolling'</param>
        /// <param name="rollingUpgradePolicy">The configuration parameters
        /// used while performing a rolling upgrade.</param>
        /// <param name="automaticOSUpgradePolicy">Configuration parameters
        /// used for performing automatic OS Upgrade.</param>
        public UpgradePolicy(UpgradeMode? mode = default(UpgradeMode?), RollingUpgradePolicy rollingUpgradePolicy = default(RollingUpgradePolicy), AutomaticOSUpgradePolicy automaticOSUpgradePolicy = default(AutomaticOSUpgradePolicy))
        {
            Mode = mode;
            RollingUpgradePolicy = rollingUpgradePolicy;
            AutomaticOSUpgradePolicy = automaticOSUpgradePolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the mode of an upgrade to virtual machines
        /// in the scale set.&amp;lt;br /&amp;gt;&amp;lt;br /&amp;gt; Possible
        /// values are:&amp;lt;br /&amp;gt;&amp;lt;br /&amp;gt; **Manual** -
        /// You  control the application of updates to virtual machines in the
        /// scale set. You do this by using the manualUpgrade action.&amp;lt;br
        /// /&amp;gt;&amp;lt;br /&amp;gt; **Automatic** - All virtual machines
        /// in the scale set are  automatically updated at the same time.
        /// Possible values include: 'Automatic', 'Manual', 'Rolling'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public UpgradeMode? Mode { get; set; }

        /// <summary>
        /// Gets or sets the configuration parameters used while performing a
        /// rolling upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "rollingUpgradePolicy")]
        public RollingUpgradePolicy RollingUpgradePolicy { get; set; }

        /// <summary>
        /// Gets or sets configuration parameters used for performing automatic
        /// OS Upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "automaticOSUpgradePolicy")]
        public AutomaticOSUpgradePolicy AutomaticOSUpgradePolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RollingUpgradePolicy != null)
            {
                RollingUpgradePolicy.Validate();
            }
        }
    }
}
