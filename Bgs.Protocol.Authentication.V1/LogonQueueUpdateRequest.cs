using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class LogonQueueUpdateRequest : IMessage<LogonQueueUpdateRequest>, IEquatable<LogonQueueUpdateRequest>, IDeepCloneable<LogonQueueUpdateRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly LogonQueueUpdateRequest.__c __9 = new LogonQueueUpdateRequest.__c();

			internal LogonQueueUpdateRequest cctor>b__34_0()
			{
				return new LogonQueueUpdateRequest();
			}
		}

		private static readonly MessageParser<LogonQueueUpdateRequest> _parser = new MessageParser<LogonQueueUpdateRequest>(new Func<LogonQueueUpdateRequest>(LogonQueueUpdateRequest.__c.__9.<.cctor>b__34_0));

		public const int PositionFieldNumber = 1;

		private uint position_;

		public const int EstimatedTimeFieldNumber = 2;

		private ulong estimatedTime_;

		public const int EtaDeviationInSecFieldNumber = 3;

		private ulong etaDeviationInSec_;

		public static MessageParser<LogonQueueUpdateRequest> Parser
		{
			get
			{
				return LogonQueueUpdateRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonQueueUpdateRequest.Descriptor;
			}
		}

		public uint Position
		{
			get
			{
				return this.position_;
			}
			set
			{
				this.position_ = value;
			}
		}

		public ulong EstimatedTime
		{
			get
			{
				return this.estimatedTime_;
			}
			set
			{
				this.estimatedTime_ = value;
			}
		}

		public ulong EtaDeviationInSec
		{
			get
			{
				return this.etaDeviationInSec_;
			}
			set
			{
				this.etaDeviationInSec_ = value;
			}
		}

		public LogonQueueUpdateRequest()
		{
		}

		public LogonQueueUpdateRequest(LogonQueueUpdateRequest other) : this()
		{
			while (true)
			{
				IL_69:
				uint arg_4D_0 = 2110764486u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4D_0 ^ 300864835u)) % 4u)
					{
					case 0u:
						goto IL_69;
					case 1u:
						this.position_ = other.position_;
						this.estimatedTime_ = other.estimatedTime_;
						arg_4D_0 = (num * 715426083u ^ 2112415803u);
						continue;
					case 3u:
						this.etaDeviationInSec_ = other.etaDeviationInSec_;
						arg_4D_0 = (num * 970424315u ^ 1982437460u);
						continue;
					}
					return;
				}
			}
		}

		public LogonQueueUpdateRequest Clone()
		{
			return new LogonQueueUpdateRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as LogonQueueUpdateRequest);
		}

		public bool Equals(LogonQueueUpdateRequest other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_DA;
			int arg_94_0;
			while (true)
			{
				IL_8F:
				switch ((arg_94_0 ^ -1818821142) % 11)
				{
				case 0:
					arg_94_0 = ((this.EstimatedTime == other.EstimatedTime) ? -1092601146 : -2142212234);
					continue;
				case 1:
					arg_94_0 = ((this.Position == other.Position) ? -1381505508 : -940670111);
					continue;
				case 2:
					return false;
				case 3:
					arg_94_0 = ((this.EtaDeviationInSec == other.EtaDeviationInSec) ? -1746640821 : -321749010);
					continue;
				case 4:
					return false;
				case 5:
					return true;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					goto IL_15;
				case 10:
					goto IL_DA;
				}
				break;
			}
			return true;
			IL_15:
			arg_94_0 = -1239473574;
			goto IL_8F;
			IL_DA:
			arg_94_0 = ((other != this) ? -1932391385 : -1823634643);
			goto IL_8F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_C9:
				uint arg_A5_0 = 3318102430u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A5_0 ^ 4030623537u)) % 6u)
					{
					case 0u:
						num ^= this.EstimatedTime.GetHashCode();
						arg_A5_0 = (num2 * 1508356065u ^ 955824411u);
						continue;
					case 1u:
						num ^= this.Position.GetHashCode();
						arg_A5_0 = (((this.EstimatedTime != 0uL) ? 1332064936u : 703646018u) ^ num2 * 2237531069u);
						continue;
					case 3u:
						goto IL_C9;
					case 4u:
						arg_A5_0 = ((this.EtaDeviationInSec != 0uL) ? 2552344042u : 3951435367u);
						continue;
					case 5u:
						num ^= this.EtaDeviationInSec.GetHashCode();
						arg_A5_0 = (num2 * 3409107818u ^ 3944225225u);
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
			output.WriteRawTag(8);
			output.WriteUInt32(this.Position);
			while (true)
			{
				IL_E2:
				uint arg_BA_0 = 1937638019u;
				while (true)
				{
					uint num;
					switch ((num = (arg_BA_0 ^ 761901952u)) % 7u)
					{
					case 0u:
						goto IL_E2;
					case 1u:
						output.WriteRawTag(24);
						output.WriteUInt64(this.EtaDeviationInSec);
						arg_BA_0 = (num * 2835013844u ^ 1493910251u);
						continue;
					case 2u:
						output.WriteUInt64(this.EstimatedTime);
						arg_BA_0 = (num * 3766526760u ^ 2519109804u);
						continue;
					case 4u:
						arg_BA_0 = (((this.EstimatedTime == 0uL) ? 1693817993u : 1715156562u) ^ num * 845969767u);
						continue;
					case 5u:
						output.WriteRawTag(16);
						arg_BA_0 = (num * 4006040366u ^ 1443994168u);
						continue;
					case 6u:
						arg_BA_0 = ((this.EtaDeviationInSec == 0uL) ? 687167271u : 2032648071u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + (1 + CodedOutputStream.ComputeUInt32Size(this.Position));
			while (true)
			{
				IL_C6:
				uint arg_A2_0 = 38483644u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A2_0 ^ 15952688u)) % 6u)
					{
					case 0u:
						goto IL_C6;
					case 1u:
						arg_A2_0 = ((this.EtaDeviationInSec == 0uL) ? 859042946u : 234880459u);
						continue;
					case 2u:
						arg_A2_0 = (((this.EstimatedTime != 0uL) ? 962860201u : 1428860507u) ^ num2 * 3784449556u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.EtaDeviationInSec);
						arg_A2_0 = (num2 * 944212354u ^ 402524916u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.EstimatedTime);
						arg_A2_0 = (num2 * 3884531822u ^ 3865236405u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(LogonQueueUpdateRequest other)
		{
			if (other == null)
			{
				goto IL_AE;
			}
			goto IL_F8;
			uint arg_B8_0;
			while (true)
			{
				IL_B3:
				uint num;
				switch ((num = (arg_B8_0 ^ 3086365112u)) % 9u)
				{
				case 0u:
					goto IL_AE;
				case 1u:
					arg_B8_0 = ((other.EstimatedTime != 0uL) ? 3058626605u : 3509444008u);
					continue;
				case 2u:
					return;
				case 3u:
					arg_B8_0 = ((other.EtaDeviationInSec != 0uL) ? 2244488532u : 3955051427u);
					continue;
				case 4u:
					this.EtaDeviationInSec = other.EtaDeviationInSec;
					arg_B8_0 = (num * 1150859818u ^ 3504962843u);
					continue;
				case 5u:
					this.EstimatedTime = other.EstimatedTime;
					arg_B8_0 = (num * 3040145819u ^ 1970513823u);
					continue;
				case 6u:
					goto IL_F8;
				case 8u:
					this.Position = other.Position;
					arg_B8_0 = (num * 2894661705u ^ 1849898459u);
					continue;
				}
				break;
			}
			return;
			IL_AE:
			arg_B8_0 = 3385016051u;
			goto IL_B3;
			IL_F8:
			arg_B8_0 = ((other.Position == 0u) ? 3273454731u : 3083528040u);
			goto IL_B3;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_137:
				uint num;
				uint arg_EF_0 = ((num = input.ReadTag()) != 0u) ? 548686898u : 890504412u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_EF_0 ^ 1511266981u)) % 11u)
					{
					case 0u:
						arg_EF_0 = (num2 * 1333366569u ^ 2207006487u);
						continue;
					case 1u:
						arg_EF_0 = (((num == 16u) ? 3325365498u : 3815587427u) ^ num2 * 1642363592u);
						continue;
					case 2u:
						this.EstimatedTime = input.ReadUInt64();
						arg_EF_0 = 351138800u;
						continue;
					case 3u:
						input.SkipLastField();
						arg_EF_0 = (num2 * 3143313333u ^ 3009371021u);
						continue;
					case 4u:
						this.Position = input.ReadUInt32();
						arg_EF_0 = 351138800u;
						continue;
					case 5u:
						goto IL_137;
					case 6u:
						arg_EF_0 = ((num != 8u) ? 71230868u : 1719801838u);
						continue;
					case 8u:
						this.EtaDeviationInSec = input.ReadUInt64();
						arg_EF_0 = 351138800u;
						continue;
					case 9u:
						arg_EF_0 = 548686898u;
						continue;
					case 10u:
						arg_EF_0 = (((num != 24u) ? 3319841572u : 3850272146u) ^ num2 * 3415702243u);
						continue;
					}
					return;
				}
			}
		}
	}
}
