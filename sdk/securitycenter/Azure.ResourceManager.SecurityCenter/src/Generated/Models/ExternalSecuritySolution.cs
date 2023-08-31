// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary>
    /// Represents a security solution external to Microsoft Defender for Cloud which sends information to an OMS workspace and whose data is displayed by Microsoft Defender for Cloud.
    /// Please note <see cref="ExternalSecuritySolution"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AadExternalSecuritySolution"/>, <see cref="AtaExternalSecuritySolution"/> and <see cref="CefExternalSecuritySolution"/>.
    /// </summary>
    public partial class ExternalSecuritySolution : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExternalSecuritySolution"/>. </summary>
        public ExternalSecuritySolution()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExternalSecuritySolution"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the external solution. </param>
        /// <param name="location"> Location where the resource is stored. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExternalSecuritySolution(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ExternalSecuritySolutionKind? kind, AzureLocation? location, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            Location = location;
            _rawData = rawData;
        }
        /// <summary> Location where the resource is stored. </summary>
        public AzureLocation? Location { get; }
    }
}
