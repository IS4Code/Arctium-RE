using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Connection.V1
{
	[DebuggerNonUserCode]
	public sealed class DisconnectNotification : IMessage<DisconnectNotification>, IEquatable<DisconnectNotification>, IDeepCloneable<DisconnectNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly DisconnectNotification.__c __9 = new DisconnectNotification.__c();

			internal DisconnectNotification cctor>b__29_0()
			{
				return new DisconnectNotification();
			}
		}

		private static readonly MessageParser<DisconnectNotification> _parser = new MessageParser<DisconnectNotification>(new Func<DisconnectNotification>(DisconnectNotification.__c.__9.<.cctor>b__29_0));

		public const int ErrorCodeFieldNumber = 1;

		private uint errorCode_;

		public const int ReasonFieldNumber = 2;

		private string reason_ = "";

		public static MessageParser<DisconnectNotification> Parser
		{
			get
			{
				return DisconnectNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DisconnectNotification.Descriptor;
			}
		}

		public uint ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		public string Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public DisconnectNotification()
		{
		}

		public DisconnectNotification(DisconnectNotification other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.reason_ = other.reason_;
		}

		public DisconnectNotification Clone()
		{
			return new DisconnectNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as DisconnectNotification);
		}

		public bool Equals(DisconnectNotification other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 1962082648) % 9)
				{
				case 0:
					arg_72_0 = (DisconnectNotification.smethod_0(this.Reason, other.Reason) ? 1193456763 : 1985649246);
					continue;
				case 1:
					return true;
				case 3:
					arg_72_0 = ((this.ErrorCode != other.ErrorCode) ? 491538400 : 587253656);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					goto IL_B0;
				case 7:
					return false;
				case 8:
					goto IL_15;
				}
				break;
			}
			return true;
			IL_15:
			arg_72_0 = 1053876395;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? 1022963011 : 1330329338);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_95:
				uint arg_75_0 = 270620356u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_75_0 ^ 682722254u)) % 5u)
					{
					case 0u:
						arg_75_0 = (((this.Reason.Length == 0) ? 2125452037u : 1981747327u) ^ num2 * 443203998u);
						continue;
					case 1u:
						num ^= this.Reason.GetHashCode();
						arg_75_0 = (num2 * 2548730569u ^ 1645213132u);
						continue;
					case 3u:
						num ^= this.ErrorCode.GetHashCode();
						arg_75_0 = (num2 * 2074297616u ^ 134810843u);
						continue;
					case 4u:
						goto IL_95;
					}
					return num;
				}
			}
			return num;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(8);
			while (true)
			{
				IL_9B:
				uint arg_7B_0 = 1120006891u;
				while (true)
				{
					uint num;
					switch ((num = (arg_7B_0 ^ 1800966462u)) % 5u)
					{
					case 0u:
						arg_7B_0 = (((DisconnectNotification.smethod_1(this.Reason) == 0) ? 114186832u : 1626263313u) ^ num * 4275512467u);
						continue;
					case 1u:
						output.WriteUInt32(this.ErrorCode);
						arg_7B_0 = (num * 4027297186u ^ 3135366442u);
						continue;
					case 2u:
						goto IL_9B;
					case 3u:
						output.WriteRawTag(18);
						output.WriteString(this.Reason);
						arg_7B_0 = (num * 1154006875u ^ 1113089309u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_80:
				uint arg_64_0 = 666374123u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_64_0 ^ 1896924473u)) % 4u)
					{
					case 1u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Reason);
						arg_64_0 = (num2 * 2669438851u ^ 4188596162u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode);
						arg_64_0 = (((DisconnectNotification.smethod_1(this.Reason) != 0) ? 236975560u : 459307745u) ^ num2 * 2795989196u);
						continue;
					case 3u:
						goto IL_80;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(DisconnectNotification other)
		{
			if (other == null)
			{
				goto IL_71;
			}
			goto IL_B2;
			uint arg_7B_0;
			while (true)
			{
				IL_76:
				uint num;
				switch ((num = (arg_7B_0 ^ 1074202343u)) % 7u)
				{
				case 0u:
					goto IL_71;
				case 1u:
					arg_7B_0 = ((DisconnectNotification.smethod_1(other.Reason) == 0) ? 2133840753u : 889196001u);
					continue;
				case 2u:
					this.ErrorCode = other.ErrorCode;
					arg_7B_0 = (num * 2898430631u ^ 588046206u);
					continue;
				case 3u:
					goto IL_B2;
				case 5u:
					return;
				case 6u:
					this.Reason = other.Reason;
					arg_7B_0 = (num * 4213298707u ^ 2678916611u);
					continue;
				}
				break;
			}
			return;
			IL_71:
			arg_7B_0 = 902649751u;
			goto IL_76;
			IL_B2:
			arg_7B_0 = ((other.ErrorCode == 0u) ? 400785972u : 1211991361u);
			goto IL_76;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_103:
				uint num;
				uint arg_BF_0 = ((num = input.ReadTag()) != 0u) ? 3974100276u : 4155532086u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_BF_0 ^ 3294309292u)) % 10u)
					{
					case 0u:
						arg_BF_0 = 3974100276u;
						continue;
					case 1u:
						arg_BF_0 = (num2 * 110414325u ^ 2354991898u);
						continue;
					case 3u:
						goto IL_103;
					case 4u:
						arg_BF_0 = (num2 * 2812740999u ^ 4043488643u);
						continue;
					case 5u:
						this.Reason = input.ReadString();
						arg_BF_0 = 2841963811u;
						continue;
					case 6u:
						arg_BF_0 = ((num == 8u) ? 2883768193u : 3012595781u);
						continue;
					case 7u:
						arg_BF_0 = (((num != 18u) ? 2714126970u : 3496400841u) ^ num2 * 3615887382u);
						continue;
					case 8u:
						input.SkipLastField();
						arg_BF_0 = (num2 * 2285086398u ^ 2088334764u);
						continue;
					case 9u:
						this.ErrorCode = input.ReadUInt32();
						arg_BF_0 = 2867891993u;
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

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}
	}
}
