// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The alias type.
    /// </summary>
    public partial class Alias
    {
        /// <summary>
        /// Initializes a new instance of the Alias class.
        /// </summary>
        public Alias()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Alias class.
        /// </summary>
        /// <param name="name">The alias name.</param>
        /// <param name="paths">The paths for an alias.</param>
        /// <param name="type">The type of the alias. Possible values include:
        /// 'NotSpecified', 'PlainText', 'Mask'</param>
        /// <param name="defaultPath">The default path for an alias.</param>
        /// <param name="defaultPattern">The default pattern for an
        /// alias.</param>
        public Alias(string name = default(string), IList<AliasPath> paths = default(IList<AliasPath>), AliasType? type = default(AliasType?), string defaultPath = default(string), AliasPattern defaultPattern = default(AliasPattern))
        {
            Name = name;
            Paths = paths;
            Type = type;
            DefaultPath = defaultPath;
            DefaultPattern = defaultPattern;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the alias name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the paths for an alias.
        /// </summary>
        [JsonProperty(PropertyName = "paths")]
        public IList<AliasPath> Paths { get; set; }

        /// <summary>
        /// Gets or sets the type of the alias. Possible values include:
        /// 'NotSpecified', 'PlainText', 'Mask'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public AliasType? Type { get; set; }

        /// <summary>
        /// Gets or sets the default path for an alias.
        /// </summary>
        [JsonProperty(PropertyName = "defaultPath")]
        public string DefaultPath { get; set; }

        /// <summary>
        /// Gets or sets the default pattern for an alias.
        /// </summary>
        [JsonProperty(PropertyName = "defaultPattern")]
        public AliasPattern DefaultPattern { get; set; }

    }
}
