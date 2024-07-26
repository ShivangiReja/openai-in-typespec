// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Batch
{
    internal partial class InternalBatchJob
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }
        internal InternalBatchJob(string id, string endpoint, string inputFileId, string completionWindow, InternalBatchStatus status, DateTimeOffset createdAt)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(inputFileId, nameof(inputFileId));
            Argument.AssertNotNull(completionWindow, nameof(completionWindow));

            Id = id;
            Endpoint = endpoint;
            InputFileId = inputFileId;
            CompletionWindow = completionWindow;
            Status = status;
            CreatedAt = createdAt;
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        internal InternalBatchJob(string id, InternalBatchObject @object, string endpoint, InternalBatchErrors errors, string inputFileId, string completionWindow, InternalBatchStatus status, string outputFileId, string errorFileId, DateTimeOffset createdAt, DateTimeOffset? inProgressAt, DateTimeOffset? expiresAt, DateTimeOffset? finalizingAt, DateTimeOffset? completedAt, DateTimeOffset? failedAt, DateTimeOffset? expiredAt, DateTimeOffset? cancellingAt, DateTimeOffset? cancelledAt, InternalBatchRequestCounts requestCounts, IReadOnlyDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            Endpoint = endpoint;
            Errors = errors;
            InputFileId = inputFileId;
            CompletionWindow = completionWindow;
            Status = status;
            OutputFileId = outputFileId;
            ErrorFileId = errorFileId;
            CreatedAt = createdAt;
            InProgressAt = inProgressAt;
            ExpiresAt = expiresAt;
            FinalizingAt = finalizingAt;
            CompletedAt = completedAt;
            FailedAt = failedAt;
            ExpiredAt = expiredAt;
            CancellingAt = cancellingAt;
            CancelledAt = cancelledAt;
            RequestCounts = requestCounts;
            Metadata = metadata;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalBatchJob()
        {
        }

        public string Id { get; }
        public InternalBatchObject Object { get; } = InternalBatchObject.Batch;

        public string Endpoint { get; }
        public InternalBatchErrors Errors { get; }
        public string InputFileId { get; }
        public string CompletionWindow { get; }
        public InternalBatchStatus Status { get; }
        public string OutputFileId { get; }
        public string ErrorFileId { get; }
        public DateTimeOffset CreatedAt { get; }
        public DateTimeOffset? InProgressAt { get; }
        public DateTimeOffset? ExpiresAt { get; }
        public DateTimeOffset? FinalizingAt { get; }
        public DateTimeOffset? CompletedAt { get; }
        public DateTimeOffset? FailedAt { get; }
        public DateTimeOffset? ExpiredAt { get; }
        public DateTimeOffset? CancellingAt { get; }
        public DateTimeOffset? CancelledAt { get; }
        public InternalBatchRequestCounts RequestCounts { get; }
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
