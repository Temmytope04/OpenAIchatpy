// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Attestation;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmAttestationModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="AttestationProviderData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="trustModel"> Trust model for the attestation provider. </param>
        /// <param name="status"> Status of attestation service. </param>
        /// <param name="attestUri"> Gets the uri of attestation service. </param>
        /// <param name="publicNetworkAccess"> Controls whether traffic from the public network is allowed to access the Attestation Provider APIs. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections associated with the attestation provider. </param>
        /// <returns> A new <see cref="Attestation.AttestationProviderData"/> instance for mocking. </returns>
        public static AttestationProviderData AttestationProviderData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string trustModel = null, AttestationServiceStatus? status = null, Uri attestUri = null, PublicNetworkAccessType? publicNetworkAccess = null, IEnumerable<AttestationPrivateEndpointConnectionData> privateEndpointConnections = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<AttestationPrivateEndpointConnectionData>();

            return new AttestationProviderData(id, name, resourceType, systemData, tags, location, trustModel, status, attestUri, publicNetworkAccess, privateEndpointConnections?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="AttestationPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpointId"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <returns> A new <see cref="Attestation.AttestationPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static AttestationPrivateEndpointConnectionData AttestationPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier privateEndpointId = null, AttestationPrivateLinkServiceConnectionState connectionState = null, AttestationPrivateEndpointConnectionProvisioningState? provisioningState = null)
        {
            return new AttestationPrivateEndpointConnectionData(id, name, resourceType, systemData, privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, connectionState, provisioningState, default);
        }

        /// <summary> Initializes a new instance of <see cref="AttestationProviderCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The supported Azure location where the attestation provider should be created. </param>
        /// <param name="tags"> The tags that will be assigned to the attestation provider. </param>
        /// <param name="properties"> Properties of the attestation provider. </param>
        /// <returns> A new <see cref="Models.AttestationProviderCreateOrUpdateContent"/> instance for mocking. </returns>
        public static AttestationProviderCreateOrUpdateContent AttestationProviderCreateOrUpdateContent(AzureLocation location = default, IDictionary<string, string> tags = null, AttestationServiceCreationSpecificParams properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new AttestationProviderCreateOrUpdateContent(location, tags, properties, default);
        }

        /// <summary> Initializes a new instance of <see cref="JsonWebKey"/>. </summary>
        /// <param name="alg">
        /// The "alg" (algorithm) parameter identifies the algorithm intended for
        /// use with the key.  The values used should either be registered in the
        /// IANA "JSON Web Signature and Encryption Algorithms" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.
        /// </param>
        /// <param name="crv"> The "crv" (curve) parameter identifies the curve type. </param>
        /// <param name="d"> RSA private exponent or ECC private key. </param>
        /// <param name="dp"> RSA Private Key Parameter. </param>
        /// <param name="dq"> RSA Private Key Parameter. </param>
        /// <param name="e"> RSA public exponent, in Base64. </param>
        /// <param name="k"> Symmetric key. </param>
        /// <param name="kid">
        /// The "kid" (key ID) parameter is used to match a specific key.  This
        /// is used, for instance, to choose among a set of keys within a JWK Set
        /// during key rollover.  The structure of the "kid" value is
        /// unspecified.  When "kid" values are used within a JWK Set, different
        /// keys within the JWK Set SHOULD use distinct "kid" values.  (One
        /// example in which different keys might use the same "kid" value is if
        /// they have different "kty" (key type) values but are considered to be
        /// equivalent alternatives by the application using them.)  The "kid"
        /// value is a case-sensitive string.
        /// </param>
        /// <param name="kty">
        /// The "kty" (key type) parameter identifies the cryptographic algorithm
        /// family used with the key, such as "RSA" or "EC". "kty" values should
        /// either be registered in the IANA "JSON Web Key Types" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.  The "kty" value is a case-sensitive string.
        /// </param>
        /// <param name="n"> RSA modulus, in Base64. </param>
        /// <param name="p"> RSA secret prime. </param>
        /// <param name="q"> RSA secret prime, with p &lt; q. </param>
        /// <param name="qi"> RSA Private Key Parameter. </param>
        /// <param name="use">
        /// Use ("public key use") identifies the intended use of
        /// the public key. The "use" parameter is employed to indicate whether
        /// a public key is used for encrypting data or verifying the signature
        /// on data. Values are commonly "sig" (signature) or "enc" (encryption).
        /// </param>
        /// <param name="x"> X coordinate for the Elliptic Curve point. </param>
        /// <param name="x5C">
        /// The "x5c" (X.509 certificate chain) parameter contains a chain of one
        /// or more PKIX certificates [RFC5280].  The certificate chain is
        /// represented as a JSON array of certificate value strings.  Each
        /// string in the array is a base64-encoded (Section 4 of [RFC4648] --
        /// not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value.
        /// The PKIX certificate containing the key value MUST be the first
        /// certificate.
        /// </param>
        /// <param name="y"> Y coordinate for the Elliptic Curve point. </param>
        /// <returns> A new <see cref="Models.JsonWebKey"/> instance for mocking. </returns>
        public static JsonWebKey JsonWebKey(string alg = null, string crv = null, string d = null, string dp = null, string dq = null, string e = null, string k = null, string kid = null, string kty = null, string n = null, string p = null, string q = null, string qi = null, string use = null, string x = null, IEnumerable<string> x5C = null, string y = null)
        {
            x5C ??= new List<string>();

            return new JsonWebKey(alg, crv, d, dp, dq, e, k, kid, kty, n, p, q, qi, use, x, x5C?.ToList(), y, default);
        }

        /// <summary> Initializes a new instance of <see cref="AttestationPrivateLinkResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource Private link DNS zone name. </param>
        /// <returns> A new <see cref="Models.AttestationPrivateLinkResource"/> instance for mocking. </returns>
        public static AttestationPrivateLinkResource AttestationPrivateLinkResource(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new AttestationPrivateLinkResource(id, name, resourceType, systemData, groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), default);
        }
    }
}
