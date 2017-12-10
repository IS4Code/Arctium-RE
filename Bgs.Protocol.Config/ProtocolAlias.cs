using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Config
{
	[DebuggerNonUserCode]
	public sealed class ProtocolAlias : IMessage<ProtocolAlias>, IEquatable<ProtocolAlias>, IDeepCloneable<ProtocolAlias>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ProtocolAlias.__c __9 = new ProtocolAlias.__c();

			internal ProtocolAlias cctor>b__29_0()
			{
				return new ProtocolAlias();
			}
		}

		private static readonly MessageParser<ProtocolAlias> _parser = new MessageParser<ProtocolAlias>(new Func<ProtocolAlias>(ProtocolAlias.__c.__9.<.cctor>b__29_0));

		public const int ServerServiceNameFieldNumber = 1;

		private string serverServiceName_ = "";

		public const int ClientServiceNameFieldNumber = 2;

		private string clientServiceName_ = "";

		public static MessageParser<ProtocolAlias> Parser
		{
			get
			{
				return ProtocolAlias._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcConfigReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProtocolAlias.Descriptor;
			}
		}

		public string ServerServiceName
		{
			get
			{
				return this.serverServiceName_;
			}
			set
			{
				this.serverServiceName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public string ClientServiceName
		{
			get
			{
				return this.clientServiceName_;
			}
			set
			{
				this.clientServiceName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public ProtocolAlias()
		{
		}

		public ProtocolAlias(ProtocolAlias other) : this()
		{
			while (true)
			{
				IL_4A:
				uint arg_32_0 = 3918313472u;
				while (true)
				{
					uint num;
					switch ((num = (arg_32_0 ^ 3914080008u)) % 3u)
					{
					case 0u:
						goto IL_4A;
					case 1u:
						this.serverServiceName_ = other.serverServiceName_;
						this.clientServiceName_ = other.clientServiceName_;
						arg_32_0 = (num * 3281380951u ^ 1297065091u);
						continue;
					}
					return;
				}
			}
		}

		public ProtocolAlias Clone()
		{
			return new ProtocolAlias(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ProtocolAlias);
		}

		public bool Equals(ProtocolAlias other)
		{
			if (other == null)
			{
				goto IL_41;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ -633517360) % 9)
				{
				case 0:
					return true;
				case 1:
					goto IL_B5;
				case 2:
					arg_77_0 = (ProtocolAlias.smethod_0(this.ServerServiceName, other.ServerServiceName) ? -516080716 : -1086625289);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					goto IL_41;
				case 7:
					arg_77_0 = ((!ProtocolAlias.smethod_0(this.ClientServiceName, other.ClientServiceName)) ? -771582068 : -1817700418);
					continue;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_41:
			arg_77_0 = -286104845;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other == this) ? -1892792212 : -1634641742);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			return 1 ^ ProtocolAlias.smethod_1(this.ServerServiceName) ^ ProtocolAlias.smethod_1(this.ClientServiceName);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(10);
			output.WriteString(this.ServerServiceName);
			while (true)
			{
				IL_48:
				uint arg_30_0 = 4077820895u;
				while (true)
				{
					uint num;
					switch ((num = (arg_30_0 ^ 2735186285u)) % 3u)
					{
					case 0u:
						goto IL_48;
					case 1u:
						output.WriteRawTag(18);
						arg_30_0 = (num * 169533437u ^ 3563548898u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			output.WriteString(this.ClientServiceName);
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeStringSize(this.ServerServiceName)) + (1 + CodedOutputStream.ComputeStringSize(this.ClientServiceName));
		}

		public void MergeFrom(ProtocolAlias other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B2;
			uint arg_7B_0;
			while (true)
			{
				IL_76:
				uint num;
				switch ((num = (arg_7B_0 ^ 1110768161u)) % 7u)
				{
				case 0u:
					this.ServerServiceName = other.ServerServiceName;
					arg_7B_0 = (num * 3160359261u ^ 3249303661u);
					continue;
				case 1u:
					goto IL_B2;
				case 3u:
					this.ClientServiceName = other.ClientServiceName;
					arg_7B_0 = (num * 4117471774u ^ 3660073377u);
					continue;
				case 4u:
					arg_7B_0 = ((ProtocolAlias.smethod_2(other.ClientServiceName) == 0) ? 2042397099u : 1469754250u);
					continue;
				case 5u:
					goto IL_15;
				case 6u:
					return;
				}
				break;
			}
			return;
			IL_15:
			arg_7B_0 = 1702317201u;
			goto IL_76;
			IL_B2:
			arg_7B_0 = ((ProtocolAlias.smethod_2(other.ServerServiceName) == 0) ? 1600124855u : 437771651u);
			goto IL_76;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_DA:
				uint num;
				uint arg_9F_0 = ((num = input.ReadTag()) != 0u) ? 2462312898u : 2163840056u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_9F_0 ^ 3872662923u)) % 8u)
					{
					case 0u:
						input.SkipLastField();
						arg_9F_0 = (num2 * 2812179537u ^ 3346822767u);
						continue;
					case 1u:
						arg_9F_0 = ((num != 10u) ? 3397476253u : 4184542961u);
						continue;
					case 2u:
						this.ServerServiceName = input.ReadString();
						arg_9F_0 = 3456930159u;
						continue;
					case 4u:
						goto IL_DA;
					case 5u:
						arg_9F_0 = 2462312898u;
						continue;
					case 6u:
						arg_9F_0 = (((num == 18u) ? 3407624064u : 3267351519u) ^ num2 * 411174974u);
						continue;
					case 7u:
						this.ClientServiceName = input.ReadString();
						arg_9F_0 = 3456930159u;
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}
	}
}
