// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/loan.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GSC_BackEnd_TP.Protos {
  public static partial class ProtoLoanService
  {
    static readonly string __ServiceName = "ProtoLoanService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GSC_BackEnd_TP.Protos.NewLoan> __Marshaller_NewLoan = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GSC_BackEnd_TP.Protos.NewLoan.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GSC_BackEnd_TP.Protos.Response> __Marshaller_Response = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GSC_BackEnd_TP.Protos.Response.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GSC_BackEnd_TP.Protos.LoanToClose> __Marshaller_LoanToClose = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GSC_BackEnd_TP.Protos.LoanToClose.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GSC_BackEnd_TP.Protos.PendingLoans> __Marshaller_PendingLoans = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GSC_BackEnd_TP.Protos.PendingLoans.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GSC_BackEnd_TP.Protos.NewLoan, global::GSC_BackEnd_TP.Protos.Response> __Method_CreateLoan = new grpc::Method<global::GSC_BackEnd_TP.Protos.NewLoan, global::GSC_BackEnd_TP.Protos.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateLoan",
        __Marshaller_NewLoan,
        __Marshaller_Response);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GSC_BackEnd_TP.Protos.LoanToClose, global::GSC_BackEnd_TP.Protos.Response> __Method_CloseLoan = new grpc::Method<global::GSC_BackEnd_TP.Protos.LoanToClose, global::GSC_BackEnd_TP.Protos.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CloseLoan",
        __Marshaller_LoanToClose,
        __Marshaller_Response);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GSC_BackEnd_TP.Protos.PendingLoans> __Method_GetPendingLoans = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GSC_BackEnd_TP.Protos.PendingLoans>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPendingLoans",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_PendingLoans);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GSC_BackEnd_TP.Protos.LoanReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProtoLoanService</summary>
    [grpc::BindServiceMethod(typeof(ProtoLoanService), "BindService")]
    public abstract partial class ProtoLoanServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GSC_BackEnd_TP.Protos.Response> CreateLoan(global::GSC_BackEnd_TP.Protos.NewLoan request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GSC_BackEnd_TP.Protos.Response> CloseLoan(global::GSC_BackEnd_TP.Protos.LoanToClose request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GSC_BackEnd_TP.Protos.PendingLoans> GetPendingLoans(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ProtoLoanService</summary>
    public partial class ProtoLoanServiceClient : grpc::ClientBase<ProtoLoanServiceClient>
    {
      /// <summary>Creates a new client for ProtoLoanService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProtoLoanServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProtoLoanService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProtoLoanServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProtoLoanServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProtoLoanServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GSC_BackEnd_TP.Protos.Response CreateLoan(global::GSC_BackEnd_TP.Protos.NewLoan request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateLoan(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GSC_BackEnd_TP.Protos.Response CreateLoan(global::GSC_BackEnd_TP.Protos.NewLoan request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateLoan, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GSC_BackEnd_TP.Protos.Response> CreateLoanAsync(global::GSC_BackEnd_TP.Protos.NewLoan request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateLoanAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GSC_BackEnd_TP.Protos.Response> CreateLoanAsync(global::GSC_BackEnd_TP.Protos.NewLoan request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateLoan, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GSC_BackEnd_TP.Protos.Response CloseLoan(global::GSC_BackEnd_TP.Protos.LoanToClose request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CloseLoan(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GSC_BackEnd_TP.Protos.Response CloseLoan(global::GSC_BackEnd_TP.Protos.LoanToClose request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CloseLoan, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GSC_BackEnd_TP.Protos.Response> CloseLoanAsync(global::GSC_BackEnd_TP.Protos.LoanToClose request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CloseLoanAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GSC_BackEnd_TP.Protos.Response> CloseLoanAsync(global::GSC_BackEnd_TP.Protos.LoanToClose request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CloseLoan, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GSC_BackEnd_TP.Protos.PendingLoans GetPendingLoans(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPendingLoans(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GSC_BackEnd_TP.Protos.PendingLoans GetPendingLoans(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPendingLoans, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GSC_BackEnd_TP.Protos.PendingLoans> GetPendingLoansAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPendingLoansAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GSC_BackEnd_TP.Protos.PendingLoans> GetPendingLoansAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPendingLoans, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ProtoLoanServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProtoLoanServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProtoLoanServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateLoan, serviceImpl.CreateLoan)
          .AddMethod(__Method_CloseLoan, serviceImpl.CloseLoan)
          .AddMethod(__Method_GetPendingLoans, serviceImpl.GetPendingLoans).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProtoLoanServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateLoan, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GSC_BackEnd_TP.Protos.NewLoan, global::GSC_BackEnd_TP.Protos.Response>(serviceImpl.CreateLoan));
      serviceBinder.AddMethod(__Method_CloseLoan, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GSC_BackEnd_TP.Protos.LoanToClose, global::GSC_BackEnd_TP.Protos.Response>(serviceImpl.CloseLoan));
      serviceBinder.AddMethod(__Method_GetPendingLoans, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::GSC_BackEnd_TP.Protos.PendingLoans>(serviceImpl.GetPendingLoans));
    }

  }
}
#endregion
