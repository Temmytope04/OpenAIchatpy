﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace System.ClientModel.Options;

/// <summary>
/// TODO
/// </summary>
public class DiagnosticsOptions
{
    private bool _frozen;

    private bool _isLoggingEnabled = true;
    private int _loggedContentSizeLimit = 4 * 1024;
    private bool _isLoggingContentEnabled;
    private IEnumerable<string>? _loggedHeaderNames;
    private IEnumerable<string>? _loggedQueryParameters;
    private string? _clientAssembly;
    private string? _requestIdHeaderName;

    /// <summary>
    /// Get or sets value indicating whether HTTP pipeline logging is enabled.
    /// </summary>
    public bool IsLoggingEnabled
    {
        get => _isLoggingEnabled;
        set
        {
            AssertNotFrozen();

            _isLoggingEnabled = value;
        }
    }

    /// <summary>
    /// Gets or sets value indicating if request or response content should be logged.
    /// </summary>
    public bool IsLoggingContentEnabled
    {
        get => _isLoggingContentEnabled;
        set
        {
            AssertNotFrozen();

            _isLoggingContentEnabled = value;
        }
    }

    /// <summary>
    /// Gets or sets value indicating maximum size of content to log in bytes. Defaults to 4096.
    /// </summary>
    public int LoggedContentSizeLimit
    {
        get => _loggedContentSizeLimit;
        set
        {
            AssertNotFrozen();

            _loggedContentSizeLimit = value;
        }
    }

    /// <summary>
    /// Gets or sets a list of header names that are not redacted during logging.
    /// </summary>
    public IEnumerable<string>? LoggedHeaderNames
    {
        get => _loggedHeaderNames;
        set
        {
            AssertNotFrozen();

            _loggedHeaderNames = value;
        }
    }

    /// <summary>
    /// Gets or sets a list of query parameter names that are not redacted during logging.
    /// </summary>
    public IEnumerable<string>? LoggedQueryParameters
    {
        get => _loggedQueryParameters;
        set
        {
            AssertNotFrozen();

            _loggedQueryParameters = value;
        }
    }

    /// <summary>
    /// Gets or sets the name of the client assembly to include in logging.
    /// </summary>
    public string? LoggedClientAssemblyName
    {
        get => _clientAssembly;
        set
        {
            AssertNotFrozen();

            _clientAssembly = value;
        }
    }

    /// <summary>
    /// Gets or sets the header name that contains the request Id to include in logging.
    /// </summary>
    public string? RequestIdHeaderName
    {
        get => _requestIdHeaderName;
        set
        {
            AssertNotFrozen();

            _requestIdHeaderName = value;
        }
    }

    /// <summary>
    /// Freeze this instance of <see cref="DiagnosticsOptions"/>.  After this method
    /// has been called, any attempt to set properties on the instance or call
    /// methods that would change its state will throw <see cref="InvalidOperationException"/>.
    /// </summary>
    public virtual void Freeze() => _frozen = true;

    /// <summary>
    /// Assert that <see cref="Freeze"/> has not been called on this
    /// <see cref="DiagnosticsOptions"/> instance.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when an attempt is
    /// made to change the state of this <see cref="DiagnosticsOptions"/> instance
    /// after <see cref="Freeze"/> has been called.</exception>
    protected void AssertNotFrozen()
    {
        if (_frozen)
        {
            throw new InvalidOperationException("Cannot change a DiagnosticsOptions instance after the ClientPipeline is created.");
        }
    }
}
