using System.ClientModel;
using System.ClientModel.Primitives;

namespace Azure.AI.OpenAI.Assistants;

internal partial class AzureRunStepsPageEnumerator : RunStepsPageEnumerator
{
    private readonly Uri _endpoint;
    private readonly string _apiVersion;

    public AzureRunStepsPageEnumerator(
        ClientPipeline pipeline,
        Uri endpoint,
        string threadId, string runId,
        int? limit, string order, string after, string before,
        string apiVersion,
        RequestOptions options)
        : base(pipeline, endpoint, threadId, runId, limit, order, after, before, options)
    {
        _endpoint = endpoint;
        _apiVersion = apiVersion;
    }

    internal override async Task<ClientResult> GetRunStepsAsync(string threadId, string runId, int? limit, string order, string after, string before, RequestOptions options)
    {
        Argument.AssertNotNullOrEmpty(threadId, nameof(threadId));
        Argument.AssertNotNullOrEmpty(runId, nameof(runId));

        using PipelineMessage message = CreateGetRunStepsRequest(threadId, runId, limit, order, after, before, options);
        return ClientResult.FromResponse(await Pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
    }

    internal override ClientResult GetRunSteps(string threadId, string runId, int? limit, string order, string after, string before, RequestOptions options)
    {
        Argument.AssertNotNullOrEmpty(threadId, nameof(threadId));
        Argument.AssertNotNullOrEmpty(runId, nameof(runId));

        using PipelineMessage message = CreateGetRunStepsRequest(threadId, runId, limit, order, after, before, options);
        return ClientResult.FromResponse(Pipeline.ProcessMessage(message, options));
    }

    private PipelineMessage CreateGetRunStepsRequest(string threadId, string runId, int? limit, string order, string after, string before, RequestOptions options)
        => new AzureOpenAIPipelineMessageBuilder(Pipeline, _endpoint, _apiVersion)
            .WithAssistantsHeader()
            .WithOptions(options)
            .WithMethod("GET")
            .WithAccept("application/json")
            .WithCommonListParameters(limit, order, after, before)
            .WithPath("threads", threadId, "runs", runId, "steps")
            .Build();
}
