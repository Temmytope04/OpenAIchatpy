// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiManagementGroup data model.
    /// Contract details.
    /// </summary>
    public partial class ApiManagementGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ApiManagementGroupData"/>. </summary>
        public ApiManagementGroupData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Group name. </param>
        /// <param name="description"> Group description. Can contain HTML formatting tags. </param>
        /// <param name="isBuiltIn"> true if the group is one of the three system groups (Administrators, Developers, or Guests); otherwise false. </param>
        /// <param name="groupType"> Group type. </param>
        /// <param name="externalId"> For external groups, this property contains the id of the group from the external identity provider, e.g. for Azure Active Directory `aad://&lt;tenant&gt;.onmicrosoft.com/groups/&lt;group object id&gt;`; otherwise the value is null. </param>
        internal ApiManagementGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string description, bool? isBuiltIn, ApiManagementGroupType? groupType, string externalId) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Description = description;
            IsBuiltIn = isBuiltIn;
            GroupType = groupType;
            ExternalId = externalId;
        }

        /// <summary> Group name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Group description. Can contain HTML formatting tags. </summary>
        public string Description { get; set; }
        /// <summary> true if the group is one of the three system groups (Administrators, Developers, or Guests); otherwise false. </summary>
        public bool? IsBuiltIn { get; }
        /// <summary> Group type. </summary>
        public ApiManagementGroupType? GroupType { get; set; }
        /// <summary> For external groups, this property contains the id of the group from the external identity provider, e.g. for Azure Active Directory `aad://&lt;tenant&gt;.onmicrosoft.com/groups/&lt;group object id&gt;`; otherwise the value is null. </summary>
        public string ExternalId { get; set; }
    }
}
