﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;

namespace Azure.Identity
{
    internal interface IProcess : IDisposable
    {
        bool HasExited { get; }
        int ExitCode { get; }
        StreamReader StandardOutput { get; }
        StreamReader StandardError { get; }

        event EventHandler Exited;

        void Start();
        void Kill();
    }
}
