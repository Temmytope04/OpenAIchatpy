﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.Reflection;

#nullable enable

namespace Azure.Core.Pipeline
{
#pragma warning disable CA1001 // Types that own disposable fields should be disposable
    internal class DiagnosticsScopeFactory
#pragma warning restore CA1001 // Types that own disposable fields should be disposable
    {
        private readonly string? _resourceProviderNamespace;
        private readonly DiagnosticListener? _source;

        public bool IsActivityEnabled { get;  }

        public DiagnosticsScopeFactory(string clientNamespace, string? resourceProviderNamespace, bool isActivityEnabled)
        {
            _resourceProviderNamespace = resourceProviderNamespace;
            IsActivityEnabled = isActivityEnabled;
            if (IsActivityEnabled)
            {
                _source = new DiagnosticListener(clientNamespace);
            }
        }

        public DiagnosticScope CreateScope(string name)
        {
            if (_source == null)
            {
                return default;
            }
            var scope = new DiagnosticScope(name, _source);

            if (_resourceProviderNamespace != null)
            {
                scope.AddAttribute("az.namespace", _resourceProviderNamespace);
            }
            return scope;
        }
    }
}
