﻿using System.Threading.Tasks;

namespace Microsoft.Azure.Management.V2.Resource.Core.CollectionActions
{
    public interface ISupportsGettingByName<T>
    {
        Task<T> GetByName(string name);
    }
}
