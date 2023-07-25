// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> Additional Confidential Ledger properties. </summary>
    public partial class ConfidentialLedgerProperties
    {
        /// <summary> Initializes a new instance of ConfidentialLedgerProperties. </summary>
        public ConfidentialLedgerProperties()
        {
            AadBasedSecurityPrincipals = new ChangeTrackingList<AadBasedSecurityPrincipal>();
            CertBasedSecurityPrincipals = new ChangeTrackingList<CertBasedSecurityPrincipal>();
        }

        /// <summary> Initializes a new instance of ConfidentialLedgerProperties. </summary>
        /// <param name="ledgerName"> Unique name for the Confidential Ledger. </param>
        /// <param name="ledgerUri"> Endpoint for calling Ledger Service. </param>
        /// <param name="identityServiceUri"> Endpoint for accessing network identity. </param>
        /// <param name="ledgerInternalNamespace"> Internal namespace for the Ledger. </param>
        /// <param name="runningState"> Object representing RunningState for Ledger. </param>
        /// <param name="ledgerType"> Type of Confidential Ledger. </param>
        /// <param name="provisioningState"> Provisioning state of Ledger Resource. </param>
        /// <param name="aadBasedSecurityPrincipals"> Array of all AAD based Security Principals. </param>
        /// <param name="certBasedSecurityPrincipals"> Array of all cert based Security Principals. </param>
        internal ConfidentialLedgerProperties(string ledgerName, Uri ledgerUri, Uri identityServiceUri, string ledgerInternalNamespace, ConfidentialLedgerRunningState? runningState, ConfidentialLedgerType? ledgerType, ConfidentialLedgerProvisioningState? provisioningState, IList<AadBasedSecurityPrincipal> aadBasedSecurityPrincipals, IList<CertBasedSecurityPrincipal> certBasedSecurityPrincipals)
        {
            LedgerName = ledgerName;
            LedgerUri = ledgerUri;
            IdentityServiceUri = identityServiceUri;
            LedgerInternalNamespace = ledgerInternalNamespace;
            RunningState = runningState;
            LedgerType = ledgerType;
            ProvisioningState = provisioningState;
            AadBasedSecurityPrincipals = aadBasedSecurityPrincipals;
            CertBasedSecurityPrincipals = certBasedSecurityPrincipals;
        }

        /// <summary> Unique name for the Confidential Ledger. </summary>
        public string LedgerName { get; }
        /// <summary> Endpoint for calling Ledger Service. </summary>
        public Uri LedgerUri { get; }
        /// <summary> Endpoint for accessing network identity. </summary>
        public Uri IdentityServiceUri { get; }
        /// <summary> Internal namespace for the Ledger. </summary>
        public string LedgerInternalNamespace { get; }
        /// <summary> Object representing RunningState for Ledger. </summary>
        public ConfidentialLedgerRunningState? RunningState { get; set; }
        /// <summary> Type of Confidential Ledger. </summary>
        public ConfidentialLedgerType? LedgerType { get; set; }
        /// <summary> Provisioning state of Ledger Resource. </summary>
        public ConfidentialLedgerProvisioningState? ProvisioningState { get; }
        /// <summary> Array of all AAD based Security Principals. </summary>
        public IList<AadBasedSecurityPrincipal> AadBasedSecurityPrincipals { get; }
        /// <summary> Array of all cert based Security Principals. </summary>
        public IList<CertBasedSecurityPrincipal> CertBasedSecurityPrincipals { get; }
    }
}
