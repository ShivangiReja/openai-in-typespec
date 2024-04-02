// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    /// <summary> The CreateCompletionResponseChoice. </summary>
    internal partial class CreateCompletionResponseChoice
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CreateCompletionResponseChoice"/>. </summary>
        /// <param name="index"></param>
        /// <param name="text"></param>
        /// <param name="logprobs"></param>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a
        /// natural stop point or a provided stop sequence, or `content_filter` if content was omitted
        /// due to a flag from our content filters, `length` if the maximum number of tokens specified
        /// in the request was reached, or `content_filter` if content was omitted due to a flag from our
        /// content filters.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        internal CreateCompletionResponseChoice(long index, string text, CreateCompletionResponseChoiceLogprobs logprobs, CreateCompletionResponseChoiceFinishReason finishReason)
        {
            Argument.AssertNotNull(text, nameof(text));

            Index = index;
            Text = text;
            Logprobs = logprobs;
            FinishReason = finishReason;
        }

        /// <summary> Initializes a new instance of <see cref="CreateCompletionResponseChoice"/>. </summary>
        /// <param name="index"></param>
        /// <param name="text"></param>
        /// <param name="logprobs"></param>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a
        /// natural stop point or a provided stop sequence, or `content_filter` if content was omitted
        /// due to a flag from our content filters, `length` if the maximum number of tokens specified
        /// in the request was reached, or `content_filter` if content was omitted due to a flag from our
        /// content filters.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateCompletionResponseChoice(long index, string text, CreateCompletionResponseChoiceLogprobs logprobs, CreateCompletionResponseChoiceFinishReason finishReason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Index = index;
            Text = text;
            Logprobs = logprobs;
            FinishReason = finishReason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateCompletionResponseChoice"/> for deserialization. </summary>
        internal CreateCompletionResponseChoice()
        {
        }

        /// <summary> Gets the index. </summary>
        public long Index { get; }
        /// <summary> Gets the text. </summary>
        public string Text { get; }
        /// <summary> Gets the logprobs. </summary>
        public CreateCompletionResponseChoiceLogprobs Logprobs { get; }
        /// <summary>
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a
        /// natural stop point or a provided stop sequence, or `content_filter` if content was omitted
        /// due to a flag from our content filters, `length` if the maximum number of tokens specified
        /// in the request was reached, or `content_filter` if content was omitted due to a flag from our
        /// content filters.
        /// </summary>
        public CreateCompletionResponseChoiceFinishReason FinishReason { get; }
    }
}
