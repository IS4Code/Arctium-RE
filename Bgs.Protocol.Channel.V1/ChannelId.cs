using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class ChannelId : IMessage<ChannelId>, IEquatable<ChannelId>, IDeepCloneable<ChannelId>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChannelId.__c __9 = new ChannelId.__c();

			internal ChannelId cctor>b__34_0()
			{
				return new ChannelId();
			}
		}

		private static readonly MessageParser<ChannelId> _parser = new MessageParser<ChannelId>(new Func<ChannelId>(ChannelId.__c.__9.<.cctor>b__34_0));

		public const int TypeFieldNumber = 1;

		private uint type_;

		public const int HostFieldNumber = 2;

		private ProcessId host_;

		public const int IdFieldNumber = 3;

		private uint id_;

		public static MessageParser<ChannelId> Parser
		{
			get
			{
				return ChannelId._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelId.Descriptor;
			}
		}

		public uint Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		public ChannelId()
		{
		}

		public ChannelId(ChannelId other) : this()
		{
			this.type_ = other.type_;
			this.Host = ((other.host_ != null) ? other.Host.Clone() : null);
			this.id_ = other.id_;
		}

		public ChannelId Clone()
		{
			return new ChannelId(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelId);
		}

		public bool Equals(ChannelId other)
		{
			if (other == null)
			{
				goto IL_41;
			}
			goto IL_DF;
			int arg_99_0;
			while (true)
			{
				IL_94:
				switch ((arg_99_0 ^ -1356106063) % 11)
				{
				case 0:
					arg_99_0 = ((this.Type != other.Type) ? -1799962866 : -1789347240);
					continue;
				case 1:
					arg_99_0 = ((this.Id == other.Id) ? -1975440485 : -1063779756);
					continue;
				case 2:
					goto IL_41;
				case 3:
					arg_99_0 = (ChannelId.smethod_0(this.Host, other.Host) ? -229404485 : -1938785813);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return true;
				case 7:
					return false;
				case 9:
					goto IL_DF;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_41:
			arg_99_0 = -895520380;
			goto IL_94;
			IL_DF:
			arg_99_0 = ((other == this) ? -1644978249 : -771296);
			goto IL_94;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_104:
				uint arg_D8_0 = 862454419u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_D8_0 ^ 730202337u)) % 8u)
					{
					case 0u:
						num ^= this.Host.GetHashCode();
						arg_D8_0 = (num2 * 3216021693u ^ 1490941584u);
						continue;
					case 1u:
						arg_D8_0 = ((this.Id != 0u) ? 1355644454u : 1352777933u);
						continue;
					case 2u:
						arg_D8_0 = (((this.Type == 0u) ? 135208347u : 972017152u) ^ num2 * 2022687418u);
						continue;
					case 3u:
						goto IL_104;
					case 5u:
						num ^= this.Type.GetHashCode();
						arg_D8_0 = (num2 * 1782291565u ^ 413286878u);
						continue;
					case 6u:
						arg_D8_0 = ((this.host_ != null) ? 491064321u : 1870166000u);
						continue;
					case 7u:
						num ^= this.Id.GetHashCode();
						arg_D8_0 = (num2 * 4140198779u ^ 1133303376u);
						continue;
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
			if (this.Type != 0u)
			{
				goto IL_DC;
			}
			goto IL_12A;
			uint arg_E6_0;
			while (true)
			{
				IL_E1:
				uint num;
				switch ((num = (arg_E6_0 ^ 645334621u)) % 10u)
				{
				case 0u:
					goto IL_DC;
				case 1u:
					output.WriteRawTag(29);
					arg_E6_0 = (num * 25663557u ^ 1822911300u);
					continue;
				case 2u:
					output.WriteFixed32(this.Id);
					arg_E6_0 = (num * 2384463787u ^ 1865705265u);
					continue;
				case 3u:
					output.WriteRawTag(18);
					arg_E6_0 = (num * 1078558299u ^ 3172768798u);
					continue;
				case 4u:
					output.WriteMessage(this.Host);
					arg_E6_0 = (num * 2390927234u ^ 3675076490u);
					continue;
				case 5u:
					arg_E6_0 = ((this.Id == 0u) ? 16176617u : 410801280u);
					continue;
				case 6u:
					goto IL_12A;
				case 7u:
					output.WriteRawTag(8);
					arg_E6_0 = (num * 104707172u ^ 1660984688u);
					continue;
				case 9u:
					output.WriteUInt32(this.Type);
					arg_E6_0 = (num * 541826154u ^ 2440987181u);
					continue;
				}
				break;
			}
			return;
			IL_DC:
			arg_E6_0 = 1121908196u;
			goto IL_E1;
			IL_12A:
			arg_E6_0 = ((this.host_ != null) ? 432594208u : 99703762u);
			goto IL_E1;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_F5:
				uint arg_C9_0 = 4119100922u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C9_0 ^ 2486802135u)) % 8u)
					{
					case 1u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Type);
						arg_C9_0 = (num2 * 2744624564u ^ 4250275220u);
						continue;
					case 2u:
						num += 5;
						arg_C9_0 = (num2 * 3325943629u ^ 2513488101u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
						arg_C9_0 = (num2 * 3349484198u ^ 1108509547u);
						continue;
					case 4u:
						goto IL_F5;
					case 5u:
						arg_C9_0 = (((this.Type != 0u) ? 266003368u : 407062062u) ^ num2 * 1168509638u);
						continue;
					case 6u:
						arg_C9_0 = ((this.Id != 0u) ? 3151260565u : 2335924799u);
						continue;
					case 7u:
						arg_C9_0 = ((this.host_ != null) ? 4020777212u : 2797946505u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ChannelId other)
		{
			if (other == null)
			{
				goto IL_75;
			}
			goto IL_146;
			uint arg_FE_0;
			while (true)
			{
				IL_F9:
				uint num;
				switch ((num = (arg_FE_0 ^ 3897626590u)) % 11u)
				{
				case 0u:
					arg_FE_0 = (((this.host_ == null) ? 4184165751u : 3320284482u) ^ num * 2778159608u);
					continue;
				case 1u:
					goto IL_146;
				case 2u:
					arg_FE_0 = ((other.Id == 0u) ? 4139134554u : 3519276534u);
					continue;
				case 3u:
					return;
				case 4u:
					this.Type = other.Type;
					arg_FE_0 = (num * 1693337224u ^ 3849378217u);
					continue;
				case 5u:
					this.host_ = new ProcessId();
					arg_FE_0 = (num * 2030024082u ^ 3867239720u);
					continue;
				case 6u:
					goto IL_75;
				case 8u:
					arg_FE_0 = ((other.host_ != null) ? 2316211571u : 3226900129u);
					continue;
				case 9u:
					this.Id = other.Id;
					arg_FE_0 = (num * 2478183901u ^ 3352249042u);
					continue;
				case 10u:
					this.Host.MergeFrom(other.Host);
					arg_FE_0 = 3226900129u;
					continue;
				}
				break;
			}
			return;
			IL_75:
			arg_FE_0 = 2692799248u;
			goto IL_F9;
			IL_146:
			arg_FE_0 = ((other.Type == 0u) ? 3765460713u : 3945575350u);
			goto IL_F9;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_199:
				uint num;
				uint arg_145_0 = ((num = input.ReadTag()) == 0u) ? 2466564990u : 2225669676u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_145_0 ^ 3474758463u)) % 14u)
					{
					case 0u:
						arg_145_0 = 2225669676u;
						continue;
					case 1u:
						arg_145_0 = (((num != 29u) ? 3994887371u : 3763986791u) ^ num2 * 2034259621u);
						continue;
					case 2u:
						arg_145_0 = (((num != 18u) ? 2916157896u : 2992481201u) ^ num2 * 1213961647u);
						continue;
					case 3u:
						this.Id = input.ReadFixed32();
						arg_145_0 = 3892108879u;
						continue;
					case 4u:
						arg_145_0 = ((this.host_ != null) ? 2902946160u : 2780840912u);
						continue;
					case 5u:
						input.ReadMessage(this.host_);
						arg_145_0 = 3479759777u;
						continue;
					case 6u:
						arg_145_0 = (num2 * 2379162471u ^ 162958221u);
						continue;
					case 8u:
						goto IL_199;
					case 9u:
						input.SkipLastField();
						arg_145_0 = (num2 * 514804140u ^ 2519546165u);
						continue;
					case 10u:
						this.Type = input.ReadUInt32();
						arg_145_0 = 3892108879u;
						continue;
					case 11u:
						this.host_ = new ProcessId();
						arg_145_0 = (num2 * 3721039081u ^ 607999223u);
						continue;
					case 12u:
						arg_145_0 = (num2 * 1212441014u ^ 748105755u);
						continue;
					case 13u:
						arg_145_0 = ((num != 8u) ? 4017827843u : 3658350701u);
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}
	}
}
