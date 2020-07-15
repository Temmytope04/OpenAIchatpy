// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Request parameters for adding a member to a group. </summary>
    public partial class GroupAddMemberParameters : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of GroupAddMemberParameters. </summary>
        /// <param name="url"> A member object URL, such as &quot;https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd&quot;, where &quot;0b1f9851-1bf0-433f-aec3-cb9272f093dc&quot; is the tenantId and &quot;f260bbc4-c254-447b-94cf-293b5ec434dd&quot; is the objectId of the member (user, application, servicePrincipal, group) to be added. </param>
        public GroupAddMemberParameters(string url)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            Url = url;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of GroupAddMemberParameters. </summary>
        /// <param name="url"> A member object URL, such as &quot;https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd&quot;, where &quot;0b1f9851-1bf0-433f-aec3-cb9272f093dc&quot; is the tenantId and &quot;f260bbc4-c254-447b-94cf-293b5ec434dd&quot; is the objectId of the member (user, application, servicePrincipal, group) to be added. </param>
        /// <param name="additionalProperties"> . </param>
        internal GroupAddMemberParameters(string url, IDictionary<string, object> additionalProperties)
        {
            Url = url;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> A member object URL, such as &quot;https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd&quot;, where &quot;0b1f9851-1bf0-433f-aec3-cb9272f093dc&quot; is the tenantId and &quot;f260bbc4-c254-447b-94cf-293b5ec434dd&quot; is the objectId of the member (user, application, servicePrincipal, group) to be added. </summary>
        public string Url { get; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
