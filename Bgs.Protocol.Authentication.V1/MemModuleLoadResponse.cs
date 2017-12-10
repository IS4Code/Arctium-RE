using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class MemModuleLoadResponse : IMessage<MemModuleLoadResponse>, IEquatable<MemModuleLoadResponse>, IDeepCloneable<MemModuleLoadResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly MemModuleLoadResponse.__c __9 = new MemModuleLoadResponse.__c();

			internal MemModuleLoadResponse cctor>b__24_0()
			{
				return new MemModuleLoadResponse();
			}
		}

		private static readonly MessageParser<MemModuleLoadResponse> _parser = new MessageParser<MemModuleLoadResponse>(new Func<MemModuleLoadResponse>(MemModuleLoadResponse.__c.__9.<.cctor>b__24_0));

		public const int DataFieldNumber = 1;

		private ByteString data_ = ByteString.Empty;

		public static MessageParser<MemModuleLoadResponse> Parser
		{
			get
			{
				return MemModuleLoadResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[14];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemModuleLoadResponse.Descriptor;
			}
		}

		public ByteString Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public MemModuleLoadResponse()
		{
		}

		public MemModuleLoadResponse(MemModuleLoadResponse other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 2225156761u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 3291385310u)) % 3u)
					{
					case 1u:
						this.data_ = other.data_;
						arg_26_0 = (num * 612533839u ^ 2772005066u);
						continue;
					case 2u:
						goto IL_3E;
					}
					return;
				}
			}
		}

		public MemModuleLoadResponse Clone()
		{
			return new MemModuleLoadResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as MemModuleLoadResponse);
		}

		public bool Equals(MemModuleLoadResponse other)
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
				switch ((arg_48_0 ^ -1659638366) % 7)
				{
				case 0:
					goto IL_7A;
				case 1:
					arg_48_0 = ((this.Data != other.Data) ? -1755534720 : -868457710);
					continue;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					goto IL_12;
				case 6:
					return true;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -2062170989;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? -435506360 : -958129923);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ MemModuleLoadResponse.smethod_0(this.Data);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(10);
			output.WriteBytes(this.Data);
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeBytesSize(this.Data));
		}

		public void MergeFrom(MemModuleLoadResponse other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 639490967u)) % 5u)
				{
				case 1u:
					goto IL_63;
				case 2u:
					this.Data = other.Data;
					arg_37_0 = (num * 1114774024u ^ 1098709182u);
					continue;
				case 3u:
					return;
				case 4u:
					goto IL_12;
				}
				break;
			}
			return;
			IL_12:
			arg_37_0 = 806021679u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Data.Length == 0) ? 1761134990u : 1250275633u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A9:
				uint num;
				uint arg_72_0 = ((num = input.ReadTag()) == 0u) ? 1131039098u : 1382621794u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_72_0 ^ 297379284u)) % 7u)
					{
					case 0u:
						arg_72_0 = (num2 * 71235794u ^ 1310614366u);
						continue;
					case 1u:
						arg_72_0 = ((num != 10u) ? 614668152u : 91625337u);
						continue;
					case 2u:
						input.SkipLastField();
						arg_72_0 = (num2 * 2628716216u ^ 3162790274u);
						continue;
					case 3u:
						this.Data = input.ReadBytes();
						arg_72_0 = 2054947986u;
						continue;
					case 4u:
						goto IL_A9;
					case 6u:
						arg_72_0 = 1382621794u;
						continue;
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
