// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The ResourceTypeAliasPathMetadata. </summary>
    public partial class ResourceTypeAliasPathMetadata
    {
        /// <summary> Initializes a new instance of ResourceTypeAliasPathMetadata. </summary>
        internal ResourceTypeAliasPathMetadata()
        {
        }

        /// <summary> Initializes a new instance of ResourceTypeAliasPathMetadata. </summary>
        /// <param name="tokenType"> The type of the token that the alias path is referring to. </param>
        /// <param name="attributes"> The attributes of the token that the alias path is referring to. </param>
        internal ResourceTypeAliasPathMetadata(ResourceTypeAliasPathTokenType? tokenType, ResourceTypeAliasPathAttributes? attributes)
        {
            TokenType = tokenType;
            Attributes = attributes;
        }

        /// <summary> The type of the token that the alias path is referring to. </summary>
        public ResourceTypeAliasPathTokenType? TokenType { get; }
        /// <summary> The attributes of the token that the alias path is referring to. </summary>
        public ResourceTypeAliasPathAttributes? Attributes { get; }
    }
}
