// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: api/backend.proto
// </auto-generated>
// Original file comments:
// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace OpenMatch {
  /// <summary>
  /// The Backent service implements APIs to generate matches and handle ticket assignments.
  /// </summary>
  public static partial class Backend
  {
    static readonly string __ServiceName = "openmatch.Backend";

    static readonly grpc::Marshaller<global::OpenMatch.FetchMatchesRequest> __Marshaller_openmatch_FetchMatchesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::OpenMatch.FetchMatchesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::OpenMatch.FetchMatchesResponse> __Marshaller_openmatch_FetchMatchesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::OpenMatch.FetchMatchesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::OpenMatch.AssignTicketsRequest> __Marshaller_openmatch_AssignTicketsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::OpenMatch.AssignTicketsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::OpenMatch.AssignTicketsResponse> __Marshaller_openmatch_AssignTicketsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::OpenMatch.AssignTicketsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::OpenMatch.FetchMatchesRequest, global::OpenMatch.FetchMatchesResponse> __Method_FetchMatches = new grpc::Method<global::OpenMatch.FetchMatchesRequest, global::OpenMatch.FetchMatchesResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "FetchMatches",
        __Marshaller_openmatch_FetchMatchesRequest,
        __Marshaller_openmatch_FetchMatchesResponse);

    static readonly grpc::Method<global::OpenMatch.AssignTicketsRequest, global::OpenMatch.AssignTicketsResponse> __Method_AssignTickets = new grpc::Method<global::OpenMatch.AssignTicketsRequest, global::OpenMatch.AssignTicketsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AssignTickets",
        __Marshaller_openmatch_AssignTicketsRequest,
        __Marshaller_openmatch_AssignTicketsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::OpenMatch.BackendReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Backend</summary>
    [grpc::BindServiceMethod(typeof(Backend), "BindService")]
    public abstract partial class BackendBase
    {
      /// <summary>
      /// FetchMatches triggers a MatchFunction with the specified MatchProfiles, while each MatchProfile 
      /// returns a set of match proposals. FetchMatches method streams the results back to the caller.
      /// FetchMatches immediately returns an error if it encounters any execution failures.
      ///   - If the synchronizer is enabled, FetchMatch will then call the synchronizer to deduplicate proposals with overlapped tickets.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task FetchMatches(global::OpenMatch.FetchMatchesRequest request, grpc::IServerStreamWriter<global::OpenMatch.FetchMatchesResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// AssignTickets overwrites the Assignment field of the input TicketIds.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::OpenMatch.AssignTicketsResponse> AssignTickets(global::OpenMatch.AssignTicketsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Backend</summary>
    public partial class BackendClient : grpc::ClientBase<BackendClient>
    {
      /// <summary>Creates a new client for Backend</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BackendClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Backend that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BackendClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BackendClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BackendClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// FetchMatches triggers a MatchFunction with the specified MatchProfiles, while each MatchProfile 
      /// returns a set of match proposals. FetchMatches method streams the results back to the caller.
      /// FetchMatches immediately returns an error if it encounters any execution failures.
      ///   - If the synchronizer is enabled, FetchMatch will then call the synchronizer to deduplicate proposals with overlapped tickets.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::OpenMatch.FetchMatchesResponse> FetchMatches(global::OpenMatch.FetchMatchesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchMatches(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// FetchMatches triggers a MatchFunction with the specified MatchProfiles, while each MatchProfile 
      /// returns a set of match proposals. FetchMatches method streams the results back to the caller.
      /// FetchMatches immediately returns an error if it encounters any execution failures.
      ///   - If the synchronizer is enabled, FetchMatch will then call the synchronizer to deduplicate proposals with overlapped tickets.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::OpenMatch.FetchMatchesResponse> FetchMatches(global::OpenMatch.FetchMatchesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_FetchMatches, null, options, request);
      }
      /// <summary>
      /// AssignTickets overwrites the Assignment field of the input TicketIds.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::OpenMatch.AssignTicketsResponse AssignTickets(global::OpenMatch.AssignTicketsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AssignTickets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// AssignTickets overwrites the Assignment field of the input TicketIds.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::OpenMatch.AssignTicketsResponse AssignTickets(global::OpenMatch.AssignTicketsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AssignTickets, null, options, request);
      }
      /// <summary>
      /// AssignTickets overwrites the Assignment field of the input TicketIds.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::OpenMatch.AssignTicketsResponse> AssignTicketsAsync(global::OpenMatch.AssignTicketsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AssignTicketsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// AssignTickets overwrites the Assignment field of the input TicketIds.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::OpenMatch.AssignTicketsResponse> AssignTicketsAsync(global::OpenMatch.AssignTicketsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AssignTickets, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override BackendClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BackendClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(BackendBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_FetchMatches, serviceImpl.FetchMatches)
          .AddMethod(__Method_AssignTickets, serviceImpl.AssignTickets).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BackendBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_FetchMatches, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::OpenMatch.FetchMatchesRequest, global::OpenMatch.FetchMatchesResponse>(serviceImpl.FetchMatches));
      serviceBinder.AddMethod(__Method_AssignTickets, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::OpenMatch.AssignTicketsRequest, global::OpenMatch.AssignTicketsResponse>(serviceImpl.AssignTickets));
    }

  }
}
#endregion
