﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;

namespace Microsoft.Azure.WebJobs.Host.Blobs
{
    // TODO (kasobol-msft) rename this
    internal static class CloudBlobExtensions
    {
        public static async Task<BlobProperties> FetchPropertiesOrNullIfNotExistAsync(this BlobBaseClient blob,
            CancellationToken cancellationToken)
        {
            if (blob == null)
            {
                throw new ArgumentNullException(nameof(blob));
            }

            try
            {
                BlobProperties blobProperties = await blob.GetPropertiesAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                return blobProperties;
            }
            catch (RequestFailedException exception)
            {
                // Remember specific error codes are not available for Fetch (HEAD request).

                if (exception.IsNotFound())
                {
                    return null;
                }
                else if (exception.IsOk())
                {
                    // If the blob type is incorrect (block vs. page) a 200 OK is returned but the SDK throws an
                    // exception.
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
