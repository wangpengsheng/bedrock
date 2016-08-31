// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Specialized;

namespace Bedrock.Regions
{
    /// <summary>
    /// Defines a collection of <see cref="IRegion"/> uniquely identified by their Name.
    /// </summary>
    public interface IRegionCollection : IEnumerable<IRegion>, INotifyCollectionChanged
    {
        /// <summary>
        /// Gets the IRegion with the name received as index.
        /// </summary>
        /// <param name="regionName">Name of the region to be retrieved.</param>
        /// <returns>The <see cref="IRegion"/> identified with the requested name.</returns>
        IRegion this[string regionName] { get; }

        /// <summary>
        /// Adds a <see cref="IRegion"/> to the collection.
        /// </summary>
        /// <param name="region">Region to be added to the collection.</param>
        void Add(IRegion region);

        /// <summary>
        /// Removes a <see cref="IRegion"/> from the collection.
        /// </summary>
        /// <param name="regionName">Name of the region to be removed.</param>
        /// <returns><see langword="true"/> if the region was removed from the collection, otherwise <see langword="false"/>.</returns>
        bool Remove(string regionName);

        /// <summary>
        /// Checks if the collection contains a <see cref="IRegion"/> with the name received as parameter.
        /// </summary>
        /// <param name="regionName">The name of the region to look for.</param>
        /// <returns><see langword="true"/> if the region is contained in the collection, otherwise <see langword="false"/>.</returns>
        bool ContainsRegionWithName(string regionName);
    }
}