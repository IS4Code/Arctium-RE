using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameTimeInfo : IMessage<GameTimeInfo>, IEquatable<GameTimeInfo>, IDeepCloneable<GameTimeInfo>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameTimeInfo.__c __9 = new GameTimeInfo.__c();

			internal GameTimeInfo cctor>b__39_0()
			{
				return new GameTimeInfo();
			}
		}

		private static readonly MessageParser<GameTimeInfo> _parser = new MessageParser<GameTimeInfo>(new Func<GameTimeInfo>(GameTimeInfo.__c.__9.<.cctor>b__39_0));

		public const int IsUnlimitedPlayTimeFieldNumber = 3;

		private bool isUnlimitedPlayTime_;

		public const int PlayTimeExpiresFieldNumber = 5;

		private ulong playTimeExpires_;

		public const int IsSubscriptionFieldNumber = 6;

		private bool isSubscription_;

		public const int IsRecurringSubscriptionFieldNumber = 7;

		private bool isRecurringSubscription_;

		public static MessageParser<GameTimeInfo> Parser
		{
			get
			{
				return GameTimeInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[22];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameTimeInfo.Descriptor;
			}
		}

		public bool IsUnlimitedPlayTime
		{
			get
			{
				return this.isUnlimitedPlayTime_;
			}
			set
			{
				this.isUnlimitedPlayTime_ = value;
			}
		}

		public ulong PlayTimeExpires
		{
			get
			{
				return this.playTimeExpires_;
			}
			set
			{
				this.playTimeExpires_ = value;
			}
		}

		public bool IsSubscription
		{
			get
			{
				return this.isSubscription_;
			}
			set
			{
				this.isSubscription_ = value;
			}
		}

		public bool IsRecurringSubscription
		{
			get
			{
				return this.isRecurringSubscription_;
			}
			set
			{
				this.isRecurringSubscription_ = value;
			}
		}

		public GameTimeInfo()
		{
		}

		public GameTimeInfo(GameTimeInfo other) : this()
		{
			while (true)
			{
				IL_5D:
				uint arg_41_0 = 3602275973u;
				while (true)
				{
					uint num;
					switch ((num = (arg_41_0 ^ 3198732164u)) % 4u)
					{
					case 1u:
						this.isUnlimitedPlayTime_ = other.isUnlimitedPlayTime_;
						arg_41_0 = (num * 3655563608u ^ 1813241327u);
						continue;
					case 2u:
						goto IL_5D;
					case 3u:
						this.playTimeExpires_ = other.playTimeExpires_;
						arg_41_0 = (num * 863551025u ^ 2866047399u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.isSubscription_ = other.isSubscription_;
			this.isRecurringSubscription_ = other.isRecurringSubscription_;
		}

		public GameTimeInfo Clone()
		{
			return new GameTimeInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameTimeInfo);
		}

		public bool Equals(GameTimeInfo other)
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
				switch ((arg_C1_0 ^ 746529686) % 13)
				{
				case 0:
					goto IL_B7;
				case 1:
					return true;
				case 2:
					goto IL_10F;
				case 4:
					return false;
				case 5:
					arg_C1_0 = ((this.IsUnlimitedPlayTime == other.IsUnlimitedPlayTime) ? 1941741381 : 985612789);
					continue;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					arg_C1_0 = ((this.IsSubscription == other.IsSubscription) ? 1475474008 : 1752349830);
					continue;
				case 9:
					arg_C1_0 = ((this.PlayTimeExpires != other.PlayTimeExpires) ? 1391513001 : 567571621);
					continue;
				case 10:
					arg_C1_0 = ((this.IsRecurringSubscription != other.IsRecurringSubscription) ? 900195119 : 988631239);
					continue;
				case 11:
					return false;
				case 12:
					return false;
				}
				break;
			}
			return true;
			IL_B7:
			arg_C1_0 = 757025905;
			goto IL_BC;
			IL_10F:
			arg_C1_0 = ((other == this) ? 2056781396 : 421944477);
			goto IL_BC;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsUnlimitedPlayTime)
			{
				goto IL_66;
			}
			goto IL_131;
			uint arg_F1_0;
			while (true)
			{
				IL_EC:
				uint num2;
				switch ((num2 = (arg_F1_0 ^ 2847128956u)) % 9u)
				{
				case 0u:
					goto IL_131;
				case 1u:
					num ^= this.IsRecurringSubscription.GetHashCode();
					arg_F1_0 = (num2 * 1878415994u ^ 2277784839u);
					continue;
				case 2u:
					num ^= this.IsSubscription.GetHashCode();
					arg_F1_0 = (num2 * 1216864577u ^ 3270196655u);
					continue;
				case 3u:
					num ^= this.PlayTimeExpires.GetHashCode();
					arg_F1_0 = (num2 * 4016113339u ^ 3663968010u);
					continue;
				case 4u:
					arg_F1_0 = ((!this.IsSubscription) ? 3099546537u : 4062100474u);
					continue;
				case 5u:
					goto IL_66;
				case 6u:
					arg_F1_0 = (this.IsRecurringSubscription ? 2661449705u : 2496208901u);
					continue;
				case 7u:
					num ^= this.IsUnlimitedPlayTime.GetHashCode();
					arg_F1_0 = (num2 * 1787413873u ^ 2170065536u);
					continue;
				}
				break;
			}
			return num;
			IL_66:
			arg_F1_0 = 3872063840u;
			goto IL_EC;
			IL_131:
			arg_F1_0 = ((this.PlayTimeExpires != 0uL) ? 3074779365u : 4146801609u);
			goto IL_EC;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.IsUnlimitedPlayTime)
			{
				goto IL_ED;
			}
			goto IL_17D;
			uint arg_131_0;
			while (true)
			{
				IL_12C:
				uint num;
				switch ((num = (arg_131_0 ^ 3636632299u)) % 12u)
				{
				case 0u:
					output.WriteRawTag(40);
					output.WriteUInt64(this.PlayTimeExpires);
					arg_131_0 = (num * 1052604510u ^ 2094441647u);
					continue;
				case 1u:
					output.WriteRawTag(56);
					arg_131_0 = (num * 2489699817u ^ 1354504647u);
					continue;
				case 3u:
					goto IL_ED;
				case 4u:
					output.WriteRawTag(48);
					arg_131_0 = (num * 4069860581u ^ 2419833484u);
					continue;
				case 5u:
					goto IL_17D;
				case 6u:
					arg_131_0 = (this.IsRecurringSubscription ? 3049597822u : 2410519229u);
					continue;
				case 7u:
					output.WriteBool(this.IsSubscription);
					arg_131_0 = (num * 992443645u ^ 66921438u);
					continue;
				case 8u:
					arg_131_0 = ((!this.IsSubscription) ? 2931234001u : 3208253831u);
					continue;
				case 9u:
					output.WriteBool(this.IsRecurringSubscription);
					arg_131_0 = (num * 3010728642u ^ 4081895071u);
					continue;
				case 10u:
					output.WriteRawTag(24);
					arg_131_0 = (num * 2958756816u ^ 3504931896u);
					continue;
				case 11u:
					output.WriteBool(this.IsUnlimitedPlayTime);
					arg_131_0 = (num * 4264823141u ^ 2142448845u);
					continue;
				}
				break;
			}
			return;
			IL_ED:
			arg_131_0 = 4100759733u;
			goto IL_12C;
			IL_17D:
			arg_131_0 = ((this.PlayTimeExpires == 0uL) ? 2951819799u : 2179046799u);
			goto IL_12C;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.IsUnlimitedPlayTime)
			{
				goto IL_85;
			}
			goto IL_103;
			uint arg_C3_0;
			while (true)
			{
				IL_BE:
				uint num2;
				switch ((num2 = (arg_C3_0 ^ 1177913292u)) % 9u)
				{
				case 0u:
					arg_C3_0 = ((!this.IsRecurringSubscription) ? 974203901u : 629709780u);
					continue;
				case 1u:
					num += 2;
					arg_C3_0 = (num2 * 2016200696u ^ 2386097341u);
					continue;
				case 2u:
					goto IL_85;
				case 3u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.PlayTimeExpires);
					arg_C3_0 = (num2 * 821010884u ^ 3739596345u);
					continue;
				case 4u:
					num += 2;
					arg_C3_0 = (num2 * 1480017282u ^ 4088801763u);
					continue;
				case 5u:
					num += 2;
					arg_C3_0 = (num2 * 2483916660u ^ 2062307051u);
					continue;
				case 7u:
					arg_C3_0 = ((!this.IsSubscription) ? 1811330353u : 1959238245u);
					continue;
				case 8u:
					goto IL_103;
				}
				break;
			}
			return num;
			IL_85:
			arg_C3_0 = 1225201101u;
			goto IL_BE;
			IL_103:
			arg_C3_0 = ((this.PlayTimeExpires == 0uL) ? 10465537u : 620548706u);
			goto IL_BE;
		}

		public void MergeFrom(GameTimeInfo other)
		{
			if (other == null)
			{
				goto IL_D5;
			}
			goto IL_142;
			uint arg_FA_0;
			while (true)
			{
				IL_F5:
				uint num;
				switch ((num = (arg_FA_0 ^ 1533742554u)) % 11u)
				{
				case 0u:
					this.IsUnlimitedPlayTime = other.IsUnlimitedPlayTime;
					arg_FA_0 = (num * 1953361960u ^ 202599206u);
					continue;
				case 1u:
					return;
				case 2u:
					goto IL_D5;
				case 3u:
					arg_FA_0 = (other.IsSubscription ? 178581258u : 1879838060u);
					continue;
				case 4u:
					arg_FA_0 = ((!other.IsRecurringSubscription) ? 437598352u : 1454063079u);
					continue;
				case 5u:
					this.PlayTimeExpires = other.PlayTimeExpires;
					arg_FA_0 = (num * 429844447u ^ 2380229598u);
					continue;
				case 6u:
					arg_FA_0 = ((other.PlayTimeExpires == 0uL) ? 25736822u : 1332476546u);
					continue;
				case 7u:
					this.IsRecurringSubscription = other.IsRecurringSubscription;
					arg_FA_0 = (num * 3765170131u ^ 1375374807u);
					continue;
				case 8u:
					this.IsSubscription = other.IsSubscription;
					arg_FA_0 = (num * 4117448332u ^ 44623020u);
					continue;
				case 10u:
					goto IL_142;
				}
				break;
			}
			return;
			IL_D5:
			arg_FA_0 = 908826704u;
			goto IL_F5;
			IL_142:
			arg_FA_0 = ((!other.IsUnlimitedPlayTime) ? 1203594070u : 1080013292u);
			goto IL_F5;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1C2:
				uint num;
				uint arg_166_0 = ((num = input.ReadTag()) == 0u) ? 1417992160u : 647609780u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_166_0 ^ 1763525878u)) % 16u)
					{
					case 0u:
						arg_166_0 = ((num != 48u) ? 538067070u : 1218339516u);
						continue;
					case 1u:
						arg_166_0 = (num2 * 2793299539u ^ 2086395192u);
						continue;
					case 2u:
						arg_166_0 = ((num <= 40u) ? 2048604265u : 213184982u);
						continue;
					case 3u:
						this.IsUnlimitedPlayTime = input.ReadBool();
						arg_166_0 = 1578914379u;
						continue;
					case 4u:
						arg_166_0 = 647609780u;
						continue;
					case 5u:
						input.SkipLastField();
						arg_166_0 = 1578914379u;
						continue;
					case 7u:
						arg_166_0 = (num2 * 977953524u ^ 1808996711u);
						continue;
					case 8u:
						arg_166_0 = (((num != 56u) ? 1255886371u : 2123091311u) ^ num2 * 220825578u);
						continue;
					case 9u:
						this.IsRecurringSubscription = input.ReadBool();
						arg_166_0 = 1578914379u;
						continue;
					case 10u:
						this.IsSubscription = input.ReadBool();
						arg_166_0 = 414835409u;
						continue;
					case 11u:
						arg_166_0 = (((num != 40u) ? 3983105647u : 2498481517u) ^ num2 * 3860019151u);
						continue;
					case 12u:
						arg_166_0 = (num2 * 3462588562u ^ 838158187u);
						continue;
					case 13u:
						goto IL_1C2;
					case 14u:
						this.PlayTimeExpires = input.ReadUInt64();
						arg_166_0 = 1363796631u;
						continue;
					case 15u:
						arg_166_0 = (((num != 24u) ? 204023570u : 1750700378u) ^ num2 * 546724033u);
						continue;
					}
					return;
				}
			}
		}
	}
}
