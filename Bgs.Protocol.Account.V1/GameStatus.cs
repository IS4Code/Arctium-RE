using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameStatus : IMessage<GameStatus>, IEquatable<GameStatus>, IDeepCloneable<GameStatus>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameStatus.__c __9 = new GameStatus.__c();

			internal GameStatus cctor>b__49_0()
			{
				return new GameStatus();
			}
		}

		private static readonly MessageParser<GameStatus> _parser = new MessageParser<GameStatus>(new Func<GameStatus>(GameStatus.__c.__9.<.cctor>b__49_0));

		public const int IsSuspendedFieldNumber = 4;

		private bool isSuspended_;

		public const int IsBannedFieldNumber = 5;

		private bool isBanned_;

		public const int SuspensionExpiresFieldNumber = 6;

		private ulong suspensionExpires_;

		public const int ProgramFieldNumber = 7;

		private uint program_;

		public const int IsLockedFieldNumber = 8;

		private bool isLocked_;

		public const int IsBamUnlockableFieldNumber = 9;

		private bool isBamUnlockable_;

		public static MessageParser<GameStatus> Parser
		{
			get
			{
				return GameStatus._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[24];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameStatus.Descriptor;
			}
		}

		public bool IsSuspended
		{
			get
			{
				return this.isSuspended_;
			}
			set
			{
				this.isSuspended_ = value;
			}
		}

		public bool IsBanned
		{
			get
			{
				return this.isBanned_;
			}
			set
			{
				this.isBanned_ = value;
			}
		}

		public ulong SuspensionExpires
		{
			get
			{
				return this.suspensionExpires_;
			}
			set
			{
				this.suspensionExpires_ = value;
			}
		}

		public uint Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = value;
			}
		}

		public bool IsLocked
		{
			get
			{
				return this.isLocked_;
			}
			set
			{
				this.isLocked_ = value;
			}
		}

		public bool IsBamUnlockable
		{
			get
			{
				return this.isBamUnlockable_;
			}
			set
			{
				this.isBamUnlockable_ = value;
			}
		}

		public GameStatus()
		{
		}

		public GameStatus(GameStatus other) : this()
		{
			this.isSuspended_ = other.isSuspended_;
			this.isBanned_ = other.isBanned_;
			this.suspensionExpires_ = other.suspensionExpires_;
			this.program_ = other.program_;
			this.isLocked_ = other.isLocked_;
			this.isBamUnlockable_ = other.isBamUnlockable_;
		}

		public GameStatus Clone()
		{
			return new GameStatus(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameStatus);
		}

		public bool Equals(GameStatus other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_173;
			int arg_115_0;
			while (true)
			{
				IL_110:
				switch ((arg_115_0 ^ 704938898) % 17)
				{
				case 0:
					arg_115_0 = ((this.IsSuspended != other.IsSuspended) ? 125779508 : 576979541);
					continue;
				case 1:
					arg_115_0 = ((this.Program == other.Program) ? 1552015610 : 892418761);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					return true;
				case 6:
					return false;
				case 7:
					arg_115_0 = ((this.IsBanned == other.IsBanned) ? 1674986449 : 1406201151);
					continue;
				case 8:
					goto IL_173;
				case 9:
					return false;
				case 10:
					arg_115_0 = ((this.IsBamUnlockable != other.IsBamUnlockable) ? 2031535869 : 1177791015);
					continue;
				case 12:
					arg_115_0 = ((this.IsLocked != other.IsLocked) ? 821005336 : 1571598494);
					continue;
				case 13:
					return false;
				case 14:
					return false;
				case 15:
					arg_115_0 = ((this.SuspensionExpires != other.SuspensionExpires) ? 1236992923 : 1550186207);
					continue;
				case 16:
					goto IL_18;
				}
				break;
			}
			return true;
			IL_18:
			arg_115_0 = 1980764523;
			goto IL_110;
			IL_173:
			arg_115_0 = ((other != this) ? 397469767 : 1833802045);
			goto IL_110;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_1FD:
				uint arg_1B7_0 = 2174246834u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1B7_0 ^ 2915265802u)) % 14u)
					{
					case 0u:
						arg_1B7_0 = (this.IsBanned ? 3987873133u : 2464427640u);
						continue;
					case 1u:
						num ^= this.IsBanned.GetHashCode();
						arg_1B7_0 = (num2 * 3074323623u ^ 3624194377u);
						continue;
					case 2u:
						arg_1B7_0 = (this.IsBamUnlockable ? 3320264586u : 2433908111u);
						continue;
					case 4u:
						arg_1B7_0 = ((!this.IsLocked) ? 2812194756u : 3567744314u);
						continue;
					case 5u:
						arg_1B7_0 = ((this.Program != 0u) ? 2634316833u : 2711165038u);
						continue;
					case 6u:
						num ^= this.IsBamUnlockable.GetHashCode();
						arg_1B7_0 = (num2 * 2434681340u ^ 1837493135u);
						continue;
					case 7u:
						goto IL_1FD;
					case 8u:
						arg_1B7_0 = (((!this.IsSuspended) ? 1534782626u : 2081865591u) ^ num2 * 3249248707u);
						continue;
					case 9u:
						num ^= this.IsSuspended.GetHashCode();
						arg_1B7_0 = (num2 * 3787416474u ^ 3945141416u);
						continue;
					case 10u:
						num ^= this.IsLocked.GetHashCode();
						arg_1B7_0 = (num2 * 3659852330u ^ 148469796u);
						continue;
					case 11u:
						num ^= this.Program.GetHashCode();
						arg_1B7_0 = (num2 * 1315161629u ^ 2599168945u);
						continue;
					case 12u:
						arg_1B7_0 = ((this.SuspensionExpires != 0uL) ? 3180418981u : 2467715403u);
						continue;
					case 13u:
						num ^= this.SuspensionExpires.GetHashCode();
						arg_1B7_0 = (num2 * 3283181319u ^ 1158926978u);
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
			if (this.IsSuspended)
			{
				goto IL_1AD;
			}
			goto IL_24D;
			uint arg_1E9_0;
			while (true)
			{
				IL_1E4:
				uint num;
				switch ((num = (arg_1E9_0 ^ 3529202056u)) % 18u)
				{
				case 0u:
					output.WriteBool(this.IsSuspended);
					arg_1E9_0 = (num * 4222591131u ^ 3942372874u);
					continue;
				case 1u:
					output.WriteRawTag(40);
					arg_1E9_0 = (num * 2295273288u ^ 2367402868u);
					continue;
				case 2u:
					goto IL_1AD;
				case 3u:
					output.WriteFixed32(this.Program);
					arg_1E9_0 = (num * 1182062462u ^ 752056561u);
					continue;
				case 4u:
					output.WriteRawTag(64);
					arg_1E9_0 = (num * 321140805u ^ 174703598u);
					continue;
				case 5u:
					output.WriteRawTag(61);
					arg_1E9_0 = (num * 1352848382u ^ 781429127u);
					continue;
				case 6u:
					output.WriteRawTag(48);
					arg_1E9_0 = (num * 1950994611u ^ 901734008u);
					continue;
				case 7u:
					arg_1E9_0 = ((!this.IsLocked) ? 3152306185u : 4128204932u);
					continue;
				case 8u:
					output.WriteRawTag(32);
					arg_1E9_0 = (num * 2898492668u ^ 2492160696u);
					continue;
				case 9u:
					arg_1E9_0 = ((this.Program == 0u) ? 3323112135u : 2370381987u);
					continue;
				case 10u:
					output.WriteBool(this.IsBanned);
					arg_1E9_0 = (num * 330443539u ^ 889897889u);
					continue;
				case 12u:
					output.WriteUInt64(this.SuspensionExpires);
					arg_1E9_0 = (num * 526607474u ^ 2760145829u);
					continue;
				case 13u:
					arg_1E9_0 = ((this.SuspensionExpires != 0uL) ? 2192572612u : 3429488589u);
					continue;
				case 14u:
					output.WriteBool(this.IsLocked);
					arg_1E9_0 = (num * 2742460482u ^ 2121481021u);
					continue;
				case 15u:
					output.WriteRawTag(72);
					output.WriteBool(this.IsBamUnlockable);
					arg_1E9_0 = (num * 2291139683u ^ 3548296302u);
					continue;
				case 16u:
					goto IL_24D;
				case 17u:
					arg_1E9_0 = (this.IsBamUnlockable ? 3435196439u : 4114063379u);
					continue;
				}
				break;
			}
			return;
			IL_1AD:
			arg_1E9_0 = 2296593328u;
			goto IL_1E4;
			IL_24D:
			arg_1E9_0 = ((!this.IsBanned) ? 3688584829u : 2876773689u);
			goto IL_1E4;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.IsSuspended)
			{
				goto IL_BF;
			}
			goto IL_18D;
			uint arg_13D_0;
			while (true)
			{
				IL_138:
				uint num2;
				switch ((num2 = (arg_13D_0 ^ 2722431718u)) % 13u)
				{
				case 0u:
					num += 2;
					arg_13D_0 = (num2 * 4179465297u ^ 3734901049u);
					continue;
				case 1u:
					arg_13D_0 = ((!this.IsLocked) ? 2741388593u : 2442345705u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.SuspensionExpires);
					arg_13D_0 = (num2 * 1701809348u ^ 3269322603u);
					continue;
				case 3u:
					arg_13D_0 = ((this.SuspensionExpires != 0uL) ? 4281590670u : 2495386827u);
					continue;
				case 4u:
					goto IL_BF;
				case 5u:
					num += 2;
					arg_13D_0 = (num2 * 10920059u ^ 2937418756u);
					continue;
				case 7u:
					num += 2;
					arg_13D_0 = (num2 * 4213893559u ^ 1959316269u);
					continue;
				case 8u:
					goto IL_18D;
				case 9u:
					num += 2;
					arg_13D_0 = (num2 * 645337564u ^ 158725054u);
					continue;
				case 10u:
					num += 5;
					arg_13D_0 = (num2 * 3437042153u ^ 1542179959u);
					continue;
				case 11u:
					arg_13D_0 = ((!this.IsBamUnlockable) ? 3510189955u : 2401036836u);
					continue;
				case 12u:
					arg_13D_0 = ((this.Program != 0u) ? 2366385766u : 3264859383u);
					continue;
				}
				break;
			}
			return num;
			IL_BF:
			arg_13D_0 = 3432410772u;
			goto IL_138;
			IL_18D:
			arg_13D_0 = (this.IsBanned ? 2309442562u : 2996098845u);
			goto IL_138;
		}

		public void MergeFrom(GameStatus other)
		{
			if (other == null)
			{
				goto IL_DB;
			}
			goto IL_1D9;
			uint arg_181_0;
			while (true)
			{
				IL_17C:
				uint num;
				switch ((num = (arg_181_0 ^ 2494152374u)) % 15u)
				{
				case 0u:
					this.IsSuspended = other.IsSuspended;
					arg_181_0 = (num * 475771685u ^ 466501501u);
					continue;
				case 1u:
					arg_181_0 = ((!other.IsBanned) ? 3851206085u : 3642064365u);
					continue;
				case 2u:
					arg_181_0 = ((!other.IsBamUnlockable) ? 3659153738u : 3720507268u);
					continue;
				case 3u:
					arg_181_0 = ((other.Program != 0u) ? 3280544930u : 3630703577u);
					continue;
				case 4u:
					this.IsBamUnlockable = other.IsBamUnlockable;
					arg_181_0 = (num * 1871693306u ^ 3995698590u);
					continue;
				case 5u:
					goto IL_DB;
				case 6u:
					this.SuspensionExpires = other.SuspensionExpires;
					arg_181_0 = (num * 2128428366u ^ 2496473350u);
					continue;
				case 7u:
					return;
				case 8u:
					this.Program = other.Program;
					arg_181_0 = (num * 1934032453u ^ 709459133u);
					continue;
				case 9u:
					goto IL_1D9;
				case 10u:
					this.IsLocked = other.IsLocked;
					arg_181_0 = (num * 142262143u ^ 260556625u);
					continue;
				case 11u:
					this.IsBanned = other.IsBanned;
					arg_181_0 = (num * 2882402856u ^ 1353243133u);
					continue;
				case 12u:
					arg_181_0 = ((!other.IsLocked) ? 2227606025u : 3850954782u);
					continue;
				case 13u:
					arg_181_0 = ((other.SuspensionExpires != 0uL) ? 3959304164u : 4007000570u);
					continue;
				}
				break;
			}
			return;
			IL_DB:
			arg_181_0 = 3773501141u;
			goto IL_17C;
			IL_1D9:
			arg_181_0 = (other.IsSuspended ? 3489351683u : 2820343892u);
			goto IL_17C;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_269:
				uint num;
				uint arg_1F9_0 = ((num = input.ReadTag()) == 0u) ? 2687901265u : 4233664132u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1F9_0 ^ 2937249619u)) % 21u)
					{
					case 1u:
						this.IsBamUnlockable = input.ReadBool();
						arg_1F9_0 = 2808365043u;
						continue;
					case 2u:
						input.SkipLastField();
						arg_1F9_0 = 2808365043u;
						continue;
					case 3u:
						this.SuspensionExpires = input.ReadUInt64();
						arg_1F9_0 = 4200563411u;
						continue;
					case 4u:
						this.IsSuspended = input.ReadBool();
						arg_1F9_0 = 2808365043u;
						continue;
					case 5u:
						arg_1F9_0 = ((num == 61u) ? 3868692083u : 2566828164u);
						continue;
					case 6u:
						arg_1F9_0 = (num2 * 1281090770u ^ 1586025747u);
						continue;
					case 7u:
						arg_1F9_0 = (num2 * 2519876589u ^ 4161261364u);
						continue;
					case 8u:
						arg_1F9_0 = (((num == 72u) ? 752205734u : 1397204880u) ^ num2 * 3135799358u);
						continue;
					case 9u:
						arg_1F9_0 = (((num != 40u) ? 366933030u : 1822645494u) ^ num2 * 904805659u);
						continue;
					case 10u:
						arg_1F9_0 = ((num > 48u) ? 2445081200u : 3594365350u);
						continue;
					case 11u:
						arg_1F9_0 = (num2 * 2456076982u ^ 1824474867u);
						continue;
					case 12u:
						goto IL_269;
					case 13u:
						this.IsLocked = input.ReadBool();
						arg_1F9_0 = 2808365043u;
						continue;
					case 14u:
						arg_1F9_0 = (((num == 48u) ? 226402797u : 89642483u) ^ num2 * 1124960321u);
						continue;
					case 15u:
						arg_1F9_0 = (((num == 32u) ? 925881250u : 2134855725u) ^ num2 * 2641605395u);
						continue;
					case 16u:
						this.Program = input.ReadFixed32();
						arg_1F9_0 = 3073369251u;
						continue;
					case 17u:
						arg_1F9_0 = (((num != 64u) ? 2798207785u : 2166756900u) ^ num2 * 2142774483u);
						continue;
					case 18u:
						this.IsBanned = input.ReadBool();
						arg_1F9_0 = 3002923439u;
						continue;
					case 19u:
						arg_1F9_0 = 4233664132u;
						continue;
					case 20u:
						arg_1F9_0 = (num2 * 3027626962u ^ 2335535435u);
						continue;
					}
					return;
				}
			}
		}
	}
}
