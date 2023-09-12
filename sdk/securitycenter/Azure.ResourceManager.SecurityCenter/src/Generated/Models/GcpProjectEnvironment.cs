// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The GCP project connector environment data. </summary>
    public partial class GcpProjectEnvironment : SecurityConnectorEnvironment
    {
        /// <summary> Initializes a new instance of GcpProjectEnvironment. </summary>
        public GcpProjectEnvironment()
        {
            EnvironmentType = EnvironmentType.GcpProject;
        }

        /// <summary> Initializes a new instance of GcpProjectEnvironment. </summary>
        /// <param name="environmentType"> The type of the environment data. </param>
        /// <param name="organizationalData">
        /// The Gcp project's organizational data
        /// Please note <see cref="GcpOrganizationalInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GcpMemberOrganizationalInfo"/> and <see cref="GcpParentOrganizationalInfo"/>.
        /// </param>
        /// <param name="projectDetails"> The Gcp project's details. </param>
        internal GcpProjectEnvironment(EnvironmentType environmentType, GcpOrganizationalInfo organizationalData, GcpProjectDetails projectDetails) : base(environmentType)
        {
            OrganizationalData = organizationalData;
            ProjectDetails = projectDetails;
            EnvironmentType = environmentType;
        }

        /// <summary>
        /// The Gcp project's organizational data
        /// Please note <see cref="GcpOrganizationalInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GcpMemberOrganizationalInfo"/> and <see cref="GcpParentOrganizationalInfo"/>.
        /// </summary>
        public GcpOrganizationalInfo OrganizationalData { get; set; }
        /// <summary> The Gcp project's details. </summary>
        public GcpProjectDetails ProjectDetails { get; set; }
    }
}
