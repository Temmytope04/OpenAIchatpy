// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Orbital
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AvailableGroundStationsOperations.
    /// </summary>
    public static partial class AvailableGroundStationsOperationsExtensions
    {
            /// <summary>
            /// Returns list of available ground stations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capability'>
            /// Ground Station Capability. Possible values include: 'EarthObservation',
            /// 'Communication'
            /// </param>
            public static IPage<AvailableGroundStation> ListByCapability(this IAvailableGroundStationsOperations operations, string capability)
            {
                return operations.ListByCapabilityAsync(capability).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns list of available ground stations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capability'>
            /// Ground Station Capability. Possible values include: 'EarthObservation',
            /// 'Communication'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AvailableGroundStation>> ListByCapabilityAsync(this IAvailableGroundStationsOperations operations, string capability, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByCapabilityWithHttpMessagesAsync(capability, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified  available ground station
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groundStationName'>
            /// Ground Station name
            /// </param>
            public static AvailableGroundStation Get(this IAvailableGroundStationsOperations operations, string groundStationName)
            {
                return operations.GetAsync(groundStationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified  available ground station
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groundStationName'>
            /// Ground Station name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AvailableGroundStation> GetAsync(this IAvailableGroundStationsOperations operations, string groundStationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(groundStationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns list of available ground stations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AvailableGroundStation> ListByCapabilityNext(this IAvailableGroundStationsOperations operations, string nextPageLink)
            {
                return operations.ListByCapabilityNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns list of available ground stations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AvailableGroundStation>> ListByCapabilityNextAsync(this IAvailableGroundStationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByCapabilityNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
