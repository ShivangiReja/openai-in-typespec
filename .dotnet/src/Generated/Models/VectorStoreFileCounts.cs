// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.VectorStores
{
    public readonly partial struct VectorStoreFileCounts
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }
        internal VectorStoreFileCounts(int inProgress, int completed, int failed, int cancelled, int total)
        {
            InProgress = inProgress;
            Completed = completed;
            Failed = failed;
            Cancelled = cancelled;
            Total = total;
        }

        internal VectorStoreFileCounts(int inProgress, int completed, int failed, int cancelled, int total, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InProgress = inProgress;
            Completed = completed;
            Failed = failed;
            Cancelled = cancelled;
            Total = total;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        public VectorStoreFileCounts()
        {
        }

        public int InProgress { get; }
        public int Completed { get; }
        public int Failed { get; }
        public int Cancelled { get; }
        public int Total { get; }
    }
}
