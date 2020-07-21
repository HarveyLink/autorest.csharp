// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveSearch.Models
{
    /// <summary> Represents service-level resource counters and quotas. </summary>
    public partial class ServiceCounters
    {
        /// <summary> Initializes a new instance of ServiceCounters. </summary>
        /// <param name="documentCounter"> Total number of documents across all indexes in the service. </param>
        /// <param name="indexCounter"> Total number of indexes. </param>
        /// <param name="indexerCounter"> Total number of indexers. </param>
        /// <param name="dataSourceCounter"> Total number of data sources. </param>
        /// <param name="storageSizeCounter"> Total size of used storage in bytes. </param>
        /// <param name="synonymMapCounter"> Total number of synonym maps. </param>
        /// <param name="skillsetCounter"> Total number of skillsets. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="documentCounter"/>, <paramref name="indexCounter"/>, <paramref name="indexerCounter"/>, <paramref name="dataSourceCounter"/>, <paramref name="storageSizeCounter"/>, <paramref name="synonymMapCounter"/>, or <paramref name="skillsetCounter"/> is null. </exception>
        internal ServiceCounters(ResourceCounter documentCounter, ResourceCounter indexCounter, ResourceCounter indexerCounter, ResourceCounter dataSourceCounter, ResourceCounter storageSizeCounter, ResourceCounter synonymMapCounter, ResourceCounter skillsetCounter)
        {
            if (documentCounter == null)
            {
                throw new ArgumentNullException(nameof(documentCounter));
            }
            if (indexCounter == null)
            {
                throw new ArgumentNullException(nameof(indexCounter));
            }
            if (indexerCounter == null)
            {
                throw new ArgumentNullException(nameof(indexerCounter));
            }
            if (dataSourceCounter == null)
            {
                throw new ArgumentNullException(nameof(dataSourceCounter));
            }
            if (storageSizeCounter == null)
            {
                throw new ArgumentNullException(nameof(storageSizeCounter));
            }
            if (synonymMapCounter == null)
            {
                throw new ArgumentNullException(nameof(synonymMapCounter));
            }
            if (skillsetCounter == null)
            {
                throw new ArgumentNullException(nameof(skillsetCounter));
            }

            DocumentCounter = documentCounter;
            IndexCounter = indexCounter;
            IndexerCounter = indexerCounter;
            DataSourceCounter = dataSourceCounter;
            StorageSizeCounter = storageSizeCounter;
            SynonymMapCounter = synonymMapCounter;
            SkillsetCounter = skillsetCounter;
        }

        /// <summary> Total number of documents across all indexes in the service. </summary>
        public ResourceCounter DocumentCounter { get; }
        /// <summary> Total number of indexes. </summary>
        public ResourceCounter IndexCounter { get; }
        /// <summary> Total number of indexers. </summary>
        public ResourceCounter IndexerCounter { get; }
        /// <summary> Total number of data sources. </summary>
        public ResourceCounter DataSourceCounter { get; }
        /// <summary> Total size of used storage in bytes. </summary>
        public ResourceCounter StorageSizeCounter { get; }
        /// <summary> Total number of synonym maps. </summary>
        public ResourceCounter SynonymMapCounter { get; }
        /// <summary> Total number of skillsets. </summary>
        public ResourceCounter SkillsetCounter { get; }
    }
}
