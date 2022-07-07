// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Static Site Reset Properties ARM resource. </summary>
    public partial class StaticSiteResetPropertiesARMResource : ResourceData
    {
        /// <summary> Initializes a new instance of StaticSiteResetPropertiesARMResource. </summary>
        public StaticSiteResetPropertiesARMResource()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteResetPropertiesARMResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="repositoryToken"> The token which proves admin privileges to the repository. </param>
        /// <param name="shouldUpdateRepository"> Determines whether the repository should be updated with the new properties. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal StaticSiteResetPropertiesARMResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string repositoryToken, bool? shouldUpdateRepository, string kind) : base(id, name, resourceType, systemData)
        {
            RepositoryToken = repositoryToken;
            ShouldUpdateRepository = shouldUpdateRepository;
            Kind = kind;
        }

        /// <summary> The token which proves admin privileges to the repository. </summary>
        public string RepositoryToken { get; set; }
        /// <summary> Determines whether the repository should be updated with the new properties. </summary>
        public bool? ShouldUpdateRepository { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
