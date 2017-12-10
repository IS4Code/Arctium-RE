using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class CAIS : IMessage<CAIS>, IEquatable<CAIS>, IDeepCloneable<CAIS>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly CAIS.__c __9 = new CAIS.__c();

			internal CAIS cctor>b__34_0()
			{
				return new CAIS();
			}
		}

		private static readonly MessageParser<CAIS> _parser = new MessageParser<CAIS>(new Func<CAIS>(CAIS.__c.__9.<.cctor>b__34_0));

		public const int PlayedMinutesFieldNumber = 1;

		private uint playedMinutes_;

		public const int RestedMinutesFieldNumber = 2;

		private uint restedMinutes_;

		public const int LastHeardTimeFieldNumber = 3;

		private ulong lastHeardTime_;

		public static MessageParser<CAIS> Parser
		{
			get
			{
				return CAIS._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[29];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CAIS.Descriptor;
			}
		}

		public uint PlayedMinutes
		{
			get
			{
				return this.playedMinutes_;
			}
			set
			{
				this.playedMinutes_ = value;
			}
		}

		public uint RestedMinutes
		{
			get
			{
				return this.restedMinutes_;
			}
			set
			{
				this.restedMinutes_ = value;
			}
		}

		public ulong LastHeardTime
		{
			get
			{
				return this.lastHeardTime_;
			}
			set
			{
				this.lastHeardTime_ = value;
			}
		}

		public CAIS()
		{
		}

		public CAIS(CAIS other) : this()
		{
			this.playedMinutes_ = other.playedMinutes_;
			this.restedMinutes_ = other.restedMinutes_;
			this.lastHeardTime_ = other.lastHeardTime_;
		}

		public CAIS Clone()
		{
			return new CAIS(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as CAIS);
		}

		public bool Equals(CAIS other)
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
				switch ((arg_94_0 ^ -543145949) % 11)
				{
				case 0:
					return false;
				case 1:
					arg_94_0 = ((this.RestedMinutes == other.RestedMinutes) ? -1532837262 : -1083600432);
					continue;
				case 2:
					return false;
				case 4:
					arg_94_0 = ((this.LastHeardTime == other.LastHeardTime) ? -1347461862 : -394787137);
					continue;
				case 5:
					return true;
				case 6:
					arg_94_0 = ((this.PlayedMinutes == other.PlayedMinutes) ? -875897569 : -526584138);
					continue;
				case 7:
					goto IL_15;
				case 8:
					return false;
				case 9:
					goto IL_DA;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_94_0 = -1546120889;
			goto IL_8F;
			IL_DA:
			arg_94_0 = ((other != this) ? -1658604238 : -606880997);
			goto IL_8F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_107:
				uint arg_DB_0 = 1962987964u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_DB_0 ^ 901537614u)) % 8u)
					{
					case 0u:
						num ^= this.LastHeardTime.GetHashCode();
						arg_DB_0 = (num2 * 3084281597u ^ 3159695849u);
						continue;
					case 1u:
						num ^= this.RestedMinutes.GetHashCode();
						arg_DB_0 = (num2 * 448395839u ^ 3995251908u);
						continue;
					case 2u:
						arg_DB_0 = (((this.PlayedMinutes != 0u) ? 4272970276u : 3827088267u) ^ num2 * 1774890807u);
						continue;
					case 3u:
						arg_DB_0 = ((this.RestedMinutes != 0u) ? 954814119u : 418334355u);
						continue;
					case 4u:
						num ^= this.PlayedMinutes.GetHashCode();
						arg_DB_0 = (num2 * 205455522u ^ 2604331485u);
						continue;
					case 5u:
						arg_DB_0 = ((this.LastHeardTime == 0uL) ? 1165606953u : 1789209486u);
						continue;
					case 6u:
						goto IL_107;
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
			if (this.PlayedMinutes != 0u)
			{
				goto IL_8A;
			}
			goto IL_111;
			uint arg_D1_0;
			while (true)
			{
				IL_CC:
				uint num;
				switch ((num = (arg_D1_0 ^ 155981260u)) % 9u)
				{
				case 0u:
					output.WriteUInt32(this.RestedMinutes);
					arg_D1_0 = (num * 1811475733u ^ 3708700066u);
					continue;
				case 1u:
					output.WriteRawTag(8);
					output.WriteUInt32(this.PlayedMinutes);
					arg_D1_0 = (num * 2555029284u ^ 2810492738u);
					continue;
				case 2u:
					goto IL_8A;
				case 3u:
					output.WriteUInt64(this.LastHeardTime);
					arg_D1_0 = (num * 186596288u ^ 1521572225u);
					continue;
				case 4u:
					goto IL_111;
				case 6u:
					output.WriteRawTag(24);
					arg_D1_0 = (num * 2076385301u ^ 380596949u);
					continue;
				case 7u:
					output.WriteRawTag(16);
					arg_D1_0 = (num * 548678034u ^ 2987952886u);
					continue;
				case 8u:
					arg_D1_0 = ((this.LastHeardTime == 0uL) ? 127149377u : 1215334744u);
					continue;
				}
				break;
			}
			return;
			IL_8A:
			arg_D1_0 = 573170018u;
			goto IL_CC;
			IL_111:
			arg_D1_0 = ((this.RestedMinutes == 0u) ? 426695144u : 1922573088u);
			goto IL_CC;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_104:
				uint arg_D8_0 = 857681489u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_D8_0 ^ 1740180947u)) % 8u)
					{
					case 0u:
						arg_D8_0 = ((this.LastHeardTime != 0uL) ? 497396605u : 523424127u);
						continue;
					case 1u:
						arg_D8_0 = ((this.RestedMinutes == 0u) ? 1145820915u : 476631932u);
						continue;
					case 2u:
						arg_D8_0 = (((this.PlayedMinutes != 0u) ? 364237456u : 758900106u) ^ num2 * 1905355708u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlayedMinutes);
						arg_D8_0 = (num2 * 1148747790u ^ 3876715464u);
						continue;
					case 5u:
						goto IL_104;
					case 6u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.LastHeardTime);
						arg_D8_0 = (num2 * 3031618132u ^ 3492789351u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.RestedMinutes);
						arg_D8_0 = (num2 * 810113680u ^ 4202045059u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(CAIS other)
		{
			if (other == null)
			{
				goto IL_75;
			}
			goto IL_F5;
			uint arg_B5_0;
			while (true)
			{
				IL_B0:
				uint num;
				switch ((num = (arg_B5_0 ^ 1364849488u)) % 9u)
				{
				case 0u:
					this.LastHeardTime = other.LastHeardTime;
					arg_B5_0 = (num * 1792188523u ^ 2982327818u);
					continue;
				case 1u:
					return;
				case 2u:
					goto IL_F5;
				case 3u:
					this.PlayedMinutes = other.PlayedMinutes;
					arg_B5_0 = (num * 3080066855u ^ 3164104926u);
					continue;
				case 5u:
					goto IL_75;
				case 6u:
					arg_B5_0 = ((other.RestedMinutes == 0u) ? 535616843u : 818182767u);
					continue;
				case 7u:
					this.RestedMinutes = other.RestedMinutes;
					arg_B5_0 = (num * 3243017014u ^ 1841753345u);
					continue;
				case 8u:
					arg_B5_0 = ((other.LastHeardTime != 0uL) ? 1608127018u : 1239272436u);
					continue;
				}
				break;
			}
			return;
			IL_75:
			arg_B5_0 = 337209324u;
			goto IL_B0;
			IL_F5:
			arg_B5_0 = ((other.PlayedMinutes != 0u) ? 2055855364u : 780202514u);
			goto IL_B0;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_14A:
				uint num;
				uint arg_FE_0 = ((num = input.ReadTag()) != 0u) ? 1790477706u : 759564264u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_FE_0 ^ 1469330716u)) % 12u)
					{
					case 0u:
						arg_FE_0 = (num2 * 1869952245u ^ 1445616303u);
						continue;
					case 1u:
						this.RestedMinutes = input.ReadUInt32();
						arg_FE_0 = 1733251629u;
						continue;
					case 2u:
						arg_FE_0 = ((num == 8u) ? 1323734714u : 1525353709u);
						continue;
					case 3u:
						goto IL_14A;
					case 4u:
						input.SkipLastField();
						arg_FE_0 = (num2 * 203685526u ^ 1603747804u);
						continue;
					case 5u:
						arg_FE_0 = (num2 * 1999272859u ^ 3923468356u);
						continue;
					case 6u:
						this.PlayedMinutes = input.ReadUInt32();
						arg_FE_0 = 1571644911u;
						continue;
					case 7u:
						this.LastHeardTime = input.ReadUInt64();
						arg_FE_0 = 1571644911u;
						continue;
					case 9u:
						arg_FE_0 = (((num != 16u) ? 1404183982u : 1665641032u) ^ num2 * 1280648697u);
						continue;
					case 10u:
						arg_FE_0 = 1790477706u;
						continue;
					case 11u:
						arg_FE_0 = (((num == 24u) ? 3600765743u : 2328140624u) ^ num2 * 472972132u);
						continue;
					}
					return;
				}
			}
		}
	}
}
