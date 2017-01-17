// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: api_v2.proto
// Original file comments:
// Copyright 2015 ThoughtWorks, Inc.
//
// This file is part of gauge-proto.
//
// gauge-proto is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// gauge-proto is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with gauge-proto.  If not, see <http://www.gnu.org/licenses/>.
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Gauge.Messages {
  /// <summary>
  ///  Define the gRPC service
  /// </summary>
  public static class Execution
  {
    static readonly string __ServiceName = "gauge.messages.Execution";

    static readonly Marshaller<global::Gauge.Messages.ExecutionRequest> __Marshaller_ExecutionRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gauge.Messages.ExecutionRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Gauge.Messages.ExecutionResponse> __Marshaller_ExecutionResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gauge.Messages.ExecutionResponse.Parser.ParseFrom);

    static readonly Method<global::Gauge.Messages.ExecutionRequest, global::Gauge.Messages.ExecutionResponse> __Method_execute = new Method<global::Gauge.Messages.ExecutionRequest, global::Gauge.Messages.ExecutionResponse>(
        MethodType.ServerStreaming,
        __ServiceName,
        "execute",
        __Marshaller_ExecutionRequest,
        __Marshaller_ExecutionResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Gauge.Messages.ApiV2Reflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Execution</summary>
    public abstract class ExecutionBase
    {
      /// <summary>
      ///  Bind RPC method
      /// </summary>
      public virtual global::System.Threading.Tasks.Task execute(global::Gauge.Messages.ExecutionRequest request, IServerStreamWriter<global::Gauge.Messages.ExecutionResponse> responseStream, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Execution</summary>
    public class ExecutionClient : ClientBase<ExecutionClient>
    {
      /// <summary>Creates a new client for Execution</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ExecutionClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Execution that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ExecutionClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ExecutionClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ExecutionClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Bind RPC method
      /// </summary>
      public virtual AsyncServerStreamingCall<global::Gauge.Messages.ExecutionResponse> execute(global::Gauge.Messages.ExecutionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return execute(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Bind RPC method
      /// </summary>
      public virtual AsyncServerStreamingCall<global::Gauge.Messages.ExecutionResponse> execute(global::Gauge.Messages.ExecutionRequest request, CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_execute, null, options, request);
      }
      protected override ExecutionClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ExecutionClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ExecutionBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_execute, serviceImpl.execute).Build();
    }

  }
}
#endregion
