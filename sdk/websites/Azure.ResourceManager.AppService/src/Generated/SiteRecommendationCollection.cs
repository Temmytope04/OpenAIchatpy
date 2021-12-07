// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of RecommendationRule and their operations over its parent. </summary>
    public partial class SiteRecommendationCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RecommendationsRestOperations _recommendationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteRecommendationCollection"/> class for mocking. </summary>
        protected SiteRecommendationCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteRecommendationCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteRecommendationCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _recommendationsRestClient = new RecommendationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => WebSite.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/recommendations/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: Recommendations_GetRuleDetailsByWebApp
        /// <summary> Description for Get a recommendation rule for an app. </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<SiteRecommendation> Get(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteRecommendationCollection.Get");
            scope.Start();
            try
            {
                var response = _recommendationsRestClient.GetRuleDetailsByWebApp(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecommendation(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/recommendations/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: Recommendations_GetRuleDetailsByWebApp
        /// <summary> Description for Get a recommendation rule for an app. </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<SiteRecommendation>> GetAsync(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteRecommendationCollection.Get");
            scope.Start();
            try
            {
                var response = await _recommendationsRestClient.GetRuleDetailsByWebAppAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteRecommendation(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<SiteRecommendation> GetIfExists(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteRecommendationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _recommendationsRestClient.GetRuleDetailsByWebApp(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteRecommendation>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteRecommendation(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<SiteRecommendation>> GetIfExistsAsync(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteRecommendationCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _recommendationsRestClient.GetRuleDetailsByWebAppAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteRecommendation>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteRecommendation(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteRecommendationCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, updateSeen, recommendationId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don&apos;t need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteRecommendationCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, updateSeen, recommendationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SiteRecommendation, RecommendationRuleData> Construct() { }
    }
}
