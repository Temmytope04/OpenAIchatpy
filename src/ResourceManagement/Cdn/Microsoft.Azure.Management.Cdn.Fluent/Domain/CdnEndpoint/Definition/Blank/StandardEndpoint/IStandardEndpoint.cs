// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.Definition.Blank.StandardEndpoint
{
    using Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.Definition;

    /// <summary>
    /// The stage of the CDN profile endpoint definition allowing to specify the origin.
    /// </summary>
    /// <typeparam name="Parent">The return type of AttachableStandard.attach().</typeparam>
    public interface IStandardEndpoint<ParentT> 
    {
        /// <summary>
        /// Specifies the origin of the CDN endpoint.
        /// </summary>
        /// <param name="originName">Name of the origin.</param>
        /// <param name="originHostName">Origin hostname.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.Definition.IWithStandardAttach<ParentT> WithOrigin(string originName, string originHostName);

        /// <summary>
        /// Specifies the origin of the CDN endpoint.
        /// </summary>
        /// <param name="originHostName">Origin hostname.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.Definition.IWithStandardAttach<ParentT> WithOrigin(string originHostName);
    }
}