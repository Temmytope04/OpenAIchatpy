// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region Profile
        /// <summary> Gets an object representing a Profile along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Profile" /> object. </returns>
        public static Profile GetProfile(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Profile(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Endpoint
        /// <summary> Gets an object representing a Endpoint along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Endpoint" /> object. </returns>
        public static Endpoint GetEndpoint(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Endpoint(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Origin
        /// <summary> Gets an object representing a Origin along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Origin" /> object. </returns>
        public static Origin GetOrigin(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Origin(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region OriginGroup
        /// <summary> Gets an object representing a OriginGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OriginGroup" /> object. </returns>
        public static OriginGroup GetOriginGroup(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new OriginGroup(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region CustomDomain
        /// <summary> Gets an object representing a CustomDomain along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CustomDomain" /> object. </returns>
        public static CustomDomain GetCustomDomain(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new CustomDomain(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AFDDomain
        /// <summary> Gets an object representing a AFDDomain along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AFDDomain" /> object. </returns>
        public static AFDDomain GetAFDDomain(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AFDDomain(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AFDEndpoint
        /// <summary> Gets an object representing a AFDEndpoint along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AFDEndpoint" /> object. </returns>
        public static AFDEndpoint GetAFDEndpoint(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AFDEndpoint(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AFDOriginGroup
        /// <summary> Gets an object representing a AFDOriginGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AFDOriginGroup" /> object. </returns>
        public static AFDOriginGroup GetAFDOriginGroup(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AFDOriginGroup(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AFDOrigin
        /// <summary> Gets an object representing a AFDOrigin along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AFDOrigin" /> object. </returns>
        public static AFDOrigin GetAFDOrigin(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AFDOrigin(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Route
        /// <summary> Gets an object representing a Route along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Route" /> object. </returns>
        public static Route GetRoute(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Route(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region RuleSet
        /// <summary> Gets an object representing a RuleSet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RuleSet" /> object. </returns>
        public static RuleSet GetRuleSet(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new RuleSet(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Rule
        /// <summary> Gets an object representing a Rule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Rule" /> object. </returns>
        public static Rule GetRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Rule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SecurityPolicy
        /// <summary> Gets an object representing a SecurityPolicy along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityPolicy" /> object. </returns>
        public static SecurityPolicy GetSecurityPolicy(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SecurityPolicy(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Secret
        /// <summary> Gets an object representing a Secret along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Secret" /> object. </returns>
        public static Secret GetSecret(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Secret(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region CdnWebApplicationFirewallPolicy
        /// <summary> Gets an object representing a CdnWebApplicationFirewallPolicy along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CdnWebApplicationFirewallPolicy" /> object. </returns>
        public static CdnWebApplicationFirewallPolicy GetCdnWebApplicationFirewallPolicy(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new CdnWebApplicationFirewallPolicy(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
