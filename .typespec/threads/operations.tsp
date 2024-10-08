import "@typespec/http";
import "@typespec/openapi";

import "../common";
import "./models.tsp";

using TypeSpec.Http;
using TypeSpec.OpenAPI;

namespace OpenAI;

@route("/threads")
interface Threads {
  @post
  @operationId("createThread")
  @tag("Assistants")
  @summary("Create a thread.")
  createThread(
    @header accept: "application/json",
    @body requestBody: CreateThreadRequest,
  ): ThreadObject | ErrorResponse;

  @route("{thread_id}")
  @get
  @operationId("getThread")
  @tag("Assistants")
  @summary("Retrieves a thread.")
  getThread(
    @header accept: "application/json",

    /** The ID of the thread to retrieve. */
    @path thread_id: string,
  ): ThreadObject | ErrorResponse;

  @route("{thread_id}")
  @post
  @operationId("modifyThread")
  @tag("Assistants")
  @summary("Modifies a thread.")
  modifyThread(
    @header accept: "application/json",

    /** The ID of the thread to modify. Only the `metadata` can be modified. */
    @path thread_id: string,

    @body requestBody: ModifyThreadRequest,
  ): ThreadObject | ErrorResponse;

  @route("{thread_id}")
  @delete
  @operationId("deleteThread")
  @tag("Assistants")
  @summary("Delete a thread.")
  deleteThread(
    @header accept: "application/json",

    /** The ID of the thread to delete. */
    @path thread_id: string,
  ): DeleteThreadResponse | ErrorResponse;
}
