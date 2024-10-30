using System;
using System.Collections.Generic;
using System.ClientModel.Primitives;
using System.Text.Json;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.RealtimeConversation;

/// <summary>
/// The update (response command) of type <c>conversation.item.deleted</c>, which is received in response to a
/// <c>conversation.item.delete</c> request command
/// (<see cref="RealtimeConversationSession.DeleteItemAsync(string, System.Threading.CancellationToken)"/>).
/// </summary>
[Experimental("OPENAI002")]
[CodeGenModel("RealtimeServerEventConversationItemDeleted")]
public partial class ConversationItemDeletedUpdate
{ }