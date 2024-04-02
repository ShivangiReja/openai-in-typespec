// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using OpenAI.Internal.Models;

namespace OpenAI.Internal
{
    // Data plane generated sub-client.
    /// <summary> The ModelsOps sub-client. </summary>
    internal partial class ModelsOps
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _credential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ModelsOps for mocking. </summary>
        protected ModelsOps()
        {
        }

        /// <summary> Initializes a new instance of ModelsOps. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="credential"> The key credential to copy. </param>
        /// <param name="endpoint"> OpenAI Endpoint. </param>
        internal ModelsOps(ClientPipeline pipeline, ApiKeyCredential credential, Uri endpoint)
        {
            _pipeline = pipeline;
            _credential = credential;
            _endpoint = endpoint;
        }

        /// <summary>
        /// Lists the currently available models, and provides basic information about each one such as the
        /// owner and availability.
        /// </summary>
        public virtual async Task<ClientResult<ListModelsResponse>> GetModelsAsync()
        {
            ClientResult result = await GetModelsAsync(DefaultRequestContext).ConfigureAwait(false);
            return ClientResult.FromValue(ListModelsResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// Lists the currently available models, and provides basic information about each one such as the
        /// owner and availability.
        /// </summary>
        public virtual ClientResult<ListModelsResponse> GetModels()
        {
            ClientResult result = GetModels(DefaultRequestContext);
            return ClientResult.FromValue(ListModelsResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Lists the currently available models, and provides basic information about each one such as the
        /// owner and availability.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetModelsAsync()"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> GetModelsAsync(RequestOptions options)
        {
            using PipelineMessage message = CreateGetModelsRequest(options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Lists the currently available models, and provides basic information about each one such as the
        /// owner and availability.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetModels()"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult GetModels(RequestOptions options)
        {
            using PipelineMessage message = CreateGetModelsRequest(options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary>
        /// Retrieves a model instance, providing basic information about the model such as the owner and
        /// permissioning.
        /// </summary>
        /// <param name="model"> The ID of the model to use for this request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="model"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="model"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual async Task<ClientResult<Model>> RetrieveAsync(string model)
        {
            Argument.AssertNotNullOrEmpty(model, nameof(model));

            ClientResult result = await RetrieveAsync(model, DefaultRequestContext).ConfigureAwait(false);
            return ClientResult.FromValue(Model.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// Retrieves a model instance, providing basic information about the model such as the owner and
        /// permissioning.
        /// </summary>
        /// <param name="model"> The ID of the model to use for this request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="model"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="model"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual ClientResult<Model> Retrieve(string model)
        {
            Argument.AssertNotNullOrEmpty(model, nameof(model));

            ClientResult result = Retrieve(model, DefaultRequestContext);
            return ClientResult.FromValue(Model.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Retrieves a model instance, providing basic information about the model such as the owner and
        /// permissioning.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="RetrieveAsync(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="model"> The ID of the model to use for this request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="model"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="model"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> RetrieveAsync(string model, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(model, nameof(model));

            using PipelineMessage message = CreateRetrieveRequest(model, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Retrieves a model instance, providing basic information about the model such as the owner and
        /// permissioning.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Retrieve(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="model"> The ID of the model to use for this request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="model"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="model"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Retrieve(string model, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(model, nameof(model));

            using PipelineMessage message = CreateRetrieveRequest(model, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Delete a fine-tuned model. You must have the Owner role in your organization to delete a model. </summary>
        /// <param name="model"> The model to delete. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="model"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="model"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual async Task<ClientResult<DeleteModelResponse>> DeleteAsync(string model)
        {
            Argument.AssertNotNullOrEmpty(model, nameof(model));

            ClientResult result = await DeleteAsync(model, DefaultRequestContext).ConfigureAwait(false);
            return ClientResult.FromValue(DeleteModelResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Delete a fine-tuned model. You must have the Owner role in your organization to delete a model. </summary>
        /// <param name="model"> The model to delete. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="model"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="model"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual ClientResult<DeleteModelResponse> Delete(string model)
        {
            Argument.AssertNotNullOrEmpty(model, nameof(model));

            ClientResult result = Delete(model, DefaultRequestContext);
            return ClientResult.FromValue(DeleteModelResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Delete a fine-tuned model. You must have the Owner role in your organization to delete a model.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="DeleteAsync(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="model"> The model to delete. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="model"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="model"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> DeleteAsync(string model, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(model, nameof(model));

            using PipelineMessage message = CreateDeleteRequest(model, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Delete a fine-tuned model. You must have the Owner role in your organization to delete a model.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Delete(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="model"> The model to delete. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="model"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="model"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Delete(string model, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(model, nameof(model));

            using PipelineMessage message = CreateDeleteRequest(model, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        internal PipelineMessage CreateGetModelsRequest(RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            if (options != null)
            {
                message.Apply(options);
            }
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/models", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            return message;
        }

        internal PipelineMessage CreateRetrieveRequest(string model, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            if (options != null)
            {
                message.Apply(options);
            }
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/models/", false);
            uri.AppendPath(model, true);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            return message;
        }

        internal PipelineMessage CreateDeleteRequest(string model, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            if (options != null)
            {
                message.Apply(options);
            }
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "DELETE";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/models/", false);
            uri.AppendPath(model, true);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            return message;
        }

        private static RequestOptions DefaultRequestContext = new RequestOptions();

        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
    }
}
