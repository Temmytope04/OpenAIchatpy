﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Azure.Storage
{
    /// <summary>
    /// Extension methods to make tests easier to author.
    /// </summary>
    public static partial class TestExtensions
    {
        /// <summary>
        /// Convert an IAsyncEnumerable into a List to make test verification
        /// easier.
        /// </summary>
        /// <typeparam name="T">The item type.</typeparam>
        /// <param name="items">The seqeuence of items.</param>
        /// <returns>A list of all the items in the sequence.</returns>
        public static async Task<IList<T>> ToListAsync<T>(this IAsyncEnumerable<T> items)
        {
            var all = new List<T>();
            await foreach (T item in items)
            {
                all.Add(item);
            }
            return all;
        }

        /// <summary>
        /// Get the first item in an IAsyncEnumerable.
        /// </summary>
        /// <typeparam name="T">The item type.</typeparam>
        /// <param name="items">The seqeuence of items.</param>
        /// <returns>
        /// The first item in the sequence or an
        /// <see cref="InvalidOperationException"/>.
        /// </returns>
        public static async Task<T> FirstAsync<T>(this IAsyncEnumerable<T> items)
        {
            await foreach (T item in items)
            {
                return item;
            }
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Returns a new Uri based on the supplied Uri, but with Http enabled.
        /// </summary>
        /// <param name="uri">Source Uri.</param>
        /// <returns>Http Uri.</returns>
        public static Uri ToHttp(this Uri uri)
        {
            var builder = new UriBuilder(uri)
            {
                Scheme = "http",
                Port = 80
            };
            return builder.Uri;
        }

        /// <summary>
        /// Returns a connection string for the storage account, optionally with sensitive data.
        /// </summary>
        /// <param name="exportSecrets"><c>True</c> to include sensitive data in the string; otherwise, <c>false</c>.</param>
        /// <returns>A connection string.</returns>
        internal static string ToString(this StorageConnectionString conn, bool exportSecrets)
        {
            if (conn.Settings == null)
            {
                conn.Settings = new Dictionary<string, string>();

                if (conn.DefaultEndpoints)
                {
                    conn.Settings.Add(Constants.ConnectionStrings.DefaultEndpointsProtocolSetting, conn.BlobEndpoint.Scheme);

                    if (conn.EndpointSuffix != null)
                    {
                        conn.Settings.Add(Constants.ConnectionStrings.EndpointSuffixSetting, conn.EndpointSuffix);
                    }
                }
                else
                {
                    if (conn.BlobEndpoint != null)
                    {
                        conn.Settings.Add(Constants.ConnectionStrings.BlobEndpointSetting, conn.BlobEndpoint.ToString());
                    }

                    if (conn.QueueEndpoint != null)
                    {
                        conn.Settings.Add(Constants.ConnectionStrings.QueueEndpointSetting, conn.QueueEndpoint.ToString());
                    }

                    if (conn.TableEndpoint != null)
                    {
                        conn.Settings.Add(Constants.ConnectionStrings.TableEndpointSetting, conn.TableEndpoint.ToString());
                    }

                    if (conn.FileEndpoint != null)
                    {
                        conn.Settings.Add(Constants.ConnectionStrings.FileEndpointSetting, conn.FileEndpoint.ToString());
                    }

                    if (conn.BlobStorageUri.SecondaryUri != null)
                    {
                        conn.Settings.Add(Constants.ConnectionStrings.BlobSecondaryEndpointSetting,
                            conn.BlobStorageUri.SecondaryUri.ToString());
                    }

                    if (conn.QueueStorageUri.SecondaryUri != null)
                    {
                        conn.Settings.Add(Constants.ConnectionStrings.QueueSecondaryEndpointSetting,
                            conn.QueueStorageUri.SecondaryUri.ToString());
                    }

                    if (conn.TableStorageUri.SecondaryUri != null)
                    {
                        conn.Settings.Add(Constants.ConnectionStrings.TableSecondaryEndpointSetting,
                            conn.TableStorageUri.SecondaryUri.ToString());
                    }

                    if (conn.FileStorageUri.SecondaryUri != null)
                    {
                        conn.Settings.Add(Constants.ConnectionStrings.FileSecondaryEndpointSetting,
                            conn.FileStorageUri.SecondaryUri.ToString());
                    }
                }
            }

            var listOfSettings = conn.Settings.Select(pair => string.Format(CultureInfo.InvariantCulture, "{0}={1}", pair.Key, pair.Value)).ToList();

            if (conn.Credentials != null && !conn.IsDevStoreAccount)
            {
                listOfSettings.Add(ToString(conn.Credentials, exportSecrets));
            }

            if (!string.IsNullOrWhiteSpace(conn._accountName) && (conn.Credentials is StorageSharedKeyCredential sharedKeyCredentials ? string.IsNullOrWhiteSpace(sharedKeyCredentials.AccountName) : true))
            {
                listOfSettings.Add(string.Format(CultureInfo.InvariantCulture, "{0}={1}", Constants.ConnectionStrings.AccountNameSetting, conn._accountName));
            }

            return string.Join(";", listOfSettings);
        }

        private static string ToString(object credentials, bool exportSecrets)
        {
            if (credentials is StorageSharedKeyCredential sharedKeyCredentials)
            {
                return string.Format(
                    CultureInfo.InvariantCulture,
                    "{0}={1};{2}={3}",
                    Constants.ConnectionStrings.AccountNameSetting,
                    sharedKeyCredentials.AccountName,
                    Constants.ConnectionStrings.AccountKeySetting,
                    exportSecrets ? ((StorageSharedKeyCredential)credentials).ExportBase64EncodedKey() : "Sanitized");
            }
            else if (credentials is SharedAccessSignatureCredentials sasCredentials)
            {
                return string.Format(CultureInfo.InvariantCulture, "{0}={1}", Constants.ConnectionStrings.SharedAccessSignatureSetting, exportSecrets ? sasCredentials.SasToken : "[signature hidden]");
            }

            return string.Empty;
        }

        internal static string ExportBase64EncodedKey(this StorageSharedKeyCredential credential)
        {
            Type type = credential.GetType();
            PropertyInfo prop = type.GetProperty("AccountKeyValue", BindingFlags.NonPublic | BindingFlags.Instance);
            var val = prop.GetValue(credential);
            return !(val is byte[] key) ?
                null :
                Convert.ToBase64String(key);
        }
    }
}
