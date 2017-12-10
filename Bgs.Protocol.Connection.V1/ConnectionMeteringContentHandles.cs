using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Connection.V1
{
	[DebuggerNonUserCode]
	public sealed class ConnectionMeteringContentHandles : IMessage<ConnectionMeteringContentHandles>, IEquatable<ConnectionMeteringContentHandles>, IDeepCloneable<ConnectionMeteringContentHandles>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ConnectionMeteringContentHandles.__c __9 = new ConnectionMeteringContentHandles.__c();

			internal ConnectionMeteringContentHandles cctor>b__24_0()
			{
				return new ConnectionMeteringContentHandles();
			}
		}

		private static readonly MessageParser<ConnectionMeteringContentHandles> _parser = new MessageParser<ConnectionMeteringContentHandles>(new Func<ConnectionMeteringContentHandles>(ConnectionMeteringContentHandles.__c.__9.<.cctor>b__24_0));

		public const int ContentHandleFieldNumber = 1;

		private static readonly FieldCodec<ContentHandle> _repeated_contentHandle_codec = FieldCodec.ForMessage<ContentHandle>(10u, Bgs.Protocol.ContentHandle.Parser);

		private readonly RepeatedField<ContentHandle> contentHandle_ = new RepeatedField<ContentHandle>();

		public static MessageParser<ConnectionMeteringContentHandles> Parser
		{
			get
			{
				return ConnectionMeteringContentHandles._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectionMeteringContentHandles.Descriptor;
			}
		}

		public RepeatedField<ContentHandle> ContentHandle
		{
			get
			{
				return this.contentHandle_;
			}
		}

		public ConnectionMeteringContentHandles()
		{
		}

		public ConnectionMeteringContentHandles(ConnectionMeteringContentHandles other) : this()
		{
			while (true)
			{
				IL_43:
				uint arg_2B_0 = 805634705u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2B_0 ^ 18227793u)) % 3u)
					{
					case 0u:
						goto IL_43;
					case 1u:
						this.contentHandle_ = other.contentHandle_.Clone();
						arg_2B_0 = (num * 993386224u ^ 3821718727u);
						continue;
					}
					return;
				}
			}
		}

		public ConnectionMeteringContentHandles Clone()
		{
			return new ConnectionMeteringContentHandles(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectionMeteringContentHandles);
		}

		public bool Equals(ConnectionMeteringContentHandles other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ -1861139250) % 7)
				{
				case 0:
					goto IL_7A;
				case 1:
					return false;
				case 2:
					arg_48_0 = (this.contentHandle_.Equals(other.contentHandle_) ? -1974796784 : -1213030504);
					continue;
				case 3:
					return false;
				case 4:
					return true;
				case 5:
					goto IL_12;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -1501355481;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -300635687 : -938899260);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ ConnectionMeteringContentHandles.smethod_0(this.contentHandle_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.contentHandle_.WriteTo(output, ConnectionMeteringContentHandles._repeated_contentHandle_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.contentHandle_.CalculateSize(ConnectionMeteringContentHandles._repeated_contentHandle_codec);
		}

		public void MergeFrom(ConnectionMeteringContentHandles other)
		{
			if (other == null)
			{
				return;
			}
			this.contentHandle_.Add(other.contentHandle_);
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_9B:
				uint num;
				uint arg_68_0 = ((num = input.ReadTag()) != 0u) ? 2004300352u : 562414307u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 1026528567u)) % 6u)
					{
					case 0u:
						arg_68_0 = 2004300352u;
						continue;
					case 1u:
						arg_68_0 = ((num != 10u) ? 477558627u : 817790408u);
						continue;
					case 3u:
						this.contentHandle_.AddEntriesFrom(input, ConnectionMeteringContentHandles._repeated_contentHandle_codec);
						arg_68_0 = 462478470u;
						continue;
					case 4u:
						input.SkipLastField();
						arg_68_0 = (num2 * 656091581u ^ 17420418u);
						continue;
					case 5u:
						goto IL_9B;
					}
					return;
				}
			}
		}

		static int smethod_0(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
