import "@typespec/http";
import "@typespec/openapi";

import "../common";
import "./models.tsp";

using TypeSpec.Http;
using TypeSpec.OpenAPI;

namespace OpenAI;

@route("/threads/{thread_id}/messages")
interface Messages {
  @post
  @operationId("createMessage")
  @tag("Assistants")
  @summary("Create a message.")
  createMessage(
    @header accept: "application/json",

    /** The ID of the [thread](/docs/api-reference/threads) to create a message for. */
    @path thread_id: string,

    @body requestBody: CreateMessageRequest,
  ): MessageObject | ErrorResponse;

  @get
  @operationId("listMessages")
  @tag("Assistants")
  @summary("Returns a list of messages for a given thread.")
  listMessages(
    @header accept: "application/json",

    /** The ID of the [thread](/docs/api-reference/threads) the messages belong to. */
    @path thread_id: string,

    /**
     * A limit on the number of objects to be returned. Limit can range between 1 and 100, and the
     * default is 20.
     */
    @query limit?: int32 = 20,

    /**
     * Sort order by the `created_at` timestamp of the objects. `asc` for ascending order and`desc`
     * for descending order.
     */
    @query order?: "asc" | "desc" = "desc",

    /**
     * A cursor for use in pagination. `after` is an object ID that defines your place in the list.
     * For instance, if you make a list request and receive 100 objects, ending with obj_foo, your
     * subsequent call can include after=obj_foo in order to fetch the next page of the list.
     */
    @query after?: string,

    /**
     * A cursor for use in pagination. `before` is an object ID that defines your place in the list.
     * For instance, if you make a list request and receive 100 objects, ending with obj_foo, your
     * subsequent call can include before=obj_foo in order to fetch the previous page of the list.
     */
    @query before?: string,
  ): ListMessagesResponse | ErrorResponse;

  @route("{message_id}")
  @get
  @operationId("getMessage")
  @tag("Assistants")
  @summary("Retrieve a message.")
  getMessage(
    @header accept: "application/json",

    /** The ID of the [thread](/docs/api-reference/threads) to which this message belongs. */
    @path thread_id: string,

    /** The ID of the message to retrieve. */
    @path message_id: string,
  ): MessageObject | ErrorResponse;

  @route("{message_id}")
  @post
  @operationId("modifyMessage")
  @tag("Assistants")
  @summary("Modifies a message.")
  modifyMessage(
    @header accept: "application/json",

    /** The ID of the thread to which this message belongs. */
    @path thread_id: string,

    /** The ID of the message to modify. */
    @path message_id: string,

    @body requestBody: ModifyMessageRequest,
  ): MessageObject | ErrorResponse;

  @route("{message_id}")
  @delete
  @operationId("deleteMessage")
  @tag("Assistants")
  @summary("Deletes a message.")
  deleteMessage(
    @header accept: "application/json",

    /** The ID of the thread to which this message belongs. */
    @path thread_id: string,

    /** The ID of the message to delete. */
    @path message_id: string,
  ): DeleteMessageResponse | ErrorResponse;
}
