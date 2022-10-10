﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Storage.DataMovement.Models
{
    /// <summary>
    /// Determines whether or not the resource requires a commit block list (e.g. Commit Block List)
    /// to determine which blocks will make up the resource.
    /// </summary>
    public enum CanCommitListType
    {
        /// <summary>
        /// Requires Commit List to finish the transfer
        /// </summary>
        CanCommitBlockList,

        /// <summary>
        /// Does not require any commit list type to finish the transfer.
        /// </summary>
        None = ~0,
    }
}
