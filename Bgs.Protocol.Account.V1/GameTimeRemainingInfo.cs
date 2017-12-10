using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameTimeRemainingInfo : IMessage<GameTimeRemainingInfo>, IEquatable<GameTimeRemainingInfo>, IDeepCloneable<GameTimeRemainingInfo>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameTimeRemainingInfo.__c __9 = new GameTimeRemainingInfo.__c();

			internal GameTimeRemainingInfo cctor>b__39_0()
			{
				return new GameTimeRemainingInfo();
			}
		}

		private static readonly MessageParser<GameTimeRemainingInfo> _parser = new MessageParser<GameTimeRemainingInfo>(new Func<GameTimeRemainingInfo>(GameTimeRemainingInfo.__c.__9.<.cctor>b__39_0));

		public const int MinutesRemainingFieldNumber = 1;

		private uint minutesRemaining_;

		public const int ParentalDailyMinutesRemainingFieldNumber = 2;

		private uint parentalDailyMinutesRemaining_;

		public const int ParentalWeeklyMinutesRemainingFieldNumber = 3;

		private uint parentalWeeklyMinutesRemaining_;

		public const int SecondsRemainingUntilKickFieldNumber = 4;

		private uint secondsRemainingUntilKick_;

		public static MessageParser<GameTimeRemainingInfo> Parser
		{
			get
			{
				return GameTimeRemainingInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[23];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameTimeRemainingInfo.Descriptor;
			}
		}

		public uint MinutesRemaining
		{
			get
			{
				return this.minutesRemaining_;
			}
			set
			{
				this.minutesRemaining_ = value;
			}
		}

		public uint ParentalDailyMinutesRemaining
		{
			get
			{
				return this.parentalDailyMinutesRemaining_;
			}
			set
			{
				this.parentalDailyMinutesRemaining_ = value;
			}
		}

		public uint ParentalWeeklyMinutesRemaining
		{
			get
			{
				return this.parentalWeeklyMinutesRemaining_;
			}
			set
			{
				this.parentalWeeklyMinutesRemaining_ = value;
			}
		}

		public uint SecondsRemainingUntilKick
		{
			get
			{
				return this.secondsRemainingUntilKick_;
			}
			set
			{
				this.secondsRemainingUntilKick_ = value;
			}
		}

		public GameTimeRemainingInfo()
		{
		}

		public GameTimeRemainingInfo(GameTimeRemainingInfo other) : this()
		{
			while (true)
			{
				IL_8B:
				uint arg_6B_0 = 1334479563u;
				while (true)
				{
					uint num;
					switch ((num = (arg_6B_0 ^ 2011994161u)) % 5u)
					{
					case 1u:
						this.minutesRemaining_ = other.minutesRemaining_;
						arg_6B_0 = (num * 3032968231u ^ 1985865826u);
						continue;
					case 2u:
						this.parentalWeeklyMinutesRemaining_ = other.parentalWeeklyMinutesRemaining_;
						this.secondsRemainingUntilKick_ = other.secondsRemainingUntilKick_;
						arg_6B_0 = (num * 796308061u ^ 3112442197u);
						continue;
					case 3u:
						goto IL_8B;
					case 4u:
						this.parentalDailyMinutesRemaining_ = other.parentalDailyMinutesRemaining_;
						arg_6B_0 = (num * 3827292595u ^ 442628402u);
						continue;
					}
					return;
				}
			}
		}

		public GameTimeRemainingInfo Clone()
		{
			return new GameTimeRemainingInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameTimeRemainingInfo);
		}

		public bool Equals(GameTimeRemainingInfo other)
		{
			if (other == null)
			{
				goto IL_B7;
			}
			goto IL_10F;
			int arg_C1_0;
			while (true)
			{
				IL_BC:
				switch ((arg_C1_0 ^ 1108728933) % 13)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					goto IL_B7;
				case 3:
					return false;
				case 4:
					arg_C1_0 = ((this.SecondsRemainingUntilKick == other.SecondsRemainingUntilKick) ? 1548450896 : 394552166);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_C1_0 = ((this.ParentalDailyMinutesRemaining == other.ParentalDailyMinutesRemaining) ? 322847209 : 1698043102);
					continue;
				case 8:
					arg_C1_0 = ((this.ParentalWeeklyMinutesRemaining != other.ParentalWeeklyMinutesRemaining) ? 1519474985 : 1406408068);
					continue;
				case 9:
					goto IL_10F;
				case 10:
					arg_C1_0 = ((this.MinutesRemaining != other.MinutesRemaining) ? 245569071 : 1138568159);
					continue;
				case 12:
					return false;
				}
				break;
			}
			return true;
			IL_B7:
			arg_C1_0 = 1239026021;
			goto IL_BC;
			IL_10F:
			arg_C1_0 = ((other == this) ? 823495174 : 1601204904);
			goto IL_BC;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.MinutesRemaining != 0u)
			{
				goto IL_42;
			}
			goto IL_134;
			uint arg_F4_0;
			while (true)
			{
				IL_EF:
				uint num2;
				switch ((num2 = (arg_F4_0 ^ 1252092497u)) % 9u)
				{
				case 0u:
					goto IL_134;
				case 1u:
					arg_F4_0 = ((this.SecondsRemainingUntilKick == 0u) ? 1573162544u : 597437664u);
					continue;
				case 3u:
					num ^= this.ParentalDailyMinutesRemaining.GetHashCode();
					arg_F4_0 = (num2 * 3191000824u ^ 2249053647u);
					continue;
				case 4u:
					arg_F4_0 = ((this.ParentalWeeklyMinutesRemaining != 0u) ? 1739034547u : 2070203717u);
					continue;
				case 5u:
					num ^= this.ParentalWeeklyMinutesRemaining.GetHashCode();
					arg_F4_0 = (num2 * 2817116869u ^ 3137468335u);
					continue;
				case 6u:
					num ^= this.MinutesRemaining.GetHashCode();
					arg_F4_0 = (num2 * 3028446015u ^ 3635102536u);
					continue;
				case 7u:
					goto IL_42;
				case 8u:
					num ^= this.SecondsRemainingUntilKick.GetHashCode();
					arg_F4_0 = (num2 * 3147985672u ^ 2322151096u);
					continue;
				}
				break;
			}
			return num;
			IL_42:
			arg_F4_0 = 1699683512u;
			goto IL_EF;
			IL_134:
			arg_F4_0 = ((this.ParentalDailyMinutesRemaining == 0u) ? 700866439u : 650740614u);
			goto IL_EF;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.MinutesRemaining != 0u)
			{
				goto IL_9E;
			}
			goto IL_166;
			uint arg_11E_0;
			while (true)
			{
				IL_119:
				uint num;
				switch ((num = (arg_11E_0 ^ 1443989396u)) % 11u)
				{
				case 0u:
					output.WriteUInt32(this.MinutesRemaining);
					arg_11E_0 = (num * 1906318153u ^ 101627716u);
					continue;
				case 1u:
					arg_11E_0 = ((this.ParentalWeeklyMinutesRemaining == 0u) ? 2124977148u : 983362526u);
					continue;
				case 2u:
					output.WriteRawTag(16);
					arg_11E_0 = (num * 3771641000u ^ 607446359u);
					continue;
				case 3u:
					output.WriteRawTag(32);
					output.WriteUInt32(this.SecondsRemainingUntilKick);
					arg_11E_0 = (num * 683761773u ^ 3899789931u);
					continue;
				case 4u:
					goto IL_9E;
				case 5u:
					arg_11E_0 = ((this.SecondsRemainingUntilKick == 0u) ? 973808713u : 1826704126u);
					continue;
				case 6u:
					output.WriteRawTag(8);
					arg_11E_0 = (num * 1540757261u ^ 1403889235u);
					continue;
				case 7u:
					output.WriteRawTag(24);
					output.WriteUInt32(this.ParentalWeeklyMinutesRemaining);
					arg_11E_0 = (num * 1662541385u ^ 3652165350u);
					continue;
				case 8u:
					output.WriteUInt32(this.ParentalDailyMinutesRemaining);
					arg_11E_0 = (num * 2070313900u ^ 3407234370u);
					continue;
				case 9u:
					goto IL_166;
				}
				break;
			}
			return;
			IL_9E:
			arg_11E_0 = 1281729900u;
			goto IL_119;
			IL_166:
			arg_11E_0 = ((this.ParentalDailyMinutesRemaining != 0u) ? 1156073229u : 477099686u);
			goto IL_119;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.MinutesRemaining != 0u)
			{
				goto IL_E6;
			}
			goto IL_130;
			uint arg_F0_0;
			while (true)
			{
				IL_EB:
				uint num2;
				switch ((num2 = (arg_F0_0 ^ 1990061862u)) % 9u)
				{
				case 0u:
					goto IL_E6;
				case 1u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.MinutesRemaining);
					arg_F0_0 = (num2 * 1523330026u ^ 1020555326u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.SecondsRemainingUntilKick);
					arg_F0_0 = (num2 * 2258341739u ^ 3576632522u);
					continue;
				case 3u:
					arg_F0_0 = ((this.SecondsRemainingUntilKick != 0u) ? 1878390054u : 1445448394u);
					continue;
				case 4u:
					arg_F0_0 = ((this.ParentalWeeklyMinutesRemaining == 0u) ? 648795471u : 1874262675u);
					continue;
				case 5u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.ParentalDailyMinutesRemaining);
					arg_F0_0 = (num2 * 50370749u ^ 2042565846u);
					continue;
				case 6u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.ParentalWeeklyMinutesRemaining);
					arg_F0_0 = (num2 * 2291712911u ^ 3401198164u);
					continue;
				case 7u:
					goto IL_130;
				}
				break;
			}
			return num;
			IL_E6:
			arg_F0_0 = 147186989u;
			goto IL_EB;
			IL_130:
			arg_F0_0 = ((this.ParentalDailyMinutesRemaining == 0u) ? 2062740312u : 1305966208u);
			goto IL_EB;
		}

		public void MergeFrom(GameTimeRemainingInfo other)
		{
			if (other == null)
			{
				goto IL_B4;
			}
			goto IL_142;
			uint arg_FA_0;
			while (true)
			{
				IL_F5:
				uint num;
				switch ((num = (arg_FA_0 ^ 1732481152u)) % 11u)
				{
				case 0u:
					goto IL_142;
				case 1u:
					arg_FA_0 = ((other.SecondsRemainingUntilKick == 0u) ? 54932113u : 480832012u);
					continue;
				case 2u:
					this.SecondsRemainingUntilKick = other.SecondsRemainingUntilKick;
					arg_FA_0 = (num * 1191462452u ^ 1321279201u);
					continue;
				case 4u:
					goto IL_B4;
				case 5u:
					return;
				case 6u:
					arg_FA_0 = ((other.ParentalDailyMinutesRemaining != 0u) ? 190350255u : 1303300692u);
					continue;
				case 7u:
					this.ParentalDailyMinutesRemaining = other.ParentalDailyMinutesRemaining;
					arg_FA_0 = (num * 204726876u ^ 2326374576u);
					continue;
				case 8u:
					this.ParentalWeeklyMinutesRemaining = other.ParentalWeeklyMinutesRemaining;
					arg_FA_0 = (num * 1858816156u ^ 2758176590u);
					continue;
				case 9u:
					arg_FA_0 = ((other.ParentalWeeklyMinutesRemaining == 0u) ? 1589121918u : 1114127508u);
					continue;
				case 10u:
					this.MinutesRemaining = other.MinutesRemaining;
					arg_FA_0 = (num * 45647181u ^ 2041268913u);
					continue;
				}
				break;
			}
			return;
			IL_B4:
			arg_FA_0 = 2051357815u;
			goto IL_F5;
			IL_142:
			arg_FA_0 = ((other.MinutesRemaining == 0u) ? 980481496u : 753546253u);
			goto IL_F5;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1C4:
				uint num;
				uint arg_168_0 = ((num = input.ReadTag()) == 0u) ? 4217257166u : 3678895974u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_168_0 ^ 2686828653u)) % 16u)
					{
					case 0u:
						arg_168_0 = 3678895974u;
						continue;
					case 1u:
						this.ParentalWeeklyMinutesRemaining = input.ReadUInt32();
						arg_168_0 = 4278304665u;
						continue;
					case 2u:
						input.SkipLastField();
						arg_168_0 = 2439819975u;
						continue;
					case 4u:
						goto IL_1C4;
					case 5u:
						arg_168_0 = (num2 * 472258690u ^ 3425863827u);
						continue;
					case 6u:
						arg_168_0 = (((num == 8u) ? 1089951388u : 769894490u) ^ num2 * 264770532u);
						continue;
					case 7u:
						this.SecondsRemainingUntilKick = input.ReadUInt32();
						arg_168_0 = 4278304665u;
						continue;
					case 8u:
						arg_168_0 = ((num == 24u) ? 2946641516u : 2826423923u);
						continue;
					case 9u:
						this.MinutesRemaining = input.ReadUInt32();
						arg_168_0 = 4278304665u;
						continue;
					case 10u:
						arg_168_0 = (num2 * 3913435159u ^ 2695668447u);
						continue;
					case 11u:
						arg_168_0 = ((num > 16u) ? 3953409109u : 2595424859u);
						continue;
					case 12u:
						arg_168_0 = (num2 * 1868726851u ^ 3519582427u);
						continue;
					case 13u:
						this.ParentalDailyMinutesRemaining = input.ReadUInt32();
						arg_168_0 = 2684227112u;
						continue;
					case 14u:
						arg_168_0 = (((num != 32u) ? 2539890263u : 3123533954u) ^ num2 * 1641793964u);
						continue;
					case 15u:
						arg_168_0 = (((num == 16u) ? 1691229296u : 2112846705u) ^ num2 * 1094445424u);
						continue;
					}
					return;
				}
			}
		}
	}
}
