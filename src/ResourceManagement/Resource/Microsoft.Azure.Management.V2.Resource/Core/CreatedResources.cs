﻿using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Azure.Management.V2.Resource.Core
{
    /// <summary>
    /// Implementation of <see cref="ICreatedResources{ResourceT}"> interface.
    /// </summary>
    /// <typeparam name="ResourceT">the type of the resources in the batch</typeparam>
    internal class CreatedResources<ResourceT> : ICreatedResources<ResourceT>
        where ResourceT : class, IResource
    {
        /// <summary>
        /// The dummy root resource for this batch.
        /// </summary>
        private ICreatableUpdatableResourcesRoot<ResourceT> creatableUpdatableResourcesRoot;

        /// <summary>
        /// The top level resources created in this batch.
        /// </summary>
        private IEnumerable<ResourceT> topLevelResources;

        internal CreatedResources(ICreatableUpdatableResourcesRoot<ResourceT> creatableUpdatableResourcesRoot)
        {
            this.creatableUpdatableResourcesRoot = creatableUpdatableResourcesRoot;
            this.topLevelResources = this.creatableUpdatableResourcesRoot.createdTopLevelResources();
        }

        #region Implementation of ICreatedResources interface

        public IResource CreatedRelatedResource(string key)
        {
            return this.creatableUpdatableResourcesRoot.CreatedRelatedResource(key);
        }

        public IEnumerator<ResourceT> GetEnumerator()
        {
            return this.topLevelResources.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #endregion
    }
}
