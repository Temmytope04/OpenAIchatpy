// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualMachineImagesOperations.
    /// </summary>
    public static partial class VirtualMachineImagesOperationsExtensions
    {
            /// <summary>
            /// Gets a virtual machine image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='publisherName'>
            /// A valid image publisher.
            /// </param>
            /// <param name='offer'>
            /// A valid image publisher offer.
            /// </param>
            /// <param name='skus'>
            /// A valid image SKU.
            /// </param>
            /// <param name='version'>
            /// A valid image SKU version.
            /// </param>
            public static VirtualMachineImage Get(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, string skus, string version)
            {
                return operations.GetAsync(location, publisherName, offer, skus, version).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a virtual machine image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='publisherName'>
            /// A valid image publisher.
            /// </param>
            /// <param name='offer'>
            /// A valid image publisher offer.
            /// </param>
            /// <param name='skus'>
            /// A valid image SKU.
            /// </param>
            /// <param name='version'>
            /// A valid image SKU version.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineImage> GetAsync(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, string skus, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, publisherName, offer, skus, version, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of all virtual machine image versions for the specified
            /// location, publisher, offer, and SKU.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='publisherName'>
            /// A valid image publisher.
            /// </param>
            /// <param name='offer'>
            /// A valid image publisher offer.
            /// </param>
            /// <param name='skus'>
            /// A valid image SKU.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='orderby'>
            /// </param>
            public static IList<VirtualMachineImageResource> List(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, string skus, string expand = default(string), int? top = default(int?), string orderby = default(string))
            {
                return operations.ListAsync(location, publisherName, offer, skus, expand, top, orderby).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of all virtual machine image versions for the specified
            /// location, publisher, offer, and SKU.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='publisherName'>
            /// A valid image publisher.
            /// </param>
            /// <param name='offer'>
            /// A valid image publisher offer.
            /// </param>
            /// <param name='skus'>
            /// A valid image SKU.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='orderby'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResource>> ListAsync(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, string skus, string expand = default(string), int? top = default(int?), string orderby = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, publisherName, offer, skus, expand, top, orderby, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of virtual machine image offers for the specified location and
            /// publisher.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='publisherName'>
            /// A valid image publisher.
            /// </param>
            public static IList<VirtualMachineImageResource> ListOffers(this IVirtualMachineImagesOperations operations, string location, string publisherName)
            {
                return operations.ListOffersAsync(location, publisherName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual machine image offers for the specified location and
            /// publisher.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='publisherName'>
            /// A valid image publisher.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResource>> ListOffersAsync(this IVirtualMachineImagesOperations operations, string location, string publisherName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOffersWithHttpMessagesAsync(location, publisherName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of virtual machine image publishers for the specified Azure
            /// location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            public static IList<VirtualMachineImageResource> ListPublishers(this IVirtualMachineImagesOperations operations, string location)
            {
                return operations.ListPublishersAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual machine image publishers for the specified Azure
            /// location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResource>> ListPublishersAsync(this IVirtualMachineImagesOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListPublishersWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of virtual machine image SKUs for the specified location,
            /// publisher, and offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='publisherName'>
            /// A valid image publisher.
            /// </param>
            /// <param name='offer'>
            /// A valid image publisher offer.
            /// </param>
            public static IList<VirtualMachineImageResource> ListSkus(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer)
            {
                return operations.ListSkusAsync(location, publisherName, offer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual machine image SKUs for the specified location,
            /// publisher, and offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='publisherName'>
            /// A valid image publisher.
            /// </param>
            /// <param name='offer'>
            /// A valid image publisher offer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResource>> ListSkusAsync(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSkusWithHttpMessagesAsync(location, publisherName, offer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
