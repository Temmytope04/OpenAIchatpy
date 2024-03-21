// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableCdnResourceGroupResource : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private CdnManagementRestOperations _defaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableCdnResourceGroupResource"/> class for mocking. </summary>
        protected MockableCdnResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableCdnResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableCdnResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Cdn", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CdnManagementRestOperations DefaultRestClient => _defaultRestClient ??= new CdnManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ProfileResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ProfileResources and their operations over a ProfileResource. </returns>
        public virtual ProfileCollection GetProfiles()
        {
            return GetCachedClient(client => new ProfileCollection(client, Id));
        }

        /// <summary>
        /// Gets an Azure Front Door Standard or Azure Front Door Premium or CDN profile with the specified profile name under the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium or CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ProfileResource>> GetProfileAsync(string profileName, CancellationToken cancellationToken = default)
        {
            return await GetProfiles().GetAsync(profileName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an Azure Front Door Standard or Azure Front Door Premium or CDN profile with the specified profile name under the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium or CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ProfileResource> GetProfile(string profileName, CancellationToken cancellationToken = default)
        {
            return GetProfiles().Get(profileName, cancellationToken);
        }

        /// <summary> Gets a collection of CdnWebApplicationFirewallPolicyResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of CdnWebApplicationFirewallPolicyResources and their operations over a CdnWebApplicationFirewallPolicyResource. </returns>
        public virtual CdnWebApplicationFirewallPolicyCollection GetCdnWebApplicationFirewallPolicies()
        {
            return GetCachedClient(client => new CdnWebApplicationFirewallPolicyCollection(client, Id));
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CdnWebApplicationFirewallPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The name of the CdnWebApplicationFirewallPolicy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CdnWebApplicationFirewallPolicyResource>> GetCdnWebApplicationFirewallPolicyAsync(string policyName, CancellationToken cancellationToken = default)
        {
            return await GetCdnWebApplicationFirewallPolicies().GetAsync(policyName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CdnWebApplicationFirewallPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The name of the CdnWebApplicationFirewallPolicy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<CdnWebApplicationFirewallPolicyResource> GetCdnWebApplicationFirewallPolicy(string policyName, CancellationToken cancellationToken = default)
        {
            return GetCdnWebApplicationFirewallPolicies().Get(policyName, cancellationToken);
        }

        /// <summary>
        /// Check the availability of a resource name. This is needed for resources where name is globally unique, such as a afdx endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/checkEndpointNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckEndpointNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<EndpointNameAvailabilityResult>> CheckEndpointNameAvailabilityAsync(EndpointNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = DefaultClientDiagnostics.CreateScope("MockableCdnResourceGroupResource.CheckEndpointNameAvailability");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.CheckEndpointNameAvailabilityAsync(Id.SubscriptionId, Id.ResourceGroupName, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a resource name. This is needed for resources where name is globally unique, such as a afdx endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/checkEndpointNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckEndpointNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<EndpointNameAvailabilityResult> CheckEndpointNameAvailability(EndpointNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = DefaultClientDiagnostics.CreateScope("MockableCdnResourceGroupResource.CheckEndpointNameAvailability");
            scope.Start();
            try
            {
                var response = DefaultRestClient.CheckEndpointNameAvailability(Id.SubscriptionId, Id.ResourceGroupName, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
